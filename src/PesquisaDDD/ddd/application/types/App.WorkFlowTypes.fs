namespace Application
open Domain.Apolice
open Domain.Endosso

type Find = unit -> List<ApoliceDTO>
type FindOne = NumeroDaApolice -> string
type Update = (NumeroDaApolice * ApoliceDTO) -> ApoliceDTO
type Delete = NumeroDaApolice -> string

type CadastrarApolice = unit -> ApoliceDTO

type CreateApolice =
  CadastrarApolice
    -> ApoliceDTO

type CadastrarEndoso = unit -> EndossoDTO

type CreateEndosso =
  CadastrarApolice
    -> EndossoDTO    