using SalesManagementSystem.Controllers;
using System;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    public partial class NewSaleForm : Form
    {
        static NewSaleForm newSaleForm;
        public NewSaleForm()
        {
            if (newSaleForm == null) { newSaleForm = this; }
            InitializeComponent();
            NewSalesManagment.AddComboCategories(this);
            NewSalesManagment.GetAllFeeType(this);
            NewSalesManagment.GetAllDiscountType(this);
            NewSalesManagment.GetAllAccounts(this);
        }


        static void NewSaleForm_Closed(object sender, FormClosedEventArgs e)
        {
            newSaleForm = null;
        }

        public static NewSaleForm getNewSaleForm
        {
            get
            {
                newSaleForm = new NewSaleForm();
                newSaleForm.FormClosed += NewSaleForm_Closed;
                return newSaleForm;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            NewSalesManagment.ComboBox1ItemChange(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewSaleForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewSalesManagment.ComboBox1ItemChange(this);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewSalesManagment.FeeComboBoxIndexChange(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewSalesManagment.GetItemByBarCode(this);
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
                else if (dataGridView1.RowCount > 0)
                {
                    NewSalesManagment.CalculateBill(this);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                if (!PublicOperations.CheckNumbersOnly(textBox3.Text))
                {
                    MessageBox.Show("ادخال خاطئ");
                    textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                }
                else if (dataGridView1.RowCount > 0)
                {
                    NewSalesManagment.CalculateBill(this);
                }
            }
        }



        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewSalesManagment.DiscountComboBoxIndexChange(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewSalesManagment.GetClientByPhoneNumber(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewSalesManagment.GetItemById(this);
        }


        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            NewSalesManagment.CalculateBill(this);
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            NewSalesManagment.CalculateBill(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewSalesManagment.CheckSaleType(this);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.Visible = false;
            label13.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.Visible = true;
            label13.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                groupBox3.Visible = true;
                if (radioButton1.Checked)
                {
                    comboBox5.Visible = true;
                    label13.Visible = true;
                }

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                groupBox3.Visible = false;
                comboBox5.Visible = false;
                label13.Visible = false;
            }
        }

    }
}
