namespace Application

open Domain
open Domain.Endosso

module EndossoValidator =
  let validar(endosso:EndossoDTO) =
    let tipoMovto = TipoMovtoEndosso.create endosso.TipoMovto  
    let apoliceDoc = String30.create endosso.ApoliceDoc

    match tipoMovto with
    | Error e -> raise(System.ArgumentException("Error de validação Tipo Movimento"))
    | OK -> 
      match apoliceDoc with
      | Error e -> raise(System.ArgumentException("Error de validação Endosso"))
      | OK -> "S"