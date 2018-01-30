namespace CrossInfra
open Infra
open Domain.Apolice
open Domain.Endosso
open System.Collections.Generic

type IApoliceRepository = 
  abstract FindApolice : List<ApoliceEntity>
  abstract FindOneApolice : int -> ApoliceEntity
  abstract CreateApolice : ApoliceEntity -> ApoliceEntity
  abstract UpdateApolice : int * ApoliceEntity -> ApoliceEntity
  abstract DeleteApolice : int -> string
  abstract FindEndossos : int -> List<int>

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
      let emDocto = ApoliceMapper.entityToModel entidade
      let model = RepositoryApolice.update id emDocto
      let retorno = ApoliceMapper.modelToEntity model
      retorno

    member __.DeleteApolice(id) = 
      let retorno = RepositoryApolice.delete id
      retorno

    member __.FindEndossos(idApolice) =
      let retorno = RepositoryApolice.findEndossos idApolice
      retorno 
           
type IEndossoRepository = 
  abstract FindEndosso : List<EndossoEntity>
  abstract FindOneEndosso : int -> EndossoEntity
  abstract CreateEndosso : EndossoEntity -> EndossoEntity
  abstract UpdateEndosso : int * EndossoEntity -> EndossoEntity
  abstract DeleteEndosso : int -> string

type EndossoRepository() =
  interface IEndossoRepository with

    member __.FindEndosso = 
      let lista = RepositoryEndosso.find
      let endossos = new List<EndossoEntity>()

      for emDocto in lista do
        endossos.Add(EndossoMapper.modelToEntity {
            DocNumProposta = emDocto.DocNumProposta
            DocTipoMovto = emDocto.DocTipoMovto
            DocApolice = emDocto.DocApolice
        })
      endossos

    member __.FindOneEndosso(id) = 
      let emDocto = RepositoryEndosso.findOne id
      let retorno = EndossoMapper.modelToEntity emDocto
      retorno

    member __.CreateEndosso(entidade) = 
      let emDocto = EndossoMapper.entityToModel entidade
      let model = RepositoryEndosso.create emDocto
      let retorno = EndossoMapper.modelToEntity model
      retorno

    member __.UpdateEndosso(id, entidade) = 
      let emDocto = EndossoMapper.entityToModel entidade
      let model = RepositoryEndosso.update id emDocto
      let retorno = EndossoMapper.modelToEntity model
      retorno

    member __.DeleteEndosso(id) = 
      let retorno = RepositoryEndosso.delete id
      retorno
           