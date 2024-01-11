using System.Drawing;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    partial class PurchasesManagementForm
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
            textBox7 = new TextBox();
            groupBox3 = new GroupBox();
            radioButton3 = new RadioButton();
            button1 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button5 = new Button();
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
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1182, 101);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "بحث";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Cairo", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(807, 35);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(270, 30);
            textBox7.TabIndex = 37;
            textBox7.TextChanged += textBox7_TextChanged;
            textBox7.KeyPress += textBox7_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(3, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(401, 79);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "نوع المشتريات";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.CheckAlign = ContentAlignment.MiddleRight;
            radioButton3.Location = new Point(153, 25);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(46, 19);
            radioButton3.TabIndex = 9;
            radioButton3.Text = "الكل";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(41, 16);
            button1.Name = "button1";
            button1.Size = new Size(98, 35);
            button1.TabIndex = 8;
            button1.Text = "بحث";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.CheckAlign = ContentAlignment.MiddleRight;
            radioButton2.Location = new Point(213, 25);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(54, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "مرتجع";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.CheckAlign = ContentAlignment.MiddleRight;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(273, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "مشتريات";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.RoyalBlue;
            button5.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(726, 33);
            button5.Name = "button5";
            button5.Size = new Size(75, 35);
            button5.TabIndex = 7;
            button5.Text = "بحث";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1083, 46);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "رقم الفاتورة";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1182, 642);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "فواتير المشتريات";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1182, 551);
            dataGridView1.TabIndex = 0;
            // 
            // PurchasesManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 661);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            MaximumSize = new Size(1198, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1198, 700);
            Name = "PurchasesManagementForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ادارة المشتريات";
            Load += PurchasesManagementForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public GroupBox groupBox1;
        public GroupBox groupBox3;
        public Button button1;
        public RadioButton radioButton2;
        public RadioButton radioButton1;
        public Button button5;
        public Label label1;
        public GroupBox groupBox2;
        public TextBox textBox7;
        public DataGridView dataGridView1;
        public RadioButton radioButton3;
    }
}