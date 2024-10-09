using System;
using System.Collections.Generic;

namespace PantheonApi.Models;
public partial class THeMove
{
    public string AcKey { get; set; } = null!;

    public string AcDocType { get; set; } = null!;

    public DateTime AdDate { get; set; }

    public string AcReceiver { get; set; } = null!;

    public string AcIssuer { get; set; } = null!;

    public string? AcReceiverStock { get; set; }

    public string? AcIssuerStock { get; set; }

    public string AcPrsn3 { get; set; } = null!;

    public string AcContactPrsn { get; set; } = null!;

    public string? AcDoc1 { get; set; }

    public DateTime? AdDateDoc1 { get; set; }

    public string? AcDoc2 { get; set; }

    public DateTime? AdDateDoc2 { get; set; }

    public string? AcStatement { get; set; }

    public string? AcWayOfSale { get; set; }

    public string? AcPriceRate { get; set; }

    public string AcPayMethod { get; set; } = null!;

    public string AcDelivery { get; set; } = null!;

    public string? AcForm { get; set; }

    public string? AcInvoiceForm { get; set; }

    public DateTime AdDateInv { get; set; }

    public int AnDaysForPayment { get; set; }

    public DateTime? AdDateDue { get; set; }

    public decimal AnValue { get; set; }

    public decimal AnVat { get; set; }

    public decimal AnDiscount { get; set; }

    public decimal AnForPay { get; set; }

    public string AcLimitDuty { get; set; } = null!;

    public int AnClerk { get; set; }

    public string? AcVerifiedPrices { get; set; }

    public string AcCurrency { get; set; } = null!;

    public decimal AnCurrValue { get; set; }

    public string? AcCode1 { get; set; }

    public string? AcCode2 { get; set; }

    public string? AcCode3 { get; set; }

    public string? AcPayPurpose1 { get; set; }

    public string? AcPayPurpose2 { get; set; }

    public string? AcPayPurpose3 { get; set; }

    public string? AcRefNo1 { get; set; }

    public string? AcRefNo2 { get; set; }

    public string AcDept { get; set; } = null!;

    public string? AcContactPrsn3 { get; set; }

    public decimal AnRebate { get; set; }

    public decimal AnTransport { get; set; }

    public decimal AnDuty { get; set; }

    public double AnDirectCost { get; set; }

    public decimal AnIncTax { get; set; }

    public string? AcPosted { get; set; }

    public string? AcTransPaperForm { get; set; }

    public decimal AnVatin { get; set; }

    public DateTime? AdDateVat { get; set; }

    public string AcParity { get; set; } = null!;

    public string AcParityPost { get; set; } = null!;

    public string? AcDutyTran { get; set; }

    public decimal AnVatbase { get; set; }

    public int AnBnkAcctNo { get; set; }

    public string? AcCreatFromWo { get; set; }

    public DateTime? AdDateBeforeVat { get; set; }

    public string AcIsocountry { get; set; } = null!;

    public string AcTriangTrans { get; set; } = null!;

    public string AcAcctClaimLiab { get; set; } = null!;

    public string? AcVatattType { get; set; }

    public DateTime? AdVatattDate { get; set; }

    public string? AcCreatePayOrd { get; set; }

    public string AcDeptOut { get; set; } = null!;

    public string AcCostDrvOut { get; set; } = null!;

    public int AnNoteClerk { get; set; }

    public DateTime? AdDateDdvpay { get; set; }

    public DateTime? AdTimeIns { get; set; }

    public int? AnUserIns { get; set; }

    public DateTime? AdTimeChg { get; set; }

    public int? AnUserChg { get; set; }

    public string AcContractNo { get; set; } = null!;

    public string? AcIdbcstate { get; set; }

    public decimal AnRoundItem { get; set; }

    public decimal AnRoundValue { get; set; }

    public string? AcRoundVatonDoc { get; set; }

    public string? AcRefNo3 { get; set; }

    public string? AcRefNo4 { get; set; }

    public string? AcPackNum { get; set; }

    public string AcDocTypePayOrd { get; set; } = null!;

    public string AcDocTypePayOrdFgn { get; set; } = null!;

    public int? AnOurBankAcctNo { get; set; }

    public string? AcNote { get; set; }

    public string? AcInternalNote { get; set; }

    public int? AnFgnBankNo { get; set; }

    public string AcVerifyStatus { get; set; } = null!;

    public int AnSigner1 { get; set; }

    public DateTime? AdSigned1 { get; set; }

    public int AnSigner2 { get; set; }

    public DateTime? AdSigned2 { get; set; }

    public int AnSigner3 { get; set; }

    public DateTime? AdSigned3 { get; set; }

    public string? AcFiskPrintNo { get; set; }

    public string? AcFiskPrintNoS { get; set; }

    public string? AcTransportCalcType { get; set; }

    public string? AcFieldSa { get; set; }

    public string? AcFieldSb { get; set; }

    public string? AcFieldSc { get; set; }

    public string? AcFieldSd { get; set; }

    public string? AcFieldSe { get; set; }

    public string? AcFieldSf { get; set; }

    public string? AcFieldSg { get; set; }

