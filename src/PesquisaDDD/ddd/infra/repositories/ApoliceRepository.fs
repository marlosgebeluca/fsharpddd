namespace Infra
open DataAccess
open System.Collections.Generic

module RepositoryApolice = 
  let ctx = Sql.GetDataContext()

  let find : BuscarTodos = 
    let lista =
      query {
          for emDocto in ctx.Dados.EmDoctos do
          where(emDocto.DocTipoMovto = "AP")
          select emDocto
      } |> Seq.toArray |> Array.map(fun i -> i.ColumnValues |> Map.ofSeq)

    let apolices = new List<EmDoctos>()

    for emDocto in lista do
      apolices.Add(
        { 
          DocNumProposta = emDocto.["doc_num_proposta"] |> string |> int
          DocTipoMovto = emDocto.["doc_tipo_movto"] |> string
          DocApolice = emDocto.["doc_apolice"] |> string 
        }
      ) 
    
    apolices
  
  let findOne id : BuscarUm =
    let emDocto =
      query {
          for emDocto in ctx.Dados.EmDoctos do
          where (emDocto.DocPropApolice = id && 
                 emDocto.DocTipoMovto = "AP")
          select emDocto
      } |> Seq.toArray |> Array.map(fun i -> i.ColumnValues |> Map.ofSeq)

    let retorno : EmDoctos = { 
      DocNumProposta = 0
      DocTipoMovto = ""
      DocApolice = ""
    }    

    for e in emDocto do
      retorno.DocNumProposta <- e.["doc_num_proposta"] |> string |> int
      retorno.DocTipoMovto <- e.["doc_tipo_movto"] |> string
      retorno.DocApolice <- e.["doc_apolice"] |> string  

    retorno

  let create emDocto : Cadastrar = 
    let tableEmDoctos = ctx.Dados.EmDoctos
    let novoEmDocto = tableEmDoctos.Create()

    novoEmDocto.CliCodigo <- 1
    novoEmDocto.DocPropApolice <- 1
    novoEmDocto.PtoCodigo <- 1
    novoEmDocto.RamoCodigo <- 1
    novoEmDocto.DocTipoMovto <- emDocto.DocTipoMovto
    novoEmDocto.DocApolice <- emDocto.DocApolice |> Some
    ctx.SubmitUpdates()
    novoEmDocto.DocPropApolice <- novoEmDocto.DocNumProposta
    ctx.SubmitUpdates()

    let busca =
      query {
          for emDocto in ctx.Dados.EmDoctos do
          where (emDocto.DocPropApolice = novoEmDocto.DocNumProposta)
          select emDocto
      } |> Seq.toArray |> Array.map(fun i -> i.ColumnValues |> Map.ofSeq)

    let retorno : EmDoctos = { 
      DocNumProposta = 0
      DocTipoMovto = ""
      DocApolice = ""
    }

    for novo in busca do
      retorno.DocNumProposta <- novo.["doc_num_proposta"] |> string |> int
      retorno.DocTipoMovto <- novo.["doc_tipo_movto"] |> string
      retorno.DocApolice <- novo.["doc_apolice"] |> string

    retorno

  let update : AtualizarUmaApolice = 
    fun _atualizar emDocto -> 
    emDocto

  let delete : DeletarApolice = 
    fun _deletar id ->
    let retorno = "Deletar Apolice"
    retorno
