using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Data.Dtos
{
    internal class WarehouseReportDto
    {
        
        public string Name { get; set; }
        public string Category { get; set; }
        public string Barcode { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Total { get; set; }
    }
}
