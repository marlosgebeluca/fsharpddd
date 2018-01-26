namespace Apresentacao

open Suave

module Config =
  let cfg ={ 
    defaultConfig with
      bindings = [ HttpBinding.createSimple HTTP "127.0.0.1" 3000 ] 
  }
