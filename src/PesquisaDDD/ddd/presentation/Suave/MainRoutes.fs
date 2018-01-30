namespace Apresentacao

open Suave
open Suave.RequestErrors

open ApoliceRoutes
open EndossoRoutes

module MainRoutes =
  let webPart =
    choose [
      apoliceRoutes
      endossoRoutes
      NOT_FOUND "Nada Por aqui!" 
    ]