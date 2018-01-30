namespace Domain
open System.Runtime.Serialization
open System.Collections.Generic

module Apolice = 
  [<CLIMutable>]
  [<DataContract>]
  type ApoliceDTO = {
    [<field: DataMember(Name = "NumProposta")>]
    NumProposta : int;
    [<field: DataMember(Name = "TipoMovto")>]
    TipoMovto : string;
    [<field: DataMember(Name = "ApoliceDoc")>]
    ApoliceDoc : string;
    [<field: DataMember(Name = "Endossos")>]
    Endossos : List<int>;
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
    NumProposta : NumeroDaApolice;
    TipoMovto : TipoMovtoApolice;
    ApoliceDoc : ApoliceDoc;
    mutable Endossos : List<int>;
  }