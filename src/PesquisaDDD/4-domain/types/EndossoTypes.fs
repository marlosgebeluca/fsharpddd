namespace Domain
open System.Runtime.Serialization

module Endosso = 
  
  type EndossoJson = {
    [<field: DataMember(Name = "numProposta")>]
    mutable numProposta : int;
    [<field: DataMember(Name = "tipoMovto")>]
    mutable tipoMovto : string;
    [<field: DataMember(Name = "apolice")>]
    mutable apolice : string;
  }

  [<DataContract>]
  type EndossoResult = { 
    [<field: DataMember(Name = "resultEndosso")>]
    resultEndosso : EndossoJson;
  }

  [<DataContract>]
  type EndossosResult = { 
    [<field: DataMember(Name = "resultEndosso")>]
    resultEndossos : EndossoJson list;
  }