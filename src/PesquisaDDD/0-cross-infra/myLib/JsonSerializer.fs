namespace CrossInfra

module JsonSerializer = 
  let serializer = System.Web.Script.Serialization.JavaScriptSerializer()

  let jsonToObj<'T> json = 
    serializer.Deserialize<'T>(json)   

  let objToJson obj = 
    serializer.Serialize(obj)