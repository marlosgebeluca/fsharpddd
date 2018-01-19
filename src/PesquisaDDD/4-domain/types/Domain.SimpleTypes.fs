namespace Domain
open System

// Symple Types
type String01 = String01 of string
type String02 = String02 of string
type String15 = String15 of string
type String18 = String18 of string
type String20 = String20 of string
type String25 = String25 of string
type String30 = String30 of string
type String32 = String32 of string
type String40 = String40 of string
type String50 = String50 of string
type String60 = String60 of string
type String100 = String100 of string
type String200 = String200 of string
type String400 = String400 of string

module ConstrainedType =
  /// Create a constrained string using the constructor provided
  /// Return Error if input is null, empty, or length > maxLen
  let createString name ctor maxLen str = 
    if String.IsNullOrEmpty(str) then
      let msg = sprintf "%s must not be null or empty" name 
      Error msg
    elif str.Length > maxLen then
      let msg = sprintf "%s must not be more than %i chars" name maxLen 
      Error msg 
    else
      Ok (ctor str)

  /// Create a optional constrained string using the constructor provided
  /// Return None if input is null, empty. 
  /// Return error if length > maxLen
  /// Return Some if the input is valid
  let createStringOption name ctor maxLen str = 
    if String.IsNullOrEmpty(str) then
      Ok None
    elif str.Length > maxLen then
      let msg = sprintf "%s must not be more than %i chars" name maxLen 
      Error msg 
    else
      Ok (ctor str |> Some)

  /// Create a constrained integer using the constructor provided
  /// Return Error if input is less than minVal or more than maxVal
  let createInt name ctor minVal maxVal i = 
    if i < minVal then
      let msg = sprintf "%s: Must not be less than %i" name minVal
      Error msg
    elif i > maxVal then
      let msg = sprintf "%s: Must not be greater than %i" name maxVal
      Error msg
    else
      Ok (ctor i)

  /// Create a constrained decimal using the constructor provided
  /// Return Error if input is less than minVal or more than maxVal
  let createDecimal name ctor minVal maxVal i = 
    if i < minVal then
      let msg = sprintf "%s: Must not be less than %M" name minVal
      Error msg
    elif i > maxVal then
      let msg = sprintf "%s: Must not be greater than %M" name maxVal
      Error msg
    else
      Ok (ctor i)

  /// Create a constrained string using the constructor provided
  /// Return Error if input is null. empty, or does not match the regex pattern
  let createLike name ctor pattern str = 
    if String.IsNullOrEmpty(str) then
      let msg = sprintf "%s: Must not be null or empty" name 
      Error msg
    elif System.Text.RegularExpressions.Regex.IsMatch(str,pattern) then
      Ok (ctor str)
    else
      let msg = sprintf "%s: '%s' must match the pattern '%s'" name str pattern
      Error msg 

module String01 =
  /// Retorna Valor da String02
  let value (String01 str) = str

  /// Cria uma String01
  /// Retorna Erro se valor for null ou tamanho diferente de 1
  let create str =
    ConstrainedType.createString "String01" String01 1 str

  /// Cria uma String01
  /// Retorna Erro se valor for null ou tamanho diferente de 1
  let createOption str = 
      ConstrainedType.createStringOption "String01" String01 01 str

module String02 =
  /// Retorna Valor da String02
  let value (String02 str) = str

  /// Cria uma String02
  /// Retorna Erro se valor for null ou tamanho diferente de 2
  let create str =
    ConstrainedType.createString "String02" String02 2 str

  /// Cria uma String02
  /// Retorna Erro se valor for null ou tamanho diferente de 2
  let createOption str = 
      ConstrainedType.createStringOption "String02" String02 02 str      

module String15 =
  /// Retorna Valor da String15
  let value (String15 str) = str

  /// Cria uma String15
  /// Retorna Erro se valor for null ou tamanho diferente de 15
  let create str =
    ConstrainedType.createString "String15" String15 15 str

  /// Cria uma String15
  /// Retorna Erro se valor for null ou tamanho diferente de 15
  let createOption str = 
      ConstrainedType.createStringOption "String15" String15 15 str      

module String18 =
  /// Retorna Valor da String18
  let value (String18 str) = str

  /// Cria uma String18
  /// Retorna Erro se valor for null ou tamanho diferente de 18
  let create str =
    ConstrainedType.createString "String18" String18 18 str

  /// Cria uma String18
  /// Retorna Erro se valor for null ou tamanho diferente de 18
  let createOption str = 
      ConstrainedType.createStringOption "String18" String18 18 str

