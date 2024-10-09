using System;
using System.Collections.Generic;

namespace PantheonApi.Models;

public partial class THeStock
{
    public string AcWarehouse { get; set; } = null!;

    public string AcIdent { get; set; } = null!;

    public decimal AnStock { get; set; }

    public double AnValue { get; set; }

    public double AnLastPrice { get; set; }

    public DateTime? AdTimeChg { get; set; }

    public decimal AnReserved { get; set; }

    public DateTime? AdTimeIns { get; set; }

    public int? AnUserIns { get; set; }

    public int? AnUserChg { get; set; }

    public decimal AnMinStock { get; set; }

    public decimal AnOptStock { get; set; }

    public decimal AnMaxStock { get; set; }

    public int AnQid { get; set; }

    public virtual THeSetItem AcIdentNavigation { get; set; } = null!;

    public virtual THeSetSubj AcWarehouseNavigation { get; set; } = null!;
}
