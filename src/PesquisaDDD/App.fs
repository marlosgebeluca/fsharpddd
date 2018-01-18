module PesquisaDDD

// open Apresentacao.MainRoutes
// open Apresentacao.Config

// open Suave

open Domain.Apolice
open CrossInfra.JsonSerializer

open Application.ApoliceService

[<EntryPoint>]
let main _ =

    let json = "{\"tipoMovto\":\"AP\"," +
                "\"apolice\":\"123456\"}";
    
    let apoliceDto = jsonToObj<ApoliceDTO>(json)
    printfn "DTO: %O" apoliceDto
    printfn "\n"  

    let testeDTO = create apoliceDto
    printfn "Teste DTO: %O" testeDTO   
    printfn "\n" 

    let jsonTeste = objToJson(testeDTO)
    printfn "Json Teste: %O" jsonTeste
    printfn "\n"  

    let JsonDTO = objToJson(apoliceDto)
    printfn "Json Teste: %O" JsonDTO

    System.Console.ReadKey() |> ignore
    0
    // startWebServer cfg webPart
    // 0