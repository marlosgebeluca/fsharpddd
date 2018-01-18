namespace Application

open CrossInfra
open Domain.Apolice

module ApoliceValidator =
  let validar(apolice:ApoliceDTO) =
    let tipoMovto = TipoMovto.create apolice.tipoMovto  
    let apolice = String30.create apolice.apolice

    match tipoMovto with
    | Error e -> raise(System.ArgumentException("Error de validação Tipo Movimento"))
    | OK -> match apolice with
            | Error e -> raise(System.ArgumentException("Error de validação Apolice"))
            | OK -> "S"