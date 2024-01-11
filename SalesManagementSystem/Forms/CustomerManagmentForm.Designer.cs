using System.Drawing;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    partial class CustomerManagmentForm : Form
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
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            تعديلToolStripMenuItem1 = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            id = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { تعديلToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RightToLeft = RightToLeft.Yes;
            contextMenuStrip1.Size = new Size(116, 28);
            // 
            // تعديلToolStripMenuItem1
            // 
            تعديلToolStripMenuItem1.Name = "تعديلToolStripMenuItem1";
            تعديلToolStripMenuItem1.Size = new Size(115, 24);
            تعديلToolStripMenuItem1.Text = "تعديل";
            تعديلToolStripMenuItem1.Click += تعديلToolStripMenuItem1_Click;
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
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "خيارات ادارة العملاء";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(246, 174);
            id.Name = "id";
            id.Size = new Size(0, 29);
            id.TabIndex = 8;
            id.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(405, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(594, 42);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1005, 157);
            label4.Name = "label4";
            label4.Size = new Size(127, 36);
            label4.TabIndex = 6;
            label4.Text = "عنوان التوصيل";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(81, 100);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.No;
            textBox2.Size = new Size(318, 42);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(405, 103);
            label2.Name = "label2";
            label2.Size = new Size(103, 36);
            label2.TabIndex = 4;
            label2.Text = "رقم الهاتف";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(615, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 42);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1005, 103);
            label1.Name = "label1";
            label1.Size = new Size(107, 36);
            label1.TabIndex = 2;
            label1.Text = "اسم العميل";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { جديدToolStripMenuItem, حفظToolStripMenuItem, تعديلToolStripMenuItem, إلغاءToolStripMenuItem });
            menuStrip1.Location = new Point(3, 33);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 4, 0, 4);
            menuStrip1.Size = new Size(1176, 41);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // جديدToolStripMenuItem
            // 
            جديدToolStripMenuItem.Name = "جديدToolStripMenuItem";
            جديدToolStripMenuItem.Size = new Size(55, 33);
            جديدToolStripMenuItem.Text = "جديد";
            جديدToolStripMenuItem.Click += إضافةToolStripMenuItem_Click;
            // 
            // حفظToolStripMenuItem
            // 
            حفظToolStripMenuItem.Enabled = false;
            حفظToolStripMenuItem.Name = "حفظToolStripMenuItem";
            حفظToolStripMenuItem.Size = new Size(57, 33);
            حفظToolStripMenuItem.Text = "حفظ";
            حفظToolStripMenuItem.Click += حفظToolStripMenuItem_Click;
            // 
            // تعديلToolStripMenuItem
            // 
            تعديلToolStripMenuItem.Enabled = false;
            تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            تعديلToolStripMenuItem.Size = new Size(63, 33);
            تعديلToolStripMenuItem.Text = "تعديل";
            تعديلToolStripMenuItem.Click += تعديلToolStripMenuItem_Click_1;
            // 
            // إلغاءToolStripMenuItem
            // 
            إلغاءToolStripMenuItem.Enabled = false;
            إلغاءToolStripMenuItem.Name = "إلغاءToolStripMenuItem";
            إلغاءToolStripMenuItem.Size = new Size(57, 33);
            إلغاءToolStripMenuItem.Text = "إلغاء";
            إلغاءToolStripMenuItem.Click += إلغاءToolStripMenuItem_Click;
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
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "البحث عن عميل";
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
            // textBox3
            // 
            textBox3.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(615, 45);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(384, 42);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1005, 48);
            label3.Name = "label3";
            label3.Size = new Size(90, 36);
            label3.TabIndex = 4;
            label3.Text = "نص البحث";
            // 
            // CustomerManagmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerManagmentForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة العملاء";
            Load += CustomerManagmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public DataGridView dataGridView1;
        public GroupBox groupBox1;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem جديدToolStripMenuItem;
        public ToolStripMenuItem حفظToolStripMenuItem;
        public ToolStripMenuItem تعديلToolStripMenuItem;
        public ToolStripMenuItem إلغاءToolStripMenuItem;
        public TextBox textBox1;
        public Label label1;
        public TextBox textBox2;
        public Label label2;
        public GroupBox groupBox2;
        public TextBox textBox3;
        public Label label3;
        public TextBox textBox4;
        public Label label4;
        private Button button1;
        public ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديلToolStripMenuItem1;
        public Label id;
    }
}