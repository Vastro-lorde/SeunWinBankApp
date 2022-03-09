using SeunWinBankAppCore;
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
    public partial class Login : Form
    {
        private static IValidation _validation;
        public static IValidation Validation
        {
            get => _validation ??= new Validations();
        }
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
