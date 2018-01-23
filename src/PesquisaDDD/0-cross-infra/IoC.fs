namespace CrossInfra

open System
open System.Collections.Generic
open System.Reflection

module FSharpIoCModule = 
    let rec Resolve requestedType (typeContainer:Dictionary<Type,Type>) =
        let newType = typeContainer.[requestedType]
        let constructors = newType.GetConstructors() 
                           |> Array.sortBy (fun c -> c.GetParameters().Length) 
                           |> Array.rev
        let theConstructor = constructors.[0]
        match theConstructor.GetParameters() with
        | cstorParams when cstorParams.Length = 0 -> Activator.CreateInstance(newType)
        | cstorParams -> cstorParams 
                         |> Seq.map(fun (paramInfo:ParameterInfo) -> 
                                (Resolve paramInfo.ParameterType typeContainer)) 
                         |> Seq.toArray 
                         |> theConstructor.Invoke

type Container =
    val typeContainer : Dictionary<Type, Type>
    new () = {typeContainer = new Dictionary<Type, Type>()}
    member x.Register<'a,'b> () =        
        x.typeContainer.Add(typeof<'a>, typeof<'b>)
    member x.Resolve(requestedType) =
        FSharpIoCModule.Resolve requestedType x.typeContainer
    member x.Resolve<'a> () =
        FSharpIoCModule.Resolve typeof<'a> x.typeContainer :?> 'a

// exemplo
// type Person =
//     { FirstName : string
//       LastName : string}

// type IPersonFactory = 
//   abstract CreatePerson : unit -> Person

// type PersonFactory() = 
//     interface IPersonFactory with
//         member x.CreatePerson () = {
//           FirstName = "TestFirst"; 
//           LastName = "TestLast"
//         }  

// type PersonService = 
//     val personFactory : IPersonFactory
//     new (personFactory) = {personFactory = personFactory}
//     member x.GetPerson () = 
//         x.personFactory.CreatePerson()     

// [<EntryPoint>]
// let main _ =
//   let iocContainer = Container()
//   do iocContainer.Register<IPersonFactory, PersonFactory>()
//   do iocContainer.Register<PersonService, PersonService>()

//   let personService = iocContainer.Resolve<PersonService>()

//   let person = personService.GetPerson()
//   do Console.WriteLine("The person's name is {0} {1}", person.FirstName, person.LastName)
//   do Console.ReadLine()  

//   System.Console.ReadKey() |> ignore
//   0    
            