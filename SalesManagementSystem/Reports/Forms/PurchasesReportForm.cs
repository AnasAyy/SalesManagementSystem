using Dapper;
using SalesManagementSystem.Data.Dtos;
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

namespace SalesManagementSystem.Reports.Forms
{
    public partial class PurchasesReportForm : Form
    {
        public PurchasesReportForm()
        {
            InitializeComponent();
        }

        private void PurchasesReportForm_Load(object sender, EventArgs e)
        {

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

                        string purchasesQuery = "SELECT i.Name, bi.Quantity, bi.TotalPrice/bi.Quantity , bi.TotalPrice, CONVERT(DATE, b.CreatedAt) AS CreatedDate " +
                                                "FROM Bills b " +
                                                "JOIN BillItems bi ON b.Id = bi.BillId " +
                                                "JOIN Items i ON i.Id = bi.ItemId " +
                                                "WHERE b.BillType = 3 " +
                                                "AND CONVERT(DATE, b.CreatedAt) >= '" + startDate.ToString("yyyy-MM-dd") + "' " +
                                                "AND CONVERT(DATE, b.CreatedAt) <= '" + endDate.ToString("yyyy-MM-dd") + "'";

                        List<PurchasesReportDto> list = sqlconn.Query<PurchasesReportDto>(purchasesQuery, commandType: CommandType.Text).ToList();

                        purchasesReport1.SetDataSource(list);


                        string SumQuery = "SELECT SUM(bi.TotalPrice) as Total " +
                                          "FROM Bills b " +
                                          "JOIN BillItems bi ON b.Id = bi.BillId " +
                                          "JOIN Items i ON i.Id = bi.ItemId " +
                                          "WHERE b.BillType = 3 " +
                                          "AND CONVERT(DATE, b.CreatedAt) >= '" + startDate.ToString("yyyy-MM-dd") + "' " +
                                          "AND CONVERT(DATE, b.CreatedAt) <= '" + endDate.ToString("yyyy-MM-dd") + "'";

                        List<PurchasesReportDto> list2 = sqlconn.Query<PurchasesReportDto>(SumQuery, commandType: CommandType.Text).ToList();

                        purchasesReport1.SetParameterValue("Total", list2.FirstOrDefault()?.Total.ToString());
                        purchasesReport1.SetParameterValue("Date", DateTime.Now.ToString("yyyy/MM/dd"));
                        
                        crystalReportViewer1.ReportSource = purchasesReport1;
                        crystalReportViewer1.Refresh();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
