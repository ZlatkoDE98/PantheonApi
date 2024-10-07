using System;
using System.Collections.Generic;

namespace PantheonApi.Models;

public partial class THeSetSubj
{
    public string AcSubject { get; set; } = null!;

    public string? AcBuyer { get; set; }

    public string? AcSupplier { get; set; }

    public string? AcBank { get; set; }

    public string? AcMunicipality { get; set; }

    public string? AcLocComm { get; set; }

    public string? AcWarehouse { get; set; }

    public string? AcWorker { get; set; }

    public string? AcUser { get; set; }

    public string? AcDept { get; set; }

    public string? AcSchool { get; set; }

    public string? AcInstitution { get; set; }

    public string? AcName2 { get; set; }

    public string AcAddress { get; set; } = null!;

    public string? AcName3 { get; set; }

    public string AcPost { get; set; } = null!;

    public string AcCountry { get; set; } = null!;

    public int AnKm { get; set; }

    public string AcVatcodePrefix { get; set; } = null!;

    public string AcCode { get; set; } = null!;

    public string? AcRegion { get; set; }

    public string AcSuprCommune { get; set; } = null!;

    public string? AcPhone { get; set; }

    public string? AcFax { get; set; }

    public string? AcSubUnit { get; set; }

    public string? AcPriceRate { get; set; }

    public int AnDaysForPayment { get; set; }

    public string? AcYearStatement { get; set; }

    public DateTime? AdDateState { get; set; }

    public string? AcStatement { get; set; }

    public decimal AnLimit { get; set; }

    public DateTime? AdDateLimit { get; set; }

    public int? AnMaxDaysPayDelay { get; set; }

    public string AcSubjTypeSupp { get; set; } = null!;

    public string AcSubjTypeBuyer { get; set; } = null!;

    public string? AcStockManage { get; set; }

    public string? AcStockValue { get; set; }

    public string? AcStockInMinus { get; set; }

    public DateTime? AdDateInvent { get; set; }

    public int AnClerk { get; set; }

    public decimal AnRebate { get; set; }

    public string? AcWayOfSale { get; set; }

    public string AcCurrency { get; set; } = null!;

    public string? AcPriceCalcMethod { get; set; }

    public string AcPayMethod { get; set; } = null!;

    public string AcDelivery { get; set; } = null!;

    public string AcRegNo { get; set; } = null!;

    public string AcPayer { get; set; } = null!;

    public string AcActivityCode { get; set; } = null!;

    public string? AcSeparSaleCalc { get; set; }

    public string? AcSuppPriceCalcMet { get; set; }

    public decimal AnSuppDiscount { get; set; }

    public string? AcSuppSaleMet { get; set; }

    public string? AcSuppYearStatement { get; set; }

    public DateTime? AdSuppDateSta { get; set; }

    public int AnSuppPayDays { get; set; }

    public string AcSuppPayMet { get; set; } = null!;

    public string AcSuppStatement { get; set; } = null!;

    public decimal AnSuppLimit { get; set; }

    public DateTime? AdSuppDateLim { get; set; }

    public string AcSuppDelivery { get; set; } = null!;

    public string AcSuppCurr { get; set; } = null!;

    public int AnSuppClerk { get; set; }

    public string? AcPayOrdPriorty { get; set; }

    public string? AcSwiftcode { get; set; }

    public string? AcAtwarehouse { get; set; }

    public string? AcMunicipCode { get; set; }

    public string? AcDispDoc { get; set; }

    public string AcSetOfInterestRates { get; set; } = null!;

    public string? AcStockRetailValue { get; set; }

    public string AcParity { get; set; } = null!;

    public string AcParityPost { get; set; } = null!;

    public string AcSuppParity { get; set; } = null!;

    public string AcSuppParityPost { get; set; } = null!;

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

    public decimal AnFieldNa { get; set; }

    public decimal AnFieldNb { get; set; }

    public decimal AnFieldNc { get; set; }

    public decimal AnFieldNd { get; set; }

    public decimal AnFieldNe { get; set; }

    public decimal AnFieldNf { get; set; }

    public decimal AnFieldNg { get; set; }

    public decimal AnFieldNh { get; set; }

    public decimal AnFieldNi { get; set; }

    public decimal AnFieldNj { get; set; }

    public DateTime? AdFieldDa { get; set; }

    public DateTime? AdFieldDb { get; set; }

    public DateTime? AdFieldDc { get; set; }

    public DateTime? AdFieldDd { get; set; }

    public string AcSkis { get; set; } = null!;

