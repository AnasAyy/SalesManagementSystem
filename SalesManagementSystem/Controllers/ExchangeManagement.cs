using SalesManagementSystem.Forms;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagementSystem.Controllers
{
    internal class ExchangeManagement
    {
        public static void FillComboBox(ExchangeForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var result = db.Accounts.ToList();
                if (result.Count > 0)
                {

                    form.comboBox2.DataSource = result;
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

        public static void FillComboBox1(ExchangeForm form)
        {
            var db = new DataBaseContext();
            try
            {
                var result = db.Accounts.ToList();
                if (result.Count > 0)
                {

                    form.comboBox1.DataSource = result;
                    form.comboBox1.ValueMember = "Id";
                    form.comboBox1.DisplayMember = "Name";
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

        public static void Exchange(ExchangeForm form)
        {
            var db = new DataBaseContext();
            try
            {
                if (form.textBox1.Text.Trim().ToString() != "")
                {


                    var account1Id = Convert.ToInt16(form.comboBox1.SelectedValue);
                    var account1 = db.Accounts
                        .Where(x => x.Id == account1Id)
                        .SingleOrDefault();

                    var account2Id = Convert.ToInt16(form.comboBox2.SelectedValue);
                    var account2 = db.Accounts
                        .Where(x => x.Id == account2Id)
                        .SingleOrDefault();

                    if(form.comboBox1.SelectedValue.ToString() == form.comboBox2.SelectedValue.ToString())
                    {
                        MessageBox.Show("لا يمكن التحويل للحساب نفسه");
                        return;
                    }

                    if (Convert.ToDecimal(form.textBox1.Text.Trim().ToString()) <= account1.Balance)
                    {
                        account1.Balance -= Convert.ToDecimal(form.textBox1.Text.Trim().ToString());
                        account2.Balance += Convert.ToDecimal(form.textBox1.Text.Trim().ToString());
                        db.Accounts.AddOrUpdate(account1);
                        db.Accounts.AddOrUpdate(account2);
                        if (db.SaveChanges() > 0)
                        {
                            form.textBox1.Text = null;
                            form.comboBox1.SelectedIndex = 0;
                            form.comboBox2.SelectedIndex = 0;
                            AccountManagement.FilldataGridView(AccountForm.GetaccountForm);
                            MessageBox.Show("تم التحويل بنجاح");
                            

                        }
                        else
                        {
                            MessageBox.Show("الرجاء المحاولة مجددا");
                        }
                        
                        


                    }
                    else
                    {
                        MessageBox.Show("ليس لديك الرصيد الكافي");
                    }
                }
                else
                {
                    MessageBox.Show("الرجاء كتابة المبلغ المراد تحويلة");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
