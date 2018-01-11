namespace FsharpdddPesquisa.Domain  
open System

/// Validação com 2 caracteres ou menos, not null
type String02 = private String02 of string

type DocTipoMovto = private DocTipoMovto of String02

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

module DocTipoMovto = 
    /// Retorna o valor da string dentro de DocTipoMovto s
    let value (DocTipoMovto str) = str

    /// Cria uma DocTipoMovto
    /// Retorna o erro se valor da string for null ou vazia
    let create str =
        if String.IsNullOrEmpty(str) then
            let msg = sprintf "DocTipoMovto: deve ser um valor valido" 
            Error msg
        else if str.Contains("AP") 
            || str.Contains("CO") 
            || str.Contains("RE") 
            || str.Contains("SM") 
            || str.Contains("CA") 
            || str.Contains("FT") then
                ConstrainedType.createStringOption "DocTipoMovto" String02 02 str
        else 
            let msg = sprintf "DocTipoMovto: Format not recognized '%s'" str
            Error msg
