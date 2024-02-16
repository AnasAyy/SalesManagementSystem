using SalesManagementSystem.Forms;
using SalesManagementSystem.Models;
using SalesManagementSystem.Reports.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;
using SalesManagementSystem.Reports.Designs;
using System.Runtime.Remoting.Contexts;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using SalesManagementSystem.Data.Dtos;

namespace SalesManagementSystem.Controllers
{
    public class SalesReportManagement
    {
        public static void LoadForm(SaleManagementReportForm form)
        {
            if (form.radioButton1.Checked)
            {
                ShowByBillId(form);
            }
            else if (form.radioButton2.Checked)
            {
                ShowByCategory(form);
            }
            else
            {
                ShowByItem(form);
            }
        }

        public static void PressSearch(SaleManagementReportForm form)
        {
            using (var db = new DataBaseContext())
            {
                string name = string.Empty, profitType = string.Empty;
                int numberOfSoldItems = 0, numberOfReturnItems = 0;
                decimal totalPurchasePrice = 0, totalSalePrice = 0, totalProfit = 0;
                decimal totalReturnPurchasePrice = 0, totalReturnSalePrice = 0, totalLose = 0;
                string fromDate = form.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), toDate = form.dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
                try
                {
                    if (form.radioButton1.Checked)
                    {
                        int billId = Convert.ToInt32(form.textBox2.Text);
                        var bill = db.Bills.FirstOrDefault(x => x.Id == billId && (x.BillType == 1 || x.BillType == 3));
                        if (bill != null)
                        {
                            var billItems = db.BillItems.Where(x => x.BillId == bill.Id).ToList();
                            if (billItems.Any())
                            {
                                fromDate = " - "; toDate = " - ";
                                if (bill.BillType == 1)
                                {
                                    name = "فاتورة مبيعات رقم " + bill.Id;
                                    for (int i = 0; i < billItems.Count(); i++)
                                    {
                                        numberOfSoldItems += billItems[i].Quantity;
                                        var itemId = billItems[i].ItemId;
                                        var item = db.Items.FirstOrDefault(x => x.Id == itemId);
                                        if (item == null)
                                        {
                                            return;
                                        }
                                        totalPurchasePrice += item.BuyPrice * billItems[i].Quantity;
                                        totalSalePrice += billItems[i].TotalPrice;
                                    }
                                    totalProfit = totalSalePrice - totalPurchasePrice;
                                }
                                else
                                {
                                    name = "فاتورة مرتجع رقم " + bill.Id;
                                    for (int i = 0; i < billItems.Count(); i++)
                                    {
                                        numberOfReturnItems += billItems[i].Quantity;
                                        int itemId = billItems[i].Id;
                                        var item = db.Items.FirstOrDefault(x => x.Id == itemId);
                                        if (item == null)
                                        {
                                            return;
                                        }
                                        totalPurchasePrice += item.BuyPrice * billItems[i].Quantity;
                                        totalSalePrice += billItems[i].TotalPrice;
                                    }
                                    totalLose = totalPurchasePrice - totalSalePrice;
                                }

                            }
                            else
                            {
                                MessageBox.Show("فاتورة لا تحتوي على عناصر");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("رقم فاتورة غير صحيح او ان الفاتورة لا تخص المبيعات");
                            return;
                        }
                    }
                    else if (form.radioButton2.Checked)
                    {
                        if (form.comboBox1.Text == "كل العناصر")
                        {
                            MessageBox.Show("يرجى تحديد فئة");
                            return;
                        }
                        var categoryId = Convert.ToInt32(form.comboBox1.SelectedValue);
                        using (IDbConnection sqlconn = new SqlConnection(db.Database.Connection.ConnectionString))
                        {
                            if (sqlconn.State == ConnectionState.Closed)
                            {
                                sqlconn.Open();
                            }
                            string saleBillDetails = "SELECT i.Id , bi.Quantity , bi.TotalPrice " +
                                "FROM Items AS i JOIN BillItems AS bi ON i.Id = bi.ItemId JOIN Bills AS b ON bi.BillId = b.Id " +
                                "WHERE i.CategoryId = " + categoryId + " AND b.CreatedAt BETWEEN '" + form.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND '"+ form.dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") +"' " +
                                "AND b.BillType = 1";
                            
                            List<GetSalesByCategoryIdResponseDto> saleResult = sqlconn.Query<GetSalesByCategoryIdResponseDto>(saleBillDetails, commandType: CommandType.Text).ToList();

                            string returnBillDetails = "SELECT i.Id , bi.Quantity , bi.TotalPrice " +
                                "FROM Items AS i JOIN BillItems AS bi ON i.Id = bi.ItemId JOIN Bills AS b ON bi.BillId = b.Id " +
                                "WHERE i.CategoryId = " + categoryId + " AND b.CreatedAt BETWEEN '" + form.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + form.dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "' " +
                                "AND b.BillType = 3";
                            List<GetSalesByCategoryIdResponseDto> returnResult = sqlconn.Query<GetSalesByCategoryIdResponseDto>(returnBillDetails, commandType: CommandType.Text).ToList();

                            if (saleResult.Count <= 0 && returnResult.Count <= 0)
                            {
                                MessageBox.Show("لا يوجد مبيعات لهذه الفئة");
                                return;
                            }

                            name = " حركة المبيعات لفئة " + form.comboBox1.Text;
                            for (int i = 0; i < saleResult.Count; i++)
                            {
                                numberOfSoldItems += saleResult[i].Quantity;
                                int itemId = saleResult[i].Id;
                                var item = db.Items.FirstOrDefault(x => x.Id == itemId);
                                if (item == null)
                                {
                                    return;
                                }
                                totalPurchasePrice += item.BuyPrice * saleResult[i].Quantity;
                                totalSalePrice += saleResult[i].TotalPrice;
                            }
                            totalProfit = totalSalePrice - totalPurchasePrice;

                            for (int i = 0; i < returnResult.Count; i++)
                            {
                                numberOfReturnItems += returnResult[i].Quantity;
                                int itemId = returnResult[i].Id;
                                var item = db.Items.FirstOrDefault(x => x.Id == itemId);
                                if (item == null)
                                {
                                    return;
                                }
                                totalReturnPurchasePrice += item.BuyPrice * returnResult[i].Quantity;
                                totalReturnSalePrice += returnResult[i].TotalPrice;
                            }
                            totalLose = totalReturnPurchasePrice - totalReturnSalePrice;

                        }

                    }
                    else
                    {
                        int itemId = 0;
                        if (form.radioButton4.Checked)
                        {
                            var getItem = db.Items.FirstOrDefault(x => x.Name == form.comboBox1.Text);
                            if (getItem == null)
                            {
                                MessageBox.Show("خطأ في جلب الصنف");
                                return;
                            }
                            itemId = getItem.Id;
                        }
                        else
                        {
                            if(form.textBox1.Text.Length <= 0)
                            {
                                MessageBox.Show("يرجى تعبة خانة الباركود");
                                return;
                            }
                            var getItem = db.Items.FirstOrDefault(x => x.Barcode == form.textBox1.Text);
                            if (getItem == null)
                            {
                                MessageBox.Show("خطأ في جلب الصنف");
                                return;
                            }
                            itemId = getItem.Id;
                        }
                        using (IDbConnection sqlconn = new SqlConnection(db.Database.Connection.ConnectionString))
                        {
                            if (sqlconn.State == ConnectionState.Closed)
                            {
                                sqlconn.Open();
                            }
                            string saleBillDetails = "SELECT i.Id , bi.Quantity , bi.TotalPrice " +
                                "FROM Items AS i JOIN BillItems AS bi ON i.Id = bi.ItemId JOIN Bills AS b ON bi.BillId = b.Id " +
                                "WHERE i.Id = " + itemId + " AND b.CreatedAt BETWEEN '" + form.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + form.dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "' " +
                                "AND b.BillType = 1";
                            List<GetSalesByCategoryIdResponseDto> saleResult = sqlconn.Query<GetSalesByCategoryIdResponseDto>(saleBillDetails, commandType: CommandType.Text).ToList();

                            string returnBillDetails = "SELECT i.Id , bi.Quantity , bi.TotalPrice " +
                                "FROM Items AS i JOIN BillItems AS bi ON i.Id = bi.ItemId JOIN Bills AS b ON bi.BillId = b.Id " +
                                "WHERE i.Id = " + itemId + " AND b.CreatedAt BETWEEN '" + form.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + form.dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "' " +
                                "AND b.BillType = 3";
                            List<GetSalesByCategoryIdResponseDto> returnResult = sqlconn.Query<GetSalesByCategoryIdResponseDto>(returnBillDetails, commandType: CommandType.Text).ToList();

                            //string test = "SELECT i.Id , bi.Quantity , bi.TotalPrice " +
                            //    "FROM Items AS i JOIN BillItems AS bi ON i.Id = bi.ItemId JOIN Bills AS b ON bi.BillId = b.Id " +
                            //    "WHERE i.Id = " + itemId + " AND b.CreatedAt BETWEEN '" + form.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + form.dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "' " +
                            //    "AND b.BillType = 3";

                            if (saleResult.Count <= 0 && returnResult.Count <= 0)
                            {
                                MessageBox.Show("لا يوجد مبيعات لهذه الفئة");
                                return;
                            }
                            var item = db.Items.FirstOrDefault(x => x.Id == itemId);
                            if (item == null)
                            {
                                return;
                            }

                            name = " حركة المبيعات لصنف " + item.Name;

                            
                            for (int i = 0; i < saleResult.Count; i++)
                            {
                                numberOfSoldItems += saleResult[i].Quantity;
                                totalPurchasePrice += item.BuyPrice * saleResult[i].Quantity;
                                totalSalePrice += saleResult[i].TotalPrice;
                            }
                            totalProfit = totalSalePrice - totalPurchasePrice;

                            
                            for (int i = 0; i < returnResult.Count; i++)
                            {
                                numberOfReturnItems += returnResult[i].Quantity;
                                totalReturnPurchasePrice += item.BuyPrice * returnResult[i].Quantity;
                                totalReturnSalePrice += returnResult[i].TotalPrice;
                            }
                            totalLose = totalReturnPurchasePrice - totalReturnSalePrice;

                        }
                    }
                    form.salesReport1.SetParameterValue("Name", name.ToString());
                    form.salesReport1.SetParameterValue("NumberOfSoldItems", numberOfSoldItems.ToString());
                    form.salesReport1.SetParameterValue("NumberOfReturnItems", numberOfReturnItems.ToString());
                    form.salesReport1.SetParameterValue("TotalPurchasePrice", totalPurchasePrice.ToString());
                    form.salesReport1.SetParameterValue("TotalSalePrice", totalSalePrice.ToString());
                    form.salesReport1.SetParameterValue("TotalProfit", totalProfit.ToString());
                    form.salesReport1.SetParameterValue("TotalLose", totalLose.ToString());
                    form.salesReport1.SetParameterValue("FromDate", fromDate.ToString());
                    form.salesReport1.SetParameterValue("ToDate", toDate.ToString());
                    form.crystalReportViewer1.ReportSource = form.salesReport1;
                    form.crystalReportViewer1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    form.textBox1.Text = string.Empty;
                    form.textBox2.Text = string.Empty;
                }
            }
        }

