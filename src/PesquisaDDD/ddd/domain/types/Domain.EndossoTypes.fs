namespace Domain
open System
open System.Runtime.Serialization

module Endosso = 

  type NumeroDoEndosso = NumeroDoEndosso of int with
    static member op_Explicit x = 
        match x with NumeroDoEndosso f -> f

  type TipoMovto = TipoMovto of String02
  
  type EndossoDoc = EndossoDoc of String30

  module TipoMovto = 
    /// Retorna o valor da string dentro de TipoMovto s
    let value (TipoMovto str) = str

    /// Cria uma TipoMovto
    /// Retorna o erro se valor da string for null ou vazia
    let create str =
        if String.IsNullOrEmpty(str) then
            let msg = sprintf "TipoMovto: deve ser um valor valido" 
            Error msg
        else if str.Contains("CO") 
            || str.Contains("RE") 
            || str.Contains("SM") 
            || str.Contains("CA") 
            || str.Contains("FT") then
                ConstrainedType.createStringOption "TipoMovto" String02 02 str
        else 
            let msg = sprintf "TipoMovto: Format onão reconhecido '%s'" str
            Error msg

  module EndossoDoc = 
    /// Retorna o valor da string dentro de TipoMovto s
    let value (EndossoDoc str) = str

    /// Cria uma Endosso
    /// Retorna o erro se valor da string for null ou vazia
    let create str =
        if String.IsNullOrEmpty(str) then
          let msg = sprintf "EndossoDoc: deve ser um valor valido" 
          Error msg
        else 
          ConstrainedType.createStringOption "EndossoDoc" String30 30 str

  [<CLIMutable>]
  [<DataContract>]
  type EndossoDTO = {
    [<field: DataMember(Name = "numProposta")>]
    NumProposta : int;
    [<field: DataMember(Name = "tipoMovto")>]
    TipoMovto : string;
    [<field: DataMember(Name = "apolice")>]
    EndossoDoc : string;
  }

  [<DataContract>]
  type EndossoResult = { 
    [<field: DataMember(Name = "resultEndosso")>]
    resultEndosso : EndossoDTO;
  }

  [<DataContract>]
  type EndossosResult = { 
    [<field: DataMember(Name = "resultEndosso")>]
    resultEndossos : EndossoDTO list;
  }
  
  type EndossoEntity = {
    NumProposta : NumeroDoEndosso;
    TipoMovto : TipoMovto;
    EndossoDoc : EndossoDoc;
  }