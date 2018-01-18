namespace Application

module ApoliceService = 
  
  let create apoliceDto =
    let validacao = ApoliceValidator.validar apoliceDto

    match validacao with
    | OK -> 
      let apoliceDomain = ApoliceAdapter.dtoToDomain apoliceDto
      ApoliceAdapter.domainToDTO apoliceDomain
    