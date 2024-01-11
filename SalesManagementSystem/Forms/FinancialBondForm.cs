using SalesManagementSystem.Controllers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    public partial class FinancialBondForm : Form
    {
        public int id;
        static FinancialBondForm financialBondForm;//
        public FinancialBondForm()
        {
            if (financialBondForm == null) { financialBondForm = this; }//
            InitializeComponent();
        }

        static void financialBondForm_FormClosed(object sender, FormClosedEventArgs e)//
        {
            financialBondForm = null;
        }

        public static FinancialBondForm GetFinancialBondForm //
        {

            get
            {
                if (financialBondForm == null)
                financialBondForm = new FinancialBondForm();
                financialBondForm.FormClosed += financialBondForm_FormClosed;
                return financialBondForm;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void جديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialBondManagement.NewButton(this);
        }

        private void ExpenseForm_Load(object sender, EventArgs e)
        {
            FinancialBondManagement.FillComboBox1(this);
            FinancialBondManagement.FillComboBox5(this);
            FinancialBondManagement.FillComboBox3(this);
            FinancialBondManagement.FilldataGridView(this);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


            try
            {
                decimal x = string.IsNullOrWhiteSpace(textBox2.Text) ? 0 : Convert.ToDecimal(textBox2.Text.Trim()); ;
                decimal y = string.IsNullOrWhiteSpace(textBox3.Text) ? 0 : Convert.ToDecimal(textBox3.Text.Trim());
                decimal z = x + y;
                textBox5.Text = z.ToString();

                decimal result;
                decimal textBox4Value = 1;
                decimal textBox5Value = 1;

                if (!string.IsNullOrEmpty(textBox4.Text.Trim()))
                {
                    textBox4Value = Convert.ToDecimal(textBox4.Text.Trim());
                }

                if (!string.IsNullOrEmpty(textBox5.Text.Trim()))
                {
                    textBox5Value = Convert.ToDecimal(textBox5.Text.Trim());
                }

                result = textBox4Value * textBox5Value;
                textBox6.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal x = string.IsNullOrWhiteSpace(textBox2.Text) ? 0 : Convert.ToDecimal(textBox2.Text.Trim()); ;
                decimal y = string.IsNullOrWhiteSpace(textBox3.Text) ? 0 : Convert.ToDecimal(textBox3.Text.Trim());
                decimal z = x + y;
                textBox5.Text = z.ToString();

                decimal result;
                decimal textBox4Value = 1;
                decimal textBox5Value = 1;

                if (!string.IsNullOrEmpty(textBox4.Text.Trim()))
                {
                    textBox4Value = Convert.ToDecimal(textBox4.Text.Trim());
                }

                if (!string.IsNullOrEmpty(textBox5.Text.Trim()))
                {
                    textBox5Value = Convert.ToDecimal(textBox5.Text.Trim());
                }

                result = textBox4Value * textBox5Value;
                textBox6.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text))
            {
                double result = Convert.ToDouble(textBox4.Text.Trim()) * Convert.ToDouble(textBox5.Text.Trim());
                textBox6.Text = result.ToString();
            }


        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                FinancialBondManagement.GetClients(this);
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                FinancialBondManagement.GetSuppliers(this);
            }
            else
            {
                comboBox5.DataSource = null;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void إلغاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialBondManagement.ResetPage(this);
        }

        private void حفظToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialBondManagement.Add(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinancialBondManagement.SearchBox(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void تعديلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FinancialBondManagement.Edit(this);
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialBondManagement.Update(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FinancialBondForm_Load(object sender, EventArgs e)
        {

        }
    }
}
