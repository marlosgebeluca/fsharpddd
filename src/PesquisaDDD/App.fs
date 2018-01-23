module PesquisaDDD

open Apresentacao.MainRoutes
open Apresentacao.Config

open Suave

// open Domain.Apolice
// open CrossInfra.JsonSerializer

// open Application.ApoliceService

[<EntryPoint>]
let main _ =

    // // Json Enviado
    // let json = "{\"TipoMovto\":\"AP\"," +
    //             "\"ApoliceDoc\":\"123456\"}";
    
    // // Json transformado em DTO
    // let apoliceDto = jsonToObj<ApoliceDTO>(json)
    // printfn "JSON to DTO: %O" apoliceDto
    // printfn "\n"  

    // // Enviado Para criar uma apolice
    // let dtoRetorno = create apoliceDto

    // // Dto Retornada para Json
    // let dTOToJson = objToJson(dtoRetorno)
    // printfn "DTO to Json: %O" dTOToJson
    // printfn "\n"  

    // System.Console.ReadKey() |> ignore
    // 0
    startWebServer cfg webPart
    0