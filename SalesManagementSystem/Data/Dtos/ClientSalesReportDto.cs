using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Data.Dtos
{
    internal class ClientSalesReportDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClientName { get; set; }
        public int Quantity { get; set; }
        public int TotalNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
