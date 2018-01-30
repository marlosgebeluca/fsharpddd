namespace Domain
open Endosso
open CrossInfra
open System.Collections.Generic

module EndossoService = 

  let repository = EndossoRepository()

  let find : BuscarEndossos =
    let retorno = (repository :> IEndossoRepository).FindEndosso
    retorno

  let findOne id : BuscarEndosso =
    let retorno = (repository :> IEndossoRepository).FindOneEndosso id
    retorno

  let create : CreateEndosso = 
    fun _cadastrarEndosso entidade ->
      let retorno = (repository :> IEndossoRepository).CreateEndosso(entidade)
      retorno

  let update id entidade : AtualizarEndosso =
    let retorno = (repository :> IEndossoRepository).UpdateEndosso(id, entidade)
    retorno

  let delete id : DeletarEndosso =
    let retorno = (repository :> IEndossoRepository).DeleteEndosso(id)
    retorno
