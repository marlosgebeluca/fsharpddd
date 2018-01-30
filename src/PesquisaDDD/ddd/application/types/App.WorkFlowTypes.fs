namespace Application
open Domain.Apolice
open Domain.Endosso
open System.Collections.Generic

type FindApolice = List<ApoliceDTO>

type BuscarUmaApolice = int -> ApoliceDTO
type FindOneApolice =
  BuscarUmaApolice
    -> ApoliceDTO

type CadastrarApolice = unit -> ApoliceDTO
type CreateApolice =
  CadastrarApolice
    -> ApoliceDTO

type AtualizarApolice = unit -> ApoliceDTO
type UpdateApolice =
  AtualizarApolice
    -> ApoliceDTO     

type DeletarApolice = int -> string
type DeleteApolice =
  DeletarApolice
    -> string         

type FindEndosso = List<EndossoDTO>

type BuscarUmEndosso = int -> EndossoDTO
type FindOneEndosso =
  BuscarUmEndosso
    -> EndossoDTO

type CadastrarEndosso = unit -> EndossoDTO
type CreateEndosso =
  CadastrarEndosso
    -> EndossoDTO

type AtualizarEndosso = unit -> EndossoDTO
type UpdateEndosso =
  AtualizarEndosso
    -> EndossoDTO     

type DeletarEndosso = int -> string
type DeleteEndosso =
  DeletarEndosso
    -> string         
      