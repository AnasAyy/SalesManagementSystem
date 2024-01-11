using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesManagementSystem.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string Description { get; set; } = string.Empty;
        public decimal Balance { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } 

    }
}
