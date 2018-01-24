module DataAccess 

// #if INTERACTIVE
#r "../../../packages/SQLProvider/lib/net451/FSharp.Data.SqlProvider.dll"
// #endif

open FSharp.Data.Sql

let [<Literal>] DbVendor = Common.DatabaseProviderTypes.MSSQLSERVER

let [<Literal>] ConnString = "Server=192.168.111.112\\sql2012;Database=ddd_dev;User Id=sa;Password=Seguros1129!"

let [<Literal>] ConnexStringName = "DefaultConnectionString"

let [<Literal>] IndivAmount = 1000

let [<Literal>] UseOptTypes  = true

// type Sql = SqlDataProvider<DbVendor,
//                            ConnString,
//                            IndividualsAmount = IndivAmount,
//                            UseOptionTypes = UseOptTypes>