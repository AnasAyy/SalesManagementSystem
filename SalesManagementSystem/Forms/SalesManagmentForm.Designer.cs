using System.Drawing;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    partial class SalesManagmentForm
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            button1 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button5 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1182, 101);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "بحث";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(3, 32);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(401, 66);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "نوع الفاتورة";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(41, 19);
            button1.Name = "button1";
            button1.Size = new Size(98, 42);
            button1.TabIndex = 8;
            button1.Text = "بحث";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.CheckAlign = ContentAlignment.MiddleRight;
            radioButton2.Location = new Point(158, 25);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 33);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "مرتجع";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.CheckAlign = ContentAlignment.MiddleRight;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(243, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 33);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "مبيعات";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.RoyalBlue;
            button5.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(740, 35);
            button5.Name = "button5";
            button5.Size = new Size(75, 42);
            button5.TabIndex = 7;
            button5.Text = "بحث";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(821, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 36);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1083, 40);
            label1.Name = "label1";
            label1.Size = new Size(87, 29);
            label1.TabIndex = 0;
            label1.Text = "رقم الفاتورة";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1182, 624);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "فواتير المبيعات";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.IBeam;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1176, 589);
            dataGridView1.TabIndex = 0;
            // 
            // SalesManagmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SalesManagmentForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ادارة المبيعات";
            Load += SalesManagmentForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public Button button5;
        public Button button1;
        public GroupBox groupBox1;
        public GroupBox groupBox2;
        public DataGridView dataGridView1;
        public TextBox textBox1;
        public Label label1;
        public GroupBox groupBox3;
        public RadioButton radioButton2;
        public RadioButton radioButton1;
    }
}