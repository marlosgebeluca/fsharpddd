namespace Infra
open System.Collections.Generic

type BuscarUm = EmDoctos

type BuscarTodos = List<EmDoctos>
  
type Cadastrar = EmDoctos

type CadastrarUmaApolice =
  Cadastrar
    -> EmDoctos
    -> EmDoctos

type CadastrarUmEndosso = 
  Cadastrar
    -> EmDoctos
    -> EmDoctos

type Atualizar = EmDoctos

type AtualizarUmaApolice = 
  Atualizar
    -> EmDoctos
    -> EmDoctos

type AtualizarEndosso = 
  Atualizar
    -> EmDoctos
    -> EmDoctos

type Deletar = string

type DeletarApolice =
  Deletar 
    -> int
    -> string

type DeletarEndosso =
  Deletar 
    -> int
    -> string
