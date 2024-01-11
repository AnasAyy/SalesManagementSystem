

using SalesManagementSystem.Data.Dtos;
using SalesManagementSystem.Forms;
using SalesManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesManagementSystem.Controllers
{
    internal class PurchasesManagement
    {
        public static void NewButton(PurchasesForm form)
        {
            //form.جديدToolStripMenuItem.Enabled = false;
            //form.حفظToolStripMenuItem.Enabled = true;
            //form.إلغاءToolStripMenuItem.Enabled = true;
            form.textBox1.Enabled = true;
            form.textBox1.Text = null;
            form.textBox2.Enabled = true;
            form.textBox2.Text = null;
            form.textBox3.Enabled = true;
            form.textBox3.Text = null;
            form.textBox4.Enabled = true;
            form.textBox8.Enabled = true;
            form.textBox4.Text = null;
            form.textBox8.Text = null;
            form.label2.Enabled = false;

            form.label1.Enabled = true;
            form.label2.Enabled = true;
            form.label3.Enabled = true;
            form.label4.Enabled = true;
            form.label5.Enabled = true;
            form.label6.Enabled = true;
            form.label7.Enabled = true;
            //form.label8.Enabled = true;
            form.label9.Enabled = true;
            form.label10.Enabled = true;
            form.label12.Enabled = true;
            form.label15.Enabled = true;
            form.label16.Enabled = true;

            form.comboBox1.Enabled = true;
            form.comboBox2.Enabled = true;
            form.comboBox3.Enabled = true;
            form.comboBox4.Enabled = true;
            form.comboBox5.Enabled = true;

            //form.richTextBox1.Enabled = true;
        }
        public static void ResetPage(PurchasesForm form)
        {
            form.textBox1.Text = null;
            form.textBox2.Text = null;
            form.textBox3.Text = null;
            form.textBox4.Text = null;
            form.textBox8.Text = null;
            form.textBox5.Text = null;
            form.textBox6.Text = null;

            form.dataGridView1.Rows.Clear();
        }
        public static void FillComboBoxItems(PurchasesForm form)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    var result = db.Items.Where(x => x.CategoryId == Convert.ToInt32(form.comboBox2.SelectedValue))
                        .ToList();

                    if (result.Count > 0)
                    {
                        form.comboBox4.DataSource = result;
                        form.comboBox4.ValueMember = nameof(Item.Id);
                        form.comboBox4.DisplayMember = nameof(Item.Name);
                    }
                    else
                    {
                        form.comboBox4.DataSource = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static void FillComboBoxCategorys(PurchasesForm form)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    var result = db.Categories.ToList();

                    
                    var comboBoxItems = new List<Category>();

                    
                    comboBoxItems.Add(new Category { Id = 0, Name = "اختر عنصر" });

                    if (result.Count > 0)
                    {
                        
                        comboBoxItems.AddRange(result);

                        form.comboBox2.DataSource = comboBoxItems;
                        form.comboBox2.ValueMember = nameof(Category.Id);
                        form.comboBox2.DisplayMember = nameof(Category.Name);
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
        }
        public static void FillComboBoxSupplier(PurchasesForm form)
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
        public static void FillComboBoxFee(PurchasesForm form)
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
        public static void FillComboBoxPayment(PurchasesForm form)
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
        public static void AddToGridView(PurchasesForm form)
        {
            if (form.textBox1.Text == string.Empty || form.textBox2.Text == string.Empty || form.textBox8.Text == string.Empty)
            {
                MessageBox.Show("لم تتم تعبئة جميع الحقول");
                return;
            }
            if (form.comboBox4.Text.Trim().ToString() == "")
            {
                MessageBox.Show("الرجاء تحديد المنتج");
                return;
            }
            if (Convert.ToDecimal(form.textBox1.Text) < Convert.ToDecimal(form.textBox2.Text))
            {
                MessageBox.Show("لا يمكن ان يكون سعر الشراء اكبر من سعر البيع");
                return;
            }

            else
            {
                try
                {
                    decimal sum = Convert.ToDecimal(form.textBox2.Text.Trim().ToString()) * Convert.ToDecimal(form.textBox8.Text.Trim().ToString());
                    string[] rowData = { Convert.ToInt32(form.comboBox4.SelectedValue).ToString(), form.comboBox4.Text.Trim(), form.textBox8.Text.Trim(), form.textBox2.Text.Trim(), form.textBox1.Text.Trim(), sum.ToString() };
                    form.dataGridView1.Rows.Add(rowData);

                    form.textBox1.Text = string.Empty;
                    form.textBox2.Text = string.Empty;
                    form.textBox8.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static void fillBarCode(PurchasesForm form)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    int selectedValue;
                    if (int.TryParse(form.comboBox4.SelectedValue.ToString(), out selectedValue))
                    {
                        var result = db.Items.FirstOrDefault(x => x.Id == selectedValue);

                        if (result != null)
                        {
                            form.textBox7.Text = result.Barcode;
                        }
                        else
                        {
                            form.textBox7.Text = string.Empty;
                        }
                    }
                    else
                    {
                        form.textBox7.Text = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public static void changeCombobox(PurchasesForm form)
        {
            using (var db = new DataBaseContext())
            {
                try
                {

                    var result = db.Items.FirstOrDefault(x => x.Barcode == form.textBox7.Text);

                    if (result != null)
                    {
                        form.comboBox2.SelectedValue = result.CategoryId;
                        form.comboBox4.SelectedValue = result.Id;
                    }
                    else
                    {
                        MessageBox.Show("الباركود غير موجود");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public static void Add(PurchasesForm form)
        {
            if (form.dataGridView1.RowCount == 0)
            {
                MessageBox.Show("الرجاء اضافة قائمة المشتريات");
                return;
            }
            if (form.textBox4.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء كتابة سعر الصرف");
                return;
            }
            var db = new DataBaseContext();
            try
            {

                if (form.radioButton3.Checked)
                {
                    // UpdateAccount(Convert.ToInt32(form.comboBox1.SelectedValue.ToString()), Convert.ToDecimal(form.textBox5.Text));


                    var result = db.Accounts.FirstOrDefault(x => x.Id == Convert.ToInt32(form.comboBox1.SelectedValue.ToString()));
                    if (result == null)
                    {
                        MessageBox.Show("خطأ في جلب الحسابات");
                        return;
                    }

                    if (result.Balance < Convert.ToDecimal(form.textBox5.Text))
                    {


                        DialogResult results = MessageBox.Show("ليس لديك الرصيد الكافي هل تريد متابعة العملية؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                        if (results == DialogResult.Yes)
                        {
                            result.UpdatedAt = DateTime.Now;
                            result.Balance -= Convert.ToDecimal(form.textBox5.Text);
                            db.Accounts.AddOrUpdate(result);

                            if (db.SaveChanges() <= 0)
                            {
                                MessageBox.Show("خطأ في تحديث الحسابات");
                                return;
                            }
                        }
                        else if (results == DialogResult.No)
                        {
                            return;
                        }
                    }
                    else
                    {
                        result.UpdatedAt = DateTime.Now;
                        result.Balance -= Convert.ToDecimal(form.textBox5.Text);
                        db.Accounts.AddOrUpdate(result);

                        if (db.SaveChanges() <= 0)
                        {
                            MessageBox.Show("خطأ في تحديث الحسابات");
                            return;
                        }
                    }


                }

                decimal sum = 0;
                foreach (DataGridViewRow row in form.dataGridView1.Rows)
                {
                    if (!row.IsNewRow && row.Cells["TotalSellPrice"].Value != null)
                    {
                        decimal value = Convert.ToDecimal(row.Cells["TotalSellPrice"].Value);
                        sum += value;
                    }
                }

                decimal feee = 0;
                if (form.textBox2.Text.Trim().ToString() != "")
                {
                    feee = Convert.ToDecimal(form.textBox2.Text.Trim().ToString());
                }

                var bill = new Bill()
                {
                    BillType = form.radioButton3.Checked ? 3 : 4,
                    Fee = feee,
                    FeeType = Convert.ToInt32(form.comboBox3.SelectedValue.ToString()),
                    Price = sum,
                    TotalPrice = Convert.ToDecimal(form.textBox5.Text),
                    TotalLocalPrice = Convert.ToDecimal(form.textBox6.Text),
                    Note = form.textBox8.Text,
                    SupplierId = Convert.ToInt32(form.comboBox5.SelectedValue),

                };
                db.Bills.Add(bill);
                if (db.SaveChanges() <= 0)
                {
                    MessageBox.Show("خطأ في اضافة الفاتورة");
                    return;
                }




                #region Get Supplier Data
                var supplier = db.Suppliers.Where(x => x.Id == Convert.ToInt32(form.comboBox5.SelectedValue)).SingleOrDefault();
                if (supplier == null)
                {
                    MessageBox.Show("خطأ في جلب بيانات التاجر");
                    return;
                }
                #endregion




                if (form.radioButton3.Checked)
                {

                    //supplier.Credit += Convert.ToDecimal(form.textBox5.Text);
                    AddFinancialBond(new FinancialBond()
                    {
                        Title = " مقابل شراء للفاتورة رقم " + bill.Id.ToString(),
                        Type = 0,
                        BoudType = 2,
                        Description = "لا يوجد",
                        Fee = feee,
                        FeeType = Convert.ToInt32(form.comboBox3.SelectedValue.ToString()),
                        Price = Convert.ToDecimal(form.textBox5.Text) - feee,
                        TotalPrice = Convert.ToDecimal(form.textBox5.Text),
                        TotalLocalPrice = Convert.ToDecimal(form.textBox6.Text),
                        SupplierId = supplier.Id,
                        AccountId = Convert.ToInt32(form.comboBox1.SelectedValue.ToString())
                    });


                    for (int i = 0; i < form.dataGridView1.Rows.Count; i++)
                    {
                        db.BillItems.Add(new BillItem()
                        {
                            ItemId = Convert.ToInt32(form.dataGridView1.Rows[i].Cells["ItemId"].Value),
                            Quantity = Convert.ToInt32(form.dataGridView1.Rows[i].Cells["ItemAmount"].Value),
                            TotalPrice = Convert.ToDecimal(form.dataGridView1.Rows[i].Cells["TotalSellPrice"].Value),
                            BillId = bill.Id
                        });
                        if (db.SaveChanges() <= 0)
                        {
                            MessageBox.Show("خطأ في اضافة اصناف للفاتورة");
                        }

                        MaximizeItemQuantity(Convert.ToInt32(form.dataGridView1.Rows[i].Cells["ItemId"].Value), Convert.ToInt32(form.dataGridView1.Rows[i].Cells["ItemAmount"].Value), Convert.ToDecimal(form.dataGridView1.Rows[i].Cells["SellPrice"].Value), Convert.ToDecimal(form.dataGridView1.Rows[i].Cells["buyPrice"].Value));
                    }





                    supplier.Credit += Convert.ToDecimal(form.textBox5.Text) - feee;

                    db.Suppliers.AddOrUpdate(supplier);

                    if (db.SaveChanges() <= 0)
                    {
                        MessageBox.Show("خطأ في تعديل حساب العميل");
                    }
                }
                if (form.radioButton4.Checked)
                {
                    //supplier.Credit += Convert.ToDecimal(form.textBox5.Text);

                    decimal fee = 0;
                    if (form.textBox3.Text.Trim() != "")
                    {
                        fee = Convert.ToDecimal(form.textBox3.Text);
                    }

                    AddFinancialBond(new FinancialBond()
                    {
                        Title = " مقابل مرتجع شراء للفاتورة رقم " + bill.Id.ToString(),
                        Type = 1,
                        BoudType = 2,
                        Description = "لا يوجد",
                        Fee = fee,
                        FeeType = Convert.ToInt32(form.comboBox3.SelectedValue.ToString()),
                        Price = Convert.ToDecimal(form.textBox5.Text) - feee,
                        TotalPrice = Convert.ToDecimal(form.textBox5.Text),
                        TotalLocalPrice = Convert.ToDecimal(form.textBox6.Text),
                        SupplierId = supplier.Id,
                        AccountId = Convert.ToInt32(form.comboBox1.SelectedValue.ToString())
                    });


                    for (int i = 0; i < form.dataGridView1.Rows.Count; i++)
                    {
                        db.BillItems.Add(new BillItem()
                        {
                            ItemId = Convert.ToInt32(form.dataGridView1.Rows[i].Cells["ItemId"].Value),
                            Quantity = Convert.ToInt32(form.dataGridView1.Rows[i].Cells["ItemAmount"].Value),
                            TotalPrice = Convert.ToDecimal(form.dataGridView1.Rows[i].Cells["TotalSellPrice"].Value),
                            BillId = bill.Id
                        });
                        if (db.SaveChanges() <= 0)
                        {
                            MessageBox.Show("خطأ في اضافة اصناف للفاتورة");
                        }

                        MinimizeItemQuantity(Convert.ToInt32(form.dataGridView1.Rows[i].Cells["ItemId"].Value), Convert.ToInt32(form.dataGridView1.Rows[i].Cells["ItemAmount"].Value), Convert.ToDecimal(form.dataGridView1.Rows[i].Cells["SellPrice"].Value), Convert.ToDecimal(form.dataGridView1.Rows[i].Cells["buyPrice"].Value));
                    }

                    UpdateAccountAdd(Convert.ToInt32(form.comboBox1.SelectedValue.ToString()), Convert.ToDecimal(form.textBox5.Text));

                    supplier.Debit += Convert.ToDecimal(form.textBox5.Text) - feee;

                    db.Suppliers.AddOrUpdate(supplier);

                    if (db.SaveChanges() <= 0)
                    {
                        MessageBox.Show("خطأ في تعديل حساب العميل");
                    }
                }

                ResetPage(form);
                MessageBox.Show("تم الحفظ بنجاح");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        public static void MaximizeItemQuantity(int itemId, int quantity, decimal sellprice, decimal buyprice)
        {
            var db = new DataBaseContext();
            try
            {
                var item = db.Items.SingleOrDefault(x => x.Id == itemId);
                if (item == null)
                {
                    MessageBox.Show("خطأ في جلب الصنف");
                    return;
                }


                var sellprices = ((item.SellPrice * item.Quantity) + (sellprice * quantity)) / (item.Quantity + quantity);
                var buyprices = ((item.BuyPrice * item.Quantity) + (buyprice * quantity)) / (item.Quantity + quantity);

                item.Quantity += quantity;
                item.SellPrice = sellprices;
                item.BuyPrice = buyprices;

                db.Items.AddOrUpdate(item);

                if (db.SaveChanges() <= 0)
                {
                    MessageBox.Show("خطأ في تعديل المخزون");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void MinimizeItemQuantity(int itemId, int quantity, decimal sellprice, decimal buyprice)
        {
            var db = new DataBaseContext();
            try
            {
                var item = db.Items.SingleOrDefault(x => x.Id == itemId);
                if (item == null)
                {
                    MessageBox.Show("خطأ في جلب الصنف");
                    return;
                }


                var sellprices = ((item.SellPrice * item.Quantity) - (sellprice * quantity)) / (item.Quantity - quantity);
                var buyprices = ((item.BuyPrice * item.Quantity) - (buyprice * quantity)) / (item.Quantity - quantity);

                item.Quantity -= quantity;
                item.SellPrice = sellprices;
                item.BuyPrice = buyprices;

                db.Items.AddOrUpdate(item);

                if (db.SaveChanges() <= 0)
                {
                    MessageBox.Show("خطأ في تعديل المخزون");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void AddFinancialBond(FinancialBond financialBond)
        {
            var db = new DataBaseContext();
            try
            {
                db.FinancialBonds.Add(financialBond);

                if (db.SaveChanges() <= 0)
                {
                    MessageBox.Show("خطأ في اضافة سند الصرف");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void UpdateAccount(int accountId, decimal balance)
        {
            var db = new DataBaseContext();
            try
            {
                var result = db.Accounts.FirstOrDefault(x => x.Id == accountId);
                if (result == null)
                {
                    MessageBox.Show("خطأ في جلب الحسابات");
                    return;
                }

                if (result.Balance < balance)
                {


                    DialogResult results = MessageBox.Show("ليس لديك الرصيد الكافي هل تريد متابعة العملية؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                    if (results == DialogResult.Yes)
                    {
                        result.UpdatedAt = DateTime.Now;
                        result.Balance -= balance;
                        db.Accounts.AddOrUpdate(result);

                        if (db.SaveChanges() <= 0)
                        {
                            MessageBox.Show("خطأ في تحديث الحسابات");
                            return;
                        }
                    }
                    else if (results == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    result.UpdatedAt = DateTime.Now;
                    result.Balance -= balance;
                    db.Accounts.AddOrUpdate(result);

                    if (db.SaveChanges() <= 0)
                    {
                        MessageBox.Show("خطأ في تحديث الحسابات");
                        return;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void UpdateAccountAdd(int accountId, decimal balance)
        {
            var db = new DataBaseContext();
            try
            {
                var result = db.Accounts.FirstOrDefault(x => x.Id == accountId);
                if (result == null)
                {
                    MessageBox.Show("خطأ في جلب الحسابات");
                    return;
                }

                result.UpdatedAt = DateTime.Now;
                result.Balance += balance;
                db.Accounts.AddOrUpdate(result);

                if (db.SaveChanges() <= 0)
                {
                    MessageBox.Show("خطأ في تحديث الحسابات");
                    return;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
