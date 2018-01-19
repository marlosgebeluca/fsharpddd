namespace Application

module ApoliceService = 

  let create : Create =    
    fun cadastrarApolice apoliceDto ->
      let validacao = ApoliceValidator.validar apoliceDto

      match validacao with
      | OK -> 
        let entidade = ApoliceAdapter.dtoToEntity apoliceDto
        let apoliceRetornoDomain = 
          entidade
          |> Domain.ApoliceService.create entidade

        ApoliceAdapter.entityToDTO apoliceRetornoDomain