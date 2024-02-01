using System.Drawing;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    partial class AccountForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.جديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حفظToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إلغاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.التحويلبينالحساباتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.التحويلبينالحساباتToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1348, 217);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أدارة الحسابات";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Cairo", 11F);
            this.textBox2.Location = new System.Drawing.Point(732, 160);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(439, 42);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Cairo", 11F);
            this.label2.Location = new System.Drawing.Point(1196, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "تفاصيل ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Cairo", 11F);
            this.textBox1.Location = new System.Drawing.Point(732, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 42);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Cairo", 11F);
            this.label1.Location = new System.Drawing.Point(1196, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم الحساب";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Cairo", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.جديدToolStripMenuItem,
            this.حفظToolStripMenuItem,
            this.تعديلToolStripMenuItem,
            this.إلغاءToolStripMenuItem,
            this.toolStripMenuItem1,
            this.التحويلبينالحساباتToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.التحويلبينالحساباتToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(3, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1342, 41);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // جديدToolStripMenuItem
            // 
            this.جديدToolStripMenuItem.Name = "جديدToolStripMenuItem";
            this.جديدToolStripMenuItem.Size = new System.Drawing.Size(55, 33);
            this.جديدToolStripMenuItem.Text = "جديد";
            this.جديدToolStripMenuItem.Click += new System.EventHandler(this.جديدToolStripMenuItem_Click_1);
            // 
            // حفظToolStripMenuItem
            // 
            this.حفظToolStripMenuItem.Enabled = false;
            this.حفظToolStripMenuItem.Name = "حفظToolStripMenuItem";
            this.حفظToolStripMenuItem.Size = new System.Drawing.Size(57, 33);
            this.حفظToolStripMenuItem.Text = "حفظ";
            this.حفظToolStripMenuItem.Click += new System.EventHandler(this.حفظToolStripMenuItem_Click_1);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Enabled = false;
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(63, 33);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click_1);
            // 
            // إلغاءToolStripMenuItem
            // 
            this.إلغاءToolStripMenuItem.Enabled = false;
            this.إلغاءToolStripMenuItem.Name = "إلغاءToolStripMenuItem";
            this.إلغاءToolStripMenuItem.Size = new System.Drawing.Size(57, 33);
            this.إلغاءToolStripMenuItem.Text = "إلغاء";
            this.إلغاءToolStripMenuItem.Click += new System.EventHandler(this.إلغاءToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(90, 33);
            this.toolStripMenuItem1.Text = "                     ";
            // 
            // التحويلبينالحساباتToolStripMenuItem
            // 
            this.التحويلبينالحساباتToolStripMenuItem.Name = "التحويلبينالحساباتToolStripMenuItem";
            this.التحويلبينالحساباتToolStripMenuItem.Size = new System.Drawing.Size(123, 33);
            this.التحويلبينالحساباتToolStripMenuItem.Text = "                                ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(156, 33);
            this.toolStripMenuItem2.Text = "                                           ";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(138, 33);
            this.toolStripMenuItem3.Text = "                                     ";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(132, 33);
            this.toolStripMenuItem4.Text = "                                   ";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Cairo", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.Green;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(165, 33);
            this.toolStripMenuItem5.Text = "التحويل بين الحسابات";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(87, 33);
            this.toolStripMenuItem6.Text = "                    ";
            // 
            // التحويلبينالحساباتToolStripMenuItem1
            // 
            this.التحويلبينالحساباتToolStripMenuItem1.Font = new System.Drawing.Font("Cairo", 8.999999F, System.Drawing.FontStyle.Bold);
            this.التحويلبينالحساباتToolStripMenuItem1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.التحويلبينالحساباتToolStripMenuItem1.Name = "التحويلبينالحساباتToolStripMenuItem1";
            this.التحويلبينالحساباتToolStripMenuItem1.Size = new System.Drawing.Size(165, 33);
            this.التحويلبينالحساباتToolStripMenuItem1.Text = "التحويل بين الحسابات";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 217);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1348, 105);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "البحث في الحسابات";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(60)))), ((int)(((byte)(119)))));
            this.button1.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(771, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Cairo", 11F);
            this.textBox3.Location = new System.Drawing.Point(883, 47);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(327, 42);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 11F);
            this.label3.Location = new System.Drawing.Point(1217, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "البحث بالاسم";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 318);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1348, 432);
            this.dataGridView1.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 28);
            // 
            // تعديلToolStripMenuItem1
            // 
            this.تعديلToolStripMenuItem1.Name = "تعديلToolStripMenuItem1";
            this.تعديلToolStripMenuItem1.Size = new System.Drawing.Size(115, 24);
            this.تعديلToolStripMenuItem1.Text = "تعديل";
            this.تعديلToolStripMenuItem1.Click += new System.EventHandler(this.تعديلToolStripMenuItem1_Click_1);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 750);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 835);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1363, 717);
            this.Name = "AccountForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الحسابات";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AccountForm_Load_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public GroupBox groupBox1;
        public TextBox textBox1;
        public Label label1;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem جديدToolStripMenuItem;
        public ToolStripMenuItem حفظToolStripMenuItem;
        public ToolStripMenuItem تعديلToolStripMenuItem;
        public ToolStripMenuItem إلغاءToolStripMenuItem;
        public TextBox textBox2;
        public Label label2;
        public GroupBox groupBox2;
        private Button button1;
        public TextBox textBox3;
        public Label label3;
        public DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديلToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem التحويلبينالحساباتToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem التحويلبينالحساباتToolStripMenuItem1;
    }
}