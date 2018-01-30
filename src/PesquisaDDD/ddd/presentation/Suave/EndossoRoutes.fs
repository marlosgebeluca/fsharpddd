namespace Apresentacao

open Suave
open Suave.Filters
open Suave.Operators
open Suave.Json
open Suave.Successful
open Domain.Endosso
open Application.EndossoService
open CrossInfra

module EndossoRoutes =
  let endossoFind =
    JsonSerializer.objToJson find 

  let endossoFindOne id = request ( fun r -> OK ( JsonSerializer.objToJson(findOne (id|>int))))

  let endossoCreate = 
    (mapJson (fun (endosso:EndossoDTO) -> 
      let retorno = create endosso
      retorno
    ))

  let endossoUpdate numProposta = 
    (mapJson (fun (endosso:EndossoDTO) -> 
      let id = (numProposta|>int) 
      let retorno = update(id, endosso)
      retorno
    ))

  let endossoDelete id = request ( fun r -> OK ( JsonSerializer.objToJson(delete (id|>int))))

  let endossoRoutes =
    choose [
      GET >=> choose [
        path "/api/endosso" >=> OK endossoFind
        pathScan "/api/endosso/%s" endossoFindOne
      ]
      POST >=> choose [
        path "/api/endosso" >=> endossoCreate
      ]
      PUT >=> choose [
        pathScan "/api/endosso/%s" endossoUpdate
      ]
      DELETE >=> choose[
        pathScan "/api/endosso/%s" endossoDelete
      ]
    ]