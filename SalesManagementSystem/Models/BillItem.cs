using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesManagementSystem.Models
{
    public class BillItem
    {
        [Key]
        public int Id { get; set; }

        public int? ItemId { get; set; }

        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public int BillId { get; set; }

    }
}
