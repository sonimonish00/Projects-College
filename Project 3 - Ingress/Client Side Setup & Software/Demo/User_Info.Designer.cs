namespace Demo
{
    partial class User_Info
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Logs = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblenroll = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastlogs = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Btnshutdown = new MaterialSkin.Controls.MaterialFlatButton();
            this.edit = new System.Windows.Forms.TabPage();
            this.txtenroll = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtoldpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnchange = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtnewpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.Logs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastlogs)).BeginInit();
            this.edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 30);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1381, 52);
            this.materialTabSelector1.TabIndex = 23;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.Logs);
            this.materialTabControl1.Controls.Add(this.edit);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 80);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1287, 1104);
            this.materialTabControl1.TabIndex = 24;
            // 
            // Logs
            // 
            this.Logs.BackColor = System.Drawing.Color.White;
            this.Logs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logs.Controls.Add(this.materialRaisedButton2);
            this.Logs.Controls.Add(this.label3);
            this.Logs.Controls.Add(this.lblname);
            this.Logs.Controls.Add(this.lblenroll);
            this.Logs.Controls.Add(this.label1);
            this.Logs.Controls.Add(this.label2);
            this.Logs.Controls.Add(this.lastlogs);
            this.Logs.Controls.Add(this.label4);
            this.Logs.Controls.Add(this.Btnshutdown);
            this.Logs.Location = new System.Drawing.Point(4, 22);
            this.Logs.Name = "Logs";
            this.Logs.Padding = new System.Windows.Forms.Padding(3);
            this.Logs.Size = new System.Drawing.Size(1279, 1078);
            this.Logs.TabIndex = 0;
            this.Logs.Text = "Logs";
            this.Logs.Click += new System.EventHandler(this.Logs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Your last five logs";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(633, 223);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(60, 24);
            this.lblname.TabIndex = 30;
            this.lblname.Text = "label3";
            // 
            // lblenroll
            // 
            this.lblenroll.AutoSize = true;
            this.lblenroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenroll.Location = new System.Drawing.Point(633, 180);
            this.lblenroll.Name = "lblenroll";
            this.lblenroll.Size = new System.Drawing.Size(76, 24);
            this.lblenroll.TabIndex = 29;
            this.lblenroll.Text = "lblenroll";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Enrollment Number :-";
            // 
            // lastlogs
            // 
            this.lastlogs.ColumnHeadersHeight = 28;
            this.lastlogs.Location = new System.Drawing.Point(346, 307);
            this.lastlogs.MinimumSize = new System.Drawing.Size(40, 40);
            this.lastlogs.Name = "lastlogs";
            this.lastlogs.RowHeadersWidth = 51;
            this.lastlogs.Size = new System.Drawing.Size(550, 180);
            this.lastlogs.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 31);
            this.label4.TabIndex = 24;
            this.label4.Text = "Welcome to your profile";
            // 
            // Btnshutdown
            // 
            this.Btnshutdown.AutoSize = true;
            this.Btnshutdown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btnshutdown.Depth = 0;
            this.Btnshutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnshutdown.Location = new System.Drawing.Point(1149, 6);
            this.Btnshutdown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btnshutdown.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btnshutdown.Name = "Btnshutdown";
            this.Btnshutdown.Primary = false;
            this.Btnshutdown.Size = new System.Drawing.Size(91, 36);
            this.Btnshutdown.TabIndex = 23;
            this.Btnshutdown.Text = "Shut down";
            this.Btnshutdown.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.White;
            this.edit.Controls.Add(this.txtnewpass);
            this.edit.Controls.Add(this.materialLabel1);
            this.edit.Controls.Add(this.materialRaisedButton1);
            this.edit.Controls.Add(this.txtenroll);
            this.edit.Controls.Add(this.materialLabel4);
            this.edit.Controls.Add(this.txtoldpass);
            this.edit.Controls.Add(this.btnchange);
            this.edit.Controls.Add(this.materialLabel5);
            this.edit.Controls.Add(this.label6);
            this.edit.Controls.Add(this.pictureBox2);
            this.edit.Controls.Add(this.materialFlatButton1);
            this.edit.Controls.Add(this.materialLabel6);
            this.edit.Location = new System.Drawing.Point(4, 22);
            this.edit.Name = "edit";
            this.edit.Padding = new System.Windows.Forms.Padding(3);
            this.edit.Size = new System.Drawing.Size(1279, 1078);
            this.edit.TabIndex = 1;
            this.edit.Text = "Edit Profile";
            // 
            // txtenroll
            // 
            this.txtenroll.Depth = 0;
            this.txtenroll.Enabled = false;
            this.txtenroll.Hint = "Number";
            this.txtenroll.Location = new System.Drawing.Point(520, 247);
            this.txtenroll.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtenroll.Name = "txtenroll";
            this.txtenroll.PasswordChar = '\0';
            this.txtenroll.SelectedText = "";
            this.txtenroll.SelectionLength = 0;
            this.txtenroll.SelectionStart = 0;
            this.txtenroll.Size = new System.Drawing.Size(419, 23);
            this.txtenroll.TabIndex = 28;
            this.txtenroll.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(343, 251);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(139, 19);
            this.materialLabel4.TabIndex = 29;
            this.materialLabel4.Text = "Enrollment Number";
            // 
            // txtoldpass
            // 
            this.txtoldpass.Depth = 0;
            this.txtoldpass.Hint = "Old Password";
            this.txtoldpass.Location = new System.Drawing.Point(520, 288);
            this.txtoldpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtoldpass.Name = "txtoldpass";
            this.txtoldpass.PasswordChar = '*';
            this.txtoldpass.SelectedText = "";
            this.txtoldpass.SelectionLength = 0;
            this.txtoldpass.SelectionStart = 0;
            this.txtoldpass.Size = new System.Drawing.Size(419, 23);
            this.txtoldpass.TabIndex = 30;
            this.txtoldpass.UseSystemPasswordChar = false;
            // 
            // btnchange
            // 
            this.btnchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchange.Depth = 0;
            this.btnchange.Location = new System.Drawing.Point(520, 418);
            this.btnchange.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnchange.Name = "btnchange";
            this.btnchange.Primary = true;
            this.btnchange.Size = new System.Drawing.Size(152, 46);
            this.btnchange.TabIndex = 33;
            this.btnchange.Text = "Change Password";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(381, 292);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(101, 19);
            this.materialLabel5.TabIndex = 31;
            this.materialLabel5.Text = "Old Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 31);
            this.label6.TabIndex = 32;
            this.label6.Text = "Edit Your Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Demo.Properties.Resources.GPERI_LOGO;
            this.pictureBox2.Location = new System.Drawing.Point(89, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialFlatButton1.Location = new System.Drawing.Point(1151, 6);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(91, 36);
            this.materialFlatButton1.TabIndex = 24;
            this.materialFlatButton1.Text = "Shut down";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(397, 350);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(0, 19);
            this.materialLabel6.TabIndex = 5;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = null;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(-11, -19);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(1311, 59);
            this.materialTabSelector2.TabIndex = 25;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(9, 6);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(118, 57);
            this.materialRaisedButton1.TabIndex = 35;
            this.materialRaisedButton1.Text = "Open Windows";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(9, 6);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(116, 58);
            this.materialRaisedButton2.TabIndex = 32;
            this.materialRaisedButton2.Text = "Open Windows";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // txtnewpass
            // 
            this.txtnewpass.Depth = 0;
            this.txtnewpass.Hint = "New Password";
            this.txtnewpass.Location = new System.Drawing.Point(520, 331);
            this.txtnewpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.PasswordChar = '*';
            this.txtnewpass.SelectedText = "";
            this.txtnewpass.SelectionLength = 0;
            this.txtnewpass.SelectionStart = 0;
            this.txtnewpass.Size = new System.Drawing.Size(419, 23);
            this.txtnewpass.TabIndex = 36;
            this.txtnewpass.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(373, 335);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 19);
            this.materialLabel1.TabIndex = 37;
            this.materialLabel1.Text = "New Password";
            // 
            // User_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 805);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Info";
            this.ShowIcon = false;
            this.Text = "User Info";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.User_Info_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.Logs.ResumeLayout(false);
            this.Logs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastlogs)).EndInit();
            this.edit.ResumeLayout(false);
            this.edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Logs;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialFlatButton Btnshutdown;
        private System.Windows.Forms.TabPage edit;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtenroll;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtoldpass;
        private MaterialSkin.Controls.MaterialRaisedButton btnchange;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private System.Windows.Forms.DataGridView lastlogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblenroll;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnewpass;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}