namespace User_Management_System
{
    partial class UserLogin
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
            this.btnLogout_User = new System.Windows.Forms.Button();
            this.label_welcome_user = new System.Windows.Forms.Label();
            this.tabControl_user = new System.Windows.Forms.TabControl();
            this.tabPage_User = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxUpdateSA = new System.Windows.Forms.TextBox();
            this.txtBoxUpdateSQ = new System.Windows.Forms.TextBox();
            this.txtBoxUpdateAdd = new System.Windows.Forms.TextBox();
            this.txtBoxUpdateFullname = new System.Windows.Forms.TextBox();
            this.txtBoxUpdatePass = new System.Windows.Forms.TextBox();
            this.txtBoxUpdateUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_SecretA = new System.Windows.Forms.Label();
            this.lbl_SecretQ = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.tabControl_user.SuspendLayout();
            this.tabPage_User.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout_User
            // 
            this.btnLogout_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout_User.Location = new System.Drawing.Point(795, 2);
            this.btnLogout_User.Name = "btnLogout_User";
            this.btnLogout_User.Size = new System.Drawing.Size(75, 28);
            this.btnLogout_User.TabIndex = 1;
            this.btnLogout_User.Text = "Logout";
            this.btnLogout_User.UseVisualStyleBackColor = true;
            this.btnLogout_User.Click += new System.EventHandler(this.btnLogout_User_Click);
            // 
            // label_welcome_user
            // 
            this.label_welcome_user.AutoSize = true;
            this.label_welcome_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome_user.Location = new System.Drawing.Point(341, 5);
            this.label_welcome_user.Name = "label_welcome_user";
            this.label_welcome_user.Size = new System.Drawing.Size(147, 24);
            this.label_welcome_user.TabIndex = 2;
            this.label_welcome_user.Text = "Welcome User";
            // 
            // tabControl_user
            // 
            this.tabControl_user.Controls.Add(this.tabPage_User);
            this.tabControl_user.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl_user.Location = new System.Drawing.Point(0, 12);
            this.tabControl_user.Name = "tabControl_user";
            this.tabControl_user.SelectedIndex = 0;
            this.tabControl_user.Size = new System.Drawing.Size(876, 371);
            this.tabControl_user.TabIndex = 3;
            // 
            // tabPage_User
            // 
            this.tabPage_User.Controls.Add(this.groupBox2);
            this.tabPage_User.Controls.Add(this.groupBox1);
            this.tabPage_User.Controls.Add(this.pictureBox_user);
            this.tabPage_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_User.Location = new System.Drawing.Point(4, 22);
            this.tabPage_User.Name = "tabPage_User";
            this.tabPage_User.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_User.Size = new System.Drawing.Size(868, 345);
            this.tabPage_User.TabIndex = 1;
            this.tabPage_User.Text = "EDIT/VIEW PROFILE";
            this.tabPage_User.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(131, 291);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(111, 289);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtBoxUpdateSA);
            this.groupBox2.Controls.Add(this.txtBoxUpdateSQ);
            this.groupBox2.Controls.Add(this.txtBoxUpdateAdd);
            this.groupBox2.Controls.Add(this.txtBoxUpdateFullname);
            this.groupBox2.Controls.Add(this.txtBoxUpdatePass);
            this.groupBox2.Controls.Add(this.txtBoxUpdateUser);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(341, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 318);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Details";
            // 
            // txtBoxUpdateSA
            // 
            this.txtBoxUpdateSA.Location = new System.Drawing.Point(99, 265);
            this.txtBoxUpdateSA.Name = "txtBoxUpdateSA";
            this.txtBoxUpdateSA.Size = new System.Drawing.Size(197, 20);
            this.txtBoxUpdateSA.TabIndex = 12;
            // 
            // txtBoxUpdateSQ
            // 
            this.txtBoxUpdateSQ.Location = new System.Drawing.Point(99, 231);
            this.txtBoxUpdateSQ.Name = "txtBoxUpdateSQ";
            this.txtBoxUpdateSQ.Size = new System.Drawing.Size(197, 20);
            this.txtBoxUpdateSQ.TabIndex = 11;
            // 
            // txtBoxUpdateAdd
            // 
            this.txtBoxUpdateAdd.Location = new System.Drawing.Point(99, 133);
            this.txtBoxUpdateAdd.Multiline = true;
            this.txtBoxUpdateAdd.Name = "txtBoxUpdateAdd";
            this.txtBoxUpdateAdd.Size = new System.Drawing.Size(197, 86);
            this.txtBoxUpdateAdd.TabIndex = 10;
            // 
            // txtBoxUpdateFullname
            // 
            this.txtBoxUpdateFullname.Location = new System.Drawing.Point(99, 94);
            this.txtBoxUpdateFullname.Name = "txtBoxUpdateFullname";
            this.txtBoxUpdateFullname.Size = new System.Drawing.Size(197, 20);
            this.txtBoxUpdateFullname.TabIndex = 9;
            // 
            // txtBoxUpdatePass
            // 
            this.txtBoxUpdatePass.Location = new System.Drawing.Point(99, 61);
            this.txtBoxUpdatePass.Name = "txtBoxUpdatePass";
            this.txtBoxUpdatePass.Size = new System.Drawing.Size(197, 20);
            this.txtBoxUpdatePass.TabIndex = 8;
            // 
            // txtBoxUpdateUser
            // 
            this.txtBoxUpdateUser.Location = new System.Drawing.Point(99, 24);
            this.txtBoxUpdateUser.Name = "txtBoxUpdateUser";
            this.txtBoxUpdateUser.ReadOnly = true;
            this.txtBoxUpdateUser.Size = new System.Drawing.Size(197, 20);
            this.txtBoxUpdateUser.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Secret A :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Secret Q :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Full name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Username :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_SecretA);
            this.groupBox1.Controls.Add(this.lbl_SecretQ);
            this.groupBox1.Controls.Add(this.lbl_address);
            this.groupBox1.Controls.Add(this.lbl_fullname);
            this.groupBox1.Controls.Add(this.lbl_username);
            this.groupBox1.Location = new System.Drawing.Point(8, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 318);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(108, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "NULL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(108, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "NULL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(108, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "NULL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(108, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "NULL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "NULL";
            // 
            // lbl_SecretA
            // 
            this.lbl_SecretA.AutoSize = true;
            this.lbl_SecretA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SecretA.Location = new System.Drawing.Point(6, 235);
            this.lbl_SecretA.Name = "lbl_SecretA";
            this.lbl_SecretA.Size = new System.Drawing.Size(75, 16);
            this.lbl_SecretA.TabIndex = 6;
            this.lbl_SecretA.Text = "Secret A :";
            // 
            // lbl_SecretQ
            // 
            this.lbl_SecretQ.AutoSize = true;
            this.lbl_SecretQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SecretQ.Location = new System.Drawing.Point(6, 200);
            this.lbl_SecretQ.Name = "lbl_SecretQ";
            this.lbl_SecretQ.Size = new System.Drawing.Size(76, 16);
            this.lbl_SecretQ.TabIndex = 5;
            this.lbl_SecretQ.Text = "Secret Q :";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(7, 102);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(74, 16);
            this.lbl_address.TabIndex = 4;
            this.lbl_address.Text = "Address :";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.Location = new System.Drawing.Point(6, 63);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(83, 16);
            this.lbl_fullname.TabIndex = 3;
            this.lbl_fullname.Text = "Full name :";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(6, 25);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(87, 16);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username :";
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_user.Location = new System.Drawing.Point(676, 6);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(164, 139);
            this.pictureBox_user.TabIndex = 0;
            this.pictureBox_user.TabStop = false;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(876, 383);
            this.Controls.Add(this.label_welcome_user);
            this.Controls.Add(this.btnLogout_User);
            this.Controls.Add(this.tabControl_user);
            this.MaximizeBox = false;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogin Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserLogin_FormClosed);
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.tabControl_user.ResumeLayout(false);
            this.tabPage_User.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout_User;
        private System.Windows.Forms.Label label_welcome_user;
        private System.Windows.Forms.TabControl tabControl_user;
        private System.Windows.Forms.TabPage tabPage_User;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_SecretQ;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_SecretA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxUpdateSA;
        private System.Windows.Forms.TextBox txtBoxUpdateSQ;
        private System.Windows.Forms.TextBox txtBoxUpdateAdd;
        private System.Windows.Forms.TextBox txtBoxUpdateFullname;
        private System.Windows.Forms.TextBox txtBoxUpdatePass;
        private System.Windows.Forms.TextBox txtBoxUpdateUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}