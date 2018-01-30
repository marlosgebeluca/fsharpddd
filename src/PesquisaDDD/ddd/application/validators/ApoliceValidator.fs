namespace Application

open Domain
open Domain.Apolice

module ApoliceValidator =
  let validar(apolice:ApoliceDTO) =
    let tipoMovto = TipoMovtoApolice.create apolice.TipoMovto  
    let apoliceDoc = String30.create apolice.ApoliceDoc

    match tipoMovto with
    | Error e -> raise(System.ArgumentException("Error de validação Tipo Movimento"))
    | OK -> 
      match apoliceDoc with
      | Error e -> raise(System.ArgumentException("Error de validação Apolice"))
      | OK -> "S"