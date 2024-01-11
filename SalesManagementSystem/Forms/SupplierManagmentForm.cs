using SalesManagementSystem.Controllers;
using System;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    public partial class SupplierManagmentForm : Form
    {
        static SupplierManagmentForm supplierManagmentForm;
        public SupplierManagmentForm()
        {
            if (supplierManagmentForm == null) { supplierManagmentForm = this; }
            InitializeComponent();
            SupplierManagment.GetAllMerchant(this);
        }

        static void SupplierManagmentForm_Closed(object sender, FormClosedEventArgs e)
        {
            supplierManagmentForm = null;
        }

        public static SupplierManagmentForm getSupplierManagmentForm
        {
            get
            {
                supplierManagmentForm = new SupplierManagmentForm();
                supplierManagmentForm.FormClosed += SupplierManagmentForm_Closed;
                return supplierManagmentForm;
            }
        }

        private void جديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            جديدToolStripMenuItem.Enabled = false;
            حفظToolStripMenuItem.Enabled = true;
            إلغاءToolStripMenuItem.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            label4.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox4.Enabled = true;
        }

        private void حفظToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierManagment.CreateMerchant(this);
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierManagment.UpdateMerchant(this);
        }

        private void إلغاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            جديدToolStripMenuItem.Enabled = true;
            حفظToolStripMenuItem.Enabled = false;
            تعديلToolStripMenuItem.Enabled = false;
            إلغاءToolStripMenuItem.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label4.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox4.Enabled = false;
        }

        private void تعديلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SupplierManagment.GetMerchantDataById(this);
            جديدToolStripMenuItem.Enabled = false;
            حفظToolStripMenuItem.Enabled = false;
            تعديلToolStripMenuItem.Enabled = true;
            إلغاءToolStripMenuItem.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            label4.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupplierManagment.SearchMerchant(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
            {
                if (!PublicOperations.CheckArabicCharsOnly(textBox4.Text))
                {
                    MessageBox.Show("ادخال خاطئ");
                    textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                SupplierManagment.SearchMerchant(this);
            }
        }
    }
}
