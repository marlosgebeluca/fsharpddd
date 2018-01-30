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

  let apoliceDelete id = request ( fun r -> OK ( JsonSerializer.objToJson(delete (id|>int))))

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
        pathScan "/api/apolice/%s" apoliceUpdate
      ]
      DELETE >=> choose[
        pathScan "/api/apolice/%s" apoliceDelete
      ]
    ]