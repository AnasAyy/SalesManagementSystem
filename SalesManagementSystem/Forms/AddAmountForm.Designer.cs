using System.Drawing;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    partial class AddAmountForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 8;
            label1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 30);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 28);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 11;
            label2.Text = "الكمية";
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(16, 162);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 18;
            button4.Text = "إلغاء";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(16, 119);
            button3.Name = "button3";
            button3.Size = new Size(107, 42);
            button3.TabIndex = 17;
            button3.Text = "إضافة";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AddAmountForm
            // 
            AutoScaleDimensions = new SizeF(6F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(138, 211);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAmountForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إضافة الكمية";
            TopMost = true;
            Load += AddAmountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label label1;
        public TextBox textBox1;
        public Label label2;
        public Button button4;
        public Button button3;
    }
}