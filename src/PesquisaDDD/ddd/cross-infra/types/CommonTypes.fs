namespace CrossInfra
open Infra
open Domain.Apolice
open Domain.Endosso

type IApoliceRepository = 
  abstract FindApolice : string[] -> List<string>
  abstract FindOneApolice : int -> string
  abstract CreateApolice : ApoliceEntity -> ApoliceEntity
  abstract UpdateApolice : int * ApoliceEntity -> string
  abstract DeleteApolice : int -> string

type ApoliceRepository() =
  interface IApoliceRepository with
    member __.FindApolice(parametros) = 
      RepositoryApolice.find

    member __.FindOneApolice(id) = 
      RepositoryApolice.findOne 

    member __.CreateApolice(entidade) = 
      let emDocto = ApoliceMapper.entityToModel entidade
      let model = RepositoryApolice.create emDocto
      let retorno = ApoliceMapper.modelToEntity model

      retorno

    member __.UpdateApolice(id, entidade) = 
      RepositoryApolice.update 

    member __.DeleteApolice(id) = 
      RepositoryApolice.delete 
           
type IEndossoRepository = 
  abstract FindEndosso : string[] -> List<string>
  abstract FindOneEndosso : int -> string
  abstract CreateEndosso : EndossoEntity -> int
  abstract UpdateEndosso : int * EndossoEntity -> string
  abstract DeleteEndosso : int -> string

type EndossoRepository() =
  interface IEndossoRepository with
    member __.FindEndosso(parametros) = 
      RepositoryEndosso.find

    member __.FindOneEndosso(id) = 
      RepositoryEndosso.findOne 

    member __.CreateEndosso(entidade) = 
      RepositoryEndosso.create 

    member __.UpdateEndosso(id, entidade) = 
      RepositoryEndosso.update 

    member __.DeleteEndosso(id) = 
      RepositoryEndosso.delete 
           