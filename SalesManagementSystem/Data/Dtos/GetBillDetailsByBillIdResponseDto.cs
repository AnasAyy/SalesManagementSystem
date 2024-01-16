using System;

namespace SalesManagementSystem.Data.Dtos
{
    public class GetBillDetailsByBillIdResponseDto
    {
        public int Id { get; set; }
        public int BillType { get; set; }
        public string DiscountType { get; set; }
        public decimal Discount { get; set; }
        public string FeeType { get; set; }
        public decimal Fee { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalLocalPrice { get; set; }
        public DateTime Date {  get; set; }

    }
}
