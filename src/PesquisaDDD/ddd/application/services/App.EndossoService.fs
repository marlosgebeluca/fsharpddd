namespace Application

// module EndossoService = 

//   let create endossoDto : CreateEndosso =
//     let __validar = EndossoValidator.validar endossoDto
//     let entidade = EndossoAdapter.dtoToEntity endossoDto
//     let endossoRetornoDomain = 
//       entidade
//       |> Domain.EndossoService.create entidade

//     let retorno = EndossoAdapter.entityToDTO endossoRetornoDomain
//     fun _cadastrarEndosso ->
//       retorno