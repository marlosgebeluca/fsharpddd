namespace Infra

module EmDoctos = 
  [<CustomEquality; NoComparison>]
  type EmDoctos = {
    DocNumProposta : int
    DocTipoMovto : string
    DocApolice : string
  }
  with 
    override this.Equals(obj) =
      match obj with
      | :? EmDoctos as e -> this.DocNumProposta = e.DocNumProposta 
      | _ -> false
    override this.GetHashCode() =
      hash this.DocNumProposta