namespace PantheonApi.DTOs.Stock
{
    public class StockDto
    {
        public string AcWarehouse { get; set; }
        public string AcIdent { get; set; }
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
    }
}
