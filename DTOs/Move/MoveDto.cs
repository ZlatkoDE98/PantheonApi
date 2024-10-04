using System;
using System.Collections.Generic;
using PantheonApi.Models;

namespace PantheonApi.DTOs
{
    public class MoveDto
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
        public virtual ICollection<THeMoveItem> THeMoveItems { get; set; } = new List<THeMoveItem>();
    }
}
