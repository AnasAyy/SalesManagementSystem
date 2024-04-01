﻿using SalesManagementSystem.Controllers;
using SalesManagementSystem.Forms;
using SalesManagementSystem.Reports.Designs;
using SalesManagementSystem.Reports.Forms;
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
            CustomerManagmentForm.getCustomerManagmentForm.ShowDialog();
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
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ادارةالتجارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierManagmentForm.getSupplierManagmentForm.ShowDialog();
        }


        private void ادارةالمتغيراتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublicListManagmentForm.getChangesManagmentForm.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }


        private void إدارةالاصنافToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            ItemForm.GetCategoryForm.ShowDialog();
        }

        private void اضافةفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSaleForm.getNewSaleForm.ShowDialog();
        }

        private void ارجاعفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesManagmentForm.getSalesManagmentForm.ShowDialog();
        }

        private void إدارةالاصنافToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CategoryForm.GetCategoryForm.ShowDialog();
        }

        private void ادارةالنظامToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialBondForm.GetFinancialBondForm.ShowDialog();
        }

        private void التقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm.GetaccountForm.ShowDialog();
        }

        private void ادارةالمشترياتToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void عمليةشراءجديدةToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PurchasesForm.GetPurchasesForm.ShowDialog();
        }

        private void ادارةالمشToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PurchasesManagementForm.GetPurchasesManagementForm.ShowDialog();
        }

        private void تسجيلالدخولToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            LoginForm.GetloginForm.Show();
        }

        private void HomePage_Load_1(object sender, EventArgs e)
        {

        }

        private void تسجيلالخروجToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            loginClass.LogOut();
        }

        private void التقاريرToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AccountForm.GetaccountForm.ShowDialog();
        }

        private void تقريرالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasesReportForm.GetPurchasesReportForm.ShowDialog();
        }

        private void تقريرالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustmoerReport.GetCustmoerReport.ShowDialog();
        }

        private void تقريرالمخازنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarehouseReportForm.GetWarehouseReportForm.ShowDialog();
        }

        private void تقريرالمشترياتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExpencesReportForm.GetExpencesReportForm.ShowDialog();
        }

        private void تقريرالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleManagementReportForm.GetSaleManagementReportForm.ShowDialog();
        }
    }
}