    public string? AcXmldocType { get; set; }

    public string? AcXmldocCript { get; set; }

    public string? AcXmldocSign { get; set; }

    public string? AcCreatePayOrd { get; set; }

    public string? AcXmlglnno { get; set; }

    public string? AcIntrstsBuyer { get; set; }

    public string? AcIntrstsSupplier { get; set; }

    public string? AcRsbainDistrikt { get; set; }

    public string? AcHttppath { get; set; }

    public string? AcIbanprefix { get; set; }

    public string AcSuprDept { get; set; } = null!;

    public decimal? AnSubjVar1 { get; set; }

    public decimal? AnSubjVar2 { get; set; }

    public decimal? AnSubjVar3 { get; set; }

    public decimal? AnSubjVar4 { get; set; }

    public decimal? AnSubjVar5 { get; set; }

    public decimal? AnSubjVar6 { get; set; }

    public decimal? AnSubjVar7 { get; set; }

    public decimal? AnSubjVar8 { get; set; }

    public decimal? AnSubjVar9 { get; set; }

    public decimal? AnSubjVar10 { get; set; }

    public decimal? AnLatitude { get; set; }

    public decimal? AnLongitude { get; set; }

    public decimal AnMaxRebate { get; set; }

    public string AcPerInv { get; set; } = null!;

    public string AcSuppPerInv { get; set; } = null!;

    public string AcActive { get; set; } = null!;

    public string? AcActiveContacts { get; set; }

    public string? AcDeptRegNo { get; set; }

    public string AcPayLoc { get; set; } = null!;

    public string? AcBuyerLimitCtrl { get; set; }

    public string? AcSubUnitCode { get; set; }

    public string? AcJibcode { get; set; }

    public DateTime? AdTimeIns { get; set; }

    public int? AnUserIns { get; set; }

    public DateTime? AdTimeChg { get; set; }

    public int? AnUserChg { get; set; }

    public string? AcNote { get; set; }

    public string? AcPin { get; set; }

    public string AcDeptMuni { get; set; } = null!;

    public int? AnContactPrsnB { get; set; }

    public int? AnContactPrsnS { get; set; }

    public string? AcSubUnitRegNo { get; set; }

    public string? AcSubUnitTaxCode { get; set; }

    public int? AnWorkingHours { get; set; }

    public int? AnWorkingDaysInWeek { get; set; }

    public string? AcBudgetUser { get; set; }

    public string? AcExciseNumber { get; set; }

    public int? AnInstalmentNo { get; set; }

    public int? AnSuppInstalmentNo { get; set; }

    public string? AcBranch { get; set; }

    public string? AcBranchForm { get; set; }

    public int? AnOrgColor { get; set; }

    public string? AcLoyaltyPrefix { get; set; }

    public string? AcDontSendReminders { get; set; }

    public string? AcGln { get; set; }

    public string AcMunicipCreditor { get; set; } = null!;

    public string? AcBankCode { get; set; }

    public int AnQid { get; set; }

    public string? AcRetail { get; set; }

    public string? AcFiscalNo { get; set; }

    public string AcPayerS { get; set; } = null!;

    public string AcAcctClaim { get; set; } = null!;

    public string AcAcctOblig { get; set; } = null!;

    public string? AceSlogVer { get; set; }

    public string AcPincodePrefix { get; set; } = null!;

    public string AcAcctGlopen { get; set; } = null!;

    public string AcNoExciseCalc { get; set; } = null!;

    public string AcRsbainDistriktBuyer { get; set; } = null!;

    public string AcVatpayRealSupp { get; set; } = null!;

    public decimal? AnWarehouseCapacity { get; set; }

    public string? AcWarehouseCapacityUm { get; set; }

    public string? AcAcctExpense { get; set; }

    public string? AcAcctIncome { get; set; }

    public string? AcPermitLumpCompen { get; set; }

    public string AcRemindersSendType { get; set; } = null!;

    public string? AcPac { get; set; }

    public string? AcEslogContractCt { get; set; }

    public string AcSkis2 { get; set; } = null!;

    public decimal AnAllowedInvShort { get; set; }

    public string? AcAcctRebateExtra { get; set; }

    public string? AcVeterinarian { get; set; }

    public DateTime? AdAnafcheckDate { get; set; }

    public string? AcParityType { get; set; }

    public string? AcSuppParityType { get; set; }

    public string AcNaturalPerson { get; set; } = null!;

    public decimal AnMinMargin { get; set; }

