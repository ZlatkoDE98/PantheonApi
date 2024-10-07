using System;
using System.Collections.Generic;

namespace PantheonApi.Models;

public partial class THeSetItemPriceForWrh
{
    public string AcIdent { get; set; } = null!;

    public string AcWarehouse { get; set; } = null!;

    public double AnPrStPriceP { get; set; }

    public double AnPrStPrice { get; set; }

    public double AnWsprice2P { get; set; }

    public double AnWsprice2 { get; set; }

    public double AnWspriceP { get; set; }

    public double AnWsprice { get; set; }

    public double AnRtpriceP { get; set; }

    public decimal AnDiscount { get; set; }

    public double AnRtprice { get; set; }

    public string AcFormula { get; set; } = null!;

    public decimal AnSalePrice { get; set; }

    public string AcCurrency { get; set; } = null!;

    public DateTime? AdTimeIns { get; set; }

    public int? AnUserIns { get; set; }

    public DateTime? AdTimeChg { get; set; }

    public int? AnUserChg { get; set; }

    public decimal? AnBuyPrice { get; set; }

    public int AnQid { get; set; }

    public DateTime? AdDiscountBegin { get; set; }

    public DateTime? AdDiscountEnd { get; set; }

    public decimal? AnDiscountPrice { get; set; }

    public decimal? AnDiscountPriceRt { get; set; }

    public virtual THeSetItem AcIdentNavigation { get; set; } = null!;

    public virtual THeSetSubj AcWarehouseNavigation { get; set; } = null!;
}
