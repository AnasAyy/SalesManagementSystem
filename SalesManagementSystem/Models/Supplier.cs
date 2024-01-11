using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesManagementSystem.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public decimal Credit { get; set; } = 0;
        public decimal Debit { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }

        public ICollection<Bill> Bills { get; set; }
        public ICollection<FinancialBond> FinancialBonds { get;}

    }
}