    public string? AcNcc { get; set; }

    public string? AcBuyerCalcInvoOutFallDue { get; set; }

    public string? AcAssortment { get; set; }

    public string? AcOrgUnit { get; set; }

    public string? AcAccountingPeriod { get; set; }

    public int? AnOrderValidBuyer { get; set; }

    public int? AnOrderValidSupplier { get; set; }

    public string? AcLei { get; set; }

    public string? AcFreeStockReport { get; set; }

    public string? AcWebShopSubject { get; set; }

    public byte? AnDeliveryPriority { get; set; }

    public short? AnDeliveryDays { get; set; }

    public bool AbPriceRatePos { get; set; }

    public string? AcCostDrv { get; set; }

    public string? AcJbkjs { get; set; }

    public string AcPriceCalcForItem { get; set; } = null!;

    public string? AcRotationNumber { get; set; }

    public string? AcConsignee { get; set; }

    public string? AcIdentList { get; set; }

    public string? AcWarehouseStockNotInQty { get; set; }

    public string AcFarmerNo { get; set; } = null!;

    public virtual THeSetSubj AcDeptMuniNavigation { get; set; } = null!;

    public virtual THeSetSubj AcMunicipCreditorNavigation { get; set; } = null!;

    public virtual THeSetSubj AcPayerNavigation { get; set; } = null!;

    public virtual THeSetSubj AcPayerSNavigation { get; set; } = null!;

    public virtual THeSetSubj AcSuprCommuneNavigation { get; set; } = null!;

    public virtual THeSetSubj AcSuprDeptNavigation { get; set; } = null!;

    public virtual ICollection<THeSetSubj> InverseAcDeptMuniNavigation { get; set; } = new List<THeSetSubj>();

    public virtual ICollection<THeSetSubj> InverseAcMunicipCreditorNavigation { get; set; } = new List<THeSetSubj>();

    public virtual ICollection<THeSetSubj> InverseAcPayerNavigation { get; set; } = new List<THeSetSubj>();

    public virtual ICollection<THeSetSubj> InverseAcPayerSNavigation { get; set; } = new List<THeSetSubj>();

    public virtual ICollection<THeSetSubj> InverseAcSuprCommuneNavigation { get; set; } = new List<THeSetSubj>();

    public virtual ICollection<THeSetSubj> InverseAcSuprDeptNavigation { get; set; } = new List<THeSetSubj>();

    public virtual ICollection<THeMove> THeMoveAcDeptNavigations { get; set; } = new List<THeMove>();

    public virtual ICollection<THeMove> THeMoveAcDeptOutNavigations { get; set; } = new List<THeMove>();

    public virtual ICollection<THeMove> THeMoveAcIssuerNavigations { get; set; } = new List<THeMove>();

    public virtual ICollection<THeMove> THeMoveAcPrsn3Navigations { get; set; } = new List<THeMove>();

    public virtual ICollection<THeMove> THeMoveAcReceiverNavigations { get; set; } = new List<THeMove>();

    public virtual ICollection<THeMoveItem> THeMoveItems { get; set; } = new List<THeMoveItem>();

    public virtual ICollection<THeOrder> THeOrderAcConsigneeNavigations { get; set; } = new List<THeOrder>();

    public virtual ICollection<THeOrder> THeOrderAcDeptNavigations { get; set; } = new List<THeOrder>();

    public virtual ICollection<THeOrder> THeOrderAcReceiverNavigations { get; set; } = new List<THeOrder>();

    public virtual ICollection<THeOrder> THeOrderAcTransporterNavigations { get; set; } = new List<THeOrder>();

    public virtual ICollection<THeOrder> THeOrderAcWarehouseNavigations { get; set; } = new List<THeOrder>();

    public virtual ICollection<THeOrderItem> THeOrderItems { get; set; } = new List<THeOrderItem>();

    public virtual ICollection<THeSetItem> THeSetItemAcDeptNavigations { get; set; } = new List<THeSetItem>();

    public virtual ICollection<THeSetItem> THeSetItemAcDroesubjectNavigations { get; set; } = new List<THeSetItem>();

    public virtual ICollection<THeSetItem> THeSetItemAcForSubjectNavigations { get; set; } = new List<THeSetItem>();

    public virtual ICollection<THeSetItem> THeSetItemAcSupplierNavigations { get; set; } = new List<THeSetItem>();

    public virtual ICollection<THeSetItemPriceForWrh> THeSetItemPriceForWrhs { get; set; } = new List<THeSetItemPriceForWrh>();
}
