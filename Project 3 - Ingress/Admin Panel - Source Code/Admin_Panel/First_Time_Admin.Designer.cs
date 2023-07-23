namespace Admin_Panel
{
    partial class First_Time_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First_Time_Admin));
            this.Label_First_Time = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Txtbox_FirstTIme_Email = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Register = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_First_Time
            // 
            this.Label_First_Time.AutoSize = true;
            this.Label_First_Time.CustomForeColor = true;
            this.Label_First_Time.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_First_Time.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Label_First_Time.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Label_First_Time.Location = new System.Drawing.Point(32, 9);
            this.Label_First_Time.Name = "Label_First_Time";
            this.Label_First_Time.Size = new System.Drawing.Size(351, 25);
            this.Label_First_Time.TabIndex = 0;
            this.Label_First_Time.Text = "Registration for Admin - One Time Only";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Email ID : ";
            // 
            // Txtbox_FirstTIme_Email
            // 
            this.Txtbox_FirstTIme_Email.Location = new System.Drawing.Point(87, 79);
            this.Txtbox_FirstTIme_Email.Name = "Txtbox_FirstTIme_Email";
            this.Txtbox_FirstTIme_Email.Size = new System.Drawing.Size(281, 23);
            this.Txtbox_FirstTIme_Email.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Admin_Panel.Properties.Resources.add_new_user_icon_88409;
            this.pictureBox1.Location = new System.Drawing.Point(389, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(87, 117);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '●';
            this.metroTextBox1.Size = new System.Drawing.Size(281, 23);
            this.metroTextBox1.TabIndex = 5;
            this.metroTextBox1.UseSystemPasswordChar = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Password :";
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(170, 161);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(125, 30);
            this.Register.Style = MetroFramework.MetroColorStyle.Black;
            this.Register.TabIndex = 6;
            this.Register.Text = "REGISTER";
            this.Register.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // First_Time_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 223);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txtbox_FirstTIme_Email);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Label_First_Time);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "First_Time_Admin";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.First_Time_Admin_FormClosing);
            this.Load += new System.EventHandler(this.First_Time_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Label_First_Time;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Txtbox_FirstTIme_Email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton Register;
    }
}