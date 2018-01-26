namespace Application

open Domain
open Domain.Endosso

module EndossoValidator =
  let validar(endosso:EndossoDTO) =
    let tipoMovto = TipoMovto.create endosso.TipoMovto  
    let endossoDoc = String30.create endosso.EndossoDoc

    match tipoMovto with
    | Error e -> raise(System.ArgumentException("Error de validação Tipo Movimento"))
    | OK -> 
      match endossoDoc with
      | Error e -> raise(System.ArgumentException("Error de validação Endosso"))
      | OK -> "S"