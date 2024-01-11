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
            accountForm = this;//
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
    }
}
