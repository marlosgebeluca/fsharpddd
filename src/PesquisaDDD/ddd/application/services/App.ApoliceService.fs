namespace Application
open Domain.ApoliceService
open System.Collections.Generic
open Domain.Apolice

module ApoliceService = 

  let find : Find =
    let lista = find
    let apolices = new List<ApoliceDTO>()
    for i in lista do
      let entidade = ApoliceAdapter.entityToDTO i
      apolices.Add(entidade)
    
    apolices

  let findOne id : FindOneApolice =
    let entidade = findOne id
    let retorno = ApoliceAdapter.entityToDTO entidade

    fun _buscarUmaApolice ->
      retorno
    
  let create apoliceDto : CreateApolice =
    let __validar = ApoliceValidator.validar apoliceDto
    let entidade = ApoliceAdapter.dtoToEntity apoliceDto
    let apoliceRetornoDomain = 
      entidade
      |> create entidade

    let retorno = ApoliceAdapter.entityToDTO apoliceRetornoDomain
    fun _cadastrarApolice ->
      retorno

  let update(id, apoliceDto) : UpdateApolice =
    let __validar = ApoliceValidator.validar apoliceDto
    let entidade = ApoliceAdapter.dtoToEntity apoliceDto
   
    let apoliceAtualziadaDomain = update(id,entidade)

    // let retorno = ApoliceAdapter.entityToDTO apoliceAtualziadaDomain

    fun _atualizarApolice ->
      apoliceDto