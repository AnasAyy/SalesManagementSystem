using SalesManagementSystem.Controllers;
using SalesManagementSystem.Forms;
using System;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    public partial class HomePage : Form
    {
        static HomePage homePage;
        LoginManagement loginClass = new LoginManagement();

        public HomePage()
        {
            if (homePage == null) { homePage = this; }//
            InitializeComponent();
        }

        static void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            homePage = null;
        }

        public static HomePage GethomePage
        {

            get
            {
                if (homePage == null)

                    homePage = new HomePage();
                homePage.FormClosed += new FormClosedEventHandler(HomePage_FormClosed);
                return homePage;

            }
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerManagmentForm.getCustomerManagmentForm.Show();
        }

        private void تسجيلالدخولToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm.GetloginForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginClass.LogOut();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ادارةالتجارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierManagmentForm.getSupplierManagmentForm.Show();
        }


        private void ادارةالمتغيراتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublicListManagmentForm.getChangesManagmentForm.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }


        private void إدارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CategoryForm.GetCategoryForm.Show();
        }

        private void اضافةفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSaleForm.getNewSaleForm.Show();
        }

        private void ارجاعفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesManagmentForm.getSalesManagmentForm.Show();
        }

        private void إدارةالاصنافToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ItemForm.GetCategoryForm.Show();
        }

        private void ادارةالنظامToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialBondForm.GetFinancialBondForm.Show();
        }

        private void التقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm.GetaccountForm.Show();
        }

        private void ادارةالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void عمليةشراءجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasesForm.GetPurchasesForm.Show();
        }

        private void ادارةالمشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasesManagementForm.GetPurchasesManagementForm.Show();
        }

        private void تسجيلالدخولToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            LoginForm.GetloginForm.Show();
        }

        private void HomePage_Load_1(object sender, EventArgs e)
        {

        }
    }
}
