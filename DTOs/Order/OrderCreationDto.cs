public class OrderCreationDto
    {
        public string AcDocType { get; set; }         // Document type
        public string AcReceiver { get; set; }        // Receiver subject code
        public string AcIssuer { get; set; }          // Issuer subject code
        public string AcReceiverStock { get; set; }   // Receiver warehouse code
        public string AcIssuerStock { get; set; }     // Issuer warehouse code
        public DateTime? AdDate { get; set; }         // Date of the document
        public string AcDoc1 { get; set; }            // External document 1
        public DateTime? AdDateDoc1 { get; set; }     // External document 1 date
        public string? AcDoc2 { get; set; }            // External document 2
        public DateTime? AdDateDoc2 { get; set; }     // External document 2 date
        public List<MoveItemDto> OrderItems { get; set; } = new List<MoveItemDto>();  // List of move items
    }