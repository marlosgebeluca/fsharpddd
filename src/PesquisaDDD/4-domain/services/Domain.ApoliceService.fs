namespace Domain
open Apolice
open CrossInfra

module ApoliceService = 

  let find : FindApolices =
    fun buscarApolices params ->
      let buscarApolices: List<ApoliceEntity> = []
      buscarApolices

  let findOne : FindApolice =
    fun buscaApolice id->
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
    fun cadastrarApolice entidade ->
      let repository = ApoliceRepository()
     
      //Validar Regras de Negocios
      let novoId = (repository :> IApoliceRepository).CreateApolice()
      
      let updatedEntidade = { entidade with NumProposta = NumeroDaApolice novoId }
      updatedEntidade

  let update : UpdateApolice =
    fun atualizarApolice id entidade ->
      entidade

  let delete : DeleteApolice =
    fun deletarApolice id ->
      "Deletado " + id.ToString()

  let renovarApolice: RenovarApolice  =
    fun nomeDaFuncao numeroDaApolice ->
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