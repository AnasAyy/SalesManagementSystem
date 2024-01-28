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
    public partial class ExpencesReportForm : Form
    {
        static ExpencesReportForm expencesReportForm;//
        public ExpencesReportForm()
        {
            if (expencesReportForm == null) expencesReportForm = this;//
            InitializeComponent();
        }

        static void ExpencesReportForm_FormClosed(object sender, FormClosedEventArgs e)//
        {
            expencesReportForm = null;
        }

        public static ExpencesReportForm GetExpencesReportForm //
        {

            get
            {
                if (expencesReportForm == null)
                    expencesReportForm = new ExpencesReportForm();
                expencesReportForm.FormClosed += ExpencesReportForm_FormClosed;
                return expencesReportForm;

            }
        }

        private void ExpencesReportForm_Load(object sender, EventArgs e)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    var result = db.PublicLists.Where(x => x.Code == "Expense" && !x.IsParent).ToList();
                    var comboBoxItems = new List<PublicList>();

                    comboBoxItems.Add(new PublicList { Id = 0, Name = "الكل" });

                    if (result.Count > 0)
                    {
                        comboBoxItems.AddRange(result);

                        comboBox1.DataSource = comboBoxItems;
                        comboBox1.ValueMember = nameof(PublicList.Id);
                        comboBox1.DisplayMember = nameof(PublicList.Name);
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

                        string itemQuery = "Select f.Id, " +
                                            "f.Title, " +
                                            "p.Name as 'ExpenseType', " +
                                            "f.Fee, " +
                                            "f.Price, " +
                                            "f.TotalPrice, " +
                                            "a.Name as 'AccountName' " +
    
                                            "from FinancialBonds f JOIN " +
                                            "Accounts a ON f.AccountId = a.Id " +
                                            "JOIN PublicLists p ON " +
                                            "f.ExpenseType = p.Id " +
                                            "Where p.Code = 'Expense'";

                        if (comboBox1.SelectedIndex != 0)
                        {
                            itemQuery += " And p.Id = '" + comboBox1.SelectedValue + "'";
                        }


                        List<ExpencesReportDto> list = sqlconn.Query<ExpencesReportDto>(itemQuery, commandType: CommandType.Text).ToList();

                        expencesReport1.SetDataSource(list);


                        string SumQuery = "Select SUM(f.TotalPrice) as Total  from FinancialBonds f JOIN Accounts a ON f.AccountId = a.Id JOIN PublicLists p ON f.ExpenseType = p.Id Where p.Code = 'Expense'";


                        if (comboBox1.SelectedIndex != 0)
                        {
                            SumQuery += " And p.Id = '" + comboBox1.SelectedValue + "'";
                        }

                        List<ExpencesReportDto> list2 = sqlconn.Query<ExpencesReportDto>(SumQuery, commandType: CommandType.Text).ToList();

                        expencesReport1.SetParameterValue("Total", list2.FirstOrDefault()?.Total.ToString());
                        expencesReport1.SetParameterValue("Date", DateTime.Now.ToString("yyyy/MM/dd"));

                        crystalReportViewer1.ReportSource = expencesReport1;
                        crystalReportViewer1.Refresh();
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
