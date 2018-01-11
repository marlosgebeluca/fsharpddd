namespace FsharpdddPesquisa.Domain
open System

type ApoliceService () = 
  interface IApoliceService with
    member this.Find(apolice) =
      Console.WriteLine "Find Apolice Service"
      "Not Implemented Yet"      
    member this.FindOne(id) = 
      Console.WriteLine "Find One Apolice Service"
      "Not Implemented Yet"
    member this.Create(apolice) = 
      Console.WriteLine "Create Apolice Service"
      "Not Implemented Yet"
    member this.Update(id, apolice) = 
      Console.WriteLine "Update Apolice Service"
      "Not Implemented Yet"
    member this.Delete(id) = 
      Console.WriteLine "Delete Apolice Service"
      "Not Implemented Yet"