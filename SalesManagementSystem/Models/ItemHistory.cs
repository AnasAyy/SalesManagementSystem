using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Models
{
    public class ItemHistory
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Item.Id))]
        public int ItemId { get; set; }

        public int Quantity { get; set; }
        public decimal PricePerQuantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
    }
}
