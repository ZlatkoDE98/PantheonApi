using System;
using System.Collections.Generic;

namespace PantheonApi.Models;

public partial class THeOrderItem
{
    public string AcKey { get; set; } = null!;

    public int AnNo { get; set; }

    public string AcIdent { get; set; } = null!;

    public string? AcName { get; set; }

    public decimal AnQty { get; set; }

    public decimal AnQtyDispDoc { get; set; }

    public string AcUm { get; set; } = null!;

    public double AnPrice { get; set; }

    public double AnRebate { get; set; }

    public string AcVatcode { get; set; } = null!;

    public double AnVat { get; set; }

    public string? AcLnkKey { get; set; }

    public int AnLnkNo { get; set; }

    public string? AcNote { get; set; }

    public DateTime? AdTimeIns { get; set; }

    public int? AnUserIns { get; set; }

    public DateTime? AdTimeChg { get; set; }

    public int? AnUserChg { get; set; }

    public double AnExcise { get; set; }

    public double AnExciseP { get; set; }

    public decimal AnSalePrice { get; set; }

    public decimal AnPackQty { get; set; }

    public DateTime? AdDeliveryDeadline { get; set; }

    public string AcDept { get; set; } = null!;

    public string AcCostDrv { get; set; } = null!;

    public byte AnVariant { get; set; }

    public double AnDimVolume { get; set; }

    public double AnDimWeight { get; set; }

    public double AnDimWeightBrutto { get; set; }

    public double AnRebate1 { get; set; }

    public double AnRebate2 { get; set; }

    public double AnRebate3 { get; set; }

    public string AcOrigin { get; set; } = null!;

    public decimal AnRetailPrice { get; set; }

    public decimal? AnPriceCurrency { get; set; }

    public decimal? AnPvvalue { get; set; }

    public decimal? AnPvdiscount { get; set; }

    public decimal? AnPvexcise { get; set; }

    public decimal? AnPvvatbase { get; set; }

    public decimal? AnPvvat { get; set; }

    public decimal? AnPvforPay { get; set; }

    public decimal? AnPvocvalue { get; set; }

    public decimal? AnPvocdiscount { get; set; }

    public decimal? AnPvocexcise { get; set; }

    public decimal? AnPvocvatbase { get; set; }

    public decimal? AnPvocvat { get; set; }

    public decimal? AnPvocforPay { get; set; }

    public decimal? AnRtprice { get; set; }

    public decimal AnReserved { get; set; }

    public double? AnExciseInc { get; set; }

    public double? AnExciseNotInc { get; set; }

    public double? AnExciseIncP { get; set; }

    public double? AnExciseNotIncP { get; set; }

    public int AnQid { get; set; }

    public decimal? AnQtyConverted { get; set; }

    public string? AcUmconverted { get; set; }

    public double? AnLastprice { get; set; }

    public string? AcUm2 { get; set; }

    public string? AcPriority { get; set; }

    public decimal? AnUmdecPlaces { get; set; }

    public int AnRound { get; set; }

    public double AnRtpriceConverted { get; set; }

    public DateTime? AdDeliveryDate { get; set; }

    public string? AcPackNum { get; set; }

    public string AcWeighed { get; set; } = null!;

    public int? AnColorCode { get; set; }

    public string? AcFixedAsset { get; set; }

    public string AcWorker { get; set; } = null!;

    public DateTime? AdStartTime { get; set; }

    public double? AnPrstTime { get; set; }

    public string? AcPrstUmtime { get; set; }

    public DateTime? AdEndTime { get; set; }

    public int AnOrderQid { get; set; }

    public virtual THeSetSubj AcDeptNavigation { get; set; } = null!;

    public virtual THeSetItem AcIdentNavigation { get; set; } = null!;

    public virtual THeOrder AnOrderQ { get; set; } = null!;
}
