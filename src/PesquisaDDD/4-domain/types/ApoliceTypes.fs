namespace Domain

open System.Runtime.Serialization

open CrossInfra
open Endosso

module Apolice = 

  [<CLIMutable>]
  [<DataContract>]
  type ApoliceDTO = {
    [<field: DataMember(Name = "numProposta")>]
    numProposta : int;
    [<field: DataMember(Name = "tipoMovto")>]
    tipoMovto : string;
    [<field: DataMember(Name = "apolice")>]
    apolice : string;
    [<field: DataMember(Name = "endossos")>]
    endossos : list<int>;
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

  type Apolice = Apolice of String30
  
  [<CLIMutable>]
  type ApoliceDomain = {
    NumProposta : Id;
    TipoMovto : TipoMovto;
    Apolice : Apolice;
    Endossos : list<int>;
  }