namespace Domain
open System
open System.Runtime.Serialization

module Apolice = 

  type Id = Id of int with
    static member op_Explicit x = 
        match x with Id f -> f

  type TipoMovto = TipoMovto of String02
  
  type ApoliceDoc = ApoliceDoc of String30

  module TipoMovto = 
    /// Retorna o valor da string dentro de TipoMovto s
    let value (TipoMovto str) = str

    /// Cria uma TipoMovto
    /// Retorna o erro se valor da string for null ou vazia
    let create str =
        if String.IsNullOrEmpty(str) then
            let msg = sprintf "TipoMovto: deve ser um valor valido" 
            Error msg
        else if str.Contains("AP") 
            || str.Contains("CO") 
            || str.Contains("RE") 
            || str.Contains("SM") 
            || str.Contains("CA") 
            || str.Contains("FT") then
                ConstrainedType.createStringOption "TipoMovto" String02 02 str
        else 
            let msg = sprintf "TipoMovto: Format onão reconhecido '%s'" str
            Error msg

  module ApoliceDoc = 
    /// Retorna o valor da string dentro de TipoMovto s
    let value (ApoliceDoc str) = str

    /// Cria uma Apolice
    /// Retorna o erro se valor da string for null ou vazia
    let create str =
        if String.IsNullOrEmpty(str) then
          let msg = sprintf "ApoliceDoc: deve ser um valor valido" 
          Error msg
        else 
          ConstrainedType.createStringOption "ApoliceDoc" String30 30 str

  [<CLIMutable>]
  [<DataContract>]
  type ApoliceDTO = {
    [<field: DataMember(Name = "numProposta")>]
    NumProposta : int;
    [<field: DataMember(Name = "tipoMovto")>]
    TipoMovto : string;
    [<field: DataMember(Name = "apolice")>]
    ApoliceDoc : string;
    [<field: DataMember(Name = "endossos")>]
    Endossos : list<int>;
  }

  [<DataContract>]
  type ApoliceResult = { 
    [<field: DataMember(Name = "resultApolice")>]
    resultApolice : ApoliceDTO;
  }

  [<DataContract>]
  type ApolicesResult = { 
    [<field: DataMember(Name = "resultApolice")>]
    resultApolices : ApoliceDTO list;
  }
  
  type ApoliceEntity = {
    NumProposta : Id;
    TipoMovto : TipoMovto;
    ApoliceDoc : ApoliceDoc;
    Endossos : list<int>;
  }