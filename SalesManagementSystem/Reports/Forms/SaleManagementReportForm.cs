using SalesManagementSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.Reports.Forms
{
    public partial class SaleManagementReportForm : Form
    {
        static SaleManagementReportForm saleManagementReportForm;
        public SaleManagementReportForm()
        {
            if (saleManagementReportForm == null) saleManagementReportForm = this;
            InitializeComponent();
        }

        static void SaleManagementReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            saleManagementReportForm = null;
        }

        public static SaleManagementReportForm GetSaleManagementReportForm
        {
            get
            {
                if (saleManagementReportForm == null)
                    saleManagementReportForm = new SaleManagementReportForm();
                saleManagementReportForm.FormClosed += SaleManagementReportForm_FormClosed;
                return saleManagementReportForm;
            }
        }

        private void SaleManagementReportForm_Load(object sender, EventArgs e)
        {
            SalesReportManagement.LoadForm(this);
            SalesReportManagement.AddComboCategories(this);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SalesReportManagement.LoadForm(this);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SalesReportManagement.LoadForm(this);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SalesReportManagement.LoadForm(this);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SalesReportManagement.LoadForm(this);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            SalesReportManagement.LoadForm(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalesReportManagement.ComboBox1ItemChange(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesReportManagement.PressSearch(this);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                if (!PublicOperations.CheckNumbersOnly(textBox2.Text))
                {
                    MessageBox.Show("ادخال خاطئ");
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                }
            }
        }
    }
}
