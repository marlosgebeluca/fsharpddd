namespace Application
open Domain.Apolice
open Domain.Endosso
open System.Collections.Generic

type Find = List<ApoliceDTO>

type FindApolice =
  Find  
    -> string


type BuscarUmaApolice = NumeroDaApolice -> ApoliceDTO
type FindOneApolice =
  BuscarUmaApolice
    -> ApoliceDTO

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


type AtualizarApolice = unit -> ApoliceDTO
type UpdateApolice =
  AtualizarApolice
    -> ApoliceDTO      