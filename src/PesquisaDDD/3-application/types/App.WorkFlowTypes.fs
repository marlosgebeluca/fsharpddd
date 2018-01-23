namespace Application
open Domain.Apolice
open System.Runtime.Serialization

type Find = unit -> List<ApoliceDTO>
type FindOne = NumeroDaApolice -> string
type Update = (NumeroDaApolice * ApoliceDTO) -> ApoliceDTO
type Delete = NumeroDaApolice -> string

type CadastrarApolice = ApoliceDTO

type CreateApolice =
  CadastrarApolice
    -> ApoliceDTO
    -> ApoliceDTO