using System;
using System.ComponentModel.DataAnnotations;

namespace SalesManagementSystem.Models
{
    public class PublicList
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string Code { get; set; } = string.Empty;
        public bool IsParent { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
    }
}
