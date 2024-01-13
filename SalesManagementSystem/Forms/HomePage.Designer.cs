﻿using System.Drawing;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.تسجيلالدخولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلالدخولToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلالخروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالنظامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالمستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالتجارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالمتغيراتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالمبيعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةفاتورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ارجاعفاتورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالمشترياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عمليةشراءجديدةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالمشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالمخازنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إدارةالاصنافToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إدارةالاصنافToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالمصروفاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التقارييرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Cairo", 8.999999F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسجيلالدخولToolStripMenuItem,
            this.ادارةالنظامToolStripMenuItem,
            this.التقاريرToolStripMenuItem,
            this.ادارةالمبيعاتToolStripMenuItem,
            this.ادارةالمشترياتToolStripMenuItem,
            this.ادارةالمخازنToolStripMenuItem,
            this.ادارةالمصروفاتToolStripMenuItem,
            this.التقارييرToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(781, 39);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // تسجيلالدخولToolStripMenuItem
            // 
            this.تسجيلالدخولToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسجيلالدخولToolStripMenuItem1,
            this.تسجيلالخروجToolStripMenuItem});
            this.تسجيلالدخولToolStripMenuItem.Name = "تسجيلالدخولToolStripMenuItem";
            this.تسجيلالدخولToolStripMenuItem.Size = new System.Drawing.Size(73, 33);
            this.تسجيلالدخولToolStripMenuItem.Text = "الرئيسية";
            // 
            // تسجيلالدخولToolStripMenuItem1
            // 
            this.تسجيلالدخولToolStripMenuItem1.Name = "تسجيلالدخولToolStripMenuItem1";
            this.تسجيلالدخولToolStripMenuItem1.Size = new System.Drawing.Size(224, 34);
            this.تسجيلالدخولToolStripMenuItem1.Text = "تسجيل الدخول";
            this.تسجيلالدخولToolStripMenuItem1.Click += new System.EventHandler(this.تسجيلالدخولToolStripMenuItem1_Click_1);
            // 
            // تسجيلالخروجToolStripMenuItem
            // 
            this.تسجيلالخروجToolStripMenuItem.Name = "تسجيلالخروجToolStripMenuItem";
            this.تسجيلالخروجToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.تسجيلالخروجToolStripMenuItem.Text = "تسجيل الخروج";
            this.تسجيلالخروجToolStripMenuItem.Visible = false;
            this.تسجيلالخروجToolStripMenuItem.Click += new System.EventHandler(this.تسجيلالخروجToolStripMenuItem_Click_1);
            // 
            // ادارةالنظامToolStripMenuItem
            // 
            this.ادارةالنظامToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ادارةالمستخدمينToolStripMenuItem,
            this.ادارةالتجارToolStripMenuItem,
            this.ادارةالمتغيراتToolStripMenuItem});
            this.ادارةالنظامToolStripMenuItem.Name = "ادارةالنظامToolStripMenuItem";
            this.ادارةالنظامToolStripMenuItem.Size = new System.Drawing.Size(94, 33);
            this.ادارةالنظامToolStripMenuItem.Text = "ادارة النظام";
            this.ادارةالنظامToolStripMenuItem.Visible = false;
            // 
            // ادارةالمستخدمينToolStripMenuItem
            // 
            this.ادارةالمستخدمينToolStripMenuItem.Name = "ادارةالمستخدمينToolStripMenuItem";
            this.ادارةالمستخدمينToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.ادارةالمستخدمينToolStripMenuItem.Text = "ادارة العملاء";
            this.ادارةالمستخدمينToolStripMenuItem.Click += new System.EventHandler(this.ادارةالمستخدمينToolStripMenuItem_Click);
            // 
            // ادارةالتجارToolStripMenuItem
            // 
            this.ادارةالتجارToolStripMenuItem.Name = "ادارةالتجارToolStripMenuItem";
            this.ادارةالتجارToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.ادارةالتجارToolStripMenuItem.Text = "ادارة الموردين";
            this.ادارةالتجارToolStripMenuItem.Click += new System.EventHandler(this.ادارةالتجارToolStripMenuItem_Click);
            // 
            // ادارةالمتغيراتToolStripMenuItem
            // 
            this.ادارةالمتغيراتToolStripMenuItem.Name = "ادارةالمتغيراتToolStripMenuItem";
            this.ادارةالمتغيراتToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.ادارةالمتغيراتToolStripMenuItem.Text = "ادارة المتغيرات";
            this.ادارةالمتغيراتToolStripMenuItem.Click += new System.EventHandler(this.ادارةالمتغيراتToolStripMenuItem_Click);
            // 
            // التقاريرToolStripMenuItem
            // 
            this.التقاريرToolStripMenuItem.Name = "التقاريرToolStripMenuItem";
            this.التقاريرToolStripMenuItem.Size = new System.Drawing.Size(112, 33);
            this.التقاريرToolStripMenuItem.Text = "ادارة الحسابات";
            this.التقاريرToolStripMenuItem.Visible = false;
            this.التقاريرToolStripMenuItem.Click += new System.EventHandler(this.التقاريرToolStripMenuItem_Click_1);
            // 
            // ادارةالمبيعاتToolStripMenuItem
            // 
            this.ادارةالمبيعاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةفاتورةToolStripMenuItem,
            this.ارجاعفاتورةToolStripMenuItem});
            this.ادارةالمبيعاتToolStripMenuItem.Name = "ادارةالمبيعاتToolStripMenuItem";
            this.ادارةالمبيعاتToolStripMenuItem.Size = new System.Drawing.Size(110, 33);
            this.ادارةالمبيعاتToolStripMenuItem.Text = "ادارة المبيعات";
            this.ادارةالمبيعاتToolStripMenuItem.Visible = false;
            // 
            // اضافةفاتورةToolStripMenuItem
            // 
            this.اضافةفاتورةToolStripMenuItem.Name = "اضافةفاتورةToolStripMenuItem";
            this.اضافةفاتورةToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.اضافةفاتورةToolStripMenuItem.Text = "أضافة عملية";
            this.اضافةفاتورةToolStripMenuItem.Click += new System.EventHandler(this.اضافةفاتورةToolStripMenuItem_Click);
            // 
            // ارجاعفاتورةToolStripMenuItem
            // 
            this.ارجاعفاتورةToolStripMenuItem.Name = "ارجاعفاتورةToolStripMenuItem";
            this.ارجاعفاتورةToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.ارجاعفاتورةToolStripMenuItem.Text = "ادارة المبيعات";
            this.ارجاعفاتورةToolStripMenuItem.Click += new System.EventHandler(this.ارجاعفاتورةToolStripMenuItem_Click);
            // 
            // ادارةالمشترياتToolStripMenuItem
            // 
            this.ادارةالمشترياتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عمليةشراءجديدةToolStripMenuItem,
            this.ادارةالمشToolStripMenuItem});
            this.ادارةالمشترياتToolStripMenuItem.Name = "ادارةالمشترياتToolStripMenuItem";
            this.ادارةالمشترياتToolStripMenuItem.Size = new System.Drawing.Size(119, 33);
            this.ادارةالمشترياتToolStripMenuItem.Text = "ادارة المشتريات";
            this.ادارةالمشترياتToolStripMenuItem.Visible = false;
            this.ادارةالمشترياتToolStripMenuItem.Click += new System.EventHandler(this.ادارةالمشترياتToolStripMenuItem_Click_1);
            // 
            // عمليةشراءجديدةToolStripMenuItem
            // 
            this.عمليةشراءجديدةToolStripMenuItem.Name = "عمليةشراءجديدةToolStripMenuItem";
            this.عمليةشراءجديدةToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.عمليةشراءجديدةToolStripMenuItem.Text = "إضافة عملية";
            this.عمليةشراءجديدةToolStripMenuItem.Click += new System.EventHandler(this.عمليةشراءجديدةToolStripMenuItem_Click_1);
            // 
            // ادارةالمشToolStripMenuItem
            // 
            this.ادارةالمشToolStripMenuItem.Name = "ادارةالمشToolStripMenuItem";
            this.ادارةالمشToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.ادارةالمشToolStripMenuItem.Text = "المشتريات";
            this.ادارةالمشToolStripMenuItem.Click += new System.EventHandler(this.ادارةالمشToolStripMenuItem_Click_1);
            // 
            // ادارةالمخازنToolStripMenuItem
            // 
            this.ادارةالمخازنToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إدارةالاصنافToolStripMenuItem,
            this.إدارةالاصنافToolStripMenuItem1});
            this.ادارةالمخازنToolStripMenuItem.Name = "ادارةالمخازنToolStripMenuItem";
            this.ادارةالمخازنToolStripMenuItem.Size = new System.Drawing.Size(103, 33);
            this.ادارةالمخازنToolStripMenuItem.Text = "ادارة المخازن";
            this.ادارةالمخازنToolStripMenuItem.Visible = false;
            // 
            // إدارةالاصنافToolStripMenuItem
            // 
            this.إدارةالاصنافToolStripMenuItem.Name = "إدارةالاصنافToolStripMenuItem";
            this.إدارةالاصنافToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.إدارةالاصنافToolStripMenuItem.Text = "إدارة الفئات";
            // 
            // إدارةالاصنافToolStripMenuItem1
            // 
            this.إدارةالاصنافToolStripMenuItem1.Name = "إدارةالاصنافToolStripMenuItem1";
            this.إدارةالاصنافToolStripMenuItem1.Size = new System.Drawing.Size(180, 34);
            this.إدارةالاصنافToolStripMenuItem1.Text = "إدارة الاصناف";
            // 
            // ادارةالمصروفاتToolStripMenuItem
            // 
            this.ادارةالمصروفاتToolStripMenuItem.Name = "ادارةالمصروفاتToolStripMenuItem";
            this.ادارةالمصروفاتToolStripMenuItem.Size = new System.Drawing.Size(107, 33);
            this.ادارةالمصروفاتToolStripMenuItem.Text = "ادارة السندات";
            this.ادارةالمصروفاتToolStripMenuItem.Visible = false;
            // 
            // التقارييرToolStripMenuItem
            // 
            this.التقارييرToolStripMenuItem.Name = "التقارييرToolStripMenuItem";
            this.التقارييرToolStripMenuItem.Size = new System.Drawing.Size(66, 33);
            this.التقارييرToolStripMenuItem.Text = "التقارير";
            this.التقارييرToolStripMenuItem.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(781, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cairo", 8.999999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام ادارة المبيعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem تسجيلالدخولToolStripMenuItem;
        private ToolStripMenuItem ادارةالمستخدمينToolStripMenuItem;
        private ToolStripMenuItem ادارةالتجارToolStripMenuItem;
        private ToolStripMenuItem ادارةالمتغيراتToolStripMenuItem;
        private PictureBox pictureBox1;
        public ToolStripMenuItem ادارةالنظامToolStripMenuItem;
        public ToolStripMenuItem ادارةالمبيعاتToolStripMenuItem;
        public ToolStripMenuItem ادارةالمشترياتToolStripMenuItem;
        public ToolStripMenuItem ادارةالمخازنToolStripMenuItem;
        public ToolStripMenuItem ادارةالمصروفاتToolStripMenuItem;
        public ToolStripMenuItem التقاريرToolStripMenuItem;
        public ToolStripMenuItem تسجيلالدخولToolStripMenuItem1;
        public ToolStripMenuItem تسجيلالخروجToolStripMenuItem;
        private ToolStripMenuItem إدارةالاصنافToolStripMenuItem;
        private ToolStripMenuItem اضافةفاتورةToolStripMenuItem;
        private ToolStripMenuItem ارجاعفاتورةToolStripMenuItem;
        private ToolStripMenuItem إدارةالاصنافToolStripMenuItem1;
        public ToolStripMenuItem التقارييرToolStripMenuItem;
        private ToolStripMenuItem عمليةشراءجديدةToolStripMenuItem;
        private ToolStripMenuItem ادارةالمشToolStripMenuItem;
    }
}