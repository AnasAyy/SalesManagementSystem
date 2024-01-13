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
    public partial class PurchasesManagementForm : Form
    {
        static PurchasesManagementForm purchasesManagementForm;//
        public PurchasesManagementForm()
        {
            if (purchasesManagementForm == null)  purchasesManagementForm = this;//
            InitializeComponent();
        }

        static void PurchasesManagementForm_FormClosed(object sender, FormClosedEventArgs e)//
        {
            purchasesManagementForm = null;
        }

        public static PurchasesManagementForm GetPurchasesManagementForm //
        {

            get
            {
                if (purchasesManagementForm == null)
                    purchasesManagementForm = new PurchasesManagementForm();
                purchasesManagementForm.FormClosed += PurchasesManagementForm_FormClosed;
                return purchasesManagementForm;

            }
        }

        private void PurchasesManagementForm_Load_1(object sender, EventArgs e)
        {
            AllPurchasesManagement.FilldataGridView(this);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AllPurchasesManagement.SearchById(this);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AllPurchasesManagement.SearchByCategory(this);
        }

        
    }
}
