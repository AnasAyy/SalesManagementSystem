using SalesManagementSystem.Data.Dtos;
using SalesManagementSystem.Forms;
using SalesManagementSystem.Models;
using SalesManagementSystem.Reports.Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagementSystem.Controllers
{
    public class NewSalesManagment
    {
        public static void GetAllFeeType(NewSaleForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var result = db.PublicLists.Where(x => x.Code == "FEE" && x.IsParent == false).ToList();
                if (result == null)
                {
                    MessageBox.Show("يرجى تهيئة عناصر انواع الضريبة");
                    return;
                }
                else
                {
                    form.comboBox3.BindingContext = new BindingContext();
                    form.comboBox3.DisplayMember = "Name";
                    form.comboBox3.ValueMember = "Id";
                    form.comboBox3.DataSource = result;
                    form.textBox2.Text = 0.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ClearForm(NewSaleForm form)
        {
            form.dataGridView1.Rows.Clear();
            form.textBox7.Text = string.Empty;
            form.textBox6.Text = string.Empty;
            form.textBox1.Text = string.Empty;
            form.textBox5.Text = string.Empty;
            form.textBox2.Text = 0.ToString();
            form.textBox3.Text = 0.ToString();
            form.textBox4.Text = 0.ToString();
            MessageBox.Show("تمت العملية");
        }


        public static void GetAllDiscountType(NewSaleForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var result = db.PublicLists.Where(x => x.Code == "DISCOUNT" && x.IsParent == false).ToList();
                if (result == null)
                {
                    MessageBox.Show("يرجى تهيئة عناصر انواع التخفيضات");
                    return;
                }
                else
                {
                    form.comboBox4.BindingContext = new BindingContext();
                    form.comboBox4.DisplayMember = "Name";
                    form.comboBox4.ValueMember = "Id";
                    form.comboBox4.DataSource = result;
                    form.textBox3.Text = 0.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void AddComboCategories(NewSaleForm form)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    var result = db.Categories.Where(x => x.IsActive == true).ToList();
                    var comboBoxItems = new List<Category>();
                    comboBoxItems.Add(new Category { Id = 0, Name = "كل العناصر" });

                    if(result.Count > 0)
                    {
                        comboBoxItems.AddRange(result);
                        form.comboBox1.BindingContext = new BindingContext();
                        form.comboBox1.DisplayMember = "Name";
                        form.comboBox1.ValueMember = "Id";
                        form.comboBox1.DataSource = comboBoxItems;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public static void GetAllItems(NewSaleForm form)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    var result = db.Items.Where(x => x.IsActive == true).ToList();
                    form.comboBox2.BindingContext = new BindingContext();
                    form.comboBox2.DataSource = result;
                    form.comboBox2.DisplayMember = "Name";
                    form.comboBox2.ValueMember = "Id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public static void GetAllAccounts(NewSaleForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var result = db.Accounts.ToList();
                result.Insert(0, new Account { Name = "اختر حساب", Id = 0 }); // Insert at index 0
                form.comboBox5.BindingContext = new BindingContext();
                form.comboBox5.DataSource = result;
                form.comboBox5.DisplayMember = "Name";
                form.comboBox5.ValueMember = "Id";
                form.comboBox5.SelectedIndex = 0; // Set the selected index to the first item
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void GetItemByValueMember(NewSaleForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var categoryId = Convert.ToInt32(form.comboBox1.SelectedValue);
                var result = db.Items.Where(x => x.CategoryId == categoryId).ToList();
                if (result == null)
                {
                    MessageBox.Show("لا توجد عناصر");
                    GetAllItems(form);
                    return;
                }
                else
                {
                    form.comboBox2.BindingContext = new BindingContext();
                    form.comboBox2.DisplayMember = "Name";
                    form.comboBox2.ValueMember = "Id";
                    form.comboBox2.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GetItemByBarCode(NewSaleForm form)
        {
            var db = new DataBaseContext();
            try
            {
                if (form.textBox1.Text == string.Empty)
                {
                    MessageBox.Show("يرجى ادخال رقم الباركود");
                    return;
                }
                var result = db.Items.FirstOrDefault(x => x.Barcode == form.textBox1.Text);
                if (result == null)
                {
                    MessageBox.Show("لايوجد بيانات");
                    return;
                }
                if (ItemExistsInDataGridView(form.dataGridView1, result.Id.ToString()))
                {
                    MessageBox.Show("لايمكن اضافة الصنف مرتين في الفاتورة");
                }
                else
                {
                    AddAmountForm.getAddAmountForm.label1.Text = result.Id.ToString();
                    AddAmountForm.getAddAmountForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool ItemExistsInDataGridView(DataGridView dataGridView, string item)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(item))
                    {
                        return true;
                    }
            }
            return false;
        }


        public static void GetItemById(NewSaleForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var itemId = Convert.ToUInt32(form.comboBox2.SelectedValue);
                var result = db.Items.FirstOrDefault(x => x.Id == itemId);
                if (result == null)
                {
                    MessageBox.Show("لايوجد بيانات");
                    return;
                }
                if(ItemExistsInDataGridView(form.dataGridView1 , result.Id.ToString()))
                {
                    MessageBox.Show("لايمكن اضافة الصنف مرتين في الفاتورة");
                }

                else
                {
                    AddAmountForm.getAddAmountForm.label1.Text = result.Id.ToString();
                    AddAmountForm.getAddAmountForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CheckSaleType(NewSaleForm form)
        {
            if (form.radioButton3.Checked)
            {
                MakeSale(form);
            }else if (form.radioButton4.Checked)
            {
                ReturnSale(form);
            }
            else
            {
                MessageBox.Show("لم يتم تحديد نوع الفاتورة");
            }
        }


        public static void CalculateBill(NewSaleForm form)
        {
            decimal price = 0;
            foreach (DataGridViewRow r in form.dataGridView1.Rows)
            {
                price += Convert.ToDecimal(r.Cells["TotalSellPrice"].Value);
            }
            form.textBox4.Text = (price + (Convert.ToDecimal(form.textBox2.Text) - Convert.ToDecimal(form.textBox3.Text))).ToString();
        }


        public static void AddItemToGridData(AddSaleDataResponseDto responseDto)
        {
            try
            {
                NewSaleForm.getNewSaleForm.dataGridView1.Rows.
                    Add(responseDto.ProductId,
                    responseDto.ProductName,
                    responseDto.ProductPrice,
                    responseDto.ProductAmount,
                    responseDto.TotalPrice);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void ComboBox1ItemChange(NewSaleForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var selectedText = form.comboBox1.Text;
                if (selectedText == "كل العناصر")
                {
                    GetAllItems(form);
                    return;
                }
                else
                {
                    GetItemByValueMember(form);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void FeeComboBoxIndexChange(NewSaleForm form)
        {
            if (form.comboBox3.Text == "بدون ضريبة")
            {
                form.textBox2.Enabled = false;
                form.textBox2.Text = 0.ToString();
            }
            else
            {
                form.textBox2.Enabled = true;
            }
        }

        public static void DiscountComboBoxIndexChange(NewSaleForm form)
        {
            if (form.comboBox4.Text == "بدون تخفيض")
            {
                form.textBox3.Enabled = false;
                form.textBox3.Text = 0.ToString();
            }
            else
            {
                form.textBox3.Enabled = true;
            }
        }

        public static void GetClientByPhoneNumber(NewSaleForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var result = db.Clients.FirstOrDefault(x => x.PhoneNumber == form.textBox6.Text);
                if (result == null)
                {
                    MessageBox.Show("لايوجد عميل بهذا الرقم");
                    return;
                }
                else
                {
                    form.textBox7.Text = result.Name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static Client GetClientByName(string name)
        {
            var db = new DataBaseContext();
            try
            {
                return db.Clients.FirstOrDefault(x => x.Name == name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public static void MinimizeItemQuantity(int itemId, int quantity)
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
                item.Quantity -= quantity;
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

        public static void MaximizeItemQuantity(int itemId, int quantity)
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
                item.Quantity += quantity;
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

        
        public static void ReturnSale(NewSaleForm form)
        {
            #region Check if Data Exist
            if (!CheckIfDataExist(form))
            {
                return;
            }
            #endregion

            #region Get Client Data
            var client = GetClientByName(form.textBox7.Text);
            if (client == null)
            {
                MessageBox.Show("خطأ في جلب بيانات العميل");
                return;
            }
            #endregion

            var db = new DataBaseContext();
            try
            {
                decimal price = 0;
                foreach (DataGridViewRow r in form.dataGridView1.Rows)
                {
                    price += Convert.ToDecimal(r.Cells["TotalSellPrice"].Value);
                }

                var bill = new Bill()
                {
                    BillType = 3,
                    Discount = Convert.ToDecimal(form.textBox3.Text),
                    DiscountType = Convert.ToInt32(form.comboBox4.SelectedValue.ToString()),
                    Fee = Convert.ToDecimal(form.textBox2.Text),
                    FeeType = Convert.ToInt32(form.comboBox3.SelectedValue.ToString()),
                    Price = price,
                    TotalPrice = Convert.ToDecimal(form.textBox4.Text),
                    TotalLocalPrice = Convert.ToDecimal(form.textBox5.Text),
                    Note = form.textBox8.Text,
                    ClientId = client.Id,
                };
                db.Bills.Add(bill);
                if (db.SaveChanges() <= 0)
                {
                    MessageBox.Show("خطأ في اضافة الفاتورة");
                    return;
                }



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

                    MaximizeItemQuantity(Convert.ToInt32(form.dataGridView1.Rows[i].Cells["ItemId"].Value), Convert.ToInt32(form.dataGridView1.Rows[i].Cells["ItemAmount"].Value));
                }

                client.Credit += Convert.ToDecimal(form.textBox4.Text);
                client.PurchaseCount--;
                db.Clients.AddOrUpdate(client);

                if (db.SaveChanges() <= 0)
                {
                    MessageBox.Show("خطأ في تعديل حساب العميل");
                }

                ClearForm(form);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static bool CheckIfDataExist(NewSaleForm form)
        {
            if (form.dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("اضف اصناف للفاتورة");
                return false;
            }
            if (form.textBox5.Text.Length <= 0)
            {
                MessageBox.Show("قم بإدخال المبلغ بالعملة المحلية");
                return false;
            }
            if (form.textBox7.Text == string.Empty)
            {
                MessageBox.Show("حدد العميل");
                return false;
            }
            return true;
        }



        public static void MakeSale(NewSaleForm form)
        {

            #region Check if Data Exist
            if (!CheckIfDataExist(form))
            {
                return;
            }
            #endregion

            var db = new DataBaseContext();
            try
            {
                #region Get Client Data
                var client = GetClientByName(form.textBox7.Text);
                if (client == null)
                {
                    MessageBox.Show("خطأ في جلب بيانات العميل");
                    return;
                }
                #endregion

                #region Check account is choosen
                if(form.radioButton1.Checked)
                {
                    if(form.comboBox5.Text == "اختر حساب")
                    {
                        MessageBox.Show("يرجى اختيار نوع الحساب");
                        return;
                    }
                }
                #endregion

                decimal price = 0;
                foreach (DataGridViewRow r in form.dataGridView1.Rows)
                {
                    price += Convert.ToDecimal(r.Cells["TotalSellPrice"].Value);
                }

                var bill = new Bill()
                {
                    BillType = form.radioButton1.Checked ? 1 : 5,
                    Discount = Convert.ToDecimal(form.textBox3.Text),
                    DiscountType = Convert.ToInt32(form.comboBox4.SelectedValue.ToString()),
                    Fee = Convert.ToDecimal(form.textBox2.Text),
                    FeeType = Convert.ToInt32(form.comboBox3.SelectedValue.ToString()),
                    Price = price,
                    TotalPrice = Convert.ToDecimal(form.textBox4.Text),
                    TotalLocalPrice = Convert.ToDecimal(form.textBox5.Text),
                    Note = form.textBox8.Text,
                    ClientId = client.Id,
                };
                db.Bills.Add(bill);
                if (db.SaveChanges() <= 0)
                {
                    MessageBox.Show("خطأ في اضافة الفاتورة");
                    return;
                }



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

                    MinimizeItemQuantity(Convert.ToInt32(form.dataGridView1.Rows[i].Cells["ItemId"].Value), Convert.ToInt32(form.dataGridView1.Rows[i].Cells["ItemAmount"].Value));
                }

                if (form.radioButton1.Checked)
                {
                    client.Credit += Convert.ToDecimal(form.textBox4.Text);
                    AddFinancialBond(new FinancialBond()
                    {
                        Title = " مقابل بيع نقد للفاتورة رقم " + bill.Id.ToString(),
                        Type = 1,
                        BoudType = 1,
                        Description = form.textBox8.Text,
                        Fee = Convert.ToDecimal(form.textBox2.Text),
                        FeeType = Convert.ToInt32(form.comboBox3.SelectedValue.ToString()),
                        Price = price,
                        TotalPrice = Convert.ToDecimal(form.textBox4.Text),
                        TotalLocalPrice = Convert.ToDecimal(form.textBox5.Text),
                        ClientId = client.Id,
                        AccountId = Convert.ToInt32(form.comboBox5.SelectedValue.ToString())
                    });

                    UpdateAccount(Convert.ToInt32(form.comboBox5.SelectedValue.ToString()), Convert.ToDecimal(form.textBox4.Text));

                }
                client.Debit += Convert.ToDecimal(form.textBox4.Text);
                client.PurchaseCount++;
                db.Clients.AddOrUpdate(client);

                if (db.SaveChanges() <= 0)
                {
                    MessageBox.Show("خطأ في تعديل حساب العميل");
                }
                SaleBillReportForm.GetSaleBillReportForm.billNumber = bill.Id;
                SaleBillReportForm.GetSaleBillReportForm.clientName = form.textBox7.Text;
                SaleBillReportForm.GetSaleBillReportForm.Show();
                ClearForm(form);
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
                    MessageBox.Show("خطأ في اضافة سند القبض");
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
