using SalesManagementSystem.Controllers;
using System;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    public partial class PublicListManagmentForm : Form
    {
        static PublicListManagmentForm publicListManagmentForm;
        public PublicListManagmentForm()
        {
            if (publicListManagmentForm == null) { publicListManagmentForm = this; }
            InitializeComponent();
            PublicListManagment.GetAllPublicList(this);
            PublicListManagment.GetPublicListGategory(this);

        }

        static void PublicListManagmentForm_Closed(object sender, FormClosedEventArgs e)
        {
            publicListManagmentForm = null;
        }

        public static PublicListManagmentForm getChangesManagmentForm
        {
            get
            {
                if (publicListManagmentForm == null)

                    publicListManagmentForm = new PublicListManagmentForm();
                publicListManagmentForm.FormClosed += new FormClosedEventHandler(PublicListManagmentForm_Closed);
                return publicListManagmentForm;
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
