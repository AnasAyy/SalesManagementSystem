using SalesManagementSystem.Controllers;
using System;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    public partial class CustomerManagmentForm : Form
    {
        static CustomerManagmentForm customerManagmentForm;
        public CustomerManagmentForm()
        {
            if (customerManagmentForm == null) { customerManagmentForm = this; }
            InitializeComponent();
            CustomerManagment.GetAllClient(this);
        }

        static void CustomerManagmentForm_Closed(object sender, FormClosedEventArgs e)
        {
            customerManagmentForm = null;
        }

        public static CustomerManagmentForm getCustomerManagmentForm
        {
            get
            {
                customerManagmentForm = new CustomerManagmentForm();
                customerManagmentForm.FormClosed += CustomerManagmentForm_Closed;
                return customerManagmentForm;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerManagmentForm_Load(object sender, EventArgs e)
        {

        }

        private void إضافةToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void إلغاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerManagment.ClearForm(this);
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

        private void حفظToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerManagment.CreateClient(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if (textBox2.Text.Length > 0)
            //{
            //    if (!PublicOperations.CheckPhoneNumber(textBox2.Text))
            //    {
            //        MessageBox.Show("ادخال خاطئ");
            //        textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerManagment.SearchClient(this);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                CustomerManagment.SearchClient(this);
            }
        }

        private void تعديلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerManagment.GetClientDataById(this);
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


        private void تعديلToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CustomerManagment.UpdateClient(this);
        }
    }
}
