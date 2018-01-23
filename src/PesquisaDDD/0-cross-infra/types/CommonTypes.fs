namespace CrossInfra
open Infra

type IApoliceRepository = 
  abstract CreateApolice : unit -> Create

type ApoliceRepository() =
  interface IApoliceRepository with
    member __.CreateApolice() = 
       RepositoryApolice.create