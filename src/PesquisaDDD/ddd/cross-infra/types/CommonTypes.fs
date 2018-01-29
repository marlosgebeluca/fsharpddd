namespace CrossInfra
open Infra
open Domain.Apolice
open Domain.Endosso
open System.Collections.Generic

type IApoliceRepository = 
  abstract FindApolice : List<ApoliceEntity>
  abstract FindOneApolice : int -> ApoliceEntity
  abstract CreateApolice : ApoliceEntity -> ApoliceEntity
  abstract UpdateApolice : int * ApoliceEntity -> string
  // abstract DeleteApolice : int -> string
  abstract FindEndossos : int list

type ApoliceRepository() =
  interface IApoliceRepository with
    

    member __.FindApolice = 
      let lista = RepositoryApolice.find
      let apolices = new List<ApoliceEntity>()

      for emDocto in lista do
        apolices.Add(ApoliceMapper.modelToEntity {
            DocNumProposta = emDocto.DocNumProposta
            DocTipoMovto = emDocto.DocTipoMovto
            DocApolice = emDocto.DocApolice
        })

      apolices

    member __.FindOneApolice(id) = 
      let emDocto = RepositoryApolice.findOne id
      let retorno = ApoliceMapper.modelToEntity emDocto
      retorno
      

    member __.CreateApolice(entidade) = 
      let emDocto = ApoliceMapper.entityToModel entidade
      let model = RepositoryApolice.create emDocto
      let retorno = ApoliceMapper.modelToEntity model

      retorno

    member __.UpdateApolice(id, entidade) = 
      "RepositoryApolice.update" 

    // member __.DeleteApolice(id) = 
    //   RepositoryApolice.delete 

    member __.FindEndossos =
      let retorno = [15;16;17]
      retorno 
           
// type IEndossoRepository = 
//   abstract FindEndosso : string[] -> List<string>
//   abstract FindOneEndosso : int -> string
//   abstract CreateEndosso : EndossoEntity -> int
//   abstract UpdateEndosso : int * EndossoEntity -> string
//   abstract DeleteEndosso : int -> string

// type EndossoRepository() =
//   interface IEndossoRepository with
//     member __.FindEndosso(parametros) = 
//       RepositoryEndosso.find

//     member __.FindOneEndosso(id) = 
//       RepositoryEndosso.findOne 

//     member __.CreateEndosso(entidade) = 
//       RepositoryEndosso.create 

//     member __.UpdateEndosso(id, entidade) = 
//       RepositoryEndosso.update 

//     member __.DeleteEndosso(id) = 
//       RepositoryEndosso.delete 
           