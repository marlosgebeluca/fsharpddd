namespace Application

open Domain
open Domain.Endosso

module EndossoAdapter = 
  let dtoToEntity(endosso:EndossoDTO) : EndossoEntity = 
    {
      NumProposta = endosso.NumProposta |> NumeroDoEndosso
      TipoMovto = endosso.TipoMovto |> String02 |> TipoMovtoEndosso
      ApoliceDoc = endosso.ApoliceDoc |> String30 |> ApoliceDoc
    }
  
  let entityToDTO(endosso:EndossoEntity) : EndossoDTO = 
    {
      NumProposta = endosso.NumProposta |> int
      TipoMovto = endosso.TipoMovto |> TipoMovtoEndosso.value |> String02.value
      ApoliceDoc = endosso.ApoliceDoc |> ApoliceDoc.value |> String30.value
    }
