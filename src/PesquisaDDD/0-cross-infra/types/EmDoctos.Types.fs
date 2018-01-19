namespace CrossInfra
// open System

// module rec EmDoctos = 
//   type NumProposta = NumProposta of Id
//   type PropApolice = PropApolice of int
//   type Endossos = Endossos of string[]
//   type TipoMovto = TipoMovto of string
//   type CliCodigo = CliCodigo of int
//   type CiaCodigo = CiaCodigo of int
//   type RamoCodigo = RamoCodigo of int
//   type PtoCodigo = PtoCodigo of int
//   type Apolice = Apolice of string
//   type Endosso = Endosso of string
//   type DataProposta = DataProposta of DateTime
//   type DataEmissao = DataEmissao of DateTime
//   type DataEntrada = DataEntrada of DateTime
//   type InicioVigenCia = InicioVigenCia of DateTime
//   type FinalVigenCia = FinalVigenCia of DateTime
//   type QtdParcelas = QtdParcelas of int
//   type Situacao = Situacao of string
//   type RenovNumero = RenovNumero of string
//   type CiaCodigoRenov = CiaCodigoRenov of int
//   type Anotacoes = Anotacoes of string
//   type ComissAdic = ComissAdic of string
//   type PropUltMov = PropUltMov of int
//   type TipoComiss = TipoComiss of string
//   type AgenCiaDebito = AgenCiaDebito of string
//   type PrimeiraAVista = PrimeiraAVista of string
//   type CliCodigoEstipulante = CliCodigoEstipulante of int
//   type FormaPagamento = FormaPagamento of string
//   type CliCodigoSubestipulante = CliCodigoSubestipulante of int
//   type RenovacaoInterna = RenovacaoInterna of string
//   type Controle = Controle of string
//   type BonusIndicacao = BonusIndicacao of int
//   type CiaRegCodigo = CiaRegCodigo of int
//   type MoedaCodigo = MoedaCodigo of int
//   type CotacData = CotacData of DateTime
//   type AdicionalFrac = AdicionalFrac of int
//   type Custo = Custo of int
//   type CliCodigoIndicacao = CliCodigoIndicacao of int
//   type Iof = Iof of int
//   type PremioTotal = PremioTotal of int
//   type DataEnvioProposta = DataEnvioProposta of DateTime
//   type PercComissao = PercComissao of int
//   type EstrutCodigo = EstrutCodigo of int
//   type PercComissaoExtra = PercComissaoExtra of int
//   type Comissao = Comissao of int
//   type SitrenCodigo = SitrenCodigo of int
//   type PercComissaoTotal = PercComissaoTotal of int
//   type DataDistrenov = DataDistrenov of DateTime
//   type DescComissao = DescComissao of int
//   type RrepCodigo = RrepCodigo of int
//   type MesBaseRenovacao = MesBaseRenovacao of string
//   type ContaDebito = ContaDebito of string
//   type TipoApolice = TipoApolice of string
//   type PremioServicoAdic = PremioServicoAdic of int
//   type Endosso2 = Endosso2 of string
//   type Apolice2 = Apolice2 of string
//   type PrimeiraParcela = PrimeiraParcela of int
//   type TpMovCodigo = TpMovCodigo of int
//   type BcoCodigoDebito = BcoCodigoDebito of string
//   type AudInclusaoUsr = AudInclusaoUsr of string
//   type AudInclusaoData = AudInclusaoData of DateTime
//   type AudAlteracaoUsr = AudAlteracaoUsr of string
//   type AudAlteracaoData = AudAlteracaoData of DateTime
//   type Tipo6 = Tipo6 of string
//   type NumProposta6 = NumProposta6 of int
//   type ComissaoOriginal = ComissaoOriginal of int
//   type FlgProbEndosso = FlgProbEndosso of string
//   type CodigoOrigem = CodigoOrigem of string
//   type Identificacao = Identificacao of string
//   type IntervaloVenc = IntervaloVenc of int
//   type ArquivoNumero = ArquivoNumero of string
//   type Sigiloso = Sigiloso of string
//   type PremioLiquidoOriginal = PremioLiquidoOriginal of int
//   type AdicionalFracOriginal = AdicionalFracOriginal of int
//   type LivroNumeroSusep = LivroNumeroSusep of int
//   type LivroPaginaSusep = LivroPaginaSusep of int
//   type LivroRegistroSusep = LivroRegistroSusep of int
//   type CiaCodigoOriginal = CiaCodigoOriginal of int
//   type PtoCodigoOriginal = PtoCodigoOriginal of int
//   type RamoCodigoOriginal = RamoCodigoOriginal of int
//   type VendCodigosOriginal = VendCodigosOriginal of string
//   type CcoCodigosOriginal = CcoCodigosOriginal of string
//   type OriCodigo = OriCodigo of int
//   type CnCodigo = CnCodigo of int
//   type CliDivCodigo = CliDivCodigo of int
//   type DataRecusa = DataRecusa of DateTime
//   type TpmovCodigoRecusa = TpmovCodigoRecusa of int
//   type CedenteBoleto = CedenteBoleto of int
//   type CodigoNegoCiacao = CodigoNegoCiacao of string
//   type DiaVencimento = DiaVencimento of int
//   type ComissOutrosServicos = ComissOutrosServicos of string
//   type NumPropRenovada = NumPropRenovada of int
//   type GeracaoAutomatica = GeracaoAutomatica of string
//   type NumPedido = NumPedido of int
//   type NumSequenCia = NumSequenCia of int

