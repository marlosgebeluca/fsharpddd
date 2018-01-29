namespace Apresentacao

open Suave
open Suave.Filters
open Suave.Operators
open Suave.Json
open Suave.Successful
open Domain.Apolice
open Application.ApoliceService
open CrossInfra

module ApoliceRoutes =
  let apoliceFind =
    JsonSerializer.objToJson find 

  let apoliceFindOne id = request ( fun r -> OK ( JsonSerializer.objToJson(findOne (id|>int))))

  // let apoliceDelete id = request (fun r -> OK (((apoliceService :> IApoliceService).Delete(int id).ToString())))

  let apoliceCreate = 
    (mapJson (fun (apolice:ApoliceDTO) -> 
      let retorno = create apolice
      retorno
    ))

  let apoliceUpdate numProposta = 
    (mapJson (fun (apolice:ApoliceDTO) -> 
      let id = (numProposta|>int) 
      let retorno = update(id, apolice)
      retorno
    ))

  let apoliceRoutes =
    choose [
      GET >=> choose [
        path "/api/apolice" >=> OK apoliceFind
        pathScan "/api/apolice/%s" apoliceFindOne
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