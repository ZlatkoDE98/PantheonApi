namespace PantheonApi.DTOs.Item;

public class ItemDto
{
    public string AcIdent { get; set; }
    public string? AcName { get; set; }
    public string AcCode { get; set; }
    public string AcCurrency { get; set; }
    public double AnSalePrice { get; set; }
    public double AnRebate { get; set; }
}