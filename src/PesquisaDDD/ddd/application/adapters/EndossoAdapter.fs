namespace Application

open Domain
open Domain.Endosso

module EndossoAdapter = 
  let dtoToEntity(endosso:EndossoDTO) : EndossoEntity = 
    {
      NumProposta = endosso.NumProposta |> NumeroDoEndosso
      TipoMovto = endosso.TipoMovto |> String02 |> TipoMovto
      EndossoDoc = endosso.EndossoDoc |> String30 |> EndossoDoc
    }
  
  let entityToDTO(endosso:EndossoEntity) : EndossoDTO = 
    {
      NumProposta = endosso.NumProposta |> int
      TipoMovto = endosso.TipoMovto |> TipoMovto.value |> String02.value
      EndossoDoc = endosso.EndossoDoc |> EndossoDoc.value |> String30.value
    }
