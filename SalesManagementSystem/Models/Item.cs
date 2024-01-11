using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Barcode { get; set; } = string.Empty;
        public string Name { get; set; } = null;
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int Quantity { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public int LessQuantity { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(Category.Id))]
        public int? CategoryId { get; set; }

        public ICollection<ItemHistory> ItemHistories { get; set; }
        public ICollection<BillItem> BillItems { get; set; }

    }
}
