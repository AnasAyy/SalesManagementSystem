using Dapper;
using SalesManagementSystem.Data.Dtos;
using SalesManagementSystem.Models;
using SalesManagementSystem.Reports.Designs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SalesManagementSystem.Reports.Forms
{
    public partial class ClientSales : Form
    {
        string clientId;
        string clientName;
        public ClientSales(string id, string clientName)
        {
            clientId = id;
            InitializeComponent();
            this.clientName = clientName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    using (IDbConnection sqlconn = new SqlConnection(db.Database.Connection.ConnectionString))
                    {
                        if (sqlconn.State == ConnectionState.Closed)
                        {
                            sqlconn.Open();
                        }


                        DateTime startDate = dateTimePicker1.Value.Date;
                        DateTime endDate = dateTimePicker2.Value.Date;

                        string Query = "SELECT b.Id,  i.Name, bi.Quantity, bi.TotalPrice, CONVERT(DATE, b.CreatedAt, 23) AS CreatedDate " +
                                                " FROM Bills b " +
                                                " JOIN BillItems bi ON b.Id = bi.BillId " +
                                                " JOIN Items i ON i.Id = bi.ItemId " +
                                                " JOIN Clients c ON c.Id = b.ClientId " +
                                                " WHERE b.BillType = 1" +
                                                " AND CONVERT(DATE, b.CreatedAt) >= '" + startDate.ToString("yyyy-MM-dd") + "' " +
                                                " AND CONVERT(DATE, b.CreatedAt) <= '" + endDate.ToString("yyyy-MM-dd") + "' " +
                                                " AND c.Id = '"+ clientId + "' " +
                                                " Order by b.Id";

                        List<ClientSalesReportDto> list = sqlconn.Query<ClientSalesReportDto>(Query, commandType: CommandType.Text).ToList();

                        clientSalesReport1.SetDataSource(list);


                        string SumQuery = "SELECT SUM(bi.TotalPrice) AS Total " +
                        " FROM Bills b " +
                        " JOIN BillItems bi ON b.Id = bi.BillId " +
                        " JOIN Items i ON i.Id = bi.ItemId " +
                        " JOIN Clients c ON c.Id = b.ClientId " +
                        " WHERE b.BillType = 1" +
                        " AND CONVERT(DATE, b.CreatedAt) >= '" + startDate.ToString("yyyy-MM-dd") + "' " +
                        " AND CONVERT(DATE, b.CreatedAt) <= '" + endDate.ToString("yyyy-MM-dd") + "' " +
                        " AND c.Id = '" + clientId + "'";

                        List<ClientSalesReportDto> list2 = sqlconn.Query<ClientSalesReportDto>(SumQuery, commandType: CommandType.Text).ToList();

                        clientSalesReport1.SetParameterValue("ClientName", clientName.ToString());
                        clientSalesReport1.SetParameterValue("Total", list2.FirstOrDefault()?.Total.ToString());

                        crystalReportViewer1.ReportSource = clientSalesReport1;
                        crystalReportViewer1.Refresh();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClientSales_Load(object sender, EventArgs e)
        {

        }
    }
}
