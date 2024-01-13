﻿using SalesManagementSystem.Controllers;
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
            if (loginForm == null) { loginForm = this; }//
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
                if (loginForm == null)
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

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
                
            
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginClass.Login(textBox1.Text, textBox2.Text);
            }
        }
    }
}