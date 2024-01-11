using SalesManagementSystem.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalesManagementSystem.Controllers
{
    internal class AllPurchasesManagement
    {
        public static void FilldataGridView(PurchasesManagementForm form)
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
                da = new SqlDataAdapter("SELECT Id AS 'الرقم', " +
                     "CASE WHEN BillType = 3 THEN N'مشتريات' ELSE N'مرتجع' END AS 'نوع المشتريات'," +
                     "TotalPrice AS 'مبلغ المشتريات', " +
                     "TotalLocalPrice AS 'اجمالي الملغ بالعملة المحلية', " +
                     "Note AS 'تفاصيل' " +
                     "FROM Bills " +
                     "WHERE BillType IN(3,4)", conn.ConnectionString);

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

        public static void SearchById(PurchasesManagementForm form)
        {
            var db = new DataBaseContext();
            try
            {
                if (form.textBox7.Text.Trim() != "")
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
                    da = new SqlDataAdapter("SELECT Id AS 'الرقم', " +
                         "CASE WHEN BillType = 3 THEN N'مشتريات' ELSE N'مرتجع' END AS 'نوع المشتريات'," +
                         "TotalPrice AS 'مبلغ المشتريات', " +
                         "TotalLocalPrice AS 'اجمالي الملغ بالعملة المحلية', " +
                         "Note AS 'تفاصيل' " +
                         "FROM Bills " +
                         "WHERE BillType IN(3,4) AND Id = '" + Convert.ToInt32(form.textBox7.Text) + "' ", conn.ConnectionString);

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
                }else FilldataGridView(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void SearchByCategory(PurchasesManagementForm form)
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
                if (form.radioButton1.Checked == true)
                {
                    SqlCommand comm = new SqlCommand();
                    da = new SqlDataAdapter("SELECT Id AS 'الرقم', " +
                         "CASE WHEN BillType = 3 THEN N'مشتريات' ELSE N'مرتجع' END AS 'نوع المشتريات'," +
                         "TotalPrice AS 'مبلغ المشتريات', " +
                         "TotalLocalPrice AS 'اجمالي الملغ بالعملة المحلية', " +
                         "Note AS 'تفاصيل' " +
                         "FROM Bills " +
                         "WHERE BillType IN(3,4) AND  BillType = 3 ", conn.ConnectionString);
                }
                if (form.radioButton2.Checked == true)
                {
                    SqlCommand comm = new SqlCommand();
                    da = new SqlDataAdapter("SELECT Id AS 'الرقم', " +
                         "CASE WHEN BillType = 3 THEN N'مشتريات' ELSE N'مرتجع' END AS 'نوع المشتريات'," +
                         "TotalPrice AS 'مبلغ المشتريات', " +
                         "TotalLocalPrice AS 'اجمالي الملغ بالعملة المحلية', " +
                         "Note AS 'تفاصيل' " +
                         "FROM Bills " +
                         "WHERE BillType IN(3,4) AND  BillType = 4 ", conn.ConnectionString);
                }
                if (form.radioButton3.Checked == true)
                {
                    SqlCommand comm = new SqlCommand();
                    da = new SqlDataAdapter("SELECT Id AS 'الرقم', " +
                         "CASE WHEN BillType = 3 THEN N'مشتريات' ELSE N'مرتجع' END AS 'نوع المشتريات'," +
                         "TotalPrice AS 'مبلغ المشتريات', " +
                         "TotalLocalPrice AS 'اجمالي الملغ بالعملة المحلية', " +
                         "Note AS 'تفاصيل' " +
                         "FROM Bills " +
                         "WHERE BillType IN(3,4)", conn.ConnectionString);
                }
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
    }
}
