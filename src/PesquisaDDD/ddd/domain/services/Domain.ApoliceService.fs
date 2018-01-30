namespace Domain
open Apolice
open CrossInfra
open System.Collections.Generic

module ApoliceService = 

  let repository = ApoliceRepository()

  let findEndossosApolice id = 
    let retorno = (repository :> IApoliceRepository).FindEndossos id
    retorno

  let find : BuscarApolices =
    let retorno = (repository :> IApoliceRepository).FindApolice

    for r in retorno do 
      r.Endossos <- findEndossosApolice(r.NumProposta|>int)
      
    retorno

  let findOne id : BuscarApolice =
    let retorno = (repository :> IApoliceRepository).FindOneApolice id
    retorno.Endossos <- findEndossosApolice id

    retorno

  let create : CreateApolice = 
    fun _cadastrarApolice entidade ->
      let retorno = (repository :> IApoliceRepository).CreateApolice(entidade)
      retorno

  let update id entidade : AtualizarApolice =
    let retorno = (repository :> IApoliceRepository).UpdateApolice(id, entidade)
    retorno.Endossos <- findEndossosApolice id

    retorno

  let delete id : DeletarApolice =
    let retorno = (repository :> IApoliceRepository).DeleteApolice(id)
    retorno

  let renovarApolice: RenovarApolice  =
    fun __ numeroDaApolice ->
      let n = numeroDaApolice |> NumeroDaApolice
      let a = "123456" |> String30 |> ApoliceDoc
      let t =  "AP" |> String02 |> TipoMovtoApolice

      let apolice: ApoliceEntity = {
        NumProposta = n;
        TipoMovto = t;
        ApoliceDoc = a;
        Endossos = new List<int>();   
      }
      apolice