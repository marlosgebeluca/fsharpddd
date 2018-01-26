namespace Domain
open Endosso
open CrossInfra

module EndossoService = 

  let find : FindEndossos =
    fun buscarEndossos _parametros ->
      let buscarEndossos: List<EndossoEntity> = []
      buscarEndossos

  let findOne : FindEndosso =
    fun buscaEndosso _id->
      let n = 666 |> NumeroDoEndosso
      let a = "123456" |> String30 |> EndossoDoc
      let t =  "AP" |> String02 |> TipoMovto

      let endosso: EndossoEntity = {
        NumProposta = n;
        TipoMovto = t;
        EndossoDoc = a;
      }
      endosso

  let create : CreateEndosso = 
    fun _cadastrarEndosso entidade ->
      let repository = EndossoRepository()
     
      //Validar Regras de Negocios
      let novoId = (repository :> IEndossoRepository).CreateEndosso(entidade)
      
      let updatedEntidade = { entidade with NumProposta = NumeroDoEndosso novoId }
      updatedEntidade

  let update : UpdateEndosso =
    fun atualizarEndosso _id entidade ->
      entidade

  let delete : DeleteEndosso =
    fun deletarEndosso id ->
      "Deletado " + id.ToString()
