namespace FsharpdddPesquisa.Domain

module EndossoDto = 
  
  type Endosso = {
    NumProposta : int
    DocPropApolice : int
    DocTipoMovto : string
    DocApolice : int
  }

  module Endosso = 
    let toDomain(endosso:Endosso) :EndossoInvalido = 
      {
        NumProposta = endosso.NumProposta
        DocPropApolice = endosso.DocPropApolice
        DocTipoMovto = endosso.DocTipoMovto
        DocApolice = endosso.DocApolice
      }

