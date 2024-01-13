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
    internal class CategoryManagment
    {
        public static void NewButton(CategoryForm form)
        {
            form.جديدToolStripMenuItem.Enabled = false;
            form.حفظToolStripMenuItem.Enabled = true;
            form.إلغاءToolStripMenuItem.Enabled = true;
            form.label1.Enabled = true;
            form.textBox1.Enabled = true;
            form.textBox1.Text = null;
            form.label2.Enabled = false;
            form.radioButton1.Enabled = false;
            form.radioButton2.Enabled = false;

        }
        public static void ResetPage(CategoryForm form)
        {
            form.جديدToolStripMenuItem.Enabled = true;
            form.حفظToolStripMenuItem.Enabled = false;
            form.إلغاءToolStripMenuItem.Enabled = false;
            form.تعديلToolStripMenuItem.Enabled = false;
            form.label1.Enabled = false;
            form.textBox1.Enabled = false;
            form.textBox1.Text = null;
            form.label2.Visible = false;
            form.radioButton1.Visible = false;
            form.radioButton2.Visible = false;
        }
        public static void Add(CategoryForm form)
        {
            if (form.textBox1.Text.Trim() != "")
            {
                var db = new DataBaseContext();
                try
                {
                    var category = db.Categories.FirstOrDefault(x => x.Name == form.textBox1.Text);
                    if (category != null)
                    {
                        MessageBox.Show("العنصر موجود مسبقا");
                    }
                    else
                    {
                        var categorys = new Category();
                        categorys.Name = form.textBox1.Text.Trim();
                        categorys.IsActive = true;
                        categorys.CreatedAt = DateTime.Now;

                        db.Categories.Add(categorys);
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
        public static void Update(CategoryForm form)
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
                        var count = db.Categories.Count(x => x.Name == form.textBox1.Text);
                        if (count > 0)
                        {
                            MessageBox.Show("العنصر موجود مسبقا");
                            return;

                        }
                    }
                    var category = db.Categories.FirstOrDefault(x => x.Id == form.id);
                    if (category == null)
                    {
                        MessageBox.Show("حدث خطاء اثناء التعديل");
                    }
                    if (category != null)
                    {
                        category.Name = form.textBox1.Text.Trim();
                        if (form.radioButton1.Checked)
                        {
                            category.IsActive = true;
                        }
                        if (form.radioButton2.Checked)
                        {
                            category.IsActive = false;
                        }
                        category.UpdatedAt = DateTime.Now;

                        db.Categories.AddOrUpdate(category);
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
        public static void SearchBox(CategoryForm form)
        {
            var db = new DataBaseContext();
            try
            {
                using (var conn = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand comm = new SqlCommand("SELECT c.Id AS 'الرقم', " +
                                                      "c.Name AS 'الاسم', " +
                                                      "CASE WHEN c.IsActive = 1 THEN N'مفعل' ELSE N'غير مفعل' END AS 'الحالة' " +
                                                      "FROM Categories c " +
                                                      "WHERE c.Name LIKE '%' + @searchText + '%'", conn);
                    comm.Parameters.AddWithValue("@searchText", form.textBox3.Text);

                    SqlDataReader reader = comm.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count > 0)
                    {
                        form.dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        form.dataGridView1.DataSource = null;
                        MessageBox.Show("لاتوجد بيانات");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void FilldataGridView(CategoryForm form)
        {
            var db = new DataBaseContext();
            try
            {
                using (var conn = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand comm = new SqlCommand("SELECT c.Id AS 'الرقم', " +
                                                      "c.Name AS 'الاسم', " +
                                                      "CASE WHEN c.IsActive = 1 THEN N'مفعل' ELSE N'غير مفعل' END AS 'الحالة' " +
                                                      "FROM Categories c", conn);

                    SqlDataReader reader = comm.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count > 0)
                    {
                        form.dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("لا توجد بيانات");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Edit(CategoryForm form)
        {
            form.label2.Visible = true;
            form.إلغاءToolStripMenuItem.Enabled = true;
            form.textBox1.Enabled = true;
            form.radioButton1.Visible = true;
            form.radioButton2.Visible = true;
            form.radioButton1.Enabled = true;
            form.radioButton2.Enabled = true;
            form.تعديلToolStripMenuItem.Enabled = true;
            form.جديدToolStripMenuItem.Enabled = false;
            int selectedrowindex = form.dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = form.dataGridView1.Rows[selectedrowindex];
            var cellValue = selectedRow.Cells["الرقم"].Value.ToString();
            var db = new DataBaseContext();
            try
            {
                int o = Convert.ToInt32(cellValue);
                var client = db.Categories.FirstOrDefault(x => x.Id == o);
                if (client == null)
                {
                    MessageBox.Show("خطأ في جلب البيانات");
                }
                else
                {
                    form.id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                    form.textBox1.Text = selectedRow.Cells[1].Value.ToString();
                    if (selectedRow.Cells[2].Value.ToString() == "مفعل")
                    {
                        form.radioButton1.Checked = true;
                    }
                    if (selectedRow.Cells[2].Value.ToString() == "غير مفعل")
                    {
                        form.radioButton2.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResetPage(form);
            }
        }
    }
}



