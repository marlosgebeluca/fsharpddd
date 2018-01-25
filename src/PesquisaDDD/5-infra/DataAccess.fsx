module DataAccess

#I @"../../../packages/SQLProvider/lib/net451"
#r @"FSharp.Data.SqlProvider.dll"

open FSharp.Data.Sql

let [<Literal>] DbVendor = Common.DatabaseProviderTypes.MSSQLSERVER

let [<Literal>] ConnString = @"Server=192.168.111.112\sql2012;Database=ddd_dev;User Id=sa;Password=Seguros1129!"

let [<Literal>] ConnexStringName = "DefaultConnectionString"

let [<Literal>] IndivAmount = 1000

let [<Literal>] UseOptTypes  = true

type Sql = SqlDataProvider<ConnectionString = ConnString,
                           ConnectionStringName = ConnexStringName,
                           DatabaseVendor = DbVendor,
                           IndividualsAmount = IndivAmount,
                           UseOptionTypes = UseOptTypes>

// let ctx = Sql.GetDataContext()

// let emDoctos = 
//   query {
//     for doc in ctx.Dados.EmDoctos do
//     where (doc.DocNumProposta > 0)
//     head
//   }                           