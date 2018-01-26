namespace Infra
open DataAccess

module RepositoryApolice = 
  let ctx = Sql.GetDataContext()
  let find : BuscarApolices = 
    let retorno = ["Buscar"; "Apolices"]
    retorno
  
  let findOne : BuscarApolice =
    let retorno = "Buscar Apolice"
    retorno

  let create(emDocto) : CadastrarApolice = 
    let tableEmDoctos = ctx.Dados.EmDoctos
    let novoEmDocto = tableEmDoctos.Create()

    novoEmDocto.CliCodigo <- 1
    novoEmDocto.DocPropApolice <- 1
    novoEmDocto.PtoCodigo <- 1
    novoEmDocto.RamoCodigo <- 1
    novoEmDocto.DocTipoMovto <- emDocto.DocTipoMovto
    
    ctx.SubmitUpdates()

    let retorno = { emDocto with DocNumProposta = 666 }
    retorno
      

  let update : AtualizarApolice = 
    let retorno = "Atualizar Apolice"
    retorno

  let delete : DeletarApolice = 
    let retorno = "Deletar Apolice"
    retorno
