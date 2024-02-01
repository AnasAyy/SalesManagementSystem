using SalesManagementSystem.Controllers;
using System;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    public partial class AccountForm : Form
    {
        public int id;
        static AccountForm accountForm;//
        public AccountForm()
        {
            if (accountForm == null) { accountForm = this; }//
            InitializeComponent();
        }

        static void accountForm_FormClosed(object sender, FormClosedEventArgs e)//
        {
            accountForm = null;
        }

        public static AccountForm GetaccountForm //
        {

            get
            {
                if (accountForm == null)
                    accountForm = new AccountForm();
                accountForm.FormClosed += accountForm_FormClosed;
                return accountForm;

            }
        }


        private void جديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountManagement.NewButton(this);
        }

        private void إلغاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountManagement.ResetPage(this);
        }

        private void حفظToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountManagement.Add(this);
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            AccountManagement.FilldataGridView(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim() == "")
            {
                AccountManagement.FilldataGridView(this);
            }
            else
                AccountManagement.SearchBox(this);
        }

        private void تعديلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AccountManagement.Edit(this);
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountManagement.Update(this);
        }

        private void التحويلبينالحساباتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExchangeForm.GetExchangeForm.Show();
        }

        private void AccountForm_Load_1(object sender, EventArgs e)
        {
            AccountManagement.FilldataGridView(this);
        }

        private void جديدToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AccountManagement.NewButton(this);
        }

        private void حفظToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AccountManagement.Add(this);
        }

        private void تعديلToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AccountManagement.Update(this);
        }

        private void إلغاءToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AccountManagement.ResetPage(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim() == "")
            {
                AccountManagement.FilldataGridView(this);
            }
            else
                AccountManagement.SearchBox(this);
        }

        private void تعديلToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AccountManagement.Edit(this);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ExchangeForm.GetExchangeForm.Show();
        }

        private void AccountForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AccountManagement.Add(this);
            }
        }
    }
}
