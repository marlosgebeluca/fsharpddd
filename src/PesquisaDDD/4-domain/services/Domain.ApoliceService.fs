namespace Domain
open Apolice

module ApoliceService = 

  let find : Find =
    fun selecionarApolices ->
      let buscarApolices: List<ApoliceEntity> = []
      buscarApolices

  let create : Create = 
    fun cadastrarApolice entidade ->
      //Validar Regras de Negocios
      let updatedEntidade = { entidade with NumProposta = Id 666 }
      updatedEntidade
