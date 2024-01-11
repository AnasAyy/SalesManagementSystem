using SalesManagementSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    public partial class PublicListManagmentForm : Form
    {
        static PublicListManagmentForm changesManagmentForm;
        public PublicListManagmentForm()
        {
            if (changesManagmentForm == null) { changesManagmentForm = this; }
            InitializeComponent();
            PublicListManagment.GetAllPublicList(this);
            PublicListManagment.GetPublicListGategory(this);

        }

        static void ChangesManagmentForm_Closed(object sender, FormClosedEventArgs e)
        {
            changesManagmentForm = null;
        }

        public static PublicListManagmentForm getChangesManagmentForm
        {
            get
            {
                changesManagmentForm = new PublicListManagmentForm();
                changesManagmentForm.FormClosed += ChangesManagmentForm_Closed;
                return changesManagmentForm;
            }
        }


        private void جديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublicListManagment.NewButton(this);
        }

        private void إلغاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublicListManagment.ResetPage(this);
        }

        private void ChangesManagmentForm_Load(object sender, EventArgs e)
        {

        }

        private void حفظToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublicListManagment.AddChange(this);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PublicListManagment.SearchByCategory(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            PublicListManagment.ResetSearchBox(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PublicListManagment.SearchBox(this);
        }

        private void تعديلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PublicListManagment.GetPublicListDataById(this);
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublicListManagment.UpdatePublicList(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (!PublicOperations.CheckArabicCharsOnly(textBox1.Text))
                {
                    MessageBox.Show("ادخال خاطئ");
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
