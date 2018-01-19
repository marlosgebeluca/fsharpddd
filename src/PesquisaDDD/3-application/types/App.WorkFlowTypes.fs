namespace Application
open Domain.Apolice

type Find = unit -> List<ApoliceDTO>
type FindOne = Id -> string
type Update = (Id * ApoliceDTO) -> ApoliceDTO
type Delete = Id -> string

type CadastrarApolice = ApoliceDTO
type Create =
  CadastrarApolice
    -> ApoliceDTO
    -> ApoliceDTO
