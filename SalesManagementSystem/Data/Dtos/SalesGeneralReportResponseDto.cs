namespace SalesManagementSystem.Data.Dtos
{
    public class SalesGeneralReportResponseDto
    {
        public string Name { get; set; }
        public int NumberSoldItems { get; set; }
        public int NumberOfReturnItems { get; set; }
        public decimal TotalBuyPrice { get; set; }
        public decimal TotalSellPrice { get; set; }
        public decimal TotalProfit { get; set; }
    }
}
