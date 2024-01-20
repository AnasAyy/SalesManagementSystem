using Dapper;
using SalesManagementSystem.Data.Dtos;
using SalesManagementSystem.Forms;
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
        static PurchasesReportForm purchasesReportForm;//
        public PurchasesReportForm()
        {
            if (purchasesReportForm == null) purchasesReportForm = this;//
            InitializeComponent();
        }

        static void PurchasesReportForm_FormClosed(object sender, FormClosedEventArgs e)//
        {
            purchasesReportForm = null;
        }

        public static PurchasesReportForm GetPurchasesReportForm //
        {

            get
            {
                if (purchasesReportForm == null)
                    purchasesReportForm = new PurchasesReportForm();
                purchasesReportForm.FormClosed += PurchasesReportForm_FormClosed;
                return purchasesReportForm;

            }
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
