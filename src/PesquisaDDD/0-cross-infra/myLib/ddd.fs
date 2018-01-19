type Request<'i,'o,'k> = 'i * ('o -> 'k)
let bindRequest bind f (s,k) = s, fun v -> bind(k v,f)

type Id = int
type Entity<'e> = Entity of Id * 'e 
[<Measure>] type money
type User = {name : string; email : string; ballance : int<money>}
type Product = { name : string; quantity : int; price : int<money>}
type Email = {body:string; subject : string}

type DbOps<'e, 'k> = 
      | Select of Request<unit,Entity<'e> seq, 'k>
      | Get of Request<Id,Entity<'e> option,'k>
      | Delete of Request<Entity<'e>,unit,'k>
      | Update of Request<Entity<'e>, unit,'k>
      | Insert of Request<'e, Id,'k>

let bindDb v f bind = 
            match v with
            | Select(r) -> Select(bindRequest bind f r)
            | Get(r) -> Get(bindRequest bind f r)
            | Delete(r) -> Delete(bindRequest bind f r)
            | Update(r) -> Update(bindRequest bind f r)
            | Insert(r) -> Insert(bindRequest bind f r)

type Dsl<'r> =
  | UsersTable of DbOps<User, Dsl<'r>>
  | ProductsTable of DbOps<Product, Dsl<'r>>
  | SendEmail of Request<User * Email, unit,Dsl<'r>>
  | Log of Request<string, unit,Dsl<'r>>
  | Pure of 'r 

type DslBuilder() =
    member x.Bind(v:Dsl<'a>,f:'a->Dsl<'b>) = 
        match v with
            | UsersTable(dbOp) -> UsersTable(bindDb dbOp f x.Bind)
            | ProductsTable(dbOp) -> ProductsTable(bindDb dbOp f x.Bind)
            | SendEmail(r) -> SendEmail(bindRequest x.Bind f r)
            | Log(r) -> Log(bindRequest x.Bind f r)
            | Pure(v) -> f(v)
    member x.Return v = Pure(v)
    member x.ReturnFrom v = v

let dsl = DslBuilder()

let lift ctor i = ctor(i, fun s -> Pure(s))

let usersTable op = lift (UsersTable << op)
let productsTable op = lift (ProductsTable << op)
let sendEmail = lift SendEmail
let log = lift Log

type Db = {
    users : Map<Id,User>
    products : Map<Id,Product>
}

let runDb (table:Map<_,_>) dbOp  =
    match dbOp with
          | Select(_,k) -> table |> Seq.map (fun kv ->  Entity(kv.Key, kv.Value)) |> k, table   
          | Get(id,k) -> if table.ContainsKey id  
                         then k (Some(Entity(id, table.[id]))), table
                         else k None, table
          | Delete(Entity(id,_),k) -> k (), table.Remove id
          | Update(Entity(id,v),k) -> k (), table |> Map.remove id |> Map.add id v
          | Insert(v,k) -> let id = table |> Seq.map (fun kv -> kv.Key) 
                                          |> Seq.max
                           k id, Map.add (id + 1) v table

let rec run db ast =
    match ast with
          | ProductsTable(dbOp) -> let r, t = runDb db.products dbOp 
                                   run {db with products = t} r
          | UsersTable(dbOp) -> let r, t = runDb db.users dbOp
                                run {db with users = t} r
          | SendEmail((u,e), k) -> printfn "Sending email to: %s\nsubject:%s\nbody:%s" u.name e.subject e.body
                                   k() |> run db
          | Log(r,k) -> printfn "Log(%A):%s" (System.DateTime.Now) r
                        k() |> run db
          | Pure(v) -> v, db

let optZip a b =
    match a,b with
        | Some(a),Some(b) -> Some(a,b)
        | _ -> None

let transferProductToUser p u count  = 
    if p.quantity < count 
    then Choice2Of2(sprintf "no enought quantity product '%s' quantity %d requested %d" p.name p.quantity count)
    elif u.ballance < p.price * count
    then Choice2Of2(sprintf "no enought money product '%s' user ballance %d requested sum %d" p.name u.ballance (p.quantity * p.price))
    else let p = {p with quantity = p.quantity - count}
         let u = {u with ballance = u.ballance - p.price * count}
         Choice1Of2(p,u)

let getAndLog tname table id =
    dsl{
        let! p = table Get id
        match p with 
            | Some(_) -> return p
            | None -> do! log <| sprintf "unable to find %d in %s" id tname
                      return None
    }



let buyProduct pid uid count = dsl{
    let! p = getAndLog "products" productsTable pid
    let! u = getAndLog "users" usersTable uid
    match optZip u p with
        | Some(Entity(idu,u), Entity(idp,p)) ->
                    do! log("found product and user") 
                    let res = transferProductToUser p u count
                    match res with
                        | Choice1Of2(p,u) -> do! sendEmail (u, { body = "you bought a product"; 
                                                                 subject = sprintf "success bought %s quantity %d" p.name count})
                                             do! productsTable Update (Entity(idp,p))
                                             do! usersTable Update (Entity(idu,u))
                                             return true
                        | Choice2Of2(error) -> do! log(error)
                                               return false
        | None -> return false
} 

let program quantity = dsl{
    let! isOK = buyProduct 1 1 quantity
    return if isOK then "ok" else "not ok"
} 

let db = {
    users = [1 , {name = "hodza"; email ="email@mail.com"; ballance = 100<money>}] |> Map.ofList
    products = [1, {name="Fsharp fun and drugs"; quantity = 10; price = 1<money>}] |> Map.ofList
}

printfn "run interpret"
printfn "before %A" db
run db (program 9)  |> printfn "result quantity 9 %A"
run db (program 21) |> printfn "result quantity 21 %A"


//run interpret
//before {users = map [(1, {name = "hodza";
//                   email = "email@mail.com";
//                   ballance = 100;})];
// products = map [(1, {name = "Fsharp fun and drugs";
//                      quantity = 10;
//                      price = 1;})];}
//Log(09.02.2016 18:56:58):found product and user
//Sending email to: hodza
//subject:success bought Fsharp fun and drugs quantity 9
//body:you bought a product
//result quantity 9 ("ok", {users = map [(1, {name = "hodza";
//                          email = "email@mail.com";
//                          ballance = 91;})];
//        products = map [(1, {name = "Fsharp fun and drugs";
//                             quantity = 1;
//                             price = 1;})];})
//Log(09.02.2016 18:56:58):found product and user
//Log(09.02.2016 18:56:58):no enought quantity product 'Fsharp fun and drugs' quantity 10 requested 21
//result quantity 21 ("not ok", {users = map [(1, {name = "hodza";
//                              email = "email@mail.com";
//                              ballance = 100;})];
//            products = map [(1, {name = "Fsharp fun and drugs";
//                                 quantity = 10;
//                                 price = 1;})];})