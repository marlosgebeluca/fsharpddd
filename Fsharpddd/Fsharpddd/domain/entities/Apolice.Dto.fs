namespace FsharpdddPesquisa.Domain

module ApoliceDto = 
  
  type Apolice = {
    NumProposta : int
    Endossos : Endosso[] option
    DocTipoMovto : string
    DocApolice : int
  }

  module Apolice = 
    let toDomain(apolice:Apolice) :ApoliceInvalida = 
      {
        NumProposta = apolice.NumProposta
        DocTipoMovto = apolice.DocTipoMovto
        DocApolice = apolice.DocApolice
      }

