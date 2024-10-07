using System;
using System.Collections.Generic;

namespace PantheonApi.Models;

public partial class THeSetItem
{
    public string AcIdent { get; set; } = null!;

    public string? AcName { get; set; }

    public string AcClassif { get; set; } = null!;

    public double AnSubClassif { get; set; }

    public string AcClassif2 { get; set; } = null!;

    public string AcCode { get; set; } = null!;

    public string AcSetOfItem { get; set; } = null!;

    public string AcSupplier { get; set; } = null!;

    public string AcFormula { get; set; } = null!;

    public decimal AnVat { get; set; }

    public string AcCurrency { get; set; } = null!;

    public decimal AnSalePrice { get; set; }

    public double AnRtprice { get; set; }

    public double AnWsprice { get; set; }

    public double AnWsprice2 { get; set; }

    public double AnPrStPrice { get; set; }

    public double AnBuyPrice { get; set; }

    public double? AnProdPrice { get; set; }

    public string AcUm { get; set; } = null!;

    public decimal AnUmtoUm2 { get; set; }

    public string AcUm2 { get; set; } = null!;

    public string AcVatcode { get; set; } = null!;

    public string AcVatcodeLow { get; set; } = null!;

    public decimal AnDiscount { get; set; }

    public int AnWarrenty { get; set; }

    public string? AcSerialNo { get; set; }

    public string? AcActive { get; set; }

    public string? AcHttppath { get; set; }

    public string? AcMakeCalc { get; set; }

    public double AnPrice { get; set; }

    public double AnRebate { get; set; }

    public double AnTransport { get; set; }

    public double AnDuty { get; set; }

    public double AnDirectCost { get; set; }

    public double AnIncTax { get; set; }

    public double AnWsprice2P { get; set; }

    public double AnWspriceP { get; set; }

    public double AnRtpriceP { get; set; }

    public decimal AnMinStock { get; set; }

    public string? AcStandardize { get; set; }

    public string AcDocTypeOrdSupp { get; set; } = null!;

    public string AcDocTypeProd { get; set; } = null!;

    public decimal AnDimHeight { get; set; }

    public decimal AnDimWidth { get; set; }

    public decimal AnDimDepth { get; set; }

    public decimal AnDimWeight { get; set; }

    public decimal AnDimWeightBrutto { get; set; }

    public string AcCustTariff { get; set; } = null!;

    public double AnPriceSupp { get; set; }

    public double AnPrStPriceP { get; set; }

    public string AcPurchCurr { get; set; } = null!;

    public string? AcOrderTransInMf { get; set; }

    public string AcOrigin { get; set; } = null!;

    public string AcDeclarForOriginType { get; set; } = null!;

    public string AcAcct { get; set; } = null!;

    public string? AcFieldSa { get; set; }

    public string? AcFieldSb { get; set; }

    public string? AcFieldSc { get; set; }

    public decimal AnFieldNa { get; set; }

    public decimal AnFieldNb { get; set; }

    public string? AcEvidence { get; set; }

    public double AnExcise { get; set; }

    public double AnExciseP { get; set; }

    public decimal AnMaxStock { get; set; }

    public decimal AnOptStock { get; set; }

    public string? AcDeclarForOrigin { get; set; }

    public string AcDept { get; set; } = null!;

    public string? AcQtyInCode { get; set; }

    public string AcUmdim1 { get; set; } = null!;

    public string AcUmdim2 { get; set; } = null!;

    public decimal AnWasteQty { get; set; }

    public string AcUmseries { get; set; } = null!;

    public decimal AnQtySeries { get; set; }

    public string AcColumn { get; set; } = null!;

    public decimal AnUmtoUm3 { get; set; }

    public string AcUm3 { get; set; } = null!;

    public decimal AnUmtoDeclarReport { get; set; }

    public string? AcReportDeclar { get; set; }

    public decimal AnFieldNc { get; set; }

    public decimal AnFieldNd { get; set; }

    public decimal AnFieldNe { get; set; }

    public string? AcFieldSd { get; set; }

    public string? AcFieldSe { get; set; }

    public string? AcPrstUmtime { get; set; }

    public double? AnPrstTime { get; set; }

    public int? AnPrStInsertUserId { get; set; }

    public DateTime? AdPrStInsertTime { get; set; }

    public int? AnPrStUpdateUserId { get; set; }

    public DateTime? AdPrStUpdateTime { get; set; }

    public int? AnPrStCheckUserId { get; set; }

    public DateTime? AdPrStCheckTime { get; set; }

    public byte AnPrStVariantValid { get; set; }

    public decimal AnPrStOptimalQty { get; set; }

    public decimal AnPrStDailyQty { get; set; }

    public int AnUnionDeadline { get; set; }

    public int AnDeliveryDeadline { get; set; }

    public decimal AnPosqty { get; set; }

    public string? AcShowAtena { get; set; }

    public string AcAcctIncome { get; set; } = null!;

    public string AcInFlowOutFlow { get; set; } = null!;

    public decimal AnFieldNf { get; set; }

    public decimal AnFieldNg { get; set; }

    public string? AcFieldSf { get; set; }

    public string? AcFieldSg { get; set; }

    public string? AcFieldSh { get; set; }

    public string? AcFieldSi { get; set; }

    public string? AcFieldSj { get; set; }

    public decimal AnFieldNh { get; set; }

    public decimal AnFieldNi { get; set; }

