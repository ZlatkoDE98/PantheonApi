public class MoveItemDto
    {
        public string AcIdent { get; set; }      // Item identifier (SKU or item code)
        public decimal AnQty { get; set; }         // Quantity of the item
        public float AnPrice { get; set; }       // Price of the item
        public float AnRebate1 { get; set; }     // Rebate on the item
        // Add any other fields as needed, for example VAT or additional rebates
    }