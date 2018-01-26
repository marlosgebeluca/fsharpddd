namespace Infra

open Domain
open Domain.Endosso
open Infra


module EndossoMapper = 
  let entityToModel(endosso:EndossoEntity) : EmDoctos = 
    {
      DocNumProposta = endosso.NumProposta |> int
      DocTipoMovto = endosso.TipoMovto |> string
      DocApolice = endosso.EndossoDoc |> string
    }
  
  let modelToEntity(endosso:EmDoctos) : EndossoEntity = 
    let endossos = []

    {
      NumProposta = endosso.DocNumProposta |> NumeroDoEndosso
      TipoMovto = endosso.DocTipoMovto |> String02 |> TipoMovto
      EndossoDoc = endosso.DocApolice |> String30 |> EndossoDoc
    }
