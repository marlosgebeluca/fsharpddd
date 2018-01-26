namespace Domain
open Apolice
open CrossInfra

module ApoliceService = 

  let find : FindApolices =
    fun buscarApolices _parametros ->
      let buscarApolices: List<ApoliceEntity> = []
      buscarApolices

  let findOne : FindApolice =
    fun buscaApolice _id->
      let n = 666 |> NumeroDaApolice
      let a = "123456" |> String30 |> ApoliceDoc
      let t =  "AP" |> String02 |> TipoMovto

      let apolice: ApoliceEntity = {
        NumProposta = n;
        TipoMovto = t;
        ApoliceDoc = a;
        Endossos = [];   
      }
      apolice

  let create : CreateApolice = 
    fun _cadastrarApolice entidade ->
      let repository = ApoliceRepository()
     
      //Validar Regras de Negocios
      let retorno = (repository :> IApoliceRepository).CreateApolice(entidade)
      retorno

  let update : UpdateApolice =
    fun atualizarApolice _id entidade ->
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