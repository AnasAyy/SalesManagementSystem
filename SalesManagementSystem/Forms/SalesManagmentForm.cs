using SalesManagementSystem.Controllers;
using System;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    public partial class SalesManagmentForm : Form
    {
        static SalesManagmentForm salesManagmentForm;
        public SalesManagmentForm()
        {
            if (salesManagmentForm == null) { salesManagmentForm = this; }
            InitializeComponent();
            SaleManagment.GetAllSaleBills(this);
        }

        static void SalesManagmentForm_Closed(object sender, FormClosedEventArgs e)
        {
            salesManagmentForm = null;
        }

        public static SalesManagmentForm getSalesManagmentForm
        {
            get
            {
                if(salesManagmentForm == null)

                    salesManagmentForm = new SalesManagmentForm();
                salesManagmentForm.FormClosed += new FormClosedEventHandler(SalesManagmentForm_Closed);
                return salesManagmentForm;
            }
        }

        private void SalesManagmentForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaleManagment.GetAllSalesByBillId(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaleManagment.GetAllSalesByChoice(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (!PublicOperations.CheckNumbersOnly(textBox1.Text))
                {
                    MessageBox.Show("ادخال خاطئ");
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
            else
            {
                SaleManagment.GetAllSaleBills(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                SaleManagment.ShowBillReportById(this);
            }
            else
            {
                MessageBox.Show("يرجى ادخال رقم الفاتورة");
            }
        }
    }
}
