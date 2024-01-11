using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesManagementSystem.Models
{
    public class FinancialBond
    {
        [Key]
        public Int32 Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Type { get; set; } // صرف / قبض
        public int BoudType { get; set; } //2 سند عادي 0/ سند تمت اضافته من مبيعات 1/ سند تمت اضافته من مشتريات
        public string Description { get; set; } = string.Empty;
        public int? FeeType { get; set; }//
        public decimal? Fee { get; set; }//
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalLocalPrice { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }

        public int? ClientId { get; set; }

        public int? SupplierId { get; set; }

        public int AccountId { get; set; }

    }
}
