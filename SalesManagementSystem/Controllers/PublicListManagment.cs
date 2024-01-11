

using SalesManagementSystem.Forms;
using SalesManagementSystem.Models;
using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagementSystem.Controllers
{
    public class PublicListManagment
    {
        public static void NewButton(PublicListManagmentForm form)
        {
            form.جديدToolStripMenuItem.Enabled = false;
            form.حفظToolStripMenuItem.Enabled = true;
            form.إلغاءToolStripMenuItem.Enabled = true;
            form.label1.Enabled = true;
            form.textBox1.Enabled = true;
            form.label4.Enabled = true;
            form.comboBox1.Enabled = true;
        }


        public static void ResetPage(PublicListManagmentForm form)
        {
            form.جديدToolStripMenuItem.Enabled = true;
            form.حفظToolStripMenuItem.Enabled = false;
            form.إلغاءToolStripMenuItem.Enabled = false;
            form.تعديلToolStripMenuItem.Enabled = false;
            form.label1.Enabled = false;
            form.textBox1.Enabled = false;
            form.textBox1.Text = string.Empty;
            form.label4.Enabled = false;
            form.comboBox1.Enabled = false;

        }

        public static void AddChange(PublicListManagmentForm form)
        {
            if (IsPublicListNameExist(form.textBox1.Text))
            {
                MessageBox.Show("البيانات موجودة مسبقاً");
                return;
            }

            if (form.textBox1.Text != string.Empty)
            {
                var db = new DataBaseContext();
                try
                {
                    var addPublicList = new PublicList();
                    addPublicList.Name = form.textBox1.Text;
                    if (form.comboBox1.SelectedIndex > -1)
                    {
                        var comboResult = form.comboBox1.SelectedValue.ToString();
                        addPublicList.Code = comboResult ?? " ";
                    }
                    else
                    {
                        MessageBox.Show("يرجى اختيار المجموعة");
                        return;
                    }

                    db.PublicLists.Add(addPublicList);
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("تم الحفظ بنجاح");
                        ResetPage(form);
                        GetAllPublicList(form);
                        GetPublicListGategory(form);

                    }
                    else
                    {
                        MessageBox.Show("فشل في العملية");
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

        public static void GetAllPublicList(PublicListManagmentForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var conn = new SqlConnection(db.Database.Connection.ConnectionString);
                DataTable dt = new DataTable();
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("GetAllPublicList", conn.ConnectionString);
                da.Fill(dt);

                form.dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResetPage(form);
            }
        }

        public static void GetPublicListGategory(PublicListManagmentForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var result = db.PublicLists.Where(x => x.IsParent == true).ToList();
                form.comboBox1.BindingContext = new BindingContext();
                form.comboBox1.DisplayMember = "Name";
                form.comboBox1.ValueMember = "Code";
                form.comboBox2.BindingContext = new BindingContext();
                form.comboBox1.DataSource = result;
                form.comboBox2.DisplayMember = "Name";
                form.comboBox2.ValueMember = "Code";
                result.Add(new PublicList()
                {
                    Id = 0,
                    Name = "كل العناصر"
                });
                form.comboBox2.DataSource = result;
                form.comboBox2.SelectedIndex = form.comboBox1.Items.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ResetSearchBox(PublicListManagmentForm form)
        {
            if (form.textBox3.Text == string.Empty)
            {
                GetAllPublicList(form);
                GetPublicListGategory(form);
            }
        }

        public static void SearchBox(PublicListManagmentForm form)
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
                da = new SqlDataAdapter("select c.Id as \"الرقم\" , " +
                    "c.Name as \"الاسم\" , " +
                    "n.Name as \"الفئة\" " +
                    "from PublicLists n , PublicLists c " +
                    "WHERE c.IsParent = 'False' AND n.IsParent = 'True' AND " +
                    "c.Code = n.Code AND " +
                    "c.Name LIKE N'%" + form.textBox3.Text + "%' ", conn.ConnectionString);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    form.dataGridView1.DataSource = dt;
                    da.Dispose();
                    dt.Dispose();
                }
                else
                {
                    MessageBox.Show("لاتوجد بيانات");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //public static void GetCategories(PublicListManagmentForm form)
        //{
        //    var db = new DataBaseContext();
        //    try
        //    {
        //        var conn = new SqlConnection(db.Database.Connection.ConnectionString);
        //        DataTable dt = new DataTable();
        //        dt.Clear();
        //        SqlDataAdapter da = new SqlDataAdapter();
        //        if (conn.State == ConnectionState.Closed)
        //        {
        //            conn.Open();
        //        }
        //        SqlCommand comm = new SqlCommand();
        //        da = new SqlDataAdapter("select Id as \"الرقم\" , " +
        //            "Name as \"الاسم\" " +
        //            "from PublicLists " +
        //            "where IsParent = 1 ", conn.ConnectionString);

        //        da.Fill(dt);
        //        if (dt.Rows.Count > 0)
        //        {
        //            form.dataGridView1.DataSource = dt;
        //            da.Dispose();
        //            dt.Dispose();
        //        }
        //        else
        //        {
        //            MessageBox.Show("لاتوجد بيانات");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        public static void SearchByCategory(PublicListManagmentForm form)
        {
            var db = new DataBaseContext();
            var selectedText = form.comboBox2.Text;
            if (selectedText == "كل العناصر")
            {
                selectedText = "";
                GetAllPublicList(form);
                return;
            }
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
                da = new SqlDataAdapter("select p1.Id as \"الرقم\" , " +
                    "p1.Name as \"الاسم\" , " +
                    "p2.Name as \"الفئة\" " +
                    "from PublicLists p1 , PublicLists p2 " +
                    "WHERE p1.IsParent = 0 AND " +
                    "p2.IsParent = 1 AND " +
                    "p1.Code = p2.Code AND " +
                    "p1.Code = (select Code from PublicLists " +
                    "Where Name LIKE N'%" + selectedText + "%') ", conn.ConnectionString);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    form.dataGridView1.DataSource = dt;
                    da.Dispose();
                    dt.Dispose();
                }
                else
                {
                    MessageBox.Show("لاتوجد بيانات");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GetPublicListDataById(PublicListManagmentForm form)
        {
            int selectedrowindex = form.dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = form.dataGridView1.Rows[selectedrowindex];
            var cellValue = selectedRow.Cells["الرقم"].Value.ToString();
            var db = new DataBaseContext();
            try
            {
                var publicList = db.PublicLists.FirstOrDefault(x => x.Id == Convert.ToInt32(cellValue));
                if (publicList == null)
                {
                    MessageBox.Show("خطأ في جلب البيانات");
                }
                else
                {
                    form.جديدToolStripMenuItem.Enabled = false;
                    form.حفظToolStripMenuItem.Enabled = false;
                    form.تعديلToolStripMenuItem.Enabled = true;
                    form.إلغاءToolStripMenuItem.Enabled = true;
                    form.label1.Enabled = true;
                    form.textBox1.Enabled = true;
                    form.textBox1.Text = publicList.Name;
                    form.label4.Enabled = true;
                    form.comboBox1.Enabled = true;


                    var getCategoryName = db.PublicLists.FirstOrDefault(x => x.Code == publicList.Code && x.IsParent == true);
                    if (getCategoryName == null)
                    {
                        MessageBox.Show("خطأ في جلب البيانات");
                        return;
                    }
                    int index = form.comboBox1.FindStringExact(getCategoryName.Name);
                    if (index >= 0)
                    {
                        form.comboBox1.SelectedIndex = index;
                    }
                    //form.comboBox1.SelectedValue = "انواع المصروفات";
                    form.id.Text = publicList.Id.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResetPage(form);
            }
        }


        public static bool IsDataExist(PublicListManagmentForm form)
        {
            if (form.textBox1.Text.Length > 0)
            {
                return true;

            }
            return false;
        }

        public static bool IsPublicListNameExist(string test)
        {
            var db = new DataBaseContext();
            try
            {
                return db.PublicLists.Any(x => x.Name == test);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static void UpdatePublicList(PublicListManagmentForm form)
        {
            if (!IsDataExist(form))
            {
                MessageBox.Show("يرجى تعبئة الحقول");
                return;
            }
            var db = new DataBaseContext();
            try
            {
                var getPublicListById = db.PublicLists.FirstOrDefault(x => x.Id == Convert.ToInt32(form.id.Text));
                if (getPublicListById == null)
                {
                    MessageBox.Show("فشل في جلب البيانات");
                    return;
                }

                if (form.textBox1.Text != getPublicListById.Name)
                {
                    if (IsPublicListNameExist(form.textBox1.Text))
                    {
                        MessageBox.Show("البيانات موجودة مسبقاً");
                        return;
                    }

                    getPublicListById.Name = form.textBox1.Text;
                }
                if (form.comboBox1.SelectedIndex > -1)
                {
                    var comboResult = form.comboBox1.SelectedValue.ToString();
                    getPublicListById.Code = comboResult ?? " ";
                }
                else
                {
                    MessageBox.Show("يرجى اختيار المجموعة");
                    return;
                }

                db.PublicLists.AddOrUpdate(getPublicListById);
                if (!(db.SaveChanges() > 0))
                {
                    MessageBox.Show("فشل في العملية");
                    return;
                }

                MessageBox.Show("تم التعديل");
                ResetPage(form);
                GetAllPublicList(form);
                GetPublicListGategory(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
