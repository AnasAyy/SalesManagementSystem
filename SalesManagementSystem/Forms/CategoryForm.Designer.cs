using System.Drawing;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    partial class CategoryForm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            جديدToolStripMenuItem = new ToolStripMenuItem();
            حفظToolStripMenuItem = new ToolStripMenuItem();
            تعديلToolStripMenuItem = new ToolStripMenuItem();
            إلغاءToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            تعديلToolStripMenuItem1 = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1182, 166);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "أدارة الفئات";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Enabled = false;
            radioButton2.Font = new Font("Cairo", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(277, 97);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(85, 33);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "غير فعال";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Enabled = false;
            radioButton1.Font = new Font("Cairo", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(409, 97);
            radioButton1.Name = "radioButton1";
            radioButton1.RightToLeft = RightToLeft.Yes;
            radioButton1.Size = new Size(64, 33);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "فعال";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(521, 99);
            label2.Name = "label2";
            label2.Size = new Size(47, 29);
            label2.TabIndex = 11;
            label2.Text = "الحالة";
            label2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(675, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 35);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1081, 97);
            label1.Name = "label1";
            label1.Size = new Size(73, 29);
            label1.TabIndex = 2;
            label1.Text = "اسم الفئة";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { جديدToolStripMenuItem, حفظToolStripMenuItem, تعديلToolStripMenuItem, إلغاءToolStripMenuItem });
            menuStrip1.Location = new Point(3, 20);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 4, 0, 4);
            menuStrip1.Size = new Size(1176, 35);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // جديدToolStripMenuItem
            // 
            جديدToolStripMenuItem.Name = "جديدToolStripMenuItem";
            جديدToolStripMenuItem.Size = new Size(44, 27);
            جديدToolStripMenuItem.Text = "جديد";
            جديدToolStripMenuItem.Click += جديدToolStripMenuItem_Click;
            // 
            // حفظToolStripMenuItem
            // 
            حفظToolStripMenuItem.Enabled = false;
            حفظToolStripMenuItem.Name = "حفظToolStripMenuItem";
            حفظToolStripMenuItem.Size = new Size(47, 27);
            حفظToolStripMenuItem.Text = "حفظ";
            حفظToolStripMenuItem.Click += حفظToolStripMenuItem_Click;
            // 
            // تعديلToolStripMenuItem
            // 
            تعديلToolStripMenuItem.Enabled = false;
            تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            تعديلToolStripMenuItem.Size = new Size(50, 27);
            تعديلToolStripMenuItem.Text = "تعديل";
            تعديلToolStripMenuItem.Click += تعديلToolStripMenuItem_Click;
            // 
            // إلغاءToolStripMenuItem
            // 
            إلغاءToolStripMenuItem.Enabled = false;
            إلغاءToolStripMenuItem.Name = "إلغاءToolStripMenuItem";
            إلغاءToolStripMenuItem.Size = new Size(47, 27);
            إلغاءToolStripMenuItem.Text = "إلغاء";
            إلغاءToolStripMenuItem.Click += إلغاءToolStripMenuItem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 166);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1182, 120);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "البحث في الفئات";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(11, 60, 119);
            button1.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(675, 44);
            button1.Name = "button1";
            button1.Size = new Size(85, 42);
            button1.TabIndex = 6;
            button1.Text = "بحث";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(772, 44);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(287, 35);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1065, 47);
            label3.Name = "label3";
            label3.Size = new Size(89, 29);
            label3.TabIndex = 4;
            label3.Text = "البحث بالاسم";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 286);
            dataGridView1.Margin = new Padding(3, 6, 3, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1182, 463);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { تعديلToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RightToLeft = RightToLeft.Yes;
            contextMenuStrip1.Size = new Size(104, 26);
            // 
            // تعديلToolStripMenuItem1
            // 
            تعديلToolStripMenuItem1.Name = "تعديلToolStripMenuItem1";
            تعديلToolStripMenuItem1.Size = new Size(103, 22);
            تعديلToolStripMenuItem1.Text = "تعديل";
            تعديلToolStripMenuItem1.Click += تعديلToolStripMenuItem1_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 749);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CategoryForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "أدارة الفئات";
            Load += CategoryForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
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
        public RadioButton radioButton2;
        public RadioButton radioButton1;
        public Label label2;
        public GroupBox groupBox2;
        private Button button1;
        public TextBox textBox3;
        public Label label3;
        public DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديلToolStripMenuItem1;
    }
}