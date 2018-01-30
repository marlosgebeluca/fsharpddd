namespace Infra

open Domain
open Domain.Apolice
open Infra
open System.Collections.Generic

module ApoliceMapper = 
  
  let modelToEntity(apolice:EmDoctos) : ApoliceEntity = 
    let endossos = new List<int>();

    {
      NumProposta = apolice.DocNumProposta |> NumeroDaApolice
      TipoMovto = apolice.DocTipoMovto |> String02 |> TipoMovtoApolice
      ApoliceDoc = apolice.DocApolice |> String30 |> ApoliceDoc
      Endossos = endossos
    }

  let entityToModel(apolice:ApoliceEntity) : EmDoctos = 
    {
      DocNumProposta = apolice.NumProposta |> int
      DocTipoMovto = apolice.TipoMovto |> TipoMovtoApolice.value |> String02.value
      DocApolice = apolice.ApoliceDoc |> ApoliceDoc.value |> String30.value
    }
