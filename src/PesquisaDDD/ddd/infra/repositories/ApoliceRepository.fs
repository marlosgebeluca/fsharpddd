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
          where (emDocto.DocNumProposta = novoEmDocto.DocNumProposta)
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

  let update id emDocto : Atualizar = 
    let retorno : EmDoctos = { 
      DocNumProposta = 0
      DocTipoMovto = ""
      DocApolice = ""
    }

    query {
      for emDoc in ctx.Dados.EmDoctos do
      where (emDoc.DocNumProposta = id)
    } 
    |> Seq.iter(fun encontrado ->
      encontrado.DocTipoMovto <- emDocto.DocTipoMovto
      encontrado.DocApolice <- emDocto.DocApolice |> Some

      retorno.DocNumProposta <- encontrado.DocNumProposta
      retorno.DocTipoMovto <- emDocto.DocTipoMovto
      retorno.DocApolice <- emDocto.DocApolice 
    )
    ctx.SubmitUpdates()
    retorno

  let delete id : Deletar = 
    query {
      for emDoc in ctx.Dados.EmDoctos do
      where (emDoc.DocNumProposta = id)
    } 
    |> Seq.iter(fun encontrado ->
      encontrado.Delete()
    )
    ctx.SubmitUpdates()

    let retorno = "Apolice " + (id|>string) + " deletada"
    retorno

  let findEndossos idApolice : BuscarEndossosDaApolice = 
    let lista =
      query {
          for emDocto in ctx.Dados.EmDoctos do
          where(emDocto.DocTipoMovto <> "AP" &&
                emDocto.DocPropApolice = idApolice)
          select emDocto
      } |> Seq.toArray |> Array.map(fun i -> i.ColumnValues |> Map.ofSeq)

    let endossos = new List<int>()

    for emDocto in lista do
      endossos.Add(emDocto.["doc_num_proposta"] |> string |> int) 
    
    endossos  