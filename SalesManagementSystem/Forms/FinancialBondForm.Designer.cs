using System.Drawing;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    partial class FinancialBondForm
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
            comboBox5 = new ComboBox();
            label16 = new Label();
            comboBox4 = new ComboBox();
            label15 = new Label();
            richTextBox1 = new RichTextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            جديدToolStripMenuItem = new ToolStripMenuItem();
            حفظToolStripMenuItem = new ToolStripMenuItem();
            تعديلToolStripMenuItem = new ToolStripMenuItem();
            إلغاءToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            comboBox6 = new ComboBox();
            label12 = new Label();
            button1 = new Button();
            textBox7 = new TextBox();
            label11 = new Label();
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
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1169, 352);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "أدارة السندات";
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.Enabled = false;
            comboBox5.FormattingEnabled = true;
            comboBox5.ItemHeight = 15;
            comboBox5.Location = new Point(455, 224);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(238, 23);
            comboBox5.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Enabled = false;
            label16.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(700, 218);
            label16.Name = "label16";
            label16.Size = new Size(61, 29);
            label16.TabIndex = 28;
            label16.Text = "الشخص";
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.Enabled = false;
            comboBox4.FormattingEnabled = true;
            comboBox4.ItemHeight = 15;
            comboBox4.Items.AddRange(new object[] { "عميل", "تاجر ", "اخرى" });
            comboBox4.Location = new Point(832, 224);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(238, 23);
            comboBox4.TabIndex = 27;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Enabled = false;
            label15.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(1077, 218);
            label15.Name = "label15";
            label15.Size = new Size(42, 29);
            label15.TabIndex = 26;
            label15.Text = "النوع";
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(62, 266);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1008, 79);
            richTextBox1.TabIndex = 25;
            richTextBox1.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1077, 266);
            label8.Name = "label8";
            label8.Size = new Size(57, 29);
            label8.TabIndex = 24;
            label8.Text = "تفاصيل\r\n";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(62, 174);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(238, 35);
            textBox6.TabIndex = 23;
            textBox6.KeyPress += textBox4_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(62, 121);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(238, 35);
            textBox5.TabIndex = 23;
            textBox5.KeyPress += textBox4_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(62, 74);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(238, 35);
            textBox4.TabIndex = 23;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Enabled = false;
            label10.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(306, 180);
            label10.Name = "label10";
            label10.Size = new Size(139, 29);
            label10.TabIndex = 22;
            label10.Text = "اجمالي المبلغ باليمني";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Enabled = false;
            label9.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(306, 127);
            label9.Name = "label9";
            label9.Size = new Size(141, 29);
            label9.TabIndex = 22;
            label9.Text = "اجمالي المبلغ بالدولار ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(306, 80);
            label7.Name = "label7";
            label7.Size = new Size(114, 29);
            label7.TabIndex = 22;
            label7.Text = "سعر صرف الدولار";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(455, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(238, 35);
            textBox3.TabIndex = 21;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(699, 181);
            label6.Name = "label6";
            label6.Size = new Size(87, 29);
            label6.TabIndex = 20;
            label6.Text = "مبلغ الضريبة";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(455, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 35);
            textBox2.TabIndex = 19;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(699, 130);
            label3.Name = "label3";
            label3.Size = new Size(49, 29);
            label3.TabIndex = 18;
            label3.Text = "المبلغ";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Enabled = false;
            comboBox3.FormattingEnabled = true;
            comboBox3.ItemHeight = 15;
            comboBox3.Location = new Point(832, 178);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(238, 23);
            comboBox3.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1076, 181);
            label5.Name = "label5";
            label5.Size = new Size(80, 29);
            label5.TabIndex = 16;
            label5.Text = "نوع الضريبة";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 15;
            comboBox1.Location = new Point(832, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 23);
            comboBox1.TabIndex = 17;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1076, 133);
            label2.Name = "label2";
            label2.Size = new Size(89, 29);
            label2.TabIndex = 16;
            label2.Text = "طريقة الدفع";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.ItemHeight = 15;
            comboBox2.Items.AddRange(new object[] { "صرف ", "قبض" });
            comboBox2.Location = new Point(455, 83);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(238, 23);
            comboBox2.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(699, 80);
            label4.Name = "label4";
            label4.Size = new Size(70, 29);
            label4.TabIndex = 14;
            label4.Text = "نوع السند";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(832, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 35);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1076, 83);
            label1.Name = "label1";
            label1.Size = new Size(58, 29);
            label1.TabIndex = 2;
            label1.Text = "العنوان";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { جديدToolStripMenuItem, حفظToolStripMenuItem, تعديلToolStripMenuItem, إلغاءToolStripMenuItem });
            menuStrip1.Location = new Point(3, 20);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 4, 0, 4);
            menuStrip1.Size = new Size(1163, 35);
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
            groupBox2.Controls.Add(comboBox6);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label11);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 352);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1169, 76);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "البحث في السندات";
            // 
            // comboBox6
            // 
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FormattingEnabled = true;
            comboBox6.ItemHeight = 15;
            comboBox6.Items.AddRange(new object[] { "قبض", "صرف", "الكل" });
            comboBox6.Location = new Point(385, 28);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(287, 23);
            comboBox6.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(678, 23);
            label12.Name = "label12";
            label12.Size = new Size(70, 29);
            label12.TabIndex = 30;
            label12.Text = "نوع السند";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(11, 60, 119);
            button1.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(279, 17);
            button1.Name = "button1";
            button1.Size = new Size(85, 42);
            button1.TabIndex = 6;
            button1.Text = "بحث";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(772, 20);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(287, 35);
            textBox7.TabIndex = 5;
            textBox7.KeyPress += textBox7_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cairo", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1065, 23);
            label11.Name = "label11";
            label11.Size = new Size(84, 29);
            label11.TabIndex = 4;
            label11.Text = "البحث بالرقم";
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
            dataGridView1.Location = new Point(0, 354);
            dataGridView1.Margin = new Padding(3, 6, 3, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1169, 325);
            dataGridView1.TabIndex = 13;
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
            // FinancialBondForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 679);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(1185, 788);
            MinimizeBox = false;
            MinimumSize = new Size(1185, 718);
            Name = "FinancialBondForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة السندات";
            Load += ExpenseForm_Load;
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
        public ComboBox comboBox2;
        public Label label4;
        public TextBox textBox1;
        public Label label1;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem جديدToolStripMenuItem;
        public ToolStripMenuItem حفظToolStripMenuItem;
        public ToolStripMenuItem تعديلToolStripMenuItem;
        public ToolStripMenuItem إلغاءToolStripMenuItem;
        public Label label2;
        public TextBox textBox2;
        public Label label3;
        public TextBox textBox3;
        public Label label6;
        public ComboBox comboBox3;
        public Label label5;
        public TextBox textBox4;
        public Label label7;
        public Label label8;
        public TextBox textBox6;
        public TextBox textBox5;
        public Label label10;
        public Label label9;
        public GroupBox groupBox2;
        private Button button1;
        public TextBox textBox7;
        public Label label11;
        public DataGridView dataGridView1;
        public RichTextBox richTextBox1;
        public ComboBox comboBox1;
        public ComboBox comboBox5;
        public Label label16;
        public ComboBox comboBox4;
        public Label label15;
        public Label label12;
        public ComboBox comboBox6;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem تعديلToolStripMenuItem1;
    }
}