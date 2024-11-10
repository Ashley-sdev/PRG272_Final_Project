using System;
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

            if (string.IsNullOrEmpty(username) || )
            {

            }
        }
    }
}
