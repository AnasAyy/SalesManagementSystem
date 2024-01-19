using SalesManagementSystem.Data.Dtos;
using SalesManagementSystem.Reports.Designs;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System;
using System.Windows.Forms;
using Dapper;

namespace SalesManagementSystem.Reports.Forms
{
    public partial class SaleBillReportForm : Form
    {
        static SaleBillReportForm saleBillReportForm;
        public int billNumber;
        public string clientName;
        public SaleBillReportForm()
        {
            if (saleBillReportForm == null) saleBillReportForm = this;
            InitializeComponent();
        }

        static void GetSaleBillReportForm_FormClosed(object sender, FormClosedEventArgs eventArgs)
        {
            saleBillReportForm = null;
        }

        public static SaleBillReportForm GetSaleBillReportForm
        {
            get
            {
                if (saleBillReportForm == null)
                    saleBillReportForm = new SaleBillReportForm();
                saleBillReportForm.FormClosed += GetSaleBillReportForm_FormClosed;
                return saleBillReportForm;
            }
        }

        private void SaleBillReportForm_Load(object sender, EventArgs e)
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
                        string billDetails = "SELECT bill.Id , " +
                            "CASE WHEN bill.BillType = 1 THEN N'مبيعات' WHEN bill.BillType = 2 THEN N'مرتجع مبيعات' WHEN bill.BillType = 3 THEN N'مشتريات' WHEN bill.BillType = 4 THEN N'مرتجع مشتريات' END AS BillType " +
                            ", discount.Name as DiscountType , bill.Discount , fee.Name as FeeType , bill.Fee , bill.Price, bill.TotalPrice, bill.TotalLocalPrice, bill.CreatedAt as Date , bill.ClientId , bill.SupplierId FROM Bills AS bill, PublicLists AS fee, PublicLists AS discount WHERE bill.Id = " + billNumber + " AND bill.DiscountType = discount.Id AND bill.FeeType = fee.Id";
                        List<GetBillDetailsByBillIdResponseDto> list2 = sqlconn.Query<GetBillDetailsByBillIdResponseDto>(billDetails, commandType: CommandType.Text).ToList();

                        string billItems = "SELECT i.Name as ItemName , bi.Quantity as Quantity , bi.TotalPrice as TotalPrice FROM BillItems bi, Items i WHERE bi.BillId = " + billNumber + " AND bi.ItemId = i.Id AND bi.Quantity != 0";
                        List<SaleBillResponseDto> list = sqlconn.Query<SaleBillResponseDto>(billItems, commandType: CommandType.Text).ToList();
                        saleBillReport1.SetDataSource(list);

                        saleBillReport1.SetParameterValue("BillNumber", list2.FirstOrDefault().Id.ToString());
                        saleBillReport1.SetParameterValue("Discount", list2.FirstOrDefault().Discount.ToString());
                        saleBillReport1.SetParameterValue("Fee", list2.FirstOrDefault().Fee.ToString());
                        saleBillReport1.SetParameterValue("TotalPrice", list2.FirstOrDefault().TotalPrice.ToString());
                        saleBillReport1.SetParameterValue("TotalLocalPrice", list2.FirstOrDefault().TotalLocalPrice.ToString());
                        saleBillReport1.SetParameterValue("ClientName", clientName);

                        crystalReportViewer1.ReportSource = saleBillReport1;
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
