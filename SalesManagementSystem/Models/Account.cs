using System;
using System.Collections.Generic;

namespace SalesManagementSystem.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string Description { get; set; } = string.Empty;
        public decimal Balance { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } 

        public ICollection<FinancialBond> FinancialBonds { get; set; }
    }
}
