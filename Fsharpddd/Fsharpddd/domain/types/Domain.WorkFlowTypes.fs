namespace FsharpdddPesquisa.Domain

type Endosso = {
  NumProposta : EndossoId
  DocTipoMovto : DocTipoMovto
  DocPropApolice : DocPropApolice
  // NumeroEndosso : NumeroEndosso
  // DocEndosso2 : DocEndosso2
  // FlgProbEndosso : FlgProbEndosso
  // CliCodigo : CliCodigo
  // CiaCodigo : CiaCodigo
  // RamoCodigo : RamoCodigo
  // PtoCodigo : PtoCodigo
  DocApolice : DocApolice
  // DocDataProposta : DocDataProposta
  // DocDataEmissao : DocDataEmissao
  // DocDataEntrada : DocDataEntrada
  // DocInicioVigencia : DocInicioVigencia
  // DocFinalVigencia : DocFinalVigencia
  // DocQtdParcelas : DocQtdParcelas
  // DocSituacao : DocSituacao
  // DocRenovNumero : DocRenovNumero
  // CiaCodigoRenov : CiaCodigoRenov
  // DocAnotacoes : DocAnotacoes
  // DocPropUltMov : DocPropUltMov
  // DocTipoComiss : DocTipoComiss
  // DocAgenciaDebito : DocAgenciaDebito
  // DocPrimeiraAVista : DocPrimeiraAVista
  // CliCodigoEstipulante : CliCodigoEstipulante
  // DocFormaPagamento : DocFormaPagamento
  // CliCodigoSubestipulante : CliCodigoSubestipulante
  // DocRenovacaoInterna : DocRenovacaoInterna
  // DocControle : DocControle
  // DocBonusIndicacao : DocBonusIndicacao
  // CiaRegCodigo : CiaRegCodigo
  // MoedaCodigo : MoedaCodigo
  // CotacData : CotacData
  // DocAdicionalFrac : DocAdicionalFrac
  // DocCusto : DocCusto
  // CliCodigoIndicacao : CliCodigoIndicacao
  // DocIof : DocIof
  // DocPremioTotal : DocPremioTotal
  // DocDataEnvioProposta : DocDataEnvioProposta
  // DocPercComissao : DocPercComissao
  // EstrutCodigo : EstrutCodigo
  // DocPercComissaoExtra : DocPercComissaoExtra
  // DocComissao : DocComissao
  // SitrenCodigo : SitrenCodigo
  // DocPercComissaoTotal : DocPercComissaoTotal
  // DocDataDistrenov : DocDataDistrenov
  // DocDescComissao : DocDescComissao
  // RrepCodigo : RrepCodigo
  // DocMesBaseRenovacao : DocMesBaseRenovacao
  // DocContaDebito : DocContaDebito
  // DocTipoApolice : DocTipoApolice
  // DocPremioServicoAdic : DocPremioServicoAdic
  // DocApolice2 : DocApolice2
  // DocPrimeiraParcela : DocPrimeiraParcela
  // TpMovCodigo : TpMovCodigo
  // BcoCodigoDebito : BcoCodigoDebito
  // AudInclusaoUsr : AudInclusaoUsr
  // AudInclusaoData : AudInclusaoData
  // AudAlteracaoUsr : AudAlteracaoUsr
  // AudAlteracaoData : AudAlteracaoData
  // DocTipo6 : DocTipo6
  // DocNumProposta6 : DocNumProposta6
  // DocComissaoOriginal : DocComissaoOriginal
  // DocCodigoOrigem : DocCodigoOrigem
  // DocIdentificacao : DocIdentificacao
  // DocIntervaloVenc : DocIntervaloVenc
  // DocArquivoNumero : DocArquivoNumero
  // DocSigiloso : DocSigiloso
  // DocPremioLiquidoOriginal : DocPremioLiquidoOriginal
  // DocAdicionalFracOriginal : DocAdicionalFracOriginal
  // DocLivroNumeroSusep : DocLivroNumeroSusep
  // DocLivroPaginaSusep : DocLivroPaginaSusep
  // DocLivroRegistroSusep : DocLivroRegistroSusep
  // CiaCodigoOriginal : CiaCodigoOriginal
  // PtoCodigoOriginal : PtoCodigoOriginal
  // RamoCodigoOriginal : RamoCodigoOriginal
  // VendCodigosOriginal : VendCodigosOriginal
  // CcoCodigosOriginal : CcoCodigosOriginal
  // DocoriCodigo : DocoriCodigo
  // CnCodigo : CnCodigo
  // CliDivCodigo : CliDivCodigo
  // DocDataRecusa : DocDataRecusa
  // TpmovCodigoRecusa : TpmovCodigoRecusa
  // DocCedenteBoleto : DocCedenteBoleto
  // DocCodigoNegociacao : DocCodigoNegociacao
  // DocDiaVencimento : DocDiaVencimento
  // DocComissOutrosServicos : DocComissOutrosServicos
  // DocNumPropRenovada : DocNumPropRenovada
  // DocGeracaoAutomatica : DocGeracaoAutomatica
  // NumPedido : NumPedido
  // NumSequencia : NumSequencia
}

