namespace CrossInfra

module MeuMonad = 
  type ParserResult<'a> =
    | Success of 'a * list<char>
    | Failure

  type Parser<'a> = list<char> -> ParserResult<'a>

  let Return (x: 'a): Parser<'a> =
    let p stream = Success(x, stream)
    in p

  let Bind (p: Parser<'a>) (f: 'a -> Parser<'b>) : Parser<'b> =
      let q stream =
          match p stream with
          | Success(x, rest) -> (f x) rest
          | Failure -> Failure
      in q