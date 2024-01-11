using System.Drawing;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    partial class SupplierManagmentForm
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
            button1 = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            إلغاءToolStripMenuItem = new ToolStripMenuItem();
            id = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            تعديلToolStripMenuItem = new ToolStripMenuItem();
            حفظToolStripMenuItem = new ToolStripMenuItem();
            جديدToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            label1 = new Label();
            تعديلToolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            label4 = new Label();
            groupBox2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(11, 60, 119);
            button1.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(509, 45);
            button1.Name = "button1";
            button1.Size = new Size(85, 42);
            button1.TabIndex = 6;
            button1.Text = "بحث";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1005, 48);
            label3.Name = "label3";
            label3.Size = new Size(71, 29);
            label3.TabIndex = 4;
            label3.Text = "نص البحث";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1182, 109);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "البحث عن مورد";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(615, 45);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(384, 35);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // إلغاءToolStripMenuItem
            // 
            إلغاءToolStripMenuItem.Enabled = false;
            إلغاءToolStripMenuItem.Name = "إلغاءToolStripMenuItem";
            إلغاءToolStripMenuItem.Size = new Size(47, 27);
            إلغاءToolStripMenuItem.Text = "إلغاء";
            إلغاءToolStripMenuItem.Click += إلغاءToolStripMenuItem_Click;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(246, 175);
            id.Name = "id";
            id.Size = new Size(0, 23);
            id.TabIndex = 8;
            id.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(81, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(318, 35);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(405, 104);
            label2.Name = "label2";
            label2.Size = new Size(81, 29);
            label2.TabIndex = 4;
            label2.Text = "رقم الهاتف";
            // 
            // تعديلToolStripMenuItem
            // 
            تعديلToolStripMenuItem.Enabled = false;
            تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            تعديلToolStripMenuItem.Size = new Size(50, 27);
            تعديلToolStripMenuItem.Text = "تعديل";
            تعديلToolStripMenuItem.Click += تعديلToolStripMenuItem_Click;
            // 
            // حفظToolStripMenuItem
            // 
            حفظToolStripMenuItem.Enabled = false;
            حفظToolStripMenuItem.Name = "حفظToolStripMenuItem";
            حفظToolStripMenuItem.Size = new Size(47, 27);
            حفظToolStripMenuItem.Text = "حفظ";
            حفظToolStripMenuItem.Click += حفظToolStripMenuItem_Click;
            // 
            // جديدToolStripMenuItem
            // 
            جديدToolStripMenuItem.Name = "جديدToolStripMenuItem";
            جديدToolStripMenuItem.Size = new Size(44, 27);
            جديدToolStripMenuItem.Text = "جديد";
            جديدToolStripMenuItem.Click += جديدToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(615, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 35);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1005, 104);
            label1.Name = "label1";
            label1.Size = new Size(80, 29);
            label1.TabIndex = 2;
            label1.Text = "اسم المورد";
            // 
            // تعديلToolStripMenuItem1
            // 
            تعديلToolStripMenuItem1.Name = "تعديلToolStripMenuItem1";
            تعديلToolStripMenuItem1.Size = new Size(103, 22);
            تعديلToolStripMenuItem1.Text = "تعديل";
            تعديلToolStripMenuItem1.Click += تعديلToolStripMenuItem1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { تعديلToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RightToLeft = RightToLeft.Yes;
            contextMenuStrip1.Size = new Size(104, 26);
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
            dataGridView1.Location = new Point(0, 343);
            dataGridView1.Margin = new Padding(3, 6, 3, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1182, 410);
            dataGridView1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { جديدToolStripMenuItem, حفظToolStripMenuItem, تعديلToolStripMenuItem, إلغاءToolStripMenuItem });
            menuStrip1.Location = new Point(3, 27);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 4, 0, 4);
            menuStrip1.Size = new Size(1176, 35);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(id);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1182, 225);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "خيارات ادارة الموردين";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(405, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(594, 35);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1005, 158);
            label4.Name = "label4";
            label4.Size = new Size(58, 29);
            label4.TabIndex = 6;
            label4.Text = "العنوان";
            // 
            // SupplierManagmentForm
            // 
            AutoScaleDimensions = new SizeF(6F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SupplierManagmentForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة الموردين";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        public Label label3;
        public GroupBox groupBox2;
        public TextBox textBox3;
        public ToolStripMenuItem إلغاءToolStripMenuItem;
        public Label id;
        public TextBox textBox2;
        public Label label2;
        public ToolStripMenuItem تعديلToolStripMenuItem;
        public ToolStripMenuItem حفظToolStripMenuItem;
        public ToolStripMenuItem جديدToolStripMenuItem;
        public TextBox textBox1;
        public Label label1;
        private ToolStripMenuItem تعديلToolStripMenuItem1;
        public ContextMenuStrip contextMenuStrip1;
        public DataGridView dataGridView1;
        public MenuStrip menuStrip1;
        public GroupBox groupBox1;
        public TextBox textBox4;
        public Label label4;
    }
}