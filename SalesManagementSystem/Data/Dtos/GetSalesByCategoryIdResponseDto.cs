namespace SalesManagementSystem.Data.Dtos
{
    public class GetSalesByCategoryIdResponseDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
