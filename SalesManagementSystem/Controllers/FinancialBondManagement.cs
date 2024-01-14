using SalesManagementSystem.Forms;
using SalesManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagementSystem.Controllers
{
    internal class FinancialBondManagement
    {
        public static void NewButton(FinancialBondForm form)
        {
            form.جديدToolStripMenuItem.Enabled = false;
            form.حفظToolStripMenuItem.Enabled = true;
            form.إلغاءToolStripMenuItem.Enabled = true;
            form.textBox1.Enabled = true;
            form.textBox1.Text = null;
            form.textBox2.Enabled = true;
            form.textBox2.Text = null;
            form.textBox3.Enabled = true;
            form.textBox3.Text = null;
            form.textBox4.Enabled = true;
            form.textBox4.Text = null;
            form.label2.Enabled = false;

            form.label1.Enabled = true;
            form.label2.Enabled = true;
            form.label3.Enabled = true;
            form.label4.Enabled = true;
            form.label5.Enabled = true;
            form.label6.Enabled = true;
            form.label7.Enabled = true;
            form.label8.Enabled = true;
            form.label9.Enabled = true;
            form.label10.Enabled = true;
            form.label15.Enabled = true;
            form.label16.Enabled = true;

            form.comboBox1.Enabled = true;
            form.comboBox2.Enabled = true;
            form.comboBox3.Enabled = true;
            form.comboBox4.Enabled = true;
            form.comboBox5.Enabled = true;

            form.richTextBox1.Enabled = true;
        }
        public static void FillComboBox1(FinancialBondForm form)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    var result = db.Accounts.ToList();
                    var comboBoxItems = new List<Account>();

                    comboBoxItems.Add(new Account { Id = 0, Name = "اختر عنصر" });

                    if (result.Count > 0)
                    {
                        comboBoxItems.AddRange(result);

                        form.comboBox1.DataSource = comboBoxItems;
                        form.comboBox1.ValueMember = nameof(Account.Id);
                        form.comboBox1.DisplayMember = nameof(Account.Name);
                    }
                    else
                    {
                        form.comboBox1.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static void FillComboBox3(FinancialBondForm form)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    var result = db.PublicLists
                        .Where(x => x.Code == "FEE" && !x.IsParent)
                        .ToList();

                    var comboBoxItems = new List<PublicList>();

                    comboBoxItems.Add(new PublicList { Id = 0, Name = "اختر عنصر" });

                    if (result.Count > 0)
                    {
                        comboBoxItems.AddRange(result);

                        form.comboBox3.DataSource = comboBoxItems;
                        form.comboBox3.ValueMember = nameof(PublicList.Id);
                        form.comboBox3.DisplayMember = nameof(PublicList.Name);
                    }
                    else
                    {
                        form.comboBox3.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static void FillComboBox5(FinancialBondForm form)
        {
            string y = string.Empty;
            string type = form.comboBox4.Text.Trim().ToString();
            if (type != string.Empty && type != "اخرى")
            {
                if (type == "عميل")
                {
                    using (var db = new DataBaseContext())
                    {
                        try
                        {
                            var result = db.Clients.ToList();

                            var comboBoxItems = new List<Client>();

                            comboBoxItems.Add(new Client { Id = 0, Name = "اختر عنصر" });

                            if (result.Count > 0)
                            {
                                comboBoxItems.AddRange(result);

                                form.comboBox5.DataSource = comboBoxItems;
                                form.comboBox5.ValueMember = nameof(Client.Id);
                                form.comboBox5.DisplayMember = nameof(Client.Name);
                            }
                            else
                            {
                                form.comboBox5.DataSource = null;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    using (var db = new DataBaseContext())
                    {
                        try
                        {
                            var result = db.Suppliers.ToList();

                            var comboBoxItems = new List<Supplier>();

                            comboBoxItems.Add(new Supplier { Id = 0, Name = "اختر عنصر" });

                            if (result.Count > 0)
                            {
                                comboBoxItems.AddRange(result);

                                form.comboBox5.DataSource = comboBoxItems;
                                form.comboBox5.ValueMember = nameof(Supplier.Id);
                                form.comboBox5.DisplayMember = nameof(Supplier.Name);
                            }
                            else
                            {
                                form.comboBox5.DataSource = null;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                form.comboBox5.DataSource = null;
            }
        }
        public static void GetClients(FinancialBondForm form)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    var result = db.Clients
                        .ToList();

                    if (result.Count > 0)
                    {
                        form.comboBox5.DataSource = result;
                        form.comboBox5.ValueMember = nameof(Client.Id);
                        form.comboBox5.DisplayMember = nameof(Client.Name);
                    }
                    else
                    {
                        form.comboBox5.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static void GetSuppliers(FinancialBondForm form)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    var result = db.Suppliers
                        .ToList();

                    if (result.Count > 0)
                    {
                        form.comboBox5.DataSource = result;
                        form.comboBox5.ValueMember = nameof(Supplier.Id);
                        form.comboBox5.DisplayMember = nameof(Supplier.Name);
                    }
                    else
                    {
                        form.comboBox5.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static void ResetPage(FinancialBondForm form)
        {
            form.جديدToolStripMenuItem.Enabled = true;
            form.حفظToolStripMenuItem.Enabled = false;
            form.إلغاءToolStripMenuItem.Enabled = false;
            form.تعديلToolStripMenuItem.Enabled = false;
            form.textBox1.Enabled = false;
            form.textBox1.Text = null;
            form.textBox2.Enabled = false;
            form.textBox2.Text = null;
            form.textBox3.Enabled = false;
            form.textBox3.Text = null;
            form.textBox4.Enabled = false;
            form.textBox4.Text = null;
            form.textBox5.Text = null;
            form.textBox6.Text = null;
            form.richTextBox1.Text = null;
            form.label2.Enabled = false;

            form.label1.Enabled = false;
            form.label2.Enabled = false;
            form.label3.Enabled = false;
            form.label4.Enabled = false;
            form.label5.Enabled = false;
            form.label6.Enabled = false;
            form.label7.Enabled = false;
            form.label8.Enabled = false;
            form.label9.Enabled = false;
            form.label10.Enabled = false;
            form.label15.Enabled = false;
            form.label16.Enabled = false;

            form.comboBox1.Enabled = false;
            form.comboBox2.Enabled = false;
            form.comboBox2.Text = null;
            form.comboBox3.Enabled = false;
            form.comboBox4.Enabled = false;
            form.comboBox4.Text = null;
            form.comboBox5.Enabled = false;

            form.richTextBox1.Enabled = false;

        }
        public static void Add(FinancialBondForm form)
        {

            if (form.textBox1.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء كتابة عنوان السند");
                return;
            }
            if (form.comboBox1.SelectedItem != null && form.comboBox1.Text == "اختر عنصر")
            {
                MessageBox.Show("الرجاء تحديد طريقة الدفع");
                return;
            }
            if (form.comboBox3.SelectedItem != null && form.comboBox3.Text == "اختر عنصر")
            {
                MessageBox.Show("الرجاء تحديد نوع الضريبة");
                return;
            }
            if (form.comboBox2.SelectedItem != null && form.comboBox2.Text == "اختر عنصر")
            {
                MessageBox.Show("الرجاء تحديد نوع السند");
                return;
            }

            if (form.textBox2.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء كتابة المبلغ");
                return;
            }
            if (form.textBox2.Text.Trim() == "0")
            {
                MessageBox.Show("الرجاء إعادة كتابة المبلغ");
                return;
            }
            if (form.textBox4.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء كتابة سعر الصرف");
                return;
            }
            if (form.comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء تحديد طريقة الدفع");
                return;
            }
            if (form.comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء تحديد نوع الضريبة");
                return;
            }
            if (form.comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء تحديد المسلم او المستلم");
                return;
            }
            if (form.comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء تحديد نوع السند");
                return;
            }
            var db = new DataBaseContext();
            try
            {

                var financialBond = new FinancialBond();

                financialBond.Title = form.textBox1.Text.Trim();
                financialBond.FeeType = Convert.ToInt32(form.comboBox3.SelectedValue);
                financialBond.Type = form.comboBox2.SelectedIndex;
                financialBond.Price = Convert.ToDecimal(form.textBox2.Text.Trim());
                financialBond.CreatedAt = DateTime.Now;
                financialBond.TotalPrice = Convert.ToDecimal(form.textBox5.Text.Trim());
                financialBond.TotalLocalPrice = Convert.ToDecimal(form.textBox6.Text.Trim());
                financialBond.AccountId = Convert.ToInt32(form.comboBox1.SelectedValue);

                if (form.richTextBox1.Text.Trim() != "")
                {
                    financialBond.Description = form.richTextBox1.Text.Trim();
                }
                else
                {
                    financialBond.Description = "لا يوجد";
                }
                if (form.textBox3.Text.Trim() != "")
                {
                    financialBond.Fee = Convert.ToDecimal(form.textBox3.Text.Trim());
                }
                if (form.comboBox5.Text.Trim() != "" && form.comboBox4.SelectedIndex == 0)
                {
                    financialBond.ClientId = Convert.ToInt32(form.comboBox5.SelectedValue);
                }
                if (form.comboBox5.Text.Trim() != "" && form.comboBox4.SelectedIndex == 1)
                {
                    financialBond.SupplierId = Convert.ToInt32(form.comboBox5.SelectedValue);
                }
                int o = Convert.ToInt32(form.comboBox1.SelectedValue);
                var account = db.Accounts.SingleOrDefault(x => x.Id == o);

                if (account != null)
                {
                    if (form.comboBox2.SelectedIndex == 0)
                    {
                        if (Convert.ToDecimal(form.textBox5.Text.Trim()) > account.Balance)
                        {
                            MessageBox.Show("ليس لديك الرصيد الكافي لاتمام العملية");
                            return;
                        }
                        else
                        {
                            db.FinancialBonds.Add(financialBond);
                            account.Balance -= Convert.ToDecimal(form.textBox5.Text.Trim());
                            db.Accounts.AddOrUpdate(account);
                        }
                    }
                    if (form.comboBox2.SelectedIndex == 1)
                    {
                        db.FinancialBonds.Add(financialBond);
                        account.Balance += Convert.ToDecimal(form.textBox5.Text.Trim());
                        db.Accounts.AddOrUpdate(account);
                    }

                }


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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void FilldataGridView(FinancialBondForm form)
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
                    SqlCommand comm = new SqlCommand("SELECT f.Id AS 'رقم السند', " +
                                                      "f.title AS 'عنوان السند', " +
                                                      "CASE WHEN f.Type = 0 THEN N'صرف' " +
                                                      "     WHEN f.Type = 1 THEN N'قبض' END " +
                                                      "AS 'نوع السند', " +
                                                      "a.Name AS 'الحساب', " +
                                                      "f.TotalPrice AS 'المبلغ الاجمالي للسند', " +
                                                      "f.CreatedAt AS 'التاريخ' " +
                                                      "FROM FinancialBonds f JOIN Accounts a ON f.AccountId = a.Id", conn);

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
        public static void SearchBox(FinancialBondForm form)
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
                    SqlCommand comm = new SqlCommand();
                    DataTable dt = new DataTable();
                    dt.Clear();

                    string query = "SELECT  f.Id AS 'رقم السند', " +
                                   "f.title AS 'عنوان السند', " +
                                   "CASE WHEN f.Type = 0 THEN N'صرف' " +
                                   "     WHEN f.Type = 1 THEN N'قبض' END " +
                                   "AS 'نوع السند', " +
                                   "a.Name AS 'الحساب', " +
                                   "f.TotalPrice AS 'المبلغ الاجمالي للسند', " +
                                   "f.CreatedAt AS 'التاريخ' " +
                                   "FROM FinancialBonds f JOIN Accounts a ON f.AccountId = a.Id ";

                    if (form.textBox7.Text.Trim() != "" && (form.comboBox6.SelectedIndex == -1 || form.comboBox6.SelectedIndex == 2))
                    {
                        query += "WHERE f.id = '" + Convert.ToInt32(form.textBox7.Text.Trim()) + "'";
                    }

                    if (form.textBox7.Text.Trim() != "" && form.comboBox6.SelectedIndex == 0)
                    {
                        query += "WHERE f.id = '" + Convert.ToInt32(form.textBox7.Text.Trim()) + "' AND f.Type = 1";
                    }

                    if (form.textBox7.Text.Trim() != "" && form.comboBox6.SelectedIndex == 1)
                    {
                        query += "WHERE f.id = '" + Convert.ToInt32(form.textBox7.Text.Trim()) + "' AND f.Type = 0";
                    }

                    if (form.textBox7.Text.Trim() == "" && form.comboBox6.SelectedIndex == 0)
                    {
                        query += "WHERE f.Type = 1";
                    }

                    if (form.textBox7.Text.Trim() == "" && form.comboBox6.SelectedIndex == 1)
                    {
                        query += "WHERE f.Type = 0";
                    }

                    comm.CommandText = query;
                    comm.Connection = conn;

                    SqlDataReader reader = comm.ExecuteReader();
                    dt.Load(reader);

                    if (dt.Rows.Count > 0)
                    {
                        form.dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        form.dataGridView1.DataSource = null;
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
        public static void Edit(FinancialBondForm form)
        {
            form.label2.Visible = true;
            form.إلغاءToolStripMenuItem.Enabled = true;
            form.textBox1.Enabled = true;
            form.textBox2.Enabled = true;
            form.textBox3.Enabled = true;
            form.textBox4.Enabled = true;

            form.label1.Enabled = true;
            form.label2.Enabled = true;
            form.label3.Enabled = true;
            form.label4.Enabled = true;
            form.label5.Enabled = true;
            form.label6.Enabled = true;
            form.label7.Enabled = true;
            form.label8.Enabled = true;
            form.label9.Enabled = true;
            form.label10.Enabled = true;
            form.label15.Enabled = true;
            form.label16.Enabled = true;

            form.comboBox1.Enabled = true;
            form.comboBox2.Enabled = true;
            form.comboBox3.Enabled = true;
            form.comboBox4.Enabled = true;
            form.comboBox5.Enabled = true;

            form.richTextBox1.Enabled = true;
            form.تعديلToolStripMenuItem.Enabled = true;
            form.جديدToolStripMenuItem.Enabled = false;

            int selectedrowindex = form.dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = form.dataGridView1.Rows[selectedrowindex];
            var cellValue = selectedRow.Cells["رقم السند"].Value.ToString();
            var db = new DataBaseContext();
            try
            {
                int o = Convert.ToInt32(cellValue);
                var fin = db.FinancialBonds.SingleOrDefault(x => x.Id == o);
                if (fin == null)
                {
                    MessageBox.Show("خطأ في جلب البيانات");
                }
                else
                {
                    if (fin != null)
                    {
                        form.id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                        form.textBox1.Text = fin.Title.ToString();
                        form.comboBox1.SelectedValue = fin.AccountId;
                        form.comboBox3.SelectedValue = fin.FeeType;
                        form.comboBox2.SelectedIndex = fin.Type;
                        if (fin.TotalPrice != 0)
                        {
                            form.textBox4.Text = (fin.TotalLocalPrice / fin.TotalPrice).ToString("0");
                        }
                        else
                        {
                            form.textBox4.Text = "";
                        }
                        form.textBox3.Text = fin.Fee.ToString();
                        //form.textBox4.Text = (fin.TotalLocalPrice / fin.TotalPrice).ToString("0");
                        form.textBox5.Text = fin.TotalPrice.ToString();
                        form.textBox2.Text = fin.Price.ToString();
                        form.textBox6.Text = fin.TotalLocalPrice.ToString();
                        form.richTextBox1.Text = fin.Description.ToString();

                        if (fin.ClientId != null)
                        {
                            form.comboBox4.SelectedIndex = 0;
                            var client = db.Clients.SingleOrDefault(x => x.Id == fin.ClientId);
                            if (client != null)
                            {
                                FillComboBox5(form);
                                form.comboBox5.SelectedValue = client.Id;
                            }
                        }
                        else if (fin.SupplierId != null)
                        {
                            form.comboBox4.SelectedIndex = 1;
                            var supplier = db.Suppliers.SingleOrDefault(x => x.Id == fin.SupplierId);
                            if (supplier != null)
                            {
                                form.comboBox5.SelectedValue = supplier.Id;
                            }
                        }
                        else
                        {
                            form.comboBox4.SelectedIndex = 2;
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
        public static void Update(FinancialBondForm form)
        {
            int selectedrowindex = form.dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = form.dataGridView1.Rows[selectedrowindex];

            if (form.textBox1.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء كتابة عنوان السند");
                return;
            }
            if (form.textBox2.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء كتابة المبلغ");
                return;
            }
            if (form.textBox2.Text.Trim() == "0")
            {
                MessageBox.Show("الرجاء إعادة كتابة المبلغ");
                return;
            }
            if (form.textBox4.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء كتابة سعر الصرف");
                return;
            }
            if (form.comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء تحديد طريقة الدفع");
                return;
            }
            if (form.comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء تحديد نوع الضريبة");
                return;
            }
            if (form.comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء تحديد المسلم او المستلم");
                return;
            }
            if (form.comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء تحديد نوع السند");
                return;
            }
            var db = new DataBaseContext();
            try
            {

                var financialBond = db.FinancialBonds.FirstOrDefault(x => x.Id == form.id);
                if (financialBond == null)
                {
                    MessageBox.Show("حدث خطاء اثناء التعديل");
                }
                if (financialBond != null)
                {
                    if (financialBond.BoudType != 0)
                    {
                        MessageBox.Show("لا يمكن تعديل السندات المرتبطة بالمبيعات او المشتريات");
                        return;
                    }
                    decimal oldTotalPrice = financialBond.TotalPrice;
                    int oldAccountId = financialBond.AccountId;
                    int oldType = financialBond.Type;

                    financialBond.Title = form.textBox1.Text.Trim();
                    financialBond.FeeType = Convert.ToInt32(form.comboBox3.SelectedValue);
                    financialBond.Type = form.comboBox2.SelectedIndex;
                    financialBond.Price = Convert.ToDecimal(form.textBox2.Text.Trim());
                    financialBond.CreatedAt = DateTime.Now;
                    financialBond.TotalPrice = Convert.ToDecimal(form.textBox5.Text.Trim());
                    financialBond.TotalLocalPrice = Convert.ToDecimal(form.textBox6.Text.Trim());
                    financialBond.AccountId = Convert.ToInt32(form.comboBox1.SelectedValue);
                    if (form.richTextBox1.Text.Trim() != "")
                    {
                        financialBond.Description = form.richTextBox1.Text.Trim();
                    }
                    else
                    {
                        financialBond.Description = "لا يوجد";
                    }
                    if (form.textBox3.Text.Trim() != "")
                    {
                        financialBond.Fee = Convert.ToDecimal(form.textBox3.Text.Trim());
                    }
                    if (form.comboBox5.Text.Trim() != "" && form.comboBox4.SelectedIndex == 0)
                    {
                        financialBond.ClientId = Convert.ToInt32(form.comboBox5.SelectedValue);
                    }
                    if (form.comboBox5.Text.Trim() != "" && form.comboBox4.SelectedIndex == 1)
                    {
                        financialBond.SupplierId = Convert.ToInt32(form.comboBox5.SelectedValue);
                    }
                    int o = Convert.ToInt32(form.comboBox1.SelectedValue);
                    var account = db.Accounts.SingleOrDefault(x => x.Id == o);

                    if (account != null)
                    {
                        if (account.Id == oldAccountId && financialBond.Type == oldType)
                        {
                            if (form.comboBox2.SelectedIndex == 0)
                            {
                                if (Convert.ToDecimal(form.textBox5.Text.Trim()) > (account.Balance + oldTotalPrice))
                                {
                                    MessageBox.Show("ليس لديك الرصيد الكافي لاتمام العملية");
                                    return;
                                }
                                else
                                {

                                    account.Balance += oldTotalPrice;
                                    account.Balance -= Convert.ToDecimal(form.textBox5.Text.Trim());
                                    db.Accounts.AddOrUpdate(account);
                                }
                            }
                            if (form.comboBox2.SelectedIndex == 1)
                            {

                                account.Balance -= oldTotalPrice;
                                account.Balance += Convert.ToDecimal(form.textBox5.Text.Trim());
                                db.Accounts.AddOrUpdate(account);
                            }

                        }

                        if (account.Id != oldAccountId && financialBond.Type == oldType)
                        {
                            var oldAccount = db.Accounts.SingleOrDefault(x => x.Id == oldAccountId);
                            if (oldAccount != null)
                            {
                                if (oldType == 0)
                                {
                                    oldAccount.Balance += oldTotalPrice;
                                }
                                if (oldType == 1)
                                {
                                    oldAccount.Balance -= oldTotalPrice;
                                }
                                db.Accounts.AddOrUpdate(oldAccount);
                            }
                            if (form.comboBox2.SelectedIndex == 0)
                            {
                                if (Convert.ToDecimal(form.textBox5.Text.Trim()) > (account.Balance))
                                {
                                    MessageBox.Show("ليس لديك الرصيد الكافي لاتمام العملية");
                                    return;
                                }
                                else
                                {

                                    //account.Balance += oldTotalPrice;
                                    account.Balance -= Convert.ToDecimal(form.textBox5.Text.Trim());
                                    db.Accounts.AddOrUpdate(account);
                                }
                            }
                            if (form.comboBox2.SelectedIndex == 1)
                            {

                                //account.Balance -= oldTotalPrice;
                                account.Balance += Convert.ToDecimal(form.textBox5.Text.Trim());
                                db.Accounts.AddOrUpdate(account);
                            }
                        }

                        if (account.Id == oldAccountId && financialBond.Type != oldType)
                        {
                            //var oldAccount = db.Accounts.SingleOrDefaultAsync(x => x.Id == oldAccountId);
                            if (oldType == 0)
                            {
                                account.Balance += oldTotalPrice;
                            }
                            if (oldType == 1)
                            {
                                account.Balance -= oldTotalPrice;
                            }
                            if (form.comboBox2.SelectedIndex == 0)
                            {
                                if (Convert.ToDecimal(form.textBox5.Text.Trim()) > (account.Balance))
                                {
                                    MessageBox.Show("ليس لديك الرصيد الكافي لاتمام العملية");
                                    return;
                                }
                                else
                                {

                                    //account.Balance += oldTotalPrice;
                                    account.Balance -= Convert.ToDecimal(form.textBox5.Text.Trim());
                                    db.Accounts.AddOrUpdate(account);
                                }
                            }
                            if (form.comboBox2.SelectedIndex == 1)
                            {

                                //account.Balance -= oldTotalPrice;
                                account.Balance += Convert.ToDecimal(form.textBox5.Text.Trim());
                                db.Accounts.AddOrUpdate(account);
                            }
                        }

                        if (account.Id != oldAccountId && financialBond.Type != oldType)
                        {

                            var oldAccount = db.Accounts.SingleOrDefault(x => x.Id == oldAccountId);
                            if (oldAccount != null)
                            {
                                if (oldType == 0)
                                {
                                    oldAccount.Balance += oldTotalPrice;
                                }
                                if (oldType == 1)
                                {
                                    oldAccount.Balance -= oldTotalPrice;
                                }
                                db.Accounts.AddOrUpdate(oldAccount);
                            }

                            if (oldType == 0)
                            {
                                account.Balance += oldTotalPrice;

                            }
                            if (oldType == 1)
                            {
                                account.Balance -= oldTotalPrice;
                            }
                            if (form.comboBox2.SelectedIndex == 0)
                            {
                                if (Convert.ToDecimal(form.textBox5.Text.Trim()) > (account.Balance + oldTotalPrice))
                                {
                                    MessageBox.Show("ليس لديك الرصيد الكافي لاتمام العملية");
                                    return;
                                }
                                else
                                {

                                    account.Balance += oldTotalPrice;
                                    account.Balance -= Convert.ToDecimal(form.textBox5.Text.Trim());
                                    db.Accounts.AddOrUpdate(account);
                                }
                            }
                            if (form.comboBox2.SelectedIndex == 1)
                            {

                                account.Balance -= oldTotalPrice;
                                account.Balance += Convert.ToDecimal(form.textBox5.Text.Trim());
                                db.Accounts.AddOrUpdate(account);
                            }
                        }
                    }

                    db.FinancialBonds.AddOrUpdate(financialBond);
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
    }
}
