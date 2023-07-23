namespace Admin_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TabControl_Login = new MetroFramework.Controls.MetroTabControl();
            this.TabPage_Login = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Login = new MetroFramework.Controls.MetroButton();
            this.txtbox_Password = new MetroFramework.Controls.MetroTextBox();
            this.txtbox_Email = new MetroFramework.Controls.MetroTextBox();
            this.lbl_pass = new MetroFramework.Controls.MetroLabel();
            this.lbl_email = new MetroFramework.Controls.MetroLabel();
            this.TabPage_Forgot = new MetroFramework.Controls.MetroTabPage();
            this.OTPgroup = new System.Windows.Forms.GroupBox();
            this.lbl_OTP = new MetroFramework.Controls.MetroLabel();
            this.btncheckotp = new MetroFramework.Controls.MetroButton();
            this.txtBox_OTP = new MetroFramework.Controls.MetroTextBox();
            this.newgroup = new System.Windows.Forms.GroupBox();
            this.Btn_Forgot_Reset_Pass = new MetroFramework.Controls.MetroButton();
            this.TxtBox_NEw_Pass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Btn_OTP_OK = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtbox_Email_Forgot = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Label_Login = new MetroFramework.Controls.MetroLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TabControl_Login.SuspendLayout();
            this.TabPage_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabPage_Forgot.SuspendLayout();
            this.OTPgroup.SuspendLayout();
            this.newgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl_Login
            // 
            this.TabControl_Login.Controls.Add(this.TabPage_Login);
            this.TabControl_Login.Controls.Add(this.TabPage_Forgot);
            this.TabControl_Login.Location = new System.Drawing.Point(3, 49);
            this.TabControl_Login.Name = "TabControl_Login";
            this.TabControl_Login.SelectedIndex = 0;
            this.TabControl_Login.Size = new System.Drawing.Size(639, 228);
            this.TabControl_Login.TabIndex = 0;
            // 
            // TabPage_Login
            // 
            this.TabPage_Login.Controls.Add(this.pictureBox1);
            this.TabPage_Login.Controls.Add(this.Btn_Login);
            this.TabPage_Login.Controls.Add(this.txtbox_Password);
            this.TabPage_Login.Controls.Add(this.txtbox_Email);
            this.TabPage_Login.Controls.Add(this.lbl_pass);
            this.TabPage_Login.Controls.Add(this.lbl_email);
            this.TabPage_Login.HorizontalScrollbarBarColor = true;
            this.TabPage_Login.Location = new System.Drawing.Point(4, 35);
            this.TabPage_Login.Name = "TabPage_Login";
            this.TabPage_Login.Size = new System.Drawing.Size(631, 189);
            this.TabPage_Login.TabIndex = 0;
            this.TabPage_Login.Text = "Login";
            this.TabPage_Login.VerticalScrollbarBarColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Admin_Panel.Properties.Resources.loginlock;
            this.pictureBox1.Location = new System.Drawing.Point(16, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(334, 125);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(109, 30);
            this.Btn_Login.TabIndex = 6;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // txtbox_Password
            // 
            this.txtbox_Password.Location = new System.Drawing.Point(274, 87);
            this.txtbox_Password.Name = "txtbox_Password";
            this.txtbox_Password.PasswordChar = '●';
            this.txtbox_Password.Size = new System.Drawing.Size(300, 23);
            this.txtbox_Password.TabIndex = 5;
            this.txtbox_Password.UseSystemPasswordChar = true;
            this.txtbox_Password.Click += new System.EventHandler(this.txtbox_Password_Click);
            // 
            // txtbox_Email
            // 
            this.txtbox_Email.Location = new System.Drawing.Point(274, 45);
            this.txtbox_Email.Name = "txtbox_Email";
            this.txtbox_Email.Size = new System.Drawing.Size(300, 23);
            this.txtbox_Email.TabIndex = 4;
            this.txtbox_Email.Click += new System.EventHandler(this.txtbox_Email_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_pass.Location = new System.Drawing.Point(187, 87);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(81, 19);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Password :";
            this.lbl_pass.Click += new System.EventHandler(this.lbl_pass_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_email.Location = new System.Drawing.Point(193, 45);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(75, 19);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email ID : ";
            this.lbl_email.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // TabPage_Forgot
            // 
            this.TabPage_Forgot.Controls.Add(this.OTPgroup);
            this.TabPage_Forgot.Controls.Add(this.newgroup);
            this.TabPage_Forgot.Controls.Add(this.Btn_OTP_OK);
            this.TabPage_Forgot.Controls.Add(this.pictureBox2);
            this.TabPage_Forgot.Controls.Add(this.txtbox_Email_Forgot);
            this.TabPage_Forgot.Controls.Add(this.metroLabel1);
            this.TabPage_Forgot.HorizontalScrollbarBarColor = true;
            this.TabPage_Forgot.Location = new System.Drawing.Point(4, 35);
            this.TabPage_Forgot.Name = "TabPage_Forgot";
            this.TabPage_Forgot.Size = new System.Drawing.Size(631, 189);
            this.TabPage_Forgot.TabIndex = 1;
            this.TabPage_Forgot.Text = "Forgot Password";
            this.TabPage_Forgot.VerticalScrollbarBarColor = true;
            // 
            // OTPgroup
            // 
            this.OTPgroup.BackColor = System.Drawing.Color.White;
            this.OTPgroup.Controls.Add(this.lbl_OTP);
            this.OTPgroup.Controls.Add(this.btncheckotp);
            this.OTPgroup.Controls.Add(this.txtBox_OTP);
            this.OTPgroup.Location = new System.Drawing.Point(48, 52);
            this.OTPgroup.Name = "OTPgroup";
            this.OTPgroup.Size = new System.Drawing.Size(405, 49);
            this.OTPgroup.TabIndex = 16;
            this.OTPgroup.TabStop = false;
            this.OTPgroup.Visible = false;
            // 
            // lbl_OTP
            // 
            this.lbl_OTP.AutoSize = true;
            this.lbl_OTP.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_OTP.Location = new System.Drawing.Point(6, 16);
            this.lbl_OTP.Name = "lbl_OTP";
            this.lbl_OTP.Size = new System.Drawing.Size(82, 19);
            this.lbl_OTP.TabIndex = 8;
            this.lbl_OTP.Text = "Enter OTP :";
            // 
            // btncheckotp
            // 
            this.btncheckotp.Location = new System.Drawing.Point(307, 16);
            this.btncheckotp.Name = "btncheckotp";
            this.btncheckotp.Size = new System.Drawing.Size(87, 25);
            this.btncheckotp.TabIndex = 14;
            this.btncheckotp.Text = "Check OTP";
            this.btncheckotp.Click += new System.EventHandler(this.btncheckotp_Click);
            // 
            // txtBox_OTP
            // 
            this.txtBox_OTP.Location = new System.Drawing.Point(92, 16);
            this.txtBox_OTP.Name = "txtBox_OTP";
            this.txtBox_OTP.PasswordChar = '●';
            this.txtBox_OTP.Size = new System.Drawing.Size(201, 23);
            this.txtBox_OTP.TabIndex = 9;
            this.txtBox_OTP.UseSystemPasswordChar = true;
            // 
            // newgroup
            // 
            this.newgroup.BackColor = System.Drawing.Color.White;
            this.newgroup.Controls.Add(this.Btn_Forgot_Reset_Pass);
            this.newgroup.Controls.Add(this.TxtBox_NEw_Pass);
            this.newgroup.Controls.Add(this.metroLabel2);
            this.newgroup.Location = new System.Drawing.Point(19, 112);
            this.newgroup.Name = "newgroup";
            this.newgroup.Size = new System.Drawing.Size(434, 59);
            this.newgroup.TabIndex = 15;
            this.newgroup.TabStop = false;
            this.newgroup.Text = "New Password";
            this.newgroup.Visible = false;
            // 
            // Btn_Forgot_Reset_Pass
            // 
            this.Btn_Forgot_Reset_Pass.Location = new System.Drawing.Point(336, 19);
            this.Btn_Forgot_Reset_Pass.Name = "Btn_Forgot_Reset_Pass";
            this.Btn_Forgot_Reset_Pass.Size = new System.Drawing.Size(92, 22);
            this.Btn_Forgot_Reset_Pass.TabIndex = 12;
            this.Btn_Forgot_Reset_Pass.Text = "Reset Password";
            this.Btn_Forgot_Reset_Pass.Click += new System.EventHandler(this.Btn_Forgot_Reset_Pass_Click);
            // 
            // TxtBox_NEw_Pass
            // 
            this.TxtBox_NEw_Pass.Location = new System.Drawing.Point(123, 16);
            this.TxtBox_NEw_Pass.Name = "TxtBox_NEw_Pass";
            this.TxtBox_NEw_Pass.PasswordChar = '●';
            this.TxtBox_NEw_Pass.Size = new System.Drawing.Size(201, 23);
            this.TxtBox_NEw_Pass.TabIndex = 11;
            this.TxtBox_NEw_Pass.UseSystemPasswordChar = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(2, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "New Password :";
            // 
            // Btn_OTP_OK
            // 
            this.Btn_OTP_OK.Location = new System.Drawing.Point(355, 12);
            this.Btn_OTP_OK.Name = "Btn_OTP_OK";
            this.Btn_OTP_OK.Size = new System.Drawing.Size(87, 27);
            this.Btn_OTP_OK.TabIndex = 13;
            this.Btn_OTP_OK.Text = "SEND OTP";
            this.Btn_OTP_OK.Click += new System.EventHandler(this.Btn_OTP_OK_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Admin_Panel.Properties.Resources.reset_password;
            this.pictureBox2.Location = new System.Drawing.Point(459, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // txtbox_Email_Forgot
            // 
            this.txtbox_Email_Forgot.Location = new System.Drawing.Point(140, 13);
            this.txtbox_Email_Forgot.Name = "txtbox_Email_Forgot";
            this.txtbox_Email_Forgot.Size = new System.Drawing.Size(201, 23);
            this.txtbox_Email_Forgot.TabIndex = 6;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(70, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Email ID : ";
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.CustomForeColor = true;
            this.Label_Login.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_Login.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Label_Login.ForeColor = System.Drawing.Color.Firebrick;
            this.Label_Login.Location = new System.Drawing.Point(7, 21);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(319, 25);
            this.Label_Login.Style = MetroFramework.MetroColorStyle.Green;
            this.Label_Login.TabIndex = 1;
            this.Label_Login.Text = "Welcome to Admin Panel - INGRESS";
            this.Label_Login.UseStyleColors = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::Admin_Panel.Properties.Resources.INGRESS_FINAL_LOGO;
            this.pictureBox3.Location = new System.Drawing.Point(339, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(242, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 284);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Label_Login);
            this.Controls.Add(this.TabControl_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.TabControl_Login.ResumeLayout(false);
            this.TabPage_Login.ResumeLayout(false);
            this.TabPage_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabPage_Forgot.ResumeLayout(false);
            this.TabPage_Forgot.PerformLayout();
            this.OTPgroup.ResumeLayout(false);
            this.OTPgroup.PerformLayout();
            this.newgroup.ResumeLayout(false);
            this.newgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl_Login;
        private MetroFramework.Controls.MetroTabPage TabPage_Login;
        private MetroFramework.Controls.MetroTabPage TabPage_Forgot;
        private MetroFramework.Controls.MetroLabel Label_Login;
        private MetroFramework.Controls.MetroLabel lbl_email;
        private MetroFramework.Controls.MetroLabel lbl_pass;
        private MetroFramework.Controls.MetroTextBox txtbox_Email;
        private MetroFramework.Controls.MetroTextBox txtbox_Password;
        private MetroFramework.Controls.MetroButton Btn_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox txtbox_Email_Forgot;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbl_OTP;
        private MetroFramework.Controls.MetroTextBox txtBox_OTP;
        private MetroFramework.Controls.MetroButton Btn_Forgot_Reset_Pass;
        private MetroFramework.Controls.MetroTextBox TxtBox_NEw_Pass;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton Btn_OTP_OK;
        private MetroFramework.Controls.MetroButton btncheckotp;
        private System.Windows.Forms.GroupBox newgroup;
        private System.Windows.Forms.GroupBox OTPgroup;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

