namespace SalesManagementSystem.Data.Dtos
{
    public class AddSaleDataResponseDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null;
        public decimal ProductPrice { get; set; }
        public int ProductAmount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
