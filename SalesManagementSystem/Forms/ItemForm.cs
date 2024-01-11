using SalesManagementSystem.Controllers;
using System;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    public partial class ItemForm : Form
    {
        static ItemForm itemForm;//
        public int id;
        public ItemForm()
        {
            itemForm = this;//
            InitializeComponent();
        }

        static void ItemForm_FormClosed(object sender, FormClosedEventArgs e)//
        {
            itemForm = null;
        }

        public static ItemForm GetCategoryForm //
        {

            get
            {
                itemForm = new ItemForm();
                itemForm.FormClosed += ItemForm_FormClosed;
                return itemForm;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void جديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemManagemet.NewButton(this);
        }

        private void إلغاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemManagemet.ResetPage(this);
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            ItemManagemet.FillComboBox(this);
            ItemManagemet.FilldataGridView(this);

            decimal sum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["اجمالي سعر الشراء"].Value != null)
                {
                    decimal value;
                    if (decimal.TryParse(row.Cells["اجمالي سعر الشراء"].Value.ToString(), out value))
                    {
                        sum += value;
                    }
                }
            }
            textBox5.Text = sum.ToString();

        }

        private void حفظToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && comboBox2.Text == "اختر عنصر")
            {
                MessageBox.Show("الرجاء تحديد الفئة");
                return;
            }
            ItemManagemet.Add(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void تعديلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ItemManagemet.Edit(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim() == "")
            {
                ItemManagemet.FilldataGridView(this);
            }
            else
                ItemManagemet.SearchBox(this);
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemManagemet.Update(this);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
