using System.Drawing;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    partial class NewSaleForm
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
            groupBox4 = new GroupBox();
            textBox7 = new TextBox();
            label11 = new Label();
            button5 = new Button();
            textBox6 = new TextBox();
            label10 = new Label();
            button4 = new Button();
            button3 = new Button();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            comboBox4 = new ComboBox();
            label7 = new Label();
            comboBox3 = new ComboBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox5 = new GroupBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox6 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            comboBox5 = new ComboBox();
            label13 = new Label();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            ItemId = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            SellPrice = new DataGridViewTextBoxColumn();
            ItemAmount = new DataGridViewTextBoxColumn();
            TotalSellPrice = new DataGridViewTextBoxColumn();
            textBox8 = new TextBox();
            label12 = new Label();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox7);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(textBox6);
            groupBox4.Controls.Add(label10);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1182, 87);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "تحديد العميل";
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(139, 34);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(348, 36);
            textBox7.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(493, 37);
            label11.Name = "label11";
            label11.Size = new Size(84, 29);
            label11.TabIndex = 7;
            label11.Text = "اسم العميل";
            // 
            // button5
            // 
            button5.BackColor = Color.RoyalBlue;
            button5.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(689, 35);
            button5.Name = "button5";
            button5.Size = new Size(75, 42);
            button5.TabIndex = 6;
            button5.Text = "بحث";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(770, 38);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(274, 36);
            textBox6.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1050, 41);
            label10.Name = "label10";
            label10.Size = new Size(120, 29);
            label10.TabIndex = 4;
            label10.Text = "رقم هاتف العميل";
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(28, 85);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 16;
            button4.Text = "إلغاء";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(28, 42);
            button3.Name = "button3";
            button3.Size = new Size(107, 42);
            button3.TabIndex = 15;
            button3.Text = "حفظ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(185, 90);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(193, 36);
            textBox5.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(384, 93);
            label9.Name = "label9";
            label9.Size = new Size(161, 29);
            label9.TabIndex = 13;
            label9.Text = "الاجمالي بالعملة المحلية";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(185, 43);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 36);
            textBox4.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(384, 46);
            label8.Name = "label8";
            label8.Size = new Size(103, 29);
            label8.TabIndex = 11;
            label8.Text = "المبلغ الاجمالي";
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(560, 42);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(193, 37);
            comboBox4.TabIndex = 10;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(759, 46);
            label7.Name = "label7";
            label7.Size = new Size(90, 29);
            label7.TabIndex = 9;
            label7.Text = "نوع التخفيض";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(898, 42);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(193, 37);
            comboBox3.TabIndex = 8;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1097, 46);
            label6.Name = "label6";
            label6.Size = new Size(80, 29);
            label6.TabIndex = 7;
            label6.Text = "نوع الضريبة";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(560, 90);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 36);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(759, 93);
            label5.Name = "label5";
            label5.Size = new Size(97, 29);
            label5.TabIndex = 5;
            label5.Text = "مبلغ التخفيض";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1097, 93);
            label4.Name = "label4";
            label4.Size = new Size(87, 29);
            label4.TabIndex = 3;
            label4.Text = "مبلغ الضريبة";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button4);
            groupBox5.Controls.Add(button3);
            groupBox5.Controls.Add(textBox5);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(textBox4);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(comboBox4);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(comboBox3);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(textBox3);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(textBox2);
            groupBox5.Controls.Add(label4);
            groupBox5.Dock = DockStyle.Bottom;
            groupBox5.Location = new Point(0, 612);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1182, 141);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "الاجمالي";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(898, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 36);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1182, 166);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "تحديد المنتج";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(radioButton3);
            groupBox6.Controls.Add(radioButton4);
            groupBox6.Location = new Point(22, 87);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(132, 69);
            groupBox6.TabIndex = 11;
            groupBox6.TabStop = false;
            groupBox6.Text = "نوع الفاتورة";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Dock = DockStyle.Left;
            radioButton3.Location = new Point(65, 32);
            radioButton3.Name = "radioButton3";
            radioButton3.RightToLeft = RightToLeft.No;
            radioButton3.Size = new Size(51, 34);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "بيع";
            radioButton3.TextAlign = ContentAlignment.MiddleRight;
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Dock = DockStyle.Left;
            radioButton4.Location = new Point(3, 32);
            radioButton4.Name = "radioButton4";
            radioButton4.RightToLeft = RightToLeft.No;
            radioButton4.Size = new Size(62, 34);
            radioButton4.TabIndex = 2;
            radioButton4.Text = "ارجاع";
            radioButton4.TextAlign = ContentAlignment.MiddleRight;
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(182, 104);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(233, 37);
            comboBox5.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(421, 107);
            label13.Name = "label13";
            label13.Size = new Size(83, 29);
            label13.TabIndex = 9;
            label13.Text = "نوع الحساب";
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(177, 46);
            button2.Name = "button2";
            button2.Size = new Size(75, 43);
            button2.TabIndex = 8;
            button2.Text = "إضافة";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(258, 52);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(233, 37);
            comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 55);
            label3.Name = "label3";
            label3.Size = new Size(48, 29);
            label3.TabIndex = 6;
            label3.Text = "المنتج";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(554, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 37);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(724, 55);
            label2.Name = "label2";
            label2.Size = new Size(48, 29);
            label2.TabIndex = 4;
            label2.Text = "الفئـة";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(834, 50);
            button1.Name = "button1";
            button1.Size = new Size(75, 42);
            button1.TabIndex = 3;
            button1.Text = "إضافة";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(915, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 36);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1082, 57);
            label1.Name = "label1";
            label1.Size = new Size(88, 29);
            label1.TabIndex = 1;
            label1.Text = "باركود المنتج";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(22, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(133, 64);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "نوع البيع";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Dock = DockStyle.Left;
            radioButton2.Location = new Point(76, 32);
            radioButton2.Name = "radioButton2";
            radioButton2.RightToLeft = RightToLeft.No;
            radioButton2.Size = new Size(56, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "اّجل";
            radioButton2.TextAlign = ContentAlignment.MiddleRight;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Dock = DockStyle.Left;
            radioButton1.Location = new Point(3, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.RightToLeft = RightToLeft.No;
            radioButton1.Size = new Size(73, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "نقديـة";
            radioButton1.TextAlign = ContentAlignment.MiddleRight;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1182, 319);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "عناصر الفاتورة";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ItemId, ItemName, SellPrice, ItemAmount, TotalSellPrice });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1176, 284);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
            dataGridView1.RowsRemoved += dataGridView1_RowsRemoved;
            // 
            // ItemId
            // 
            ItemId.HeaderText = "الرقم";
            ItemId.MinimumWidth = 6;
            ItemId.Name = "ItemId";
            ItemId.ReadOnly = true;
            // 
            // ItemName
            // 
            ItemName.HeaderText = "اسم المنتج";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            ItemName.ReadOnly = true;
            // 
            // SellPrice
            // 
            SellPrice.HeaderText = "سعر الوحدة";
            SellPrice.MinimumWidth = 6;
            SellPrice.Name = "SellPrice";
            SellPrice.ReadOnly = true;
            // 
            // ItemAmount
            // 
            ItemAmount.HeaderText = "الكمية";
            ItemAmount.MinimumWidth = 6;
            ItemAmount.Name = "ItemAmount";
            ItemAmount.ReadOnly = true;
            // 
            // TotalSellPrice
            // 
            TotalSellPrice.HeaderText = "الاجمالي";
            TotalSellPrice.MinimumWidth = 6;
            TotalSellPrice.Name = "TotalSellPrice";
            TotalSellPrice.ReadOnly = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(91, 579);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(906, 36);
            textBox8.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 582);
            label12.Name = "label12";
            label12.Size = new Size(61, 29);
            label12.TabIndex = 9;
            label12.Text = "ملاحظة";
            // 
            // NewSaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(textBox8);
            Controls.Add(label12);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewSaleForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2";
            Load += NewSaleForm_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox4;
        public Button button4;
        public Button button3;
        public TextBox textBox5;
        public Label label9;
        public TextBox textBox4;
        public Label label8;
        public ComboBox comboBox4;
        public Label label7;
        public ComboBox comboBox3;
        public Label label6;
        public TextBox textBox3;
        public Label label5;
        public Label label4;
        public GroupBox groupBox5;
        public TextBox textBox2;
        public GroupBox groupBox1;
        public Button button2;
        public ComboBox comboBox2;
        public Label label3;
        public ComboBox comboBox1;
        public Label label2;
        public Button button1;
        public TextBox textBox1;
        public Label label1;
        public GroupBox groupBox3;
        public RadioButton radioButton2;
        public RadioButton radioButton1;
        public GroupBox groupBox2;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ItemId;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn SellPrice;
        private DataGridViewTextBoxColumn ItemAmount;
        private DataGridViewTextBoxColumn TotalSellPrice;
        public Button button5;
        public TextBox textBox7;
        public Label label11;
        public TextBox textBox6;
        public Label label10;
        public TextBox textBox8;
        public Label label12;
        public ComboBox comboBox5;
        public Label label13;
        private GroupBox groupBox6;
        public RadioButton radioButton3;
        public RadioButton radioButton4;
    }
}