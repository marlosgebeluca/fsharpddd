namespace Domain
open Apolice
open Endosso
open System.Collections.Generic

type BuscarApolices = List<ApoliceEntity>
type BuscarEndossos = List<EndossoEntity>

type BuscarApolice = ApoliceEntity
type BuscarEndosso = EndossoEntity

type CadastrarApolice = ApoliceEntity
type CreateApolice =
  CadastrarApolice
    -> ApoliceEntity
    -> ApoliceEntity

type CadastrarEndosso = EndossoEntity
type CreateEndosso =
  CadastrarEndosso
    -> EndossoEntity
    -> EndossoEntity

type AtualizarApolice = ApoliceEntity
type UpdateApolice = 
  AtualizarApolice
    -> int
    -> ApoliceEntity    
    -> ApoliceEntity  

type AtualizarEndosso = EndossoEntity
type UpdateEndosso = 
  AtualizarEndosso
    -> int
    -> EndossoEntity    
    -> EndossoEntity  

type DeletarApolice = string    

type DeletarEndosso = string






type Renovar = int -> ApoliceEntity
type RenovarApolice =
  Renovar
    -> int
    -> ApoliceEntity