using Dapper;
using SalesManagementSystem.Data.Dtos;
using SalesManagementSystem.Models;
using SalesManagementSystem.Reports.Designs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.Reports.Forms
{
    public partial class WarehouseReportForm : Form
    {
        public WarehouseReportForm()
        {
            InitializeComponent();
        }

        private void WarehouseReportForm_Load(object sender, EventArgs e)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    var result = db.Categories.ToList();
                    var comboBoxItems = new List<Category>();

                    comboBoxItems.Add(new Category { Id = 0, Name = "الكل" });

                    if (result.Count > 0)
                    {
                        comboBoxItems.AddRange(result);

                        comboBox1.DataSource = comboBoxItems;
                        comboBox1.ValueMember = nameof(Category.Id);
                        comboBox1.DisplayMember = nameof(Category.Name);
                    }
                    else
                    {
                        comboBox1.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    using (IDbConnection sqlconn = new SqlConnection(db.Database.Connection.ConnectionString))
                    {
                        if (sqlconn.State == ConnectionState.Closed)
                        {
                            sqlconn.Open();
                        }

                        string itemQuery = "SELECT " +
                   "i.Name, " +
                   "c.Name AS 'Category', " +
                   "i.Barcode, " +
                   "i.Quantity, " +
                   "i.BuyPrice AS 'Price', " +
                   "i.BuyPrice * i.Quantity AS 'TotalPrice' " +
                   "FROM Items i JOIN Categories c ON i.CategoryId = c.Id";

                        if (comboBox1.SelectedIndex != 0)
                        {
                            itemQuery += " WHERE c.Id = '" + comboBox1.SelectedValue + "'";
                        }


                        List<WarehouseReportDto> list = sqlconn.Query<WarehouseReportDto>(itemQuery, commandType: CommandType.Text).ToList();

                        warehouseReport1.SetDataSource(list);


                        string SumQuery = "SELECT SUM(i.BuyPrice * i.Quantity) as Total " +
                                         "FROM Items i JOIN Categories c ON i.CategoryId = c.Id";

                        if (comboBox1.SelectedIndex != 0)
                        {
                            SumQuery += " WHERE c.Id = '" + comboBox1.SelectedValue + "'";
                        }

                        List<WarehouseReportDto> list2 = sqlconn.Query<WarehouseReportDto>(SumQuery, commandType: CommandType.Text).ToList();

                        warehouseReport1.SetParameterValue("Total", list2.FirstOrDefault()?.Total.ToString());
                        warehouseReport1.SetParameterValue("Date", DateTime.Now.ToString("yyyy/MM/dd"));

                        crystalReportViewer1.ReportSource = warehouseReport1;
                        crystalReportViewer1.Refresh();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } }
    }
}
