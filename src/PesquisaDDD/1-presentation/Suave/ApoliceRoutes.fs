namespace Apresentacao

open Suave
open Suave.Filters
open Suave.Operators
open Suave.Json
open Suave.Successful

open Domain.Apolice
open Application.ApoliceService

open CrossInfra.JsonSerializer

open System.Runtime.Serialization
[<DataContract>]
type Testezinho = { 
  [<field: DataMember(Name = "retorno")>]
  retorno : ApoliceDTO;
}

module ApoliceRoutes =
  let apoliceCreate = 
    (mapJson (fun (apolice:ApoliceDTO) -> 
      
      let dtoRetorno : ApoliceDTO = apolice
      
      { retorno = dtoRetorno }
    ))

  let apoliceRoutes =
    choose [
      GET >=> choose [
        path "/api/apolice" >=> OK "find()"
        path "/api/apolice/%s" >=> OK "findOne()"
      ]
      POST >=> choose [
        path "/api/apolice" >=> apoliceCreate
      ]
      PUT >=> choose [
        path "/api/apolice" >=> OK "update()"
      ]
      DELETE >=> choose[
        path "/api/apolice/%s" >=> OK "delete()"  
      ]

    ]