        public static void AddComboCategories(SaleManagementReportForm form)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    var result = db.Categories.Where(x => x.IsActive == true).ToList();
                    var comboBoxItems = new List<Category>();
                    comboBoxItems.Add(new Category { Id = 0, Name = "كل العناصر" });

                    if (result.Count > 0)
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

        public static void GetItemByValueMember(SaleManagementReportForm form)
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

        public static void ComboBox1ItemChange(SaleManagementReportForm form)
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

        public static void GetAllItems(SaleManagementReportForm form)
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

        public static void ShowByBillId(SaleManagementReportForm form)
        {
            form.label1.Visible = false;
            form.label2.Visible = false;
            form.label3.Visible = false;
            form.label4.Visible = false;
            form.label5.Visible = false;
            form.dateTimePicker1.Visible = false;
            form.dateTimePicker2.Visible = false;
            form.comboBox1.Visible = false;
            form.comboBox2.Visible = false;
            form.textBox1.Visible = false;
            form.groupBox3.Visible = false;
            form.label6.Visible = true;
            form.textBox2.Visible = true;
        }

        public static void ShowByCategory(SaleManagementReportForm form)
        {
            form.label1.Visible = true;
            form.label2.Visible = true;
            form.label3.Visible = false;
            form.label4.Visible = true;
            form.label5.Visible = false;
            form.dateTimePicker1.Visible = true;
            form.dateTimePicker2.Visible = true;
            form.comboBox1.Visible = true;
            form.comboBox2.Visible = false;
            form.textBox1.Visible = false;
            form.groupBox3.Visible = false;
            form.label6.Visible = false;
            form.textBox2.Visible = false;
        }

        public static void ShowByItem(SaleManagementReportForm form)
        {
            form.label1.Visible = true;
            form.label2.Visible = true;
            form.dateTimePicker1.Visible = true;
            form.dateTimePicker2.Visible = true;
            form.label6.Visible = false;
            form.textBox2.Visible = false;
            form.groupBox3.Visible = true;

            if (form.radioButton4.Checked)
            {
                form.comboBox1.Visible = true;
                form.comboBox2.Visible = true;
                form.label3.Visible = true;
                form.label4.Visible = true;
                form.label5.Visible = false;
                form.textBox1.Visible = false;
            }
            else
            {
                form.comboBox1.Visible = false;
                form.comboBox2.Visible = false;
                form.label3.Visible = false;
                form.label4.Visible = false;
                form.label5.Visible = true;
                form.textBox1.Visible = true;
            }
        }
    }
}
