using Dapper;
using SalesManagementSystem.Data.Dtos;
using SalesManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace SalesManagementSystem.Reports.Forms
{
    public partial class GetBillDetailsById : Form
    {
        public GetBillDetailsById()
        {
            InitializeComponent();
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
                        string billDetails = "SELECT bill.Id , bill.BillType , discount.Name as DiscountType , bill.Discount , fee.Name as FeeType , bill.Fee , bill.Price, bill.TotalPrice, bill.TotalLocalPrice, bill.CreatedAt as Date FROM Bills AS bill, PublicLists AS fee, PublicLists AS discount WHERE bill.Id = 40 AND bill.DiscountType = discount.Id AND bill.FeeType = fee.Id";
                        List<GetBillDetailsByBillIdResponseDto> list2 = sqlconn.Query<GetBillDetailsByBillIdResponseDto>(billDetails, commandType: CommandType.Text).ToList();

                        string billItems = "SELECT i.Name as ItemName , bi.Quantity as Quantity , CAST(ROUND(bi.TotalPrice/bi.Quantity, 2) AS DECIMAL(10,2)) as Price , bi.TotalPrice as TotalPrice FROM BillItems bi, Items i WHERE bi.BillId = 48 AND bi.ItemId = i.Id AND bi.Quantity != 0";
                        List<GetBillByBillIdResponseDto> list = sqlconn.Query<GetBillByBillIdResponseDto>(billItems, commandType: CommandType.Text).ToList();
                        
                        getBillDetailsByIdReport1.SetDataSource(list);

                        getBillDetailsByIdReport1.SetParameterValue("BillNumber", list2.FirstOrDefault().Id.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("BillType", list2.FirstOrDefault().BillType.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("DiscountType", list2.FirstOrDefault().DiscountType.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("Discount", list2.FirstOrDefault().Discount.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("FeeType", list2.FirstOrDefault().FeeType.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("Fee", list2.FirstOrDefault().Fee.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("Price", list2.FirstOrDefault().Price.ToString() );
                        getBillDetailsByIdReport1.SetParameterValue("TotalPrice", list2.FirstOrDefault().TotalPrice.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("TotalLocalPrice", list2.FirstOrDefault().TotalLocalPrice.ToString());
                        getBillDetailsByIdReport1.SetParameterValue("Date", list2.FirstOrDefault().Date.Date.ToString());
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
