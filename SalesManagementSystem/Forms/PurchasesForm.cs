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

namespace SalesManagementSystem.Forms
{
    public partial class PurchasesForm : Form
    {
        private bool isFormLoaded = false;
        static PurchasesForm purchasesForm;//
        public PurchasesForm()
        {
            purchasesForm = this;//
            InitializeComponent();
        }

        static void PurchasesForm_FormClosed(object sender, FormClosedEventArgs e)//
        {
            purchasesForm = null;
        }

        public static PurchasesForm GetPurchasesForm //
        {

            get
            {
                purchasesForm = new PurchasesForm();
                purchasesForm.FormClosed += PurchasesForm_FormClosed;
                return purchasesForm;

            }
        }


        private void جديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasesManagement.NewButton(this);
        }

        private void إلغاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasesManagement.ResetPage(this);
        }

        private void PurchasesForm_Load(object sender, EventArgs e)
        {
            textBox8.Focus();
            PurchasesManagement.FillComboBoxCategorys(this);
            isFormLoaded = true;
            PurchasesManagement.FillComboBoxItems(this);
            PurchasesManagement.FillComboBoxSupplier(this);
            PurchasesManagement.FillComboBoxFee(this);
            PurchasesManagement.FillComboBoxPayment(this);


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                PurchasesManagement.FillComboBoxItems(this);
            }

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            PurchasesManagement.AddToGridView(this);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            getTotal();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            getTotal();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            getTotal();
        }
        void getTotal()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells["TotalSellPrice"].Value != null)
                {
                    decimal value = Convert.ToDecimal(row.Cells["TotalSellPrice"].Value);
                    sum += value;
                }
            }
            decimal textBox3Value = 0;
            decimal textBox4Value = 1;
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3Value = Convert.ToDecimal(textBox3.Text);
            }
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4Value = Convert.ToDecimal(textBox4.Text);
            }
            textBox5.Text = (sum + textBox3Value).ToString();

            textBox6.Text = (Convert.ToDecimal(textBox5.Text) * textBox4Value).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PurchasesManagement.ResetPage(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem != null && comboBox5.Text == "اختر عنصر")
            {
                MessageBox.Show("الرجاء تحديد التاجر");
                return;
            }
            if (comboBox1.SelectedItem != null && comboBox1.Text == "اختر عنصر")
            {
                MessageBox.Show("الرجاء تحديد الحساب");
                return;
            }
            if (comboBox3.SelectedItem != null && comboBox3.Text == "اختر عنصر")
            {
                MessageBox.Show("الرجاء تحديد نوع الضريبة");
                return;
            }
           
            
            PurchasesManagement.Add(this);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            PurchasesManagement.fillBarCode(this);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PurchasesManagement.changeCombobox(this);
            }
        }

        private void PurchasesForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
