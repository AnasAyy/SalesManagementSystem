using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesManagementSystem.Models
{
    public class BillItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Item.Id))]
        public int? ItemId { get; set; }

        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        [ForeignKey(nameof(Bill.Id))]
        public int BillId { get; set; }

    }
}
