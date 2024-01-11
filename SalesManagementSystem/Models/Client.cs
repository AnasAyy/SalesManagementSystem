using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesManagementSystem.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string PhoneNumber { get; set; } = null;
        public int PurchaseCount { get; set; } = 0;
        public bool IsActive { get; set; } = true;
        public string Address { get; set; } = string.Empty;
        public decimal Credit { get; set; } = 0;
        public decimal Debit { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }

    }
}
