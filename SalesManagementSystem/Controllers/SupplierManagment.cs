

using SalesManagementSystem.Forms;
using SalesManagementSystem.Models;
using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesManagementSystem.Controllers
{
    public class SupplierManagment
    {
        public static void ResetForm(SupplierManagmentForm form)
        {
            form.جديدToolStripMenuItem.Enabled = true;
            form.حفظToolStripMenuItem.Enabled = false;
            form.تعديلToolStripMenuItem.Enabled = false;
            form.إلغاءToolStripMenuItem.Enabled = false;
            form.label1.Enabled = false;
            form.label2.Enabled = false;
            form.label4.Enabled = false;
            form.textBox1.Enabled = false;
            form.textBox2.Enabled = false;
            form.textBox4.Enabled = false;
            form.textBox1.Text = string.Empty;
            form.textBox2.Text = string.Empty;
            form.textBox4.Text = string.Empty;
        }
        public static void ClearForm(SupplierManagmentForm form)
        {
            form.textBox1.Text = string.Empty;
            form.textBox2.Text = string.Empty;
            form.textBox3.Text = string.Empty;
            form.textBox4.Text = string.Empty;
        }

        public static void ResetButtons(SupplierManagmentForm form)
        {
            form.جديدToolStripMenuItem.Enabled = true;
            form.حفظToolStripMenuItem.Enabled = false;
            form.تعديلToolStripMenuItem.Enabled = false;
            form.إلغاءToolStripMenuItem.Enabled = false;
            form.label1.Enabled = false;
            form.label2.Enabled = false;
            form.label4.Enabled = false;
            form.textBox1.Enabled = false;
            form.textBox2.Enabled = false;
            form.textBox4.Enabled = false;
        }

        public static bool IsTestBoxesHaveData(SupplierManagmentForm form)
        {
            if (form.textBox1.Text.Length > 0 && form.textBox2.Text.Length > 0)
                return true;
            return false;
        }

        public static void GetMerchantDataById(SupplierManagmentForm form)
        {
            int selectedrowindex = form.dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = form.dataGridView1.Rows[selectedrowindex];
            var cellValue = Convert.ToInt32(selectedRow.Cells["الرقم"].Value.ToString());
            try
            {
                var db = new DataBaseContext();
                var supplier = db.Suppliers.FirstOrDefault(x => x.Id == cellValue);
                if (supplier == null)
                {
                    MessageBox.Show("خطأ في جلب البيانات");
                }
                else
                {
                    form.id.Text = supplier.Id.ToString();
                    form.textBox1.Text = supplier.Name;
                    form.textBox2.Text = supplier.PhoneNumber;
                    form.textBox4.Text = supplier.Address;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResetButtons(form);
            }


        }

        private static Supplier GetMerchantById(int clientId)
        {
            var db = new DataBaseContext();
            try
            {
                return db.Suppliers.FirstOrDefault(x => x.Id == clientId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        private static bool IsMerchantExistByPhoneNumber(string phoneNumber)
        {
            var db = new DataBaseContext();
            try
            {
                return db.Suppliers.Any(x => x.PhoneNumber == phoneNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static void CreateMerchant(SupplierManagmentForm form)
        {
            if (!IsTestBoxesHaveData(form))
            {
                MessageBox.Show("يرجى تعبئة كافة الحقول");
                return;
            }
            if (!PublicOperations.CheckPhoneNumber(form.textBox2.Text))
            {
                MessageBox.Show("يرجى كتابة رقم الهاتف بصيفة صحيحة");
                return;
            }
            var db = new DataBaseContext();
            try
            {
                if (IsMerchantExistByPhoneNumber(form.textBox2.Text))
                {
                    MessageBox.Show("العميل مضاف مسبقاً");
                }
                else
                {
                    db.Suppliers.Add(new Supplier()
                    {
                        Name = form.textBox1.Text,
                        PhoneNumber = form.textBox2.Text,
                        Address = form.textBox4.Text,
                    });
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("تمت الاضافة بنجاح");
                        GetAllMerchant(form);
                        ClearForm(form);
                        ResetButtons(form);

                    }
                    else
                    {
                        MessageBox.Show("فشل في الاضافة");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void SearchMerchant(SupplierManagmentForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var conn = new SqlConnection(db.Database.Connection.ConnectionString);
                //if(conn == null)
                //{
                //    MessageBox.Show("Error Connecting to Database");
                //}
                DataTable dt = new DataTable();
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand comm = new SqlCommand();
                da = new SqlDataAdapter("select Id as \"الرقم\" ," +
                    "Name as \"الاسم\" ," +
                    "PhoneNumber as \"رقم الهاتف\" ," +
                    "Address as \"العنوان\"  ," +
                    "CAST(CreatedAt AS DATE) as \"تاريخ الاضافة\" " +
                    "from Merchants " +
                    "WHERE Name LIKE N'%" + form.textBox3.Text + "%' ", conn.ConnectionString);

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
                ClearForm(form);
            }
        }

        public static void GetAllMerchant(SupplierManagmentForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var conn = new SqlConnection(db.Database.Connection.ConnectionString);
                DataTable dt = new DataTable();
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("GetAllSuppliers", conn.ConnectionString);
                da.Fill(dt);

                form.dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearForm(form);
            }
        }

        public static void UpdateMerchant(SupplierManagmentForm form)
        {
            if (!IsTestBoxesHaveData(form))
            {
                MessageBox.Show("يرجى تعبئة كافة الحقول");
                return;
            }
            if (!PublicOperations.CheckPhoneNumber(form.textBox2.Text))
            {
                MessageBox.Show("يرجى كتابة رقم الهاتف بصيفة صحيحة");
                return;
            }
            var db = new DataBaseContext();
            try
            {
                var merchant = GetMerchantById(Convert.ToInt32(form.id.Text));
                if (merchant == null)
                {
                    MessageBox.Show("خطأ في جلب البيانات");
                }
                else
                {
                    if (merchant.PhoneNumber != form.textBox2.Text)
                    {
                        if (IsMerchantExistByPhoneNumber(form.textBox2.Text))
                        {
                            MessageBox.Show("العميل مضاف مسبقاً");
                            return;
                        }
                        merchant.PhoneNumber = form.textBox2.Text;
                    }
                    merchant.Name = form.textBox1.Text;
                    merchant.Address = form.textBox4.Text;
                    db.Suppliers.AddOrUpdate(merchant);
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("تم التعديل");
                        ClearForm(form);
                        GetAllMerchant(form);
                        ResetButtons(form);
                    }
                    else
                    {
                        MessageBox.Show("فشلت العملية");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

}
