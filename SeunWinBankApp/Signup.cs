using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeunWinBankApp
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnRegister;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
        }
    }
}
