﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG272_Project.data_layer;
using System.IO;

namespace PRG272_Project
{
    public partial class frmSignIn : Form
    {
        Datahandler dh = new Datahandler();
        
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dh.SignUp(username, password);

            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dh.SignIn(username, password);

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
