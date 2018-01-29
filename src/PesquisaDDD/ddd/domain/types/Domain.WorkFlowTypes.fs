namespace Domain
open Apolice
open Endosso
open System.Collections.Generic

// WorkFlow Buscar Apolice/Endosso
type BuscarApolices = List<ApoliceEntity>

type BuscarEndossos = 
  unit -> string  

type FindApolices = 
  BuscarApolices
    -> List<ApoliceEntity>

type FindEndossos = 
  BuscarEndossos
    -> string
    -> List<EndossoEntity>    

// WorkFlow Buscar um Apolice/Endosso
type BuscarApolice = ApoliceEntity

type BuscarEndosso = 
  unit -> NumeroDoEndosso    

type FindEndosso = 
  BuscarEndosso
    -> NumeroDoEndosso
    -> EndossoEntity  

// WorkFlow Cadastrar Apolice/Endosso
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

// WorkFlow Atualizar Apolice/Endosso
type AtualizarApolice = ApoliceEntity

type UpdateApolice = 
  AtualizarApolice
    -> int
    -> ApoliceEntity    
    -> ApoliceEntity  

type AtualizarEndosso = 
  NumeroDoEndosso -> EndossoEntity -> unit

type UpdateEndosso = 
  AtualizarEndosso
    -> NumeroDoEndosso
    -> EndossoEntity    
    -> EndossoEntity  

// WorkFlow Delete Apolice/Endosso
type DeletarApolice = 
  NumeroDaApolice -> string    

type DeleteApolice = 
  DeletarApolice 
    -> NumeroDaApolice
    -> string

type DeletarEndosso = 
  NumeroDoEndosso -> string  

type DeleteEndosso =
  DeletarEndosso
    -> NumeroDoEndosso
    -> string

// WorkFlow Renovar Apolice
type Renovar = int -> ApoliceEntity

type RenovarApolice =
  Renovar
    -> int
    -> ApoliceEntity