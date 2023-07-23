namespace Finance_Management_System
{
    partial class Finance_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finance_Login));
            this.mtrLbl_User = new MetroFramework.Controls.MetroLabel();
            this.mtr_Lbl_Pass = new MetroFramework.Controls.MetroLabel();
            this.mtr_txtbox_User = new MetroFramework.Controls.MetroTextBox();
            this.mtr_TxtBox_Pass = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox_Login_Lock = new System.Windows.Forms.PictureBox();
            this.mtr_Btn_Login = new MetroFramework.Controls.MetroButton();
            this.metroLabel_FMSTITLE = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_Credits = new MetroFramework.Controls.MetroLabel();
            this.lbl_Frogot_admin = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login_Lock)).BeginInit();
            this.SuspendLayout();
            // 
            // mtrLbl_User
            // 
            this.mtrLbl_User.AutoSize = true;
            this.mtrLbl_User.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mtrLbl_User.Location = new System.Drawing.Point(65, 60);
            this.mtrLbl_User.Name = "mtrLbl_User";
            this.mtrLbl_User.Size = new System.Drawing.Size(84, 19);
            this.mtrLbl_User.TabIndex = 0;
            this.mtrLbl_User.Text = "Username :";
            // 
            // mtr_Lbl_Pass
            // 
            this.mtr_Lbl_Pass.AutoSize = true;
            this.mtr_Lbl_Pass.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mtr_Lbl_Pass.Location = new System.Drawing.Point(65, 99);
            this.mtr_Lbl_Pass.Name = "mtr_Lbl_Pass";
            this.mtr_Lbl_Pass.Size = new System.Drawing.Size(81, 19);
            this.mtr_Lbl_Pass.TabIndex = 1;
            this.mtr_Lbl_Pass.Text = "Password :";
            // 
            // mtr_txtbox_User
            // 
            this.mtr_txtbox_User.Location = new System.Drawing.Point(155, 60);
            this.mtr_txtbox_User.Name = "mtr_txtbox_User";
            this.mtr_txtbox_User.Size = new System.Drawing.Size(183, 23);
            this.mtr_txtbox_User.TabIndex = 2;
            // 
            // mtr_TxtBox_Pass
            // 
            this.mtr_TxtBox_Pass.Location = new System.Drawing.Point(155, 99);
            this.mtr_TxtBox_Pass.Name = "mtr_TxtBox_Pass";
            this.mtr_TxtBox_Pass.PasswordChar = '●';
            this.mtr_TxtBox_Pass.Size = new System.Drawing.Size(183, 23);
            this.mtr_TxtBox_Pass.TabIndex = 3;
            this.mtr_TxtBox_Pass.UseSystemPasswordChar = true;
            // 
            // pictureBox_Login_Lock
            // 
            this.pictureBox_Login_Lock.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Login_Lock.Image")));
            this.pictureBox_Login_Lock.Location = new System.Drawing.Point(374, 19);
            this.pictureBox_Login_Lock.Name = "pictureBox_Login_Lock";
            this.pictureBox_Login_Lock.Size = new System.Drawing.Size(149, 151);
            this.pictureBox_Login_Lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Login_Lock.TabIndex = 4;
            this.pictureBox_Login_Lock.TabStop = false;
            // 
            // mtr_Btn_Login
            // 
            this.mtr_Btn_Login.Location = new System.Drawing.Point(189, 153);
            this.mtr_Btn_Login.Name = "mtr_Btn_Login";
            this.mtr_Btn_Login.Size = new System.Drawing.Size(104, 33);
            this.mtr_Btn_Login.TabIndex = 5;
            this.mtr_Btn_Login.Text = "Login";
            this.mtr_Btn_Login.Click += new System.EventHandler(this.mtr_Btn_Login_Click);
            // 
            // metroLabel_FMSTITLE
            // 
            this.metroLabel_FMSTITLE.AutoSize = true;
            this.metroLabel_FMSTITLE.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel_FMSTITLE.Location = new System.Drawing.Point(65, 19);
            this.metroLabel_FMSTITLE.Name = "metroLabel_FMSTITLE";
            this.metroLabel_FMSTITLE.Size = new System.Drawing.Size(290, 19);
            this.metroLabel_FMSTITLE.TabIndex = 6;
            this.metroLabel_FMSTITLE.Text = "Welcome To Finance Management System";
            // 
            // metroLabel_Credits
            // 
            this.metroLabel_Credits.AutoSize = true;
            this.metroLabel_Credits.Location = new System.Drawing.Point(317, 226);
            this.metroLabel_Credits.Name = "metroLabel_Credits";
            this.metroLabel_Credits.Size = new System.Drawing.Size(216, 19);
            this.metroLabel_Credits.TabIndex = 7;
            this.metroLabel_Credits.Text = "Credits :- Monish Soni | Amee Patel";
            // 
            // lbl_Frogot_admin
            // 
            this.lbl_Frogot_admin.AutoSize = true;
            this.lbl_Frogot_admin.Location = new System.Drawing.Point(221, 125);
            this.lbl_Frogot_admin.Name = "lbl_Frogot_admin";
            this.lbl_Frogot_admin.Size = new System.Drawing.Size(117, 19);
            this.lbl_Frogot_admin.TabIndex = 8;
            this.lbl_Frogot_admin.Text = "Forgot Password ?";
            this.lbl_Frogot_admin.Click += new System.EventHandler(this.lbl_Frogot_admin_Click);
            this.lbl_Frogot_admin.MouseHover += new System.EventHandler(this.lbl_Frogot_admin_MouseHover);
            // 
            // Finance_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 248);
            this.Controls.Add(this.lbl_Frogot_admin);
            this.Controls.Add(this.metroLabel_Credits);
            this.Controls.Add(this.metroLabel_FMSTITLE);
            this.Controls.Add(this.mtr_Btn_Login);
            this.Controls.Add(this.pictureBox_Login_Lock);
            this.Controls.Add(this.mtr_TxtBox_Pass);
            this.Controls.Add(this.mtr_txtbox_User);
            this.Controls.Add(this.mtr_Lbl_Pass);
            this.Controls.Add(this.mtrLbl_User);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Finance_Login";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login_Lock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mtrLbl_User;
        private MetroFramework.Controls.MetroLabel mtr_Lbl_Pass;
        private MetroFramework.Controls.MetroTextBox mtr_txtbox_User;
        private MetroFramework.Controls.MetroTextBox mtr_TxtBox_Pass;
        private System.Windows.Forms.PictureBox pictureBox_Login_Lock;
        private MetroFramework.Controls.MetroButton mtr_Btn_Login;
        private MetroFramework.Controls.MetroLabel metroLabel_FMSTITLE;
        private MetroFramework.Controls.MetroLabel metroLabel_Credits;
        private MetroFramework.Controls.MetroLabel lbl_Frogot_admin;
    }
}

