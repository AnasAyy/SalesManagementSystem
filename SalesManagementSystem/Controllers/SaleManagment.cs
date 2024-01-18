

using SalesManagementSystem.Forms;
using SalesManagementSystem.Reports.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagementSystem.Controllers
{
    public class SaleManagment
    {
        public static bool IsSaleBillExist(int billId)
        {
            var db = new DataBaseContext();
            try
            {
                return db.Bills.Any(x=>x.Id == billId && x.BillType == 1 || x.BillType == 3);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public static void ShowBillReportById(SalesManagmentForm form)
        {
            var billNumber = Convert.ToInt32(form.textBox1.Text);
            if (!IsSaleBillExist(billNumber))
            {
                MessageBox.Show("رقم فاتورة غير صحيح");
                return;
            }
            else
            {
                BillDetailsByIdReportForm.GetBillDetailsByIdReportForm.billNumber = billNumber;
                BillDetailsByIdReportForm.GetBillDetailsByIdReportForm.Show();
            }
        }
        public static void GetAllSaleBills(SalesManagmentForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var conn = new SqlConnection(db.Database.Connection.ConnectionString);
                DataTable dt = new DataTable();
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("GetAllSales", conn.ConnectionString);
                da.Fill(dt);
                form.dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GetAllSalesByBillId(SalesManagmentForm form)
        {
            var db = new DataBaseContext();
            try
            {
                if (form.textBox1.TextLength <= 0)
                {
                    MessageBox.Show("لم يتم ادخال رقم الفاتورة");
                    return;
                }
                var conn = new SqlConnection(db.Database.Connection.ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                /*
                using (var adapter = new SqlDataAdapter("StoredProcedureName", ConnectionString))
                {
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.Add("@ParameterName", SqlDbType.Int).Value = 123;
                    sda.Fill(dataTable);
                };
                */
                using (var sda = new SqlDataAdapter("GetAllSalesByBillId", conn))
                {
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.Add("@billNumber", SqlDbType.Int).Value = Convert.ToInt32(form.textBox1.Text);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    sda.Fill(dt);
                    if (dt.Rows.Count <= 0)
                    {
                        MessageBox.Show("لايوجد فاتورة بهذا الرقم");
                        return;
                    }
                    form.dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GetAllSalesByChoice(SalesManagmentForm form)
        {
            var db = new DataBaseContext();
            try
            {
                if (!form.radioButton1.Checked && !form.radioButton2.Checked && !form.radioButton3.Checked)
                {
                    MessageBox.Show("يرجى تحديد نوع الفاتورة");
                    return;
                }
                if (form.radioButton3.Checked)
                {
                    GetAllSaleBills(form);
                }
                else
                {
                    var conn = new SqlConnection(db.Database.Connection.ConnectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();
                    if (form.radioButton1.Checked)
                    {
                        da = new SqlDataAdapter("select Id as \"رقم الفاتورة\", " +
                        "CASE BillType WHEN 1 THEN N'بيع' else N'مرتجع' END as \"نوع الفاتورة\", " +
                        "TotalPrice as \"المبلغ\", " +
                        "TotalLocalPrice as \"المبلغ بالعملة المحلية\", " +
                        "Note as \"ملاحظات\" from Bills where BillType = 1 ", conn);
                    }
                    else
                    {
                        da = new SqlDataAdapter("select Id as \"رقم الفاتورة\", " +
                        "CASE BillType WHEN 1 THEN N'بيع' else N'مرتجع' END as \"نوع الفاتورة\", " +
                        "TotalPrice as \"المبلغ\", " +
                        "TotalLocalPrice as \"المبلغ بالعملة المحلية\", " +
                        "Note as \"ملاحظات\" from Bills where BillType = 3 ", conn);
                    }

                    da.Fill(dt);
                    if (dt.Rows.Count <= 0)
                    {
                        MessageBox.Show("لايوجد فواتير");
                        return;
                    }
                    form.dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
