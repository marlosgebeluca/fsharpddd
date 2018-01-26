namespace Apresentacao

open Suave
open Suave.RequestErrors

open ApoliceRoutes

module MainRoutes =
  let webPart =
    choose [
      apoliceRoutes
      NOT_FOUND "Nada Por aqui!" 
    ]