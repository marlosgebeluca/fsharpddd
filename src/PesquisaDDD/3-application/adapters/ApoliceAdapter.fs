namespace Application

open Domain
open Domain.Apolice

module ApoliceAdapter = 
  let dtoToEntity(apolice:ApoliceDTO) : ApoliceEntity = 
    {
      NumProposta = Id <| apolice.NumProposta
      TipoMovto = TipoMovto <| (String02 <| apolice.TipoMovto)
      ApoliceDoc = ApoliceDoc <| (String30 <| apolice.ApoliceDoc)
      Endossos = apolice.Endossos
    }
  
  let entityToDTO(apolice:ApoliceEntity) : ApoliceDTO = 
    {
      NumProposta = int <| apolice.NumProposta
      TipoMovto = apolice.TipoMovto |> TipoMovto.value |> String02.value
      ApoliceDoc = apolice.ApoliceDoc |> ApoliceDoc.value |> String30.value
      Endossos = apolice.Endossos
    }
