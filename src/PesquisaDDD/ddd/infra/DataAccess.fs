namespace Infra
open FSharp.Data.Sql

module DataAccess = 
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