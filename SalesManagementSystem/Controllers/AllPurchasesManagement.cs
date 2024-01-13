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

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT Id AS 'الرقم', " +
                    "CASE WHEN BillType = 3 THEN N'مشتريات' ELSE N'مرتجع' END AS 'نوع المشتريات'," +
                    "TotalPrice AS 'مبلغ المشتريات', " +
                    "TotalLocalPrice AS 'اجمالي الملغ بالعملة المحلية', " +
                    "Note AS 'تفاصيل' " +
                    "FROM Bills " +
                    "WHERE BillType IN(3,4)";

                SqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    form.dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("لا توجد بيانات");
                }

                reader.Close();
                conn.Close();
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

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    SqlCommand comm = new SqlCommand();
                    comm.Connection = conn;
                    comm.CommandText = "SELECT Id AS 'الرقم', " +
                        "CASE WHEN BillType = 3 THEN N'مشتريات' ELSE N'مرتجع' END AS 'نوع المشتريات'," +
                        "TotalPrice AS 'مبلغ المشتريات', " +
                        "TotalLocalPrice AS 'اجمالي الملغ بالعملة المحلية', " +
                        "Note AS 'تفاصيل' " +
                        "FROM Bills " +
                        "WHERE BillType IN(3,4) AND Id = @Id";

                    comm.Parameters.AddWithValue("@Id", Convert.ToInt32(form.textBox7.Text));

                    SqlDataReader reader = comm.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                        form.dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("لا توجد بيانات");
                    }

                    reader.Close();
                    conn.Close();
                }
                else
                {
                    FilldataGridView(form);
                }
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

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;

                if (form.radioButton1.Checked == true)
                {
                    comm.CommandText = "SELECT Id AS 'الرقم', " +
                        "CASE WHEN BillType = 3 THEN N'مشتريات' ELSE N'مرتجع' END AS 'نوع المشتريات'," +
                        "TotalPrice AS 'مبلغ المشتريات', " +
                        "TotalLocalPrice AS 'اجمالي الملغ بالعملة المحلية', " +
                        "Note AS 'تفاصيل' " +
                        "FROM Bills " +
                        "WHERE BillType IN(3,4) AND  BillType = 3 ";
                }
                if (form.radioButton2.Checked == true)
                {
                    comm.CommandText = "SELECT Id AS 'الرقم', " +
                        "CASE WHEN BillType = 3 THEN N'مشتريات' ELSE N'مرتجع' END AS 'نوع المشتريات'," +
                        "TotalPrice AS 'مبلغ المشتريات', " +
                        "TotalLocalPrice AS 'اجمالي الملغ بالعملة المحلية', " +
                        "Note AS 'تفاصيل' " +
                        "FROM Bills " +
                        "WHERE BillType IN(3,4) AND  BillType = 4 ";
                }
                if (form.radioButton3.Checked == true)
                {
                    comm.CommandText = "SELECT Id AS 'الرقم', " +
                        "CASE WHEN BillType = 3 THEN N'مشتريات' ELSE N'مرتجع' END AS 'نوع المشتريات'," +
                        "TotalPrice AS 'مبلغ المشتريات', " +
                        "TotalLocalPrice AS 'اجمالي الملغ بالعملة المحلية', " +
                        "Note AS 'تفاصيل' " +
                        "FROM Bills " +
                        "WHERE BillType IN(3,4)";
                }

                SqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    form.dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("لا توجد بيانات");
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
