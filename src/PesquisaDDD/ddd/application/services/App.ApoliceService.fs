namespace Application
open Domain.ApoliceService

module ApoliceService = 

  let create apoliceDto : CreateApolice =
    let __validar = ApoliceValidator.validar apoliceDto
    let entidade = ApoliceAdapter.dtoToEntity apoliceDto
    let apoliceRetornoDomain = 
      entidade
      |> create entidade

    let retorno = ApoliceAdapter.entityToDTO apoliceRetornoDomain
    fun _cadastrarApolice ->
      retorno