    public string? AcFieldSh { get; set; }

    public string? AcFieldSi { get; set; }

    public string? AcFieldSj { get; set; }

    public decimal? AnFieldNa { get; set; }

    public decimal? AnFieldNb { get; set; }

    public decimal? AnFieldNc { get; set; }

    public decimal? AnFieldNd { get; set; }

    public decimal? AnFieldNe { get; set; }

    public decimal? AnFieldNf { get; set; }

    public decimal? AnFieldNg { get; set; }

    public decimal? AnFieldNh { get; set; }

    public decimal? AnFieldNi { get; set; }

    public decimal? AnFieldNj { get; set; }

    public DateTime? AdFieldDa { get; set; }

    public DateTime? AdFieldDb { get; set; }

    public DateTime? AdFieldDc { get; set; }

    public DateTime? AdFieldDd { get; set; }

    public string? AcUpnreference { get; set; }

    public string? AcUpncode { get; set; }

    public string? AcUpncontrolNum { get; set; }

    public string? AcProc { get; set; }

    public string AcLoyaltyCard { get; set; } = null!;

    public string AcParityType { get; set; } = null!;

    public decimal? AnPaid2 { get; set; }

    public string? AcUpnprint { get; set; }

    public int AnQid { get; set; }

    public string? AcInsFromImport { get; set; }

    public string? AcNote2 { get; set; }

    public string? AcNote3 { get; set; }

    public decimal? AnLicensesBase { get; set; }

    public decimal? AnLicensesVat { get; set; }

    public DateTime? AdTimeFiscal { get; set; }

    public int? AnSeqWhNoIn { get; set; }

    public int? AnSeqWhNoOut { get; set; }

    public decimal AnRoundItemFc { get; set; }

    public string? AcDeliveryUnderArt163a { get; set; }

    public decimal AnRoundValueOc { get; set; }

    public decimal AnRoundPrice { get; set; }

    public string? AcUjpdocId { get; set; }

    public string AcFiscSalesBookSetNo { get; set; } = null!;

    public string AcFiscSalesBookSerNo { get; set; } = null!;

    public string AcFiscSalesBookDocNo { get; set; } = null!;

    public DateTime? AdDateTimePrint { get; set; }

    public int AnSequence { get; set; }

    public string AcVatexclude { get; set; } = null!;

    public string AcFiscExclude { get; set; } = null!;

    public decimal AnRefund { get; set; }

    public decimal AnRefundCurr { get; set; }

    public double? AnReverseChargeCoefficient { get; set; }

    public string? AcFiscStatus { get; set; }

    public string? AcTransporter { get; set; }

    public string? AcVehicleRegistrationNumber { get; set; }

    public string? AcTrailerRegistrationNumber { get; set; }

    public int? AnTradeLedgerNo { get; set; }

    public int? AnOurBankAcctNoFgn { get; set; }

    public string? AcRetailSale { get; set; }

    public int? AnRoomTableId { get; set; }

    public decimal AnFxrate { get; set; }

    public string? AcInsertedFrom { get; set; }

    public string AcMoveTranType { get; set; } = null!;

    public string? AcCostDutyCalcType { get; set; }

    public string? AcUseFiscalRounding { get; set; }

    public DateTime? AdTransportDate { get; set; }

    public string? AcCorrType { get; set; }

    public string? AcVatpaidByOurComp { get; set; }

    public string? AcDutyPaidByOurComp { get; set; }

    public string? AcBuyerCostCenterId { get; set; }

    public string? AcExcisePaidByOurComp { get; set; }

    public string? AcFiscPaymentChange { get; set; }

    public string? AcFiscPayMethodOld { get; set; }

    public string? AcTaxIdentificationCardNum { get; set; }

    public string AcPayMethodOld { get; set; } = null!;

    public string? AcBuyerId { get; set; }

    public int? AnBuyerCostCenterIdDef { get; set; }

    public int? AnBuyerIdDef { get; set; }

    public DateTime? AdAdvancePayment { get; set; }

    public string? AcSpecPayment { get; set; }

    public string? AcStockStartInventory { get; set; }

    public string AcSetOfDeal { get; set; } = null!;

    public decimal? AnVatpart { get; set; }

    public string? AcProtocol { get; set; }

    public string? AcAddress { get; set; }

    public string? AcPost { get; set; }

    public string? AcVatchecked { get; set; }

    public decimal? AnPaidCashReg { get; set; }

    public decimal? AnPaidAcct { get; set; }

    public decimal? AnPaidPrepayment { get; set; }

    public string? AcStornoType { get; set; }

    public string? AcKeyView { get; set; }

    public virtual THeSetSubj AcDeptNavigation { get; set; } = null!;

    public virtual THeSetSubj AcDeptOutNavigation { get; set; } = null!;

    public virtual THeSetSubj AcIssuerNavigation { get; set; } = null!;

    public virtual THeSetSubj AcPrsn3Navigation { get; set; } = null!;

    public virtual THeSetSubj AcReceiverNavigation { get; set; } = null!;

    public virtual ICollection<THeMoveItem> THeMoveItems { get; set; } = new List<THeMoveItem>();
}
