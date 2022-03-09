namespace SeunWinBankApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labEmail = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.BackColor = System.Drawing.Color.SteelBlue;
            this.labEmail.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labEmail.ForeColor = System.Drawing.Color.Lavender;
            this.labEmail.Location = new System.Drawing.Point(328, 331);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(83, 31);
            this.labEmail.TabIndex = 0;
            this.labEmail.Text = "Email";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.labPassword.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labPassword.ForeColor = System.Drawing.Color.Lavender;
            this.labPassword.Location = new System.Drawing.Point(328, 383);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(132, 31);
            this.labPassword.TabIndex = 1;
            this.labPassword.Text = "Password";
            this.labPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(493, 331);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "abc@email.com";
            this.txtEmail.Size = new System.Drawing.Size(269, 31);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtPassword.HideSelection = false;
            this.txtPassword.Location = new System.Drawing.Point(493, 383);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "password";
            this.txtPassword.Size = new System.Drawing.Size(269, 31);
            this.txtPassword.TabIndex = 3;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(493, 443);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(130, 34);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(632, 443);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(130, 34);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(305, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 82);
            this.label3.TabIndex = 6;
            this.label3.Text = "SPIRIT BANK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saving souls.";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 584);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labEmail);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SlateBlue;
            this.MaximumSize = new System.Drawing.Size(1124, 640);
            this.MinimumSize = new System.Drawing.Size(1124, 640);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
