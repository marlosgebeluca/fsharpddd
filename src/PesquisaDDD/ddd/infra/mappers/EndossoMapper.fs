namespace Infra

open Domain
open Domain.Endosso
open Infra


module EndossoMapper = 
  let entityToModel(endosso:EndossoEntity) : EmDoctos = 
    {
      DocNumProposta = endosso.NumProposta |> int
      DocTipoMovto = endosso.TipoMovto |> string
      DocApolice = endosso.ApoliceDoc |> string
    }
  
  let modelToEntity(endosso:EmDoctos) : EndossoEntity = 
    {
      NumProposta = endosso.DocNumProposta |> NumeroDoEndosso
      TipoMovto = endosso.DocTipoMovto |> String02 |> TipoMovtoEndosso
      ApoliceDoc = endosso.DocApolice |> String30 |> ApoliceDoc
    }
