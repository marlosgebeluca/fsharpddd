module PesquisaDDD

open Apresentacao.MainRoutes
open Apresentacao.Config

open Suave

[<EntryPoint>]
let main _ =
    startWebServer cfg webPart
    0
    