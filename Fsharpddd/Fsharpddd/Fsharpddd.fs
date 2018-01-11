module Fsharpddd
open System
open FsharpdddPesquisa.Domain

[<EntryPoint>]
let main argv =

    let sair() : int = 
        Console.Write("Tchau...")
        let input = Console.ReadLine()
        0
    
    let apolice1 =  {
        NumProposta = 1
        DocTipoMovto = "AP"
        DocApolice = 123456
    }

    let endosso1 =  {
        NumProposta = 2
        DocPropApolice = 1
        DocTipoMovto = "AP"
        DocApolice = 213456
    }

    let endosso2 =  {
        NumProposta = 3
        DocPropApolice = 1
        DocTipoMovto = "AP"
        DocApolice = 231456
    }

    let endosso3 =  {
        NumProposta = 4
        DocPropApolice = 1
        DocTipoMovto = "AP"
        DocApolice = 234156
    }

    let apoliceService = ApoliceService()

    let createRetorno = (apoliceService :> IApoliceService).Create(apolice1)
    printfn  "%s" createRetorno
    
    let findRetorno = (apoliceService :> IApoliceService).Find(apolice1)
    printfn  "%s" findRetorno

    let updateRetorno = (apoliceService :> IApoliceService).Update(apolice1.NumProposta, apolice1)
    printfn  "%s" updateRetorno

    let deleteRetorno = (apoliceService :> IApoliceService).Delete(apolice1.NumProposta)
    printfn  "%s" deleteRetorno

    sair()
