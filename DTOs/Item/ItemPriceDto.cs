namespace PantheonApi.DTOs.Item;

public class ItemPriceDto
{
    public string AcIdent { get; set; }
    public string? AcName { get; set; }
    public double anBuyPrice { get; set; }
    public double anProdPrice { get; set; }
    public double anWSPrice { get; set; }
    public double anPrice { get; set; }
    public decimal AnSalePrice { get; set; }
    
}