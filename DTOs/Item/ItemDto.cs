namespace PantheonApi.DTOs.Item;

public class ItemDto
{
    public string AcIdent { get; set; }
    public string? AcName { get; set; }
    public string AcCode { get; set; }
    public double anBuyPrice { get; set; }
    public decimal AnSalePrice { get; set; }
    public double AnRebate { get; set; }
}