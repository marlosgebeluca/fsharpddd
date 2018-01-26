namespace Infra

open ExpressionOptimizer
type BuscarApolice = 
  string

type BuscarEndosso = 
  string

type BuscarApolices = 
  List<string>

type BuscarEndossos = 
  List<string> 
  
type CadastrarApolice = EmDoctos

type Create =
  CadastrarApolice
    -> unit
    -> EmDoctos

type CadastrarEndosso = 
  int

type AtualizarApolice = 
  string

type AtualizarEndosso = 
  string

type DeletarApolice =
 string

type DeletarEndosso =
 string 
