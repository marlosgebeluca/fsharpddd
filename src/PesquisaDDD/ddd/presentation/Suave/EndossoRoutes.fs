namespace Apresentacao

open Suave
open Suave.Filters
open Suave.Operators
open Suave.Json
open Suave.Successful
open Domain.Endosso
// open Application.EndossoService

// module EndossoRoutes =
//   let endossoCreate = 
//     (mapJson (fun (endosso:EndossoDTO) -> 
//       let retorno = create endosso
//       retorno
//     ))

//   let endossoRoutes =
//     choose [
//       GET >=> choose [
//         path "/api/endosso" >=> OK "find()"
//         path "/api/endosso/%s" >=> OK "findOne()"
//       ]
//       POST >=> choose [
//         path "/api/endosso" >=> endossoCreate
//       ]
//       PUT >=> choose [
//         path "/api/endosso" >=> OK "update()"
//       ]
//       DELETE >=> choose[
//         path "/api/endosso/%s" >=> OK "delete()"  
//       ]

//     ]