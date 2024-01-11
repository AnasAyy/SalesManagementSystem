﻿

using SalesManagementSystem.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalesManagementSystem.Controllers
{
    public class SaleManagment
    {
        public static  void GetAllSaleBills(SalesManagmentForm form)
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
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GetAllSalesByBillId(SalesManagmentForm form)
        {
            var db = new DataBaseContext();
            try
            {
                if(form.textBox1.TextLength <= 0)
                {
                    MessageBox.Show("لم يتم ادخال رقم الفاتورة");
                    return;
                }
                var conn = new SqlConnection(db.Database.Connection.ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                DataTable dt = new DataTable();
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("GetAllSalesByBillId '" + Convert.ToInt32(form.textBox1.Text) + "' ", conn.ConnectionString);
                da.Fill(dt);
                if(dt.Rows.Count <= 0)
                {
                    MessageBox.Show("لايوجد فاتورة بهذا الرقم");
                    return;
                }
                form.dataGridView1.DataSource = dt;
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
                if (!form.radioButton1.Checked && !form.radioButton2.Checked)
                {
                    MessageBox.Show("يرجى تحديد نوع الفاتورة");
                    return;
                }
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
                    "Note as \"ملاحظات\" from Bills where BillType = 1 ", conn.ConnectionString);
                }
                else
                {
                    da = new SqlDataAdapter("select Id as \"رقم الفاتورة\", " +
                    "CASE BillType WHEN 1 THEN N'بيع' else N'مرتجع' END as \"نوع الفاتورة\", " +
                    "TotalPrice as \"المبلغ\", " +
                    "TotalLocalPrice as \"المبلغ بالعملة المحلية\", " +
                    "Note as \"ملاحظات\" from Bills where BillType = 3 ", conn.ConnectionString);
                }
                
                da.Fill(dt);
                if(dt.Rows.Count <= 0)
                {
                    MessageBox.Show("لايوجد فواتير");
                    return;
                }
                form.dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
