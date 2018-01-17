namespace Apresentacao

open Suave
open Suave.Filters
open Suave.Operators
open Suave.RequestErrors
open Suave.Json
open Suave.Successful

module Config =
  let cfg ={ 
    defaultConfig with
      bindings = [ HttpBinding.createSimple HTTP "127.0.0.1" 3000 ] 
  }
