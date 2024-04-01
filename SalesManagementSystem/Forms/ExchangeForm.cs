using SalesManagementSystem.Controllers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    public partial class ExchangeForm : Form
    {
        static ExchangeForm exchangeForm;//
        public ExchangeForm()
        {
            if (exchangeForm == null) { exchangeForm = this; }//
            InitializeComponent();
        }


        static void ItemForm_FormClosed(object sender, FormClosedEventArgs e)//
        {
            exchangeForm = null;
        }

        public static ExchangeForm GetExchangeForm //
        {
            get
            {
                if (exchangeForm == null)
                    exchangeForm = new ExchangeForm();
                exchangeForm.FormClosed += ItemForm_FormClosed;
                return exchangeForm;

            }
        }

        

        private void ExchangeForm_Load_1(object sender, EventArgs e)
        {
            ExchangeManagement.FillComboBox(this);
            ExchangeManagement.FillComboBox1(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExchangeManagement.Exchange(this);
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
