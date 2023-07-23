namespace User_Management_System
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.radioBtnAdmin = new System.Windows.Forms.RadioButton();
            this.radioBtnGuest = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblGuestLogin = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBoxLogin = new System.Windows.Forms.GroupBox();
            this.grpBoxFirstTime = new System.Windows.Forms.GroupBox();
            this.txtboxPass = new System.Windows.Forms.TextBox();
            this.txtboxuser = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxLogin.SuspendLayout();
            this.grpBoxFirstTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to User Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(142, 77);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(112, 24);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password :";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(265, 48);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(226, 20);
            this.txtboxUsername.TabIndex = 3;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(265, 77);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(226, 20);
            this.txtboxPassword.TabIndex = 4;
            this.txtboxPassword.UseSystemPasswordChar = true;
            // 
            // radioBtnAdmin
            // 
            this.radioBtnAdmin.AutoSize = true;
            this.radioBtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAdmin.Location = new System.Drawing.Point(265, 123);
            this.radioBtnAdmin.Name = "radioBtnAdmin";
            this.radioBtnAdmin.Size = new System.Drawing.Size(111, 17);
            this.radioBtnAdmin.TabIndex = 5;
            this.radioBtnAdmin.TabStop = true;
            this.radioBtnAdmin.Text = "Login as Admin";
            this.radioBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // radioBtnGuest
            // 
            this.radioBtnGuest.AutoSize = true;
            this.radioBtnGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnGuest.Location = new System.Drawing.Point(382, 123);
            this.radioBtnGuest.Name = "radioBtnGuest";
            this.radioBtnGuest.Size = new System.Drawing.Size(103, 17);
            this.radioBtnGuest.TabIndex = 6;
            this.radioBtnGuest.TabStop = true;
            this.radioBtnGuest.Text = "Login as User";
            this.radioBtnGuest.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Crimson;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(256, 154);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 36);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(256, 197);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(111, 36);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblGuestLogin
            // 
            this.lblGuestLogin.AutoSize = true;
            this.lblGuestLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestLogin.Location = new System.Drawing.Point(379, 162);
            this.lblGuestLogin.Name = "lblGuestLogin";
            this.lblGuestLogin.Size = new System.Drawing.Size(109, 18);
            this.lblGuestLogin.TabIndex = 9;
            this.lblGuestLogin.Text = "Login As Guest";
            this.lblGuestLogin.Click += new System.EventHandler(this.lblGuestLogin_Click);
            this.lblGuestLogin.MouseLeave += new System.EventHandler(this.lblGuestLogin_MouseLeave);
            this.lblGuestLogin.MouseHover += new System.EventHandler(this.lblGuestLogin_MouseHover);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.Location = new System.Drawing.Point(358, 97);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(133, 18);
            this.lblForgotPassword.TabIndex = 10;
            this.lblForgotPassword.Text = "Forgot password ?";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            this.lblForgotPassword.MouseLeave += new System.EventHandler(this.lblForgotPassword_MouseLeave);
            this.lblForgotPassword.MouseHover += new System.EventHandler(this.lblForgotPassword_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::User_Management_System.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(29, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // grpBoxLogin
            // 
            this.grpBoxLogin.Controls.Add(this.label2);
            this.grpBoxLogin.Controls.Add(this.lbl_Password);
            this.grpBoxLogin.Controls.Add(this.lblForgotPassword);
            this.grpBoxLogin.Controls.Add(this.txtboxUsername);
            this.grpBoxLogin.Controls.Add(this.lblGuestLogin);
            this.grpBoxLogin.Controls.Add(this.txtboxPassword);
            this.grpBoxLogin.Controls.Add(this.btnSignUp);
            this.grpBoxLogin.Controls.Add(this.radioBtnAdmin);
            this.grpBoxLogin.Controls.Add(this.btnLogin);
            this.grpBoxLogin.Controls.Add(this.radioBtnGuest);
            this.grpBoxLogin.Location = new System.Drawing.Point(7, 49);
            this.grpBoxLogin.Name = "grpBoxLogin";
            this.grpBoxLogin.Size = new System.Drawing.Size(501, 264);
            this.grpBoxLogin.TabIndex = 12;
            this.grpBoxLogin.TabStop = false;
            this.grpBoxLogin.Text = "Login ";
            // 
            // grpBoxFirstTime
            // 
            this.grpBoxFirstTime.Controls.Add(this.txtboxPass);
            this.grpBoxFirstTime.Controls.Add(this.txtboxuser);
            this.grpBoxFirstTime.Controls.Add(this.lblpass);
            this.grpBoxFirstTime.Controls.Add(this.lbluser);
            this.grpBoxFirstTime.Controls.Add(this.btnGo);
            this.grpBoxFirstTime.Location = new System.Drawing.Point(514, 50);
            this.grpBoxFirstTime.Name = "grpBoxFirstTime";
            this.grpBoxFirstTime.Size = new System.Drawing.Size(324, 264);
            this.grpBoxFirstTime.TabIndex = 13;
            this.grpBoxFirstTime.TabStop = false;
            this.grpBoxFirstTime.Text = "First Time";
            // 
            // txtboxPass
            // 
            this.txtboxPass.Enabled = false;
            this.txtboxPass.Location = new System.Drawing.Point(113, 109);
            this.txtboxPass.Name = "txtboxPass";
            this.txtboxPass.Size = new System.Drawing.Size(205, 20);
            this.txtboxPass.TabIndex = 9;
            // 
            // txtboxuser
            // 
            this.txtboxuser.Enabled = false;
            this.txtboxuser.Location = new System.Drawing.Point(113, 83);
            this.txtboxuser.Name = "txtboxuser";
            this.txtboxuser.Size = new System.Drawing.Size(205, 20);
            this.txtboxuser.TabIndex = 8;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(21, 109);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(86, 20);
            this.lblpass.TabIndex = 7;
            this.lblpass.Text = "Password :";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(16, 83);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(91, 20);
            this.lbluser.TabIndex = 6;
            this.lbluser.Text = "Username :";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(113, 151);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(92, 28);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Login";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(850, 326);
            this.Controls.Add(this.grpBoxFirstTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBoxLogin);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxLogin.ResumeLayout(false);
            this.grpBoxLogin.PerformLayout();
            this.grpBoxFirstTime.ResumeLayout(false);
            this.grpBoxFirstTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.RadioButton radioBtnAdmin;
        private System.Windows.Forms.RadioButton radioBtnGuest;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblGuestLogin;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBoxLogin;
        private System.Windows.Forms.GroupBox grpBoxFirstTime;
        private System.Windows.Forms.TextBox txtboxPass;
        private System.Windows.Forms.TextBox txtboxuser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Button btnGo;
    }
}