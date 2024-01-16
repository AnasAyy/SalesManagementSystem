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
    public class CustomerManagment
    {

        public static void ClearForm(CustomerManagmentForm form)
        {
            form.textBox1.Text = string.Empty;
            form.textBox2.Text = string.Empty;
            form.textBox3.Text = string.Empty;
            form.textBox4.Text = string.Empty;
        }

        public static void ResetButtons(CustomerManagmentForm form)
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

        public static bool IsTestBoxesHaveData(CustomerManagmentForm form)
        {
            if (form.textBox1.Text.Length > 0 && form.textBox2.Text.Length > 0)
                return true;
            return false;
        }


        public static void GetClientDataById(CustomerManagmentForm form)
        {
            int selectedrowindex = form.dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = form.dataGridView1.Rows[selectedrowindex];
            var cellValue = Convert.ToInt32(selectedRow.Cells["الرقم"].Value.ToString());
            var db = new DataBaseContext();
            try
            {
                var client = db.Clients.FirstOrDefault(x => x.Id == cellValue);
                if (client == null)
                {
                    MessageBox.Show("خطأ في جلب البيانات");
                }
                else
                {
                    form.id.Text = client.Id.ToString();
                    form.textBox1.Text = client.Name;
                    form.textBox2.Text = client.PhoneNumber;
                    form.textBox4.Text = client.Address;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResetButtons(form);
            }


        }

        private static Client GetClientById(int clientId)
        {
            var db = new DataBaseContext();
            try
            {
                return db.Clients.FirstOrDefault(x => x.Id == clientId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        private static bool IsClientExistByPhoneNumber(string phoneNumber)
        {
            var db = new DataBaseContext();
            try
            {
                return db.Clients.Any(x => x.PhoneNumber == phoneNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static void CreateClient(CustomerManagmentForm form)
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
                if (IsClientExistByPhoneNumber(form.textBox2.Text))
                {
                    MessageBox.Show("العميل مضاف مسبقاً");
                }
                else
                {
                    db.Clients.Add(new Client()
                    {
                        Name = form.textBox1.Text,
                        PhoneNumber = form.textBox2.Text,
                        Address = form.textBox4.Text,
                    });
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("تمت الاضافة بنجاح");
                        GetAllClient(form);
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

        public static void SearchClient(CustomerManagmentForm form)
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
                da = new SqlDataAdapter("select Id as \"الرقم\" ," +
                    "Name as \"الاسم\" ," +
                    "PhoneNumber as \"رقم الهاتف\" ," +
                    "Address as \"العنوان\"  ," +
                    "PurchaseCount as \"عدد مرات الشراء\" ," +
                    "CAST(CreatedAt AS DATE) as \"تاريخ الاضافة\" " +
                    "from Clients " +
                    "WHERE Name LIKE N'%" + form.textBox3.Text + "%' ", conn);

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

        public static void GetAllClient(CustomerManagmentForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var conn = new SqlConnection(db.Database.Connection.ConnectionString);
                DataTable dt = new DataTable();
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("GetAllClients", conn.ConnectionString);
                da.Fill(dt);

                form.dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearForm(form);
            }
        }

        public static void UpdateClient(CustomerManagmentForm form)
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
                var user = GetClientById(Convert.ToInt32(form.id.Text));
                if (user == null)
                {
                    MessageBox.Show("خطأ في جلب البيانات");
                }
                else
                {
                    if (user.PhoneNumber != form.textBox2.Text)
                    {
                        if (IsClientExistByPhoneNumber(form.textBox2.Text))
                        {
                            MessageBox.Show("العميل مضاف مسبقاً");
                            return;
                        }
                        user.PhoneNumber = form.textBox2.Text;
                    }
                    user.Name = form.textBox1.Text;
                    user.Address = form.textBox4.Text;
                    db.Clients.AddOrUpdate(user);
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("تم التعديل");
                        ClearForm(form);
                        GetAllClient(form);
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