module String20 =
  /// Retorna Valor da String20
  let value (String20 str) = str

  /// Cria uma String20
  /// Retorna Erro se valor for null ou tamanho diferente de 20
  let create str =
    ConstrainedType.createString "String20" String20 20 str

  /// Cria uma String20
  /// Retorna Erro se valor for null ou tamanho diferente de 20
  let createOption str = 
      ConstrainedType.createStringOption "String20" String20 20 str

module String25 =
  /// Retorna Valor da String25
  let value (String25 str) = str

  /// Cria uma String25
  /// Retorna Erro se valor for null ou tamanho diferente de 25
  let create str =
    ConstrainedType.createString "String25" String25 25 str

  /// Cria uma String25
  /// Retorna Erro se valor for null ou tamanho diferente de 25
  let createOption str = 
      ConstrainedType.createStringOption "String25" String25 25 str

module String30 =
  /// Retorna Valor da String32
  let value (String30 str) = str

  /// Cria uma String30
  /// Retorna Erro se valor for null ou tamanho diferente de 30
  let create str =
    ConstrainedType.createString "String30" String30 30 str

  /// Cria uma String30
  /// Retorna Erro se valor for null ou tamanho diferente de 30
  let createOption str = 
      ConstrainedType.createStringOption "String30" String30 30 str

module String32 =
  /// Retorna Valor da String32
  let value (String32 str) = str

  /// Cria uma String32
  /// Retorna Erro se valor for null ou tamanho diferente de 32
  let create str =
    ConstrainedType.createString "String32" String32 32 str

  /// Cria uma String32
  /// Retorna Erro se valor for null ou tamanho diferente de 32
  let createOption str = 
      ConstrainedType.createStringOption "String32" String32 32 str

module String40 =
  /// Retorna Valor da String40
  let value (String40 str) = str

  /// Cria uma String40
  /// Retorna Erro se valor for null ou tamanho diferente de 40
  let create str =
    ConstrainedType.createString "String40" String40 40 str

  /// Cria uma String40
  /// Retorna Erro se valor for null ou tamanho diferente de 40
  let createOption str = 
      ConstrainedType.createStringOption "String40" String40 40 str

module String50 =
  /// Retorna Valor da String50
  let value (String50 str) = str

  /// Cria uma String50
  /// Retorna Erro se valor for null ou tamanho diferente de 50
  let create str =
    ConstrainedType.createString "String50" String50 50 str

  /// Cria uma String50
  /// Retorna Erro se valor for null ou tamanho diferente de 50
  let createOption str = 
      ConstrainedType.createStringOption "String50" String50 50 str

module String60 =
  /// Retorna Valor da String60
  let value (String60 str) = str

  /// Cria uma String60
  /// Retorna Erro se valor for null ou tamanho diferente de 60
  let create str =
    ConstrainedType.createString "String60" String60 60 str

  /// Cria uma String60
  /// Retorna Erro se valor for null ou tamanho diferente de 60
  let createOption str = 
      ConstrainedType.createStringOption "String60" String60 60 str

module String100 =
  /// Retorna Valor da String100
  let value (String100 str) = str

  /// Cria uma String100
  /// Retorna Erro se valor for null ou tamanho diferente de 100
  let create str =
    ConstrainedType.createString "String100" String100 100 str

  /// Cria uma String100
  /// Retorna Erro se valor for null ou tamanho diferente de 100
  let createOption str = 
      ConstrainedType.createStringOption "String100" String100 100 str

module String200 =
  /// Retorna Valor da String200
  let value (String200 str) = str

  /// Cria uma String200
  /// Retorna Erro se valor for null ou tamanho diferente de 200
  let create str =
    ConstrainedType.createString "String200" String200 200 str

  /// Cria uma String200
  /// Retorna Erro se valor for null ou tamanho diferente de 200
  let createOption str = 
      ConstrainedType.createStringOption "String200" String200 200 str

module String400 =
  /// Retorna Valor da String400
  let value (String02 str) = str

  /// Cria uma String400
  /// Retorna Erro se valor for null ou tamanho diferente de 400
  let create str =
    ConstrainedType.createString "String400" String400 400 str

  /// Cria uma String400
  /// Retorna Erro se valor for null ou tamanho diferente de 400
  let createOption str = 
      ConstrainedType.createStringOption "String400" String400 400 str            

