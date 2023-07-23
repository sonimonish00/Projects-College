namespace User_Management_System
{
    partial class AdminLogin
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
            this.btnLogout_Admin = new System.Windows.Forms.Button();
            this.label_welcome_admin = new System.Windows.Forms.Label();
            this.tabControl_admin = new System.Windows.Forms.TabControl();
            this.tabpage_create = new System.Windows.Forms.TabPage();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.txtBox_signup_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_signup_SA = new System.Windows.Forms.TextBox();
            this.txtBox_signup_SQ = new System.Windows.Forms.TextBox();
            this.txtBox_signup_Add = new System.Windows.Forms.TextBox();
            this.txtBox_signup_fullname = new System.Windows.Forms.TextBox();
            this.txtBox_signup_username = new System.Windows.Forms.TextBox();
            this.lbl_Signup_SA = new System.Windows.Forms.Label();
            this.lbl_Signup_SQ = new System.Windows.Forms.Label();
            this.lbl_Signup_Address = new System.Windows.Forms.Label();
            this.lbl_Signup_FullName = new System.Windows.Forms.Label();
            this.lbl_Signup_Name = new System.Windows.Forms.Label();
            this.tabpage_delete = new System.Windows.Forms.TabPage();
            this.txtboxUserDelete = new System.Windows.Forms.TextBox();
            this.lblDeleteUsername = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabPage_Update = new System.Windows.Forms.TabPage();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.txtBoxUpdatePass = new System.Windows.Forms.TextBox();
            this.txtBoxUpdateUser = new System.Windows.Forms.TextBox();
            this.lbl_Pass_Update = new System.Windows.Forms.Label();
            this.lblUser_Update = new System.Windows.Forms.Label();
            this.tabControl_admin.SuspendLayout();
            this.tabpage_create.SuspendLayout();
            this.tabpage_delete.SuspendLayout();
            this.tabPage_Update.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout_Admin
            // 
            this.btnLogout_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout_Admin.Location = new System.Drawing.Point(827, 5);
            this.btnLogout_Admin.Name = "btnLogout_Admin";
            this.btnLogout_Admin.Size = new System.Drawing.Size(75, 28);
            this.btnLogout_Admin.TabIndex = 0;
            this.btnLogout_Admin.Text = "Logout";
            this.btnLogout_Admin.UseVisualStyleBackColor = true;
            this.btnLogout_Admin.Click += new System.EventHandler(this.btnLogout_Admin_Click);
            // 
            // label_welcome_admin
            // 
            this.label_welcome_admin.AutoSize = true;
            this.label_welcome_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome_admin.Location = new System.Drawing.Point(332, 5);
            this.label_welcome_admin.Name = "label_welcome_admin";
            this.label_welcome_admin.Size = new System.Drawing.Size(164, 24);
            this.label_welcome_admin.TabIndex = 1;
            this.label_welcome_admin.Text = "Welcome Admin";
            // 
            // tabControl_admin
            // 
            this.tabControl_admin.Controls.Add(this.tabpage_create);
            this.tabControl_admin.Controls.Add(this.tabpage_delete);
            this.tabControl_admin.Controls.Add(this.tabPage_Update);
            this.tabControl_admin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_admin.Location = new System.Drawing.Point(0, 12);
            this.tabControl_admin.Name = "tabControl_admin";
            this.tabControl_admin.SelectedIndex = 0;
            this.tabControl_admin.Size = new System.Drawing.Size(914, 364);
            this.tabControl_admin.TabIndex = 2;
            // 
            // tabpage_create
            // 
            this.tabpage_create.Controls.Add(this.btnCreateUser);
            this.tabpage_create.Controls.Add(this.txtBox_signup_pass);
            this.tabpage_create.Controls.Add(this.label1);
            this.tabpage_create.Controls.Add(this.txtBox_signup_SA);
            this.tabpage_create.Controls.Add(this.txtBox_signup_SQ);
            this.tabpage_create.Controls.Add(this.txtBox_signup_Add);
            this.tabpage_create.Controls.Add(this.txtBox_signup_fullname);
            this.tabpage_create.Controls.Add(this.txtBox_signup_username);
            this.tabpage_create.Controls.Add(this.lbl_Signup_SA);
            this.tabpage_create.Controls.Add(this.lbl_Signup_SQ);
            this.tabpage_create.Controls.Add(this.lbl_Signup_Address);
            this.tabpage_create.Controls.Add(this.lbl_Signup_FullName);
            this.tabpage_create.Controls.Add(this.lbl_Signup_Name);
            this.tabpage_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpage_create.Location = new System.Drawing.Point(4, 22);
            this.tabpage_create.Name = "tabpage_create";
            this.tabpage_create.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_create.Size = new System.Drawing.Size(906, 338);
            this.tabpage_create.TabIndex = 0;
            this.tabpage_create.Text = "Create";
            this.tabpage_create.UseVisualStyleBackColor = true;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(475, 292);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(98, 38);
            this.btnCreateUser.TabIndex = 31;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // txtBox_signup_pass
            // 
            this.txtBox_signup_pass.BackColor = System.Drawing.SystemColors.Info;
            this.txtBox_signup_pass.ForeColor = System.Drawing.Color.Black;
            this.txtBox_signup_pass.Location = new System.Drawing.Point(406, 99);
            this.txtBox_signup_pass.Name = "txtBox_signup_pass";
            this.txtBox_signup_pass.Size = new System.Drawing.Size(294, 20);
            this.txtBox_signup_pass.TabIndex = 28;
            this.txtBox_signup_pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(278, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Password :";
            // 
            // txtBox_signup_SA
            // 
            this.txtBox_signup_SA.BackColor = System.Drawing.SystemColors.Info;
            this.txtBox_signup_SA.ForeColor = System.Drawing.Color.Black;
            this.txtBox_signup_SA.Location = new System.Drawing.Point(405, 263);
            this.txtBox_signup_SA.Name = "txtBox_signup_SA";
            this.txtBox_signup_SA.Size = new System.Drawing.Size(294, 20);
            this.txtBox_signup_SA.TabIndex = 26;
            // 
            // txtBox_signup_SQ
            // 
            this.txtBox_signup_SQ.BackColor = System.Drawing.SystemColors.Info;
            this.txtBox_signup_SQ.ForeColor = System.Drawing.Color.Black;
            this.txtBox_signup_SQ.Location = new System.Drawing.Point(405, 228);
            this.txtBox_signup_SQ.Name = "txtBox_signup_SQ";
            this.txtBox_signup_SQ.Size = new System.Drawing.Size(294, 20);
            this.txtBox_signup_SQ.TabIndex = 25;
            // 
            // txtBox_signup_Add
            // 
            this.txtBox_signup_Add.BackColor = System.Drawing.SystemColors.Info;
            this.txtBox_signup_Add.ForeColor = System.Drawing.Color.Black;
            this.txtBox_signup_Add.Location = new System.Drawing.Point(405, 136);
            this.txtBox_signup_Add.Multiline = true;
            this.txtBox_signup_Add.Name = "txtBox_signup_Add";
            this.txtBox_signup_Add.Size = new System.Drawing.Size(294, 86);
            this.txtBox_signup_Add.TabIndex = 24;
            // 
            // txtBox_signup_fullname
            // 
            this.txtBox_signup_fullname.BackColor = System.Drawing.SystemColors.Info;
            this.txtBox_signup_fullname.ForeColor = System.Drawing.Color.Black;
            this.txtBox_signup_fullname.Location = new System.Drawing.Point(405, 63);
            this.txtBox_signup_fullname.Name = "txtBox_signup_fullname";
            this.txtBox_signup_fullname.Size = new System.Drawing.Size(294, 20);
            this.txtBox_signup_fullname.TabIndex = 23;
            // 
            // txtBox_signup_username
            // 
            this.txtBox_signup_username.BackColor = System.Drawing.SystemColors.Info;
            this.txtBox_signup_username.ForeColor = System.Drawing.Color.Black;
            this.txtBox_signup_username.Location = new System.Drawing.Point(405, 25);
            this.txtBox_signup_username.Name = "txtBox_signup_username";
            this.txtBox_signup_username.Size = new System.Drawing.Size(294, 20);
            this.txtBox_signup_username.TabIndex = 22;
            // 
            // lbl_Signup_SA
            // 
            this.lbl_Signup_SA.AutoSize = true;
            this.lbl_Signup_SA.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Signup_SA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Signup_SA.ForeColor = System.Drawing.Color.Black;
            this.lbl_Signup_SA.Location = new System.Drawing.Point(234, 263);
            this.lbl_Signup_SA.Name = "lbl_Signup_SA";
            this.lbl_Signup_SA.Size = new System.Drawing.Size(163, 25);
            this.lbl_Signup_SA.TabIndex = 21;
            this.lbl_Signup_SA.Text = "Secret Answer :";
            // 
            // lbl_Signup_SQ
            // 
            this.lbl_Signup_SQ.AutoSize = true;
            this.lbl_Signup_SQ.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Signup_SQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Signup_SQ.ForeColor = System.Drawing.Color.Black;
            this.lbl_Signup_SQ.Location = new System.Drawing.Point(220, 223);
            this.lbl_Signup_SQ.Name = "lbl_Signup_SQ";
            this.lbl_Signup_SQ.Size = new System.Drawing.Size(178, 25);
            this.lbl_Signup_SQ.TabIndex = 20;
            this.lbl_Signup_SQ.Text = "Secret Question :";
            // 
            // lbl_Signup_Address
            // 
            this.lbl_Signup_Address.AutoSize = true;
            this.lbl_Signup_Address.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Signup_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Signup_Address.ForeColor = System.Drawing.Color.Black;
            this.lbl_Signup_Address.Location = new System.Drawing.Point(295, 131);
            this.lbl_Signup_Address.Name = "lbl_Signup_Address";
            this.lbl_Signup_Address.Size = new System.Drawing.Size(103, 25);
            this.lbl_Signup_Address.TabIndex = 19;
            this.lbl_Signup_Address.Text = "Address :";
            // 
            // lbl_Signup_FullName
            // 
            this.lbl_Signup_FullName.AutoSize = true;
            this.lbl_Signup_FullName.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Signup_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Signup_FullName.ForeColor = System.Drawing.Color.Black;
            this.lbl_Signup_FullName.Location = new System.Drawing.Point(277, 57);
            this.lbl_Signup_FullName.Name = "lbl_Signup_FullName";
            this.lbl_Signup_FullName.Size = new System.Drawing.Size(121, 25);
            this.lbl_Signup_FullName.TabIndex = 18;
            this.lbl_Signup_FullName.Text = "Full Name :";
            // 
            // lbl_Signup_Name
            // 
            this.lbl_Signup_Name.AutoSize = true;
            this.lbl_Signup_Name.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Signup_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Signup_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Signup_Name.Location = new System.Drawing.Point(277, 20);
            this.lbl_Signup_Name.Name = "lbl_Signup_Name";
            this.lbl_Signup_Name.Size = new System.Drawing.Size(122, 25);
            this.lbl_Signup_Name.TabIndex = 17;
            this.lbl_Signup_Name.Text = "Username :";
            // 
            // tabpage_delete
            // 
            this.tabpage_delete.Controls.Add(this.txtboxUserDelete);
            this.tabpage_delete.Controls.Add(this.lblDeleteUsername);
            this.tabpage_delete.Controls.Add(this.btnDelete);
            this.tabpage_delete.Location = new System.Drawing.Point(4, 22);
            this.tabpage_delete.Name = "tabpage_delete";
            this.tabpage_delete.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_delete.Size = new System.Drawing.Size(906, 338);
            this.tabpage_delete.TabIndex = 1;
            this.tabpage_delete.Text = "Delete";
            this.tabpage_delete.UseVisualStyleBackColor = true;
            // 
            // txtboxUserDelete
            // 
            this.txtboxUserDelete.Location = new System.Drawing.Point(402, 95);
            this.txtboxUserDelete.Name = "txtboxUserDelete";
            this.txtboxUserDelete.Size = new System.Drawing.Size(199, 20);
            this.txtboxUserDelete.TabIndex = 2;
            // 
            // lblDeleteUsername
            // 
            this.lblDeleteUsername.AutoSize = true;
            this.lblDeleteUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteUsername.Location = new System.Drawing.Point(295, 95);
            this.lblDeleteUsername.Name = "lblDeleteUsername";
            this.lblDeleteUsername.Size = new System.Drawing.Size(101, 20);
            this.lblDeleteUsername.TabIndex = 1;
            this.lblDeleteUsername.Text = "Username :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(460, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabPage_Update
            // 
            this.tabPage_Update.Controls.Add(this.btnChangePass);
            this.tabPage_Update.Controls.Add(this.txtBoxUpdatePass);
            this.tabPage_Update.Controls.Add(this.txtBoxUpdateUser);
            this.tabPage_Update.Controls.Add(this.lbl_Pass_Update);
            this.tabPage_Update.Controls.Add(this.lblUser_Update);
            this.tabPage_Update.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Update.Name = "tabPage_Update";
            this.tabPage_Update.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Update.Size = new System.Drawing.Size(906, 338);
            this.tabPage_Update.TabIndex = 2;
            this.tabPage_Update.Text = "Update";
            this.tabPage_Update.UseVisualStyleBackColor = true;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(421, 218);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(144, 23);
            this.btnChangePass.TabIndex = 13;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtBoxUpdatePass
            // 
            this.txtBoxUpdatePass.Location = new System.Drawing.Point(401, 178);
            this.txtBoxUpdatePass.Name = "txtBoxUpdatePass";
            this.txtBoxUpdatePass.Size = new System.Drawing.Size(197, 20);
            this.txtBoxUpdatePass.TabIndex = 12;
            // 
            // txtBoxUpdateUser
            // 
            this.txtBoxUpdateUser.Location = new System.Drawing.Point(401, 141);
            this.txtBoxUpdateUser.Name = "txtBoxUpdateUser";
            this.txtBoxUpdateUser.Size = new System.Drawing.Size(197, 20);
            this.txtBoxUpdateUser.TabIndex = 11;
            // 
            // lbl_Pass_Update
            // 
            this.lbl_Pass_Update.AutoSize = true;
            this.lbl_Pass_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass_Update.Location = new System.Drawing.Point(277, 182);
            this.lbl_Pass_Update.Name = "lbl_Pass_Update";
            this.lbl_Pass_Update.Size = new System.Drawing.Size(118, 16);
            this.lbl_Pass_Update.TabIndex = 10;
            this.lbl_Pass_Update.Text = "New Password :";
            // 
            // lblUser_Update
            // 
            this.lblUser_Update.AutoSize = true;
            this.lblUser_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser_Update.Location = new System.Drawing.Point(308, 142);
            this.lblUser_Update.Name = "lblUser_Update";
            this.lblUser_Update.Size = new System.Drawing.Size(87, 16);
            this.lblUser_Update.TabIndex = 9;
            this.lblUser_Update.Text = "Username :";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(914, 376);
            this.Controls.Add(this.label_welcome_admin);
            this.Controls.Add(this.btnLogout_Admin);
            this.Controls.Add(this.tabControl_admin);
            this.MaximizeBox = false;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminLogin_FormClosed);
            this.tabControl_admin.ResumeLayout(false);
            this.tabpage_create.ResumeLayout(false);
            this.tabpage_create.PerformLayout();
            this.tabpage_delete.ResumeLayout(false);
            this.tabpage_delete.PerformLayout();
            this.tabPage_Update.ResumeLayout(false);
            this.tabPage_Update.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout_Admin;
        private System.Windows.Forms.Label label_welcome_admin;
        private System.Windows.Forms.TabControl tabControl_admin;
        private System.Windows.Forms.TabPage tabpage_create;
        private System.Windows.Forms.TabPage tabpage_delete;
        private System.Windows.Forms.TabPage tabPage_Update;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.TextBox txtBox_signup_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_signup_SA;
        private System.Windows.Forms.TextBox txtBox_signup_SQ;
        private System.Windows.Forms.TextBox txtBox_signup_Add;
        private System.Windows.Forms.TextBox txtBox_signup_fullname;
        private System.Windows.Forms.TextBox txtBox_signup_username;
        private System.Windows.Forms.Label lbl_Signup_SA;
        private System.Windows.Forms.Label lbl_Signup_SQ;
        private System.Windows.Forms.Label lbl_Signup_Address;
        private System.Windows.Forms.Label lbl_Signup_FullName;
        private System.Windows.Forms.Label lbl_Signup_Name;
        private System.Windows.Forms.TextBox txtboxUserDelete;
        private System.Windows.Forms.Label lblDeleteUsername;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.TextBox txtBoxUpdatePass;
        private System.Windows.Forms.TextBox txtBoxUpdateUser;
        private System.Windows.Forms.Label lbl_Pass_Update;
        private System.Windows.Forms.Label lblUser_Update;
    }
}