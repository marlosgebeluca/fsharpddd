namespace Application

open CrossInfra
open Domain.Apolice

module ApoliceAdapter = 
  let dtoToDomain(apolice:ApoliceDTO) : ApoliceDomain = 
    {
      NumProposta = Id apolice.numProposta
      TipoMovto = TipoMovto (String02 apolice.tipoMovto)
      Apolice = Apolice (String30 apolice.apolice)
      Endossos = apolice.endossos
    }
  
  let domainToDTO(apolice:ApoliceDomain) : ApoliceDTO = 
    {
      numProposta = int <| apolice.NumProposta
      tipoMovto = string <| apolice.TipoMovto
      apolice = string <| apolice.Apolice
      endossos = apolice.Endossos
    }
