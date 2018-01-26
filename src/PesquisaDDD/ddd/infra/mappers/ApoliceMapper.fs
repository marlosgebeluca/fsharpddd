namespace Infra

open Domain
open Domain.Apolice
open Infra


module ApoliceMapper = 
  
  let modelToEntity(apolice:EmDoctos) : ApoliceEntity = 
    let endossos = []

    {
      NumProposta = apolice.DocNumProposta |> NumeroDaApolice
      TipoMovto = apolice.DocTipoMovto |> String02 |> TipoMovto
      ApoliceDoc = apolice.DocApolice |> String30 |> ApoliceDoc
      Endossos = endossos
    }

  let entityToModel(apolice:ApoliceEntity) : EmDoctos = 
    {
      DocNumProposta = apolice.NumProposta |> int
      DocTipoMovto = apolice.TipoMovto |> TipoMovto.value |> String02.value
      DocApolice = apolice.ApoliceDoc |> ApoliceDoc.value |> String30.value
    }
