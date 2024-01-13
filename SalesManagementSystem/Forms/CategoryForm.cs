using SalesManagementSystem.Controllers;
using System;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    public partial class CategoryForm : Form
    {
        static CategoryForm categoryForm;//
        public int id;
        public CategoryForm()
        {
            if (categoryForm == null) { categoryForm = this; }//
            InitializeComponent();
        }

        static void categoryForm_FormClosed(object sender, FormClosedEventArgs e)//
        {
            categoryForm = null;
        }

        public static CategoryForm GetCategoryForm //
        {

            get
            {
                if (categoryForm == null)
                    categoryForm = new CategoryForm();
                categoryForm.FormClosed += categoryForm_FormClosed;
                return categoryForm;

            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CategoryForm_Load_1(object sender, EventArgs e)
        {
            CategoryManagment.FilldataGridView(this);
        }

        private void جديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryManagment.NewButton(this);
        }

        private void إلغاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryManagment.ResetPage(this);
        }

        private void حفظToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryManagment.Add(this);

        }

        private void تعديلToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CategoryManagment.Update(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim() == "")
            {
                CategoryManagment.FilldataGridView(this);
            }
            else
                CategoryManagment.SearchBox(this);
        }

        private void تعديلToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            CategoryManagment.Edit(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
