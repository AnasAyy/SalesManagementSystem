using System.Drawing;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    partial class ExchangeForm
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
            label2 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 55);
            label1.Name = "label1";
            label1.Size = new Size(27, 23);
            label1.TabIndex = 0;
            label1.Text = "من";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 103);
            label2.Name = "label2";
            label2.Size = new Size(27, 23);
            label2.TabIndex = 2;
            label2.Text = "الى";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(11, 60, 119);
            button1.Font = new Font("Cairo", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(87, 191);
            button1.Name = "button1";
            button1.Size = new Size(292, 42);
            button1.TabIndex = 18;
            button1.Text = "تحويل";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(87, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(292, 23);
            comboBox1.TabIndex = 19;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(87, 104);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(292, 23);
            comboBox2.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 149);
            label3.Name = "label3";
            label3.Size = new Size(42, 23);
            label3.TabIndex = 21;
            label3.Text = "المبلغ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 22;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // ExchangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 261);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(458, 300);
            MinimizeBox = false;
            MinimumSize = new Size(458, 300);
            Name = "ExchangeForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "التحويل بين الحسابات";
            Load += ExchangeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        public ComboBox comboBox1;
        public ComboBox comboBox2;
        private Label label3;
        public TextBox textBox1;
    }
}