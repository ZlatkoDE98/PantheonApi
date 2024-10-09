using System;
using System.Collections.Generic;

namespace PantheonApi.Models;
public partial class THeOrder
{
    public string AcKey { get; set; } = null!;

    public string AcDocType { get; set; } = null!;

    public DateTime? AdDate { get; set; }

    public string AcStatus { get; set; } = null!;

    public string? AcWayOfSale { get; set; }

    public string AcConsignee { get; set; } = null!;

    public string AcReceiver { get; set; } = null!;

    public string AcContactPrsn { get; set; } = null!;

    public string? AcPriceRate { get; set; }

    public string AcPayMethod { get; set; } = null!;

    public string AcDelivery { get; set; } = null!;

    public string? AcForm { get; set; }

    public DateTime? AdDeliveryDeadline { get; set; }

    public int AnDaysForValid { get; set; }

    public DateTime? AdDateValid { get; set; }

    public int AnClerk { get; set; }

    public string? AcConfrm { get; set; }

    public decimal AnValue { get; set; }

    public decimal AnDiscount { get; set; }

    public decimal AnVat { get; set; }

    public decimal AnForPay { get; set; }

    public string AcWarehouse { get; set; } = null!;

    public string? AcStatement { get; set; }

    public string AcCurrency { get; set; } = null!;

    public int AnDaysForPayment { get; set; }

    public string AcDept { get; set; } = null!;

    public string? AcContactPrsn3 { get; set; }

    public string? AcDoc1 { get; set; }

    public string? AcDoc2 { get; set; }

    public DateTime? AdDateDoc1 { get; set; }

    public DateTime? AdDateDoc2 { get; set; }

    public string? AcFinished { get; set; }

    public string AcParity { get; set; } = null!;

    public string AcParityPost { get; set; } = null!;

    public int AnBnkAcctNo { get; set; }

    public string? AcCode1 { get; set; }

    public string? AcCode2 { get; set; }

    public string? AcCode3 { get; set; }

    public string? AcRefNo1 { get; set; }

    public string? AcRefNo2 { get; set; }

    public DateTime? AdTimeIns { get; set; }

    public int? AnUserIns { get; set; }

    public DateTime? AdTimeChg { get; set; }

    public int? AnUserChg { get; set; }

    public int AnNoteClerk { get; set; }

    public decimal? AnRoundItem { get; set; }

    public decimal? AnRoundValue { get; set; }

    public string? AcRoundVatonDoc { get; set; }

    public string? AcRefNo3 { get; set; }

    public string? AcRefNo4 { get; set; }

    public string AcNote { get; set; } = null!;

    public int? AnFgnBankNo { get; set; }

    public int AnSigner1 { get; set; }

    public DateTime? AdSigned1 { get; set; }

    public int AnSigner2 { get; set; }

    public DateTime? AdSigned2 { get; set; }

    public int AnSigner3 { get; set; }

    public DateTime? AdSigned3 { get; set; }

    public string AcInternalNote { get; set; } = null!;

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

    public decimal? AnCurrValue { get; set; }

    public string? AcTriangTrans { get; set; }

    public string? AcUpnprint { get; set; }

    public int AnQid { get; set; }

    public decimal AnRoundItemFc { get; set; }

    public decimal AnRoundPrice { get; set; }

    public decimal AnRoundValueOc { get; set; }

    public int? AnOurBankAcctNo { get; set; }

    public int? AnOurBankAcctNoFgn { get; set; }

    public decimal? AnFxrate { get; set; }

    public string? AcRetailSale { get; set; }

    public string? AcInsertedFrom { get; set; }

    public string? AcFiscStatus { get; set; }

    public DateTime? AdDateTimePrint { get; set; }

    public int? AnRoomTableId { get; set; }

    public string? AcLoyaltyCard { get; set; }

    public string? AcWebid { get; set; }

    public byte? AnDeliveryPriority { get; set; }

    public DateTime? AdDeliveryDate { get; set; }

    public int? AnDeliveryDays { get; set; }

    public string AcTransporter { get; set; } = null!;

    public string? AcVehicleRegistrationNumber { get; set; }

    public string? AcTrailerRegistrationNumber { get; set; }

    public DateTime? AdTransportDate { get; set; }

    public string? AcBuyerCostCenterId { get; set; }

    public string? AcBuyerId { get; set; }

    public int? AnBuyerCostCenterIdDef { get; set; }

    public int? AnBuyerIdDef { get; set; }

    public string? AcKeyView { get; set; }

    public virtual THeSetSubj AcConsigneeNavigation { get; set; } = null!;

    public virtual THeSetSubj AcDeptNavigation { get; set; } = null!;

    public virtual THeSetSubj AcReceiverNavigation { get; set; } = null!;

    public virtual THeSetSubj AcTransporterNavigation { get; set; } = null!;

    public virtual THeSetSubj AcWarehouseNavigation { get; set; } = null!;

    public virtual ICollection<THeOrderItem> THeOrderItems { get; set; } = new List<THeOrderItem>();
}
