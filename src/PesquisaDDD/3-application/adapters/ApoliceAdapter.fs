namespace Application

open Domain
open Domain.Apolice

module ApoliceAdapter = 
  let dtoToEntity(apolice:ApoliceDTO) : ApoliceEntity = 
    {
      NumProposta = apolice.NumProposta |> NumeroDaApolice
      TipoMovto = apolice.TipoMovto |> String02 |> TipoMovto
      ApoliceDoc = apolice.ApoliceDoc |> String30 |> ApoliceDoc
      Endossos = apolice.Endossos
    }
  
  let entityToDTO(apolice:ApoliceEntity) : ApoliceDTO = 
    {
      NumProposta = apolice.NumProposta |> int
      TipoMovto = apolice.TipoMovto |> TipoMovto.value |> String02.value
      ApoliceDoc = apolice.ApoliceDoc |> ApoliceDoc.value |> String30.value
      Endossos = apolice.Endossos
    }