//   [<CustomEquality; NoComparison>]
//   type EmDoctos = {
//     NumProposta : NumProposta
//     PropApolice : PropApolice
//     Endossos : Endossos list
//     TipoMovto : TipoMovto
//     CliCodigo : CliCodigo
//     CiaCodigo : CiaCodigo
//     RamoCodigo : RamoCodigo
//     PtoCodigo : PtoCodigo
//     Apolice : Apolice
//     Endosso : Endosso
//     DataProposta : DataProposta
//     DataEmissao : DataEmissao
//     DataEntrada : DataEntrada
//     InicioVigenCia : InicioVigenCia
//     FinalVigenCia : FinalVigenCia
//     QtdParcelas : QtdParcelas
//     Situacao : Situacao
//     RenovNumero : RenovNumero
//     CiaCodigoRenov : CiaCodigoRenov
//     Anotacoes : Anotacoes
//     ComissAdic : ComissAdic
//     PropUltMov : PropUltMov
//     TipoComiss : TipoComiss
//     AgenCiaDebito : AgenCiaDebito
//     PrimeiraAVista : PrimeiraAVista
//     CliCodigoEstipulante : CliCodigoEstipulante
//     FormaPagamento : FormaPagamento
//     CliCodigoSubestipulante : CliCodigoSubestipulante
//     RenovacaoInterna : RenovacaoInterna
//     Controle : Controle
//     BonusIndicacao : BonusIndicacao
//     CiaRegCodigo : CiaRegCodigo
//     MoedaCodigo : MoedaCodigo
//     CotacData : CotacData
//     AdicionalFrac : AdicionalFrac
//     Custo : Custo
//     CliCodigoIndicacao : CliCodigoIndicacao
//     Iof : Iof
//     PremioTotal : PremioTotal
//     DataEnvioProposta : DataEnvioProposta
//     PercComissao : PercComissao
//     EstrutCodigo : EstrutCodigo
//     PercComissaoExtra : PercComissaoExtra
//     Comissao : Comissao
//     SitrenCodigo : SitrenCodigo
//     PercComissaoTotal : PercComissaoTotal
//     DataDistrenov : DataDistrenov
//     DescComissao : DescComissao
//     RrepCodigo : RrepCodigo
//     MesBaseRenovacao : MesBaseRenovacao
//     ContaDebito : ContaDebito
//     TipoApolice : TipoApolice
//     PremioServicoAdic : PremioServicoAdic
//     Endosso2 : Endosso2
//     Apolice2 : Apolice2
//     PrimeiraParcela : PrimeiraParcela
//     TpMovCodigo : TpMovCodigo
//     BcoCodigoDebito : BcoCodigoDebito
//     AudInclusaoUsr : AudInclusaoUsr
//     AudInclusaoData : AudInclusaoData
//     AudAlteracaoUsr : AudAlteracaoUsr
//     AudAlteracaoData : AudAlteracaoData
//     Tipo6 : Tipo6
//     NumProposta6 : NumProposta6
//     ComissaoOriginal : ComissaoOriginal
//     FlgProbEndosso : FlgProbEndosso
//     CodigoOrigem : CodigoOrigem
//     Identificacao : Identificacao
//     IntervaloVenc : IntervaloVenc
//     ArquivoNumero : ArquivoNumero
//     Sigiloso : Sigiloso
//     PremioLiquidoOriginal : PremioLiquidoOriginal
//     AdicionalFracOriginal : AdicionalFracOriginal
//     LivroNumeroSusep : LivroNumeroSusep
//     LivroPaginaSusep : LivroPaginaSusep
//     LivroRegistroSusep : LivroRegistroSusep
//     CiaCodigoOriginal : CiaCodigoOriginal
//     PtoCodigoOriginal : PtoCodigoOriginal
//     RamoCodigoOriginal : RamoCodigoOriginal
//     VendCodigosOriginal : VendCodigosOriginal
//     CcoCodigosOriginal : CcoCodigosOriginal
//     OriCodigo : OriCodigo
//     CnCodigo : CnCodigo
//     CliDivCodigo : CliDivCodigo
//     DataRecusa : DataRecusa
//     TpmovCodigoRecusa : TpmovCodigoRecusa
//     CedenteBoleto : CedenteBoleto
//     CodigoNegoCiacao : CodigoNegoCiacao
//     DiaVencimento : DiaVencimento
//     ComissOutrosServicos : ComissOutrosServicos
//     NumPropRenovada : NumPropRenovada
//     GeracaoAutomatica : GeracaoAutomatica
//     NumPedido : NumPedido
//     NumSequenCia : NumSequenCia
//   }
//   with 
//     override this.Equals(obj) =
//       match obj with
//       | :? EmDoctos as e -> this.NumProposta = e.NumProposta 
//       | _ -> false
//     override this.GetHashCode() =
//       hash this.NumProposta

