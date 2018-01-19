namespace Domain
open Apolice

type Find = unit -> List<ApoliceEntity>
type FindOne = Id -> string
type Update = (Id * ApoliceEntity) -> ApoliceEntity
type Delete = Id -> string

type CadastrarApolice = ApoliceEntity
type Create =
  CadastrarApolice
    -> ApoliceEntity
    -> ApoliceEntity



