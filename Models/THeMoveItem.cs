using System;
using System.Collections.Generic;

namespace PantheonApi.Models;

public partial class THeMoveItem
{
    public string AcKey { get; set; } = null!;

    public int AnNo { get; set; }

    public string AcIdent { get; set; } = null!;

    public string? AcName { get; set; }

    public decimal AnQty { get; set; }

    public decimal AnQtyTemp { get; set; }

    public string AcUm { get; set; } = null!;

    public double AnPrice { get; set; }

    public double AnRebate { get; set; }

    public string AcVatcode { get; set; } = null!;

    public double AnVat { get; set; }

    public double AnStockPrice { get; set; }

    public double AnPriceCurrency { get; set; }

    public string? AcLnkKey { get; set; }

    public int AnLnkNo { get; set; }

    public double AnTransport { get; set; }

    public double AnDuty { get; set; }

    public double AnDirectCost { get; set; }

    public double AnIncTax { get; set; }

    public double AnRtpriceP { get; set; }

    public double AnRtprice { get; set; }

    public double AnSalePrice { get; set; }

    public double AnWspriceP { get; set; }

    public double AnWsprice { get; set; }

    public double AnWsprice2P { get; set; }

    public double AnWsprice2 { get; set; }

    public decimal AnPackQty { get; set; }

    public string? AcPackNum { get; set; }

    public int AnWarrenty { get; set; }

    public string? AcFieldL { get; set; }

    public string AcAcctCr { get; set; } = null!;

    public string AcOrigin { get; set; } = null!;

    public string AcDeclarForOriginType { get; set; } = null!;

    public double AnExcise { get; set; }

    public double AnExciseP { get; set; }

    public string AcDept { get; set; } = null!;

    public string AcVatcodeTr { get; set; } = null!;

    public double AnVatin { get; set; }

    public DateTime? AdDate { get; set; }

    public double AnFixPriceDiff { get; set; }

    public string AcCostDrv { get; set; } = null!;

    public byte AnVtype { get; set; }

    public string? AcNote { get; set; }

    public DateTime? AdTimeIns { get; set; }

    public int? AnUserIns { get; set; }

    public DateTime? AdTimeChg { get; set; }

    public int? AnUserChg { get; set; }

    public double AnDimVolume { get; set; }

    public double AnDimWeight { get; set; }

    public double AnDimWeightBrutto { get; set; }

    public double AnInWsprice2P { get; set; }

    public double AnInWsprice2 { get; set; }

    public double AnInWspriceP { get; set; }

    public double AnInWsprice { get; set; }

    public double AnInRtpriceP { get; set; }

    public double AnInRtprice { get; set; }

    public double AnInSalePrice { get; set; }

    public double? AnWoprice { get; set; }

    public string AcRmafault { get; set; } = null!;

    public double AnBeatShare { get; set; }

    public double AnPurExciseE { get; set; }

    public double AnPurExciseA { get; set; }

    public double AnPurExciseT { get; set; }

    public decimal AnPvforPay { get; set; }

    public decimal AnPvexcise { get; set; }

    public decimal AnPvvatbase { get; set; }

    public decimal AnPvdiscount { get; set; }

    public decimal AnPvvalue { get; set; }

    public decimal AnPvocforPay { get; set; }

    public decimal AnPvocvat { get; set; }

    public decimal AnPvocvatbase { get; set; }

    public decimal AnPvocdiscount { get; set; }

    public decimal AnPvocvalue { get; set; }

    public decimal AnPvvat { get; set; }

    public decimal AnPvocexcise { get; set; }

    public decimal AnPvoctransport { get; set; }

    public decimal AnPvocduty { get; set; }

    public decimal AnPvocincVat { get; set; }

    public decimal AnPvocdirectCost { get; set; }

    public decimal AnPvocbeatShare { get; set; }

    public decimal AnPvocnonBeatShare { get; set; }

    public decimal AnPvocfixPriceDiff { get; set; }

    public decimal AnPvocstockValue { get; set; }

    public double AnRebate1 { get; set; }

    public double AnRebate2 { get; set; }

    public double AnRebate3 { get; set; }

    public decimal? AnPrsn3Price { get; set; }

    public decimal AnPvocsuppExcise { get; set; }

    public decimal AnPvocsuppExciseIncSv { get; set; }

    public decimal AnPvocincVatwoExc { get; set; }

    public decimal AnPvocvatbaseWoExc { get; set; }

    public decimal AnPvocforPayWoExc { get; set; }

    public decimal AnPvocsuppExciseIncVb { get; set; }

    public decimal AnPvocsuppExciseNonIncVb { get; set; }

    public decimal AnPvocbeatShareWoExc { get; set; }

    public decimal AnPvocnonBeatShareWoExc { get; set; }

    public decimal AnUmtoUm3 { get; set; }

    public string AcUm3 { get; set; } = null!;

    public decimal AnRetailPrice { get; set; }

    public double? AnExciseInc { get; set; }

    public double? AnExciseNotInc { get; set; }

    public double? AnExciseIncP { get; set; }

    public double? AnExciseNotIncP { get; set; }

    public int AnQid { get; set; }

    public string? AcTransferConnectDoc { get; set; }

    public string AcAcctClaim { get; set; } = null!;

    public decimal AnQtyConverted { get; set; }

    public string? AcUmconverted { get; set; }

    public decimal? AnStockChange { get; set; }

    public decimal? AnStockIndex { get; set; }

    public decimal? AnStockValue { get; set; }

    public decimal? AnStockQty { get; set; }

    public string? AcUm2 { get; set; }

    public decimal? AnStockNewValue { get; set; }

    public double? AnVatafterDeduction { get; set; }

    public decimal? AnValueAfterDeduction { get; set; }

    public decimal? AnVatValueAfterDeduction { get; set; }

    public double AnPayRebate { get; set; }

    public string AcWeighed { get; set; } = null!;

    public string? AcDistributeCosts { get; set; }

    public decimal? AnPvocsuppExciseNonIncVbincSuppForPay { get; set; }

    public decimal? AnPvocsuppExciseIncVbincSuppForPay { get; set; }

    public double? AnAllowedShortage { get; set; }

    public double? AnAllowedShortagePercent { get; set; }

    public double? AnTurnoverQty { get; set; }

    public string? AcMultiRmafault { get; set; }

    public decimal? AnUmdecPlaces { get; set; }

    public int? AnRound { get; set; }

    public DateTime? AdOrderCreated { get; set; }

    public double? AnPosxstock { get; set; }

    public string AcFiscReturn { get; set; } = null!;

    public double AnRtpriceConverted { get; set; }

    public double? AnQtyNfr { get; set; }

    public double? AnDirectCostNfr { get; set; }

    public double? AnDutyNfr { get; set; }

    public double? AnReserved { get; set; }

    public string? AcExemptFromVatstype { get; set; }

    public double? AnPckgQty { get; set; }

    public int AnMoveQid { get; set; }

    public double AnDiffPriceRt { get; set; }

    public virtual THeSetSubj AcDeptNavigation { get; set; } = null!;

    public virtual THeSetItem AcIdentNavigation { get; set; } = null!;

    public virtual THeMove AnMoveQ { get; set; } = null!;
}
