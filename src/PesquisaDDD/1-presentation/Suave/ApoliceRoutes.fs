namespace Apresentacao

open Suave
open Suave.Filters
open Suave.Operators
open Suave.Json
open Suave.Successful


module ApoliceRoutes =
  let apoliceRoutes =
    choose [
      GET >=> choose [
        path "/api/apolice" >=> OK "find()"
        path "/api/apolice/%s" >=> OK "findOne()"
      ]
      POST >=> choose [
        path "/api/apolice" >=> OK "create()"
      ]
      PUT >=> choose [
        path "/api/apolice" >=> OK "update()"
      ]
      DELETE >=> choose[
        path "/api/apolice/%s" >=> OK "delete()"  
      ]

    ]