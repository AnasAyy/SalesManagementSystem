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
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.Reports.Forms
{
    public partial class CustmoerReport : Form
    {
        static CustmoerReport custmoerReport;//
        public CustmoerReport()
        {
            if (custmoerReport == null) custmoerReport = this;//
            InitializeComponent();
        }

        static void CustmoerReport_FormClosed(object sender, FormClosedEventArgs e)//
        {
            custmoerReport = null;
        }

        public static CustmoerReport GetCustmoerReport //
        {

            get
            {
                if (custmoerReport == null)
                    custmoerReport = new CustmoerReport();
                custmoerReport.FormClosed += CustmoerReport_FormClosed;
                return custmoerReport;

            }
        }

        private void CustmoerReport_Load(object sender, EventArgs e)
        {
            FilldataGridView(this);
        }

        public static void FilldataGridView(CustmoerReport form)
        {
            var db = new DataBaseContext();
            try
            {
                var conn = new SqlConnection(db.Database.Connection.ConnectionString);
                DataTable dt = new DataTable();
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter();

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT Id as 'الرقم'," +
                                   "Name as 'الاسم'," +
                                   "PhoneNumber as 'رقم الهاتف'," +
                                   "Address as 'الموقع'," +
                                   "PurchaseCount as 'عدد مرات الشراء'" +
                                   " FROM Clients";

                da = new SqlDataAdapter(comm);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    form.dataGridView1.DataSource = dt;
                    da.Dispose();
                    dt.Dispose();
                }
                else
                {
                    MessageBox.Show("لا توجد بيانات");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientReport clientReports = new ClientReport();
            try
            {
                using (var db = new DataBaseContext())
                {
                    using (IDbConnection sqlconn = new SqlConnection(db.Database.Connection.ConnectionString))
                    {
                        if (sqlconn.State == ConnectionState.Closed)
                        {
                            sqlconn.Open();
                        }

                        string clientQuery = "SELECT Id , " +
                     "Name,  " +
                     "PhoneNumber , " +
                     "Address  , " +
                     "PurchaseCount  " +
                     "FROM Clients";

                        List<ClientReportDto> list = sqlconn.Query<ClientReportDto>(clientQuery, commandType: CommandType.Text).ToList();

                        clientReports.clientReport1.SetDataSource(list);



                        string SumQuery = "SELECT SUM(PurchaseCount)  as Total  " +
                     "FROM Clients";

                        List<ClientReportDto> list2 = sqlconn.Query<ClientReportDto>(SumQuery, commandType: CommandType.Text).ToList();

                        clientReports.clientReport1.SetParameterValue("Total", list2.FirstOrDefault()?.Total.ToString());



                        clientReports.crystalReportViewer1.ReportSource = clientReports.clientReport1;
                        clientReports.crystalReportViewer1.Refresh();

                        clientReports.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void استعراضالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            var cellValue = selectedRow.Cells["الرقم"].Value.ToString();
            int selectedrowindex1 = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow1 = dataGridView1.Rows[selectedrowindex];
            var cellValue1 = selectedRow.Cells["الاسم"].Value.ToString();
            ClientSales clientSales = new ClientSales(cellValue,cellValue1);
                clientSales.Show();
            
        }
    }

}
