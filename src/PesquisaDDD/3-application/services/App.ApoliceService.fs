namespace Application

module ApoliceService = 

  let create apoliceDto : CreateApolice =
    let __validar = ApoliceValidator.validar apoliceDto
    let entidade = ApoliceAdapter.dtoToEntity apoliceDto
    let apoliceRetornoDomain = 
      entidade
      |> Domain.ApoliceService.create entidade

    let retorno = ApoliceAdapter.entityToDTO apoliceRetornoDomain
    fun _cadastrarApolice ->
      retorno