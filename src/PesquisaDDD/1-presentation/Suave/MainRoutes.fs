namespace Apresentacao

open Suave
open Suave.Filters
open Suave.Operators
open Suave.RequestErrors
open Suave.Json
open Suave.Successful


module MainRoutes =
  let webPart =
    choose [
      GET >=> choose [
        path "/hello" >=> OK "Hello World"
      ]
      NOT_FOUND "Nada Por aqui!" 
    ]