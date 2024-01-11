using SalesManagementSystem.Controllers;
using System;
using System.Windows.Forms;

namespace SalesManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        static LoginForm loginForm;//
        LoginManagement loginClass = new LoginManagement();

        public LoginForm()
        {
            loginForm = this;
            InitializeComponent();
        }

        static void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm = null;
        }

        public static LoginForm GetloginForm //
        {

            get
            {
                loginForm = new LoginForm();
                loginForm.FormClosed += LoginForm_FormClosed;
                return loginForm;

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginClass.Login(textBox1.Text, textBox2.Text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginClass.Login(textBox1.Text, textBox2.Text);
            }
        }
    }
}
