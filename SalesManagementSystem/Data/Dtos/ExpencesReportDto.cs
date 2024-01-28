using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Data.Dtos
{
    internal class ExpencesReportDto
    {
       public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public string ExpenseType { get; set; }  // نوع المصروف
        
        public decimal Fee { get; set; }//
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }

        public string AccountName { get; set; }
        public decimal Total { get; set; }
    }
}
