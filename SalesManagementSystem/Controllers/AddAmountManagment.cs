using SalesManagementSystem.Data.Dtos;
using SalesManagementSystem.Forms;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagementSystem.Controllers
{
    public class AddAmountManagment
    {
        public static void AddToGridView(AddAmountForm form)
        {
            if (form.textBox1.Text == string.Empty)
            {
                MessageBox.Show("لم تتم تعبئة الحقول");
                return;
            }
            else
            {
                var db = new DataBaseContext();
                try
                {
                    var itemId = Convert.ToInt32(form.label1.Text);
                    var result = db.Items.FirstOrDefault(x => x.Id == itemId);
                    if (result == null)
                    {
                        MessageBox.Show("خطأ اثناء جلب البيانات");
                    }
                    else
                    {
                        int getAmount = Convert.ToInt32(form.textBox1.Text);
                        if(NewSaleForm.getNewSaleForm.radioButton3.Checked)
                        {
                            if (result.Quantity < getAmount)
                            {
                                MessageBox.Show("يوجد " + result.Quantity + " فقط بالمخزن");
                                return;
                            }
                        }
                        
                        NewSalesManagment.AddItemToGridData(new AddSaleDataResponseDto()
                        {
                            ProductId = result.Id,
                            ProductName = result.Name,
                            ProductPrice = result.SellPrice,
                            ProductAmount = getAmount,
                            TotalPrice = result.SellPrice * getAmount
                        });
                        form.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
