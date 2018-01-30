namespace Domain
open System.Runtime.Serialization

module Endosso = 
  [<CLIMutable>]
  [<DataContract>]
  type EndossoDTO = {
    [<field: DataMember(Name = "NumProposta")>]
    NumProposta : int;
    [<field: DataMember(Name = "TipoMovto")>]
    TipoMovto : string;
    [<field: DataMember(Name = "ApoliceDoc")>]
    ApoliceDoc : string;
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
    TipoMovto : TipoMovtoEndosso;
    ApoliceDoc : ApoliceDoc;
  }