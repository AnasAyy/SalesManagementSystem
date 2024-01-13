using SalesManagementSystem.Forms;
using SalesManagementSystem.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagementSystem.Controllers
{
    internal class AccountManagement
    {

        public static void NewButton(AccountForm form)
        {
            form.جديدToolStripMenuItem.Enabled = false;
            form.حفظToolStripMenuItem.Enabled = true;
            form.إلغاءToolStripMenuItem.Enabled = true;
            form.label1.Enabled = true;
            form.textBox1.Enabled = true;
            form.textBox1.Text = null;
            form.label2.Enabled = true;
            form.label1.Enabled = true;
            form.textBox2.Enabled = true;
            form.textBox2.Text = null;

        }



        public static void ResetPage(AccountForm form)
        {
            form.جديدToolStripMenuItem.Enabled = true;
            form.حفظToolStripMenuItem.Enabled = false;
            form.إلغاءToolStripMenuItem.Enabled = false;
            form.تعديلToolStripMenuItem.Enabled = false;
            form.label1.Enabled = false;
            form.textBox1.Enabled = false;
            form.textBox1.Text = null;
            form.textBox2.Enabled = false;
            form.textBox2.Text = null;
            form.label2.Enabled = false;

        }

        public static void Add(AccountForm form)
        {
            if (form.textBox1.Text.Trim() != "")
            {
                var db = new DataBaseContext();
                try
                {
                    var account = db.Accounts.FirstOrDefault(x => x.Name == form.textBox1.Text);
                    if (account != null)
                    {
                        MessageBox.Show("العنصر موجود مسبقا");
                    }
                    else
                    {
                        var accounts = new Account();
                        accounts.Name = form.textBox1.Text.Trim();
                        if (!string.IsNullOrWhiteSpace(form.textBox2.Text))
                            accounts.Description = form.textBox2.Text.Trim();
                        db.Accounts.Add(accounts);


                        if (db.SaveChanges() > 0)
                        {
                            MessageBox.Show("تم الحفظ بنجاح");
                            FilldataGridView(form);
                            ResetPage(form);
                        }
                        else
                        {
                            MessageBox.Show("فشل في العملية");
                        }

                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("يرجى تعيئة جميع الحقول");
            }
        }

        public static void FilldataGridView(AccountForm form)
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
                                   "Name as 'اسم الحساب'," +
                                   "Balance as 'الرصيد'," +
                                   "CreatedAt as 'تاريخ الانشاء'," +
                                   "UpdatedAt as 'تاريخ اخر تعديل على الحساب'," +
                                   "Description as 'تفاصيل الحساب' FROM Accounts";

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


        public static void SearchBox(AccountForm form)
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
                                   "Name as 'اسم الحساب'," +
                                   "Balance as 'الرصيد'," +
                                   "CreatedAt as 'تاريخ الانشاء'," +
                                   "UpdatedAt as 'تاريخ اخر تعديل على الحساب'," +
                                   "Description as 'تفاصيل الحساب' " +
                                   "FROM Accounts " +
                                   "WHERE Name LIKE '%' + @searchText + '%'";

                comm.Parameters.AddWithValue("@searchText", form.textBox3.Text);

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
                    form.dataGridView1.DataSource = null;
                    MessageBox.Show("لاتوجد بيانات");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void Edit(AccountForm form)
        {
            form.label2.Visible = true;
            form.label1.Visible = true;
            form.إلغاءToolStripMenuItem.Enabled = true;
            form.textBox1.Enabled = true;
            form.textBox2.Enabled = true;
            form.تعديلToolStripMenuItem.Enabled = true;
            form.جديدToolStripMenuItem.Enabled = false;
            int selectedrowindex = form.dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = form.dataGridView1.Rows[selectedrowindex];
            var cellValue = selectedRow.Cells["الرقم"].Value.ToString();
            var db = new DataBaseContext();
            try
            {
                int cellValueInt = Convert.ToInt32(cellValue);
                var client = db.Accounts.FirstOrDefault(x => x.Id == cellValueInt);
                if (client == null)
                {
                    MessageBox.Show("خطأ في جلب البيانات");
                }
                else
                {
                    form.id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                    form.textBox1.Text = selectedRow.Cells[1].Value.ToString();
                    form.textBox2.Text = selectedRow.Cells[5].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResetPage(form);
            }
        }


        public static void Update(AccountForm form)
        {
            int selectedrowindex = form.dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = form.dataGridView1.Rows[selectedrowindex];

            if (form.textBox1.Text.Trim() != "")
            {
                var db = new DataBaseContext();
                try
                {
                    if (form.textBox1.Text != selectedRow.Cells[1].Value.ToString())
                    {
                        var count = db.Accounts.Count(x => x.Name == form.textBox1.Text);
                        if (count > 0)
                        {
                            MessageBox.Show("العنصر موجود مسبقا");
                            return;

                        }
                    }
                    var account = db.Accounts.FirstOrDefault(x => x.Id == form.id);
                    if (account == null)
                    {
                        MessageBox.Show("حدث خطاء اثناء التعديل");
                    }
                    if (account != null)
                    {
                        account.Name = form.textBox1.Text.Trim();
                        account.Description = form.textBox2.Text.Trim();
                        account.UpdatedAt = DateTime.Now;

                        db.Accounts.AddOrUpdate(account);
                        if (db.SaveChanges() > 0)
                        {
                            MessageBox.Show("تم التعديل بنجاح");
                            FilldataGridView(form);
                            ResetPage(form);

                        }
                        else
                        {
                            MessageBox.Show("فشل في العملية");
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("يرجى تعيئة جميع الحقول");
            }
        }
    }
}