    public decimal AnFieldNj { get; set; }

    public double AnFixPriceDiff { get; set; }

    public int AnQtyInCodeDecPlace { get; set; }

    public decimal AnOrderMinQty { get; set; }

    public decimal AnOrderOptQty { get; set; }

    public string AcCostDrv { get; set; } = null!;

    public string? AcPacking { get; set; }

    public double AnPurExciseE { get; set; }

    public double AnPurExciseA { get; set; }

    public double AnPurExciseT { get; set; }

    public double AnBeatShare { get; set; }

    public DateTime? AdTimeIns { get; set; }

    public int? AnUserIns { get; set; }

    public DateTime? AdTimeChg { get; set; }

    public int? AnUserChg { get; set; }

    public string AcIsReturnPack { get; set; } = null!;

    public string? AcEnvrmntCost { get; set; }

    public string AcWastePack { get; set; } = null!;

    public string AcWstEeequip { get; set; } = null!;

    public string AcUsedTyre { get; set; } = null!;

    public string? AcVehiclePart { get; set; }

    public string AcPackSlopak { get; set; } = null!;

    public string? AcPackSlopaktype { get; set; }

    public string AcUmmarkLabel { get; set; } = null!;

    public decimal? AnQtyMarkLabel { get; set; }

    public string? AcPrstPrice { get; set; }

    public int? AnPlucode { get; set; }

    public string AcDateDue { get; set; } = null!;

    public int? AnMonthDue { get; set; }

    public byte[]? AcPicture { get; set; }

    public decimal AnMaxRebate { get; set; }

    public string? AcTechProcedure { get; set; }

    public string? AcDescr { get; set; }

    public byte[]? AcTouchPicture { get; set; }

    public string? AcDroe { get; set; }

    public string AcDroesubject { get; set; } = null!;

    public DateTime? AdFieldDa { get; set; }

    public DateTime? AdFieldDb { get; set; }

    public DateTime? AdFieldDc { get; set; }

    public DateTime? AdFieldDd { get; set; }

    public decimal AnMinMargin { get; set; }

    public DateTime? AdDiscountBegin { get; set; }

    public DateTime? AdDiscountEnd { get; set; }

    public string? AcDocTypeIssue { get; set; }

    public string? AcEnableChgPrSt { get; set; }

    public string? AcNote { get; set; }

    public long? AnPlucode2 { get; set; }

    public double? AnBuyRebate2 { get; set; }

    public double? AnBuyRebate3 { get; set; }

    public double? AnSaleRebate2 { get; set; }

    public double? AnSaleRebate3 { get; set; }

    public decimal? AnPosQtyStep { get; set; }

    public string? AcQtyNotToKol { get; set; }

    public int AnQid { get; set; }

    public string? AcStretchPicture { get; set; }

    public string? AcBackPacking { get; set; }

    public string AcFormulaRt { get; set; } = null!;

    public string? AcAcctNotTaxDeduct { get; set; }

    public byte[]? AcPrtPicture { get; set; }

    public string? AcClassProdByAct { get; set; }

    public string? AcBullId { get; set; }

    public string? AcPosprinterId { get; set; }

    public string? AcBst { get; set; }

    public string AcVatcodeReceive { get; set; } = null!;

    public decimal AnVatreceive { get; set; }

    public string AcWeighableItem { get; set; } = null!;

    public decimal? AnAllowedWastage { get; set; }

    public string? AcSerialnoDueType { get; set; }

    public string? AcPackagingType { get; set; }

    public string? AcTransferredWs { get; set; }

    public int? AnColorCode { get; set; }

    public byte[]? AbIcon { get; set; }

    public decimal AnAllowedInvShort { get; set; }

    public string AcAcctBuyVasale { get; set; } = null!;

    public decimal? AnPackWeight { get; set; }

    public decimal? AnPackWasteWeight { get; set; }

    public decimal AnDiscountPrice { get; set; }

    public decimal AnDiscountPriceRt { get; set; }

    public string? AcUseAsCostOnIntrastat { get; set; }

    public string? AcPrintTechProc { get; set; }

    public bool AbRoundQtyToInt { get; set; }

    public bool? AbConvertToUmForPos { get; set; }

    public string? AcUmForPos { get; set; }

    public string? AcWebShopItem { get; set; }

    public string AcUseAsCostOnVatba { get; set; } = null!;

    public byte[]? AcDescrRtf { get; set; }

    public byte[]? AcTechProcedureRtf { get; set; }

    public string? AcVatcodeReduced { get; set; }

    public int? AnNensi { get; set; }

    public string AcForSubject { get; set; } = null!;

    public int? AnMnfilesQid { get; set; }

    public virtual THeSetSubj AcDeptNavigation { get; set; } = null!;

    public virtual THeSetSubj AcDroesubjectNavigation { get; set; } = null!;

    public virtual THeSetSubj AcForSubjectNavigation { get; set; } = null!;

    public virtual THeSetSubj AcSupplierNavigation { get; set; } = null!;

    public virtual ICollection<THeMoveItem> THeMoveItems { get; set; } = new List<THeMoveItem>();

    public virtual ICollection<THeOrderItem> THeOrderItems { get; set; } = new List<THeOrderItem>();

    public virtual ICollection<THeSetItemPriceForWrh> THeSetItemPriceForWrhs { get; set; } = new List<THeSetItemPriceForWrh>();
}
