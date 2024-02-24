﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Models
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }
        public int BillType { get; set; } // 1-Sale 2-Purchase 3-Return sale 4-Return Purchase 5-Credit sales 6-Credit Purchase 7-Credit Return Sale 8-Credit Return Purchase
        public decimal Discount { get; set; } = 0;
        public int DiscountType { get; set; }
        public decimal Fee { get; set; } = 0;
        public int FeeType { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalLocalPrice { get; set; }
        public string Note { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }

        public int? SupplierId { get; set; }

        public int? ClientId {  get; set; }


    }
}
