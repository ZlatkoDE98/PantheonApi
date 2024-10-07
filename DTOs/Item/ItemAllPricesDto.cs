namespace PantheonApi.DTOs.Item
{
    public class ItemWithPriceDto
    {
        public string AcIdent { get; set; }
        public string AcName { get; set; }
        public string AcCode { get; set; }
        public decimal Price { get; set; }
        public double anWSPrice { get; set; }
        public string Warehouse { get; set; }
    }
}
