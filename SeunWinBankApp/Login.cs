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
        public Signup signup = new(); 
        public Dashboard dashboard = new();
        public static IValidation _validation;
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
            if (email == "" || password == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            else if (!Validation.VerifyEmail(email)) 
            { 
                MessageBox.Show("Incorrect format of Email inputed");
                return;
            } 
            else if (!Validation.CheckPasswordInput(password))
            {
                MessageBox.Show("Password should contain an uppercase, lowercase, number and special character");
                return;

            }
            dashboard.Show();
            this.Hide();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            signup.Show();
            this.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