type Apolice = {
  NumProposta : ApoliceId
  Endossos : Endosso[] option
  DocTipoMovto : DocTipoMovto
  // CliCodigo : CliCodigo
  // CiaCodigo : CiaCodigo
  // RamoCodigo : RamoCodigo
  // PtoCodigo : PtoCodigo
  DocApolice : DocApolice
  // DocDataProposta : DocDataProposta
  // DocDataEmissao : DocDataEmissao
  // DocDataEntrada : DocDataEntrada
  // DocInicioVigencia : DocInicioVigencia
  // DocFinalVigencia : DocFinalVigencia
  // DocQtdParcelas : DocQtdParcelas
  // DocSituacao : DocSituacao
  // DocRenovNumero : DocRenovNumero
  // CiaCodigoRenov : CiaCodigoRenov
  // DocAnotacoes : DocAnotacoes
  // DocPropUltMov : DocPropUltMov
  // DocTipoComiss : DocTipoComiss
  // DocAgenciaDebito : DocAgenciaDebito
  // DocPrimeiraAVista : DocPrimeiraAVista
  // CliCodigoEstipulante : CliCodigoEstipulante
  // DocFormaPagamento : DocFormaPagamento
  // CliCodigoSubestipulante : CliCodigoSubestipulante
  // DocRenovacaoInterna : DocRenovacaoInterna
  // DocControle : DocControle
  // DocBonusIndicacao : DocBonusIndicacao
  // CiaRegCodigo : CiaRegCodigo
  // MoedaCodigo : MoedaCodigo
  // CotacData : CotacData
  // DocAdicionalFrac : DocAdicionalFrac
  // DocCusto : DocCusto
  // CliCodigoIndicacao : CliCodigoIndicacao
  // DocIof : DocIof
  // DocPremioTotal : DocPremioTotal
  // DocDataEnvioProposta : DocDataEnvioProposta
  // DocPercComissao : DocPercComissao
  // EstrutCodigo : EstrutCodigo
  // DocPercComissaoExtra : DocPercComissaoExtra
  // DocComissao : DocComissao
  // SitrenCodigo : SitrenCodigo
  // DocPercComissaoTotal : DocPercComissaoTotal
  // DocDataDistrenov : DocDataDistrenov
  // DocDescComissao : DocDescComissao
  // RrepCodigo : RrepCodigo
  // DocMesBaseRenovacao : DocMesBaseRenovacao
  // DocContaDebito : DocContaDebito
  // DocTipoApolice : DocTipoApolice
  // DocPremioServicoAdic : DocPremioServicoAdic
  // DocApolice2 : DocApolice2
  // DocPrimeiraParcela : DocPrimeiraParcela
  // TpMovCodigo : TpMovCodigo
  // BcoCodigoDebito : BcoCodigoDebito
  // AudInclusaoUsr : AudInclusaoUsr
  // AudInclusaoData : AudInclusaoData
  // AudAlteracaoUsr : AudAlteracaoUsr
  // AudAlteracaoData : AudAlteracaoData
  // DocTipo6 : DocTipo6
  // DocNumProposta6 : DocNumProposta6
  // DocComissaoOriginal : DocComissaoOriginal
  // DocCodigoOrigem : DocCodigoOrigem
  // DocIdentificacao : DocIdentificacao
  // DocIntervaloVenc : DocIntervaloVenc
  // DocArquivoNumero : DocArquivoNumero
  // DocSigiloso : DocSigiloso
  // DocPremioLiquidoOriginal : DocPremioLiquidoOriginal
  // DocAdicionalFracOriginal : DocAdicionalFracOriginal
  // DocLivroNumeroSusep : DocLivroNumeroSusep
  // DocLivroPaginaSusep : DocLivroPaginaSusep
  // DocLivroRegistroSusep : DocLivroRegistroSusep
  // CiaCodigoOriginal : CiaCodigoOriginal
  // PtoCodigoOriginal : PtoCodigoOriginal
  // RamoCodigoOriginal : RamoCodigoOriginal
  // VendCodigosOriginal : VendCodigosOriginal
  // CcoCodigosOriginal : CcoCodigosOriginal
  // DocoriCodigo : DocoriCodigo
  // CnCodigo : CnCodigo
  // CliDivCodigo : CliDivCodigo
  // DocDataRecusa : DocDataRecusa
  // TpmovCodigoRecusa : TpmovCodigoRecusa
  // DocCedenteBoleto : DocCedenteBoleto
  // DocCodigoNegociacao : DocCodigoNegociacao
  // DocDiaVencimento : DocDiaVencimento
  // DocComissOutrosServicos : DocComissOutrosServicos
  // DocNumPropRenovada : DocNumPropRenovada
  // DocGeracaoAutomatica : DocGeracaoAutomatica
  // NumPedido : NumPedido
  // NumSequencia : NumSequencia
}

type ApoliceInvalida = {
  NumProposta : int
  DocTipoMovto : string
  DocApolice : int
}

type EndossoInvalido = {
  NumProposta : int
  DocPropApolice : int
  DocTipoMovto : string
  DocApolice : int
}

type IApoliceService = 
  abstract Find : ApoliceInvalida -> string
  abstract FindOne : int -> string
  abstract Create : ApoliceInvalida -> string
  abstract Update : int * ApoliceInvalida -> string
  abstract Delete : int -> string

type IEndossoService = 
  abstract Find : EndossoInvalido -> string
  abstract FindOne : int -> string
  abstract Create : EndossoInvalido -> string
  abstract Update : int * EndossoInvalido -> string
  abstract Delete : int -> string

type IApoliceRepository = 
  abstract Find : ApoliceInvalida -> Apolice[]
  abstract FindOne : int -> Apolice
  abstract Create : ApoliceInvalida -> Apolice
  abstract Update : int * ApoliceInvalida -> Apolice
  abstract Delete : int -> string

type IEndossoRepository = 
  abstract Find : EndossoInvalido -> Endosso[]
  abstract FindOne : int -> Endosso
  abstract Create : EndossoInvalido -> Endosso
  abstract Update : int * EndossoInvalido -> Endosso
  abstract Delete : int -> string  