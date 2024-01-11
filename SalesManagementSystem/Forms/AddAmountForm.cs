using SalesManagementSystem.Controllers;
using System;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    public partial class AddAmountForm : Form
    {
        static AddAmountForm addAmountForm;
        public AddAmountForm()
        {
            if (addAmountForm == null) { addAmountForm = this; }
            InitializeComponent();
        }


        static void AddAmountForm_Closed(object sender, FormClosedEventArgs e)
        {
            addAmountForm = null;
        }


        public static AddAmountForm getAddAmountForm
        {
            get
            {
                addAmountForm = new AddAmountForm();
                addAmountForm.FormClosed += AddAmountForm_Closed;
                return addAmountForm;
            }
        }

        private void AddAmountForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddAmountManagment.AddToGridView(this);
        }
    }
}
