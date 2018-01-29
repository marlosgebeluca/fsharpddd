namespace Domain
open Apolice
open CrossInfra
open System.Collections.Generic

module ApoliceService = 

  let repository = ApoliceRepository()

  let findEndossos = 
    let retorno = (repository :> IApoliceRepository).FindEndossos
    retorno

  let find : BuscarApolices =
    let retorno = (repository :> IApoliceRepository).FindApolice
    retorno

  let findOne id : BuscarApolice =
    let retorno = (repository :> IApoliceRepository).FindOneApolice id

    retorno.Endossos <- findEndossos
    retorno

  let create : CreateApolice = 
    fun _cadastrarApolice entidade ->
      let retorno = (repository :> IApoliceRepository).CreateApolice(entidade)
      retorno

  let update id entidade: UpdateApolice =
    fun _atualizarApolice ->
      let retorno = (repository :> IApoliceRepository).UpdateApolice(id, entidade)
      entidade

  let delete : DeleteApolice =
    fun deletarApolice id ->
      "Deletado " + id.ToString()

  

  let renovarApolice: RenovarApolice  =
    fun __ numeroDaApolice ->
      let n = numeroDaApolice |> NumeroDaApolice
      let a = "123456" |> String30 |> ApoliceDoc
      let t =  "AP" |> String02 |> TipoMovto

      let apolice: ApoliceEntity = {
        NumProposta = n;
        TipoMovto = t;
        ApoliceDoc = a;
        Endossos = [];   
      }
      apolice