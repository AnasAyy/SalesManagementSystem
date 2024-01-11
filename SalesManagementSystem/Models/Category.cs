using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesManagementSystem.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
