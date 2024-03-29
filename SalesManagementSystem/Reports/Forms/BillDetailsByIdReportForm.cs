using Dapper;
using SalesManagementSystem.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagementSystem.Reports.Forms
{
    public partial class BillDetailsByIdReportForm : Form
    {
        static BillDetailsByIdReportForm billDetailsByIdReportForm;
        public int billNumber;
        public BillDetailsByIdReportForm()
        {
            if (billDetailsByIdReportForm == null) billDetailsByIdReportForm = this;
            InitializeComponent();
        }

        static void GetBillDetailsByIdReportForm_FormCLosed(object sender, FormClosedEventArgs e)
        {
            billDetailsByIdReportForm = null;
        }

        public static BillDetailsByIdReportForm GetBillDetailsByIdReportForm
        {
            get
            {
                if (billDetailsByIdReportForm == null)
                    billDetailsByIdReportForm = new BillDetailsByIdReportForm();
                billDetailsByIdReportForm.FormClosed += GetBillDetailsByIdReportForm_FormCLosed;
                return billDetailsByIdReportForm;
            }
        }

        private void GetBillDetailsById_Load(object sender, EventArgs e)
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
                            "CASE WHEN bill.BillType = 1 THEN N'مبيعات' WHEN bill.BillType = 2 THEN N'مشتريات' WHEN bill.BillType = 3 THEN N'مرتجع مبيعات' WHEN bill.BillType = 4 THEN N'مرتجع مشتريات' WHEN bill.BillType = 5 THEN N'مبيعات اجل' WHEN bill.BillType = 6 THEN N'مشتريات اجل' WHEN bill.BillType = 7 THEN N'مرتجع مبيعات اجل' WHEN bill.BillType = 8 THEN N'مرتجع مشتريات اجل' END AS BillType " +
                            ", discount.Name as DiscountType , bill.Discount , fee.Name as FeeType , bill.Fee , bill.Price, bill.TotalPrice, bill.TotalLocalPrice, bill.CreatedAt as Date , bill.ClientId , bill.SupplierId FROM Bills AS bill, PublicLists AS fee, PublicLists AS discount WHERE bill.Id = " + billNumber + " AND bill.DiscountType = discount.Id AND bill.FeeType = fee.Id";
                        List<GetBillDetailsByBillIdResponseDto> list2 = sqlconn.Query<GetBillDetailsByBillIdResponseDto>(billDetails, commandType: CommandType.Text).ToList();

                        string billItems = "SELECT i.Barcode , i.Name as ItemName , bi.Quantity as Quantity , CAST(ROUND(bi.TotalPrice/bi.Quantity, 2) AS DECIMAL(10,2)) as Price , bi.TotalPrice as TotalPrice FROM BillItems bi, Items i WHERE bi.BillId = " + billNumber + " AND bi.ItemId = i.Id AND bi.Quantity != 0";
                        List<GetBillByBillIdResponseDto> list = sqlconn.Query<GetBillByBillIdResponseDto>(billItems, commandType: CommandType.Text).ToList();

                        getBillDetailsByIdReport1.SetDataSource(list);

                        getBillDetailsByIdReport1.SetParameterValue("BillNumber", list2.FirstOrDefault().Id.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("BillType", list2.FirstOrDefault().BillType.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("DiscountType", list2.FirstOrDefault().DiscountType.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("Discount", list2.FirstOrDefault().Discount.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("FeeType", list2.FirstOrDefault().FeeType.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("Fee", list2.FirstOrDefault().Fee.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("Price", list2.FirstOrDefault().Price.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("TotalPrice", list2.FirstOrDefault().TotalPrice.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("TotalLocalPrice", list2.FirstOrDefault().TotalLocalPrice.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("Date", list2.FirstOrDefault().Date.ToShortDateString());

                        if (list2.FirstOrDefault().ClientId == 0)
                        {
                            var supplierId = Convert.ToInt32(list2.FirstOrDefault().SupplierId);
                            var supplierName = db.Suppliers.FirstOrDefault(x => x.Id == supplierId).Name;
                            getBillDetailsByIdReport1.SetParameterValue("BillOwner", supplierName);
                        }
                        else
                        {
                            var clientId = Convert.ToInt32(list2.FirstOrDefault().ClientId);
                            var clientName = db.Clients.FirstOrDefault(x => x.Id == clientId).Name;
                            getBillDetailsByIdReport1.SetParameterValue("BillOwner", clientName);
                        }

                        crystalReportViewer1.ReportSource = getBillDetailsByIdReport1;
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
