namespace Application
open Domain.EndossoService
open System.Collections.Generic
open Domain.Endosso

module EndossoService = 

  let find : FindEndosso =
    let lista = find
    let endossos = new List<EndossoDTO>()
    
    for i in lista do
      let entidade = EndossoAdapter.entityToDTO i
      endossos.Add(entidade)
    
    endossos

  let findOne id : FindOneEndosso =
    let entidade = findOne id
    let retorno = EndossoAdapter.entityToDTO entidade
    
    fun _buscarUmaEndosso ->
      retorno
    
  let create endossoDto : CreateEndosso =
    printfn "%O" endossoDto
    let __validar = EndossoValidator.validar endossoDto
    let entidade = EndossoAdapter.dtoToEntity endossoDto
    let endossoRetornoDomain = 
      entidade
      |> create entidade
    let retorno = EndossoAdapter.entityToDTO endossoRetornoDomain
    
    fun _cadastrarEndosso ->
      retorno

  let update(id, endossoDto) : UpdateEndosso =
    let __validar = EndossoValidator.validar endossoDto
    let entidade = EndossoAdapter.dtoToEntity endossoDto
    let endossoAtualziadaDomain = update id entidade
    let retorno = EndossoAdapter.entityToDTO endossoAtualziadaDomain

    fun _atualizarEndosso ->
      retorno

  let delete(id) : DeleteEndosso =
    let retorno = delete id
    
    fun _deletarEndosso ->
      retorno