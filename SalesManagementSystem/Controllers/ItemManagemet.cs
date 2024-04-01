using SalesManagementSystem.Forms;
using SalesManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagementSystem.Controllers
{
    internal class ItemManagemet
    {

        public static void NewButton(ItemForm form)
        {
            form.جديدToolStripMenuItem.Enabled = false;
            form.حفظToolStripMenuItem.Enabled = true;
            form.إلغاءToolStripMenuItem.Enabled = true;
            form.label1.Enabled = true;
            form.label6.Enabled = true;
            form.textBox1.Enabled = true;
            form.textBox4.Enabled = true;
            form.textBox1.Text = null;
            form.textBox4.Text = null;
            form.textBox2.Enabled = true;
            form.textBox2.Text = null;
            form.label2.Enabled = false;
            form.label5.Enabled = true;
            form.label4.Enabled = true;
            form.radioButton1.Enabled = false;
            form.radioButton2.Enabled = false;
            form.comboBox2.Enabled = true;

        }

        public static void ResetPage(ItemForm form)
        {
            form.جديدToolStripMenuItem.Enabled = true;
            form.حفظToolStripMenuItem.Enabled = false;
            form.إلغاءToolStripMenuItem.Enabled = false;
            form.تعديلToolStripMenuItem.Enabled = false;
            form.label1.Enabled = false;
            form.label6.Enabled = false;
            form.textBox1.Enabled = false;
            form.textBox4.Enabled = false;
            form.textBox2.Enabled = false;
            form.textBox1.Text = null;
            form.textBox4.Text = null;
            form.textBox2.Text = null;
            form.label2.Visible = false;
            form.label4.Enabled = false;
            form.label5.Enabled = false;
            form.radioButton1.Visible = false;
            form.radioButton2.Visible = false;
            form.comboBox2.Enabled = false;
            form.label8.Visible = false;
            form.textBox6.Visible = false;
        }

        public static void FilldataGridView(ItemForm form)
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
                    SqlCommand comm = new SqlCommand("SELECT i.Id AS 'الرقم', " +
                                                      "i.Name AS 'الاسم'," +
                                                      "c.Name AS 'الفئة', " +
                                                      "i.Barcode AS 'باركود', " +
                                                      "i.Quantity AS 'الكمية في المخزن', " +
                                                      "i.BuyPrice AS 'سعر الشراء', " +
                                                      "i.SellPrice AS 'سعر البيع', " +
                                                      "i.LessQuantity AS 'اقل كمية', " +
                                                      "CASE WHEN i.IsActive = 1 THEN N'مفعل' ELSE N'غير مفعل' END AS 'الحالة', " +
                                                      "i.Quantity * i.BuyPrice AS 'اجمالي سعر الشراء' " +
                                                      "FROM Items i join Categories c on i.CategoryId = c.Id", conn);

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

        public static void Add(ItemForm form)
        {
            if (form.textBox1.Text.Trim() != "" && form.textBox4.Text.Trim() != "")
            {
                var db = new DataBaseContext();
                try
                {
                    var category = db.Items.FirstOrDefault(x => x.Name == form.textBox1.Text || x.Barcode == form.textBox4.Text.Trim());
                    if (category != null)
                    {
                        MessageBox.Show("العنصر موجود مسبقا");
                    }
                    else
                    {
                        var items = new Item();
                        items.Name = form.textBox1.Text.Trim();
                        items.LessQuantity = Convert.ToInt32(form.textBox2.Text.Trim().ToString());
                        items.CategoryId = Convert.ToInt32(form.comboBox2.SelectedValue.ToString());
                        items.IsActive = true;
                        items.Barcode = form.textBox4.Text.Trim();
                        items.CreatedAt = DateTime.Now;

                        db.Items.Add(items);
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

        public static void FillComboBox(ItemForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var result = db.Categories.ToList();
                var comboBoxItems = new List<Category>
                {
                    new Category { Id = 0, Name = "اختر عنصر" }
                };

                if (result.Count > 0)
                {
                    comboBoxItems.AddRange(result);

                    form.comboBox2.DataSource = comboBoxItems;
                    form.comboBox2.ValueMember = "Id";
                    form.comboBox2.DisplayMember = "Name";
                }
                else
                {
                    form.comboBox2.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void Edit(ItemForm form)
        {
            form.label2.Visible = true;
            form.label8.Visible = true;
            form.label8.Enabled = true;
            form.label2.Enabled = true;
            form.label6.Visible = true;
            form.label6.Enabled = true;
            form.إلغاءToolStripMenuItem.Enabled = true;
            form.textBox1.Enabled = true;
            form.textBox4.Enabled = true;
            form.textBox2.Enabled = true;
            form.textBox6.Visible = true;
            form.textBox6.Enabled = true;
            form.radioButton1.Visible = true;
            form.radioButton2.Visible = true;
            form.radioButton1.Enabled = true;
            form.radioButton2.Enabled = true;
            form.comboBox2.Enabled = true;
            form.تعديلToolStripMenuItem.Enabled = true;
            form.جديدToolStripMenuItem.Enabled = false;

            int selectedrowindex = form.dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = form.dataGridView1.Rows[selectedrowindex];
            var cellValue = selectedRow.Cells["الرقم"].Value.ToString();
            var db = new DataBaseContext();
            try
            {
                int o = Convert.ToInt32(cellValue);
                var client = db.Items.FirstOrDefault(x => x.Id == o);
                if (client == null)
                {
                    MessageBox.Show("خطأ في جلب البيانات");
                }
                else
                {
                    form.id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                    form.textBox1.Text = selectedRow.Cells[1].Value.ToString();
                    form.textBox4.Text = selectedRow.Cells[3].Value.ToString();
                    form.textBox2.Text = selectedRow.Cells[7].Value.ToString();
                    form.textBox6.Text = selectedRow.Cells[6].Value.ToString();
                    if (selectedRow.Cells[8].Value.ToString() == "مفعل")
                    {
                        form.radioButton1.Checked = true;
                    }
                    if (selectedRow.Cells[8].Value.ToString() == "غير مفعل")
                    {
                        form.radioButton2.Checked = true;


                    }
                    var allCategories = db.Categories.ToList();
                    if (allCategories != null && allCategories.Count > 0)
                    {


                        int index = form.comboBox2.FindStringExact(selectedRow.Cells[2].Value.ToString());
                        if (index >= 0)
                        {
                            form.comboBox2.SelectedIndex = index;
                        }

                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResetPage(form);
            }
        }

        public static void SearchBox(ItemForm form)
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
                    SqlCommand comm = new SqlCommand("SELECT i.Id AS 'الرقم', " +
                                                      "i.Name AS 'الاسم'," +
                                                      "c.Name AS 'الفئة', " +
                                                      "i.Barcode AS 'باركود', " +
                                                      "i.Quantity AS 'الكمية في المخزن', " +
                                                      "i.BuyPrice AS 'سعر الشراء', " +
                                                      "i.SellPrice AS 'سعر البيع', " +
                                                      "i.LessQuantity AS 'اقل كمية', " +
                                                      "CASE WHEN i.IsActive = 1 THEN N'مفعل' ELSE N'غير مفعل' END AS 'الحالة', " +
                                                      "i.Quantity * i.BuyPrice AS 'اجمالي سعر الشراء' " +
                                                      "FROM Items i join Categories c on i.CategoryId = c.Id " +
                                                      "WHERE i.Name LIKE '%' + @searchText + '%' OR i.Barcode LIKE '%' + @searchText + '%'  ", conn);
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

        public static void Update(ItemForm form)
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
                        var count = db.Items.Count(x => x.Name == form.textBox1.Text);
                        if (count > 0)
                        {
                            MessageBox.Show("العنصر موجود مسبقا");
                            return;

                        }
                    }
                    if (form.textBox4.Text != selectedRow.Cells[3].Value.ToString())
                    {
                        var count = db.Items.Count(x => x.Barcode == form.textBox4.Text);
                        if (count > 0)
                        {
                            MessageBox.Show("العنصر موجود مسبقا");
                            return;

                        }
                    }

                    if (form.textBox2.Text.Trim() == "")
                    {

                        MessageBox.Show("الرجاء تحديد اقل كمية للمنتج");
                        return;


                    }
                    if (form.textBox4.Text.Trim() == "")
                    {

                        MessageBox.Show("الرجاء كتابة باركود المنتج");
                        return;


                    }

                    var item = db.Items.FirstOrDefault(x => x.Id == form.id);
                    if (item == null)
                    {
                        MessageBox.Show("حدث خطاء اثناء التعديل");
                    }
                    if (item != null)
                    {
                        item.Name = form.textBox1.Text.Trim();
                        item.LessQuantity = Convert.ToInt32(form.textBox2.Text.Trim());
                        item.CategoryId = Convert.ToInt32(form.comboBox2.SelectedValue);
                        item.Barcode = form.textBox4.Text.Trim();
                        item.SellPrice=Convert.ToDecimal(form.textBox6.Text.Trim());

                        if (form.radioButton1.Checked)
                        {
                            item.IsActive = true;
                        }
                        if (form.radioButton2.Checked)
                        {
                            item.IsActive = false;
                        }
                        item.UpdatedAt = DateTime.Now;

                        db.Items.AddOrUpdate(item);
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
