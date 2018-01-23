namespace Application

module ApoliceService = 

  let create apoliceDto : CreateApolice =
    fun cadastrarApolice apoliceDto ->    
      let validar = ApoliceValidator.validar apoliceDto

      let entidade = ApoliceAdapter.dtoToEntity apoliceDto

      let apoliceRetornoDomain = 
        entidade
        |> Domain.ApoliceService.create entidade

      ApoliceAdapter.entityToDTO apoliceRetornoDomain