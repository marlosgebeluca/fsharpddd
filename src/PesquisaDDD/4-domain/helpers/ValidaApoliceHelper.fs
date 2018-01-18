namespace Domain

open CrossInfra
open Apolice

module ValidarApolice =
  let validarApolice(apolice:ApoliceDTO) =
    TipoMovto.create apolice.tipoMovto
