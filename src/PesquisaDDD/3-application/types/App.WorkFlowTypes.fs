namespace Application
open Domain.Apolice

type Find = unit -> List<ApoliceDTO>
type FindOne = NumeroDaApolice -> string
type Update = (NumeroDaApolice * ApoliceDTO) -> ApoliceDTO
type Delete = NumeroDaApolice -> string

type CadastrarApolice = unit -> ApoliceDTO

type CreateApolice =
  CadastrarApolice
    -> ApoliceDTO