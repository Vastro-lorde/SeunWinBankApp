
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
    public partial class Signup : Form
    {
        private static IValidation _validation;
        public static IValidation Validation
        {
            get => _validation ??= new Validations();
        }
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
            if (fullname == "" || email == "" || password == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else if (!Validation.VerifyEmail(email))
            {
                MessageBox.Show("Incorrect format of Email inputed");
            }
            else if (!Validation.CheckPasswordInput(password))
            {
                MessageBox.Show("Password should contain an uppercase, lowercase, number and special character");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Show();
            this.Hide();
        }
    }
}
