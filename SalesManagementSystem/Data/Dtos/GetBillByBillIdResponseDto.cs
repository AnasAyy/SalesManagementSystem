namespace SalesManagementSystem.Data.Dtos
{
    public class GetBillByBillIdResponseDto
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
