namespace Finance_Management_System
{
    partial class Frogot_Pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frogot_Pass));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_Pincode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_NewPass = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_Username = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(117, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Enter Pincode: ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(78, 137);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(138, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Enter New Password : ";
            // 
            // metroTextBox_Pincode
            // 
            this.metroTextBox_Pincode.Location = new System.Drawing.Point(220, 103);
            this.metroTextBox_Pincode.Name = "metroTextBox_Pincode";
            this.metroTextBox_Pincode.PasswordChar = '●';
            this.metroTextBox_Pincode.Size = new System.Drawing.Size(183, 23);
            this.metroTextBox_Pincode.TabIndex = 2;
            this.metroTextBox_Pincode.UseSystemPasswordChar = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(150, 14);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(132, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Forgot Password ?";
            // 
            // metroTextBox_NewPass
            // 
            this.metroTextBox_NewPass.Location = new System.Drawing.Point(220, 137);
            this.metroTextBox_NewPass.Name = "metroTextBox_NewPass";
            this.metroTextBox_NewPass.PasswordChar = '●';
            this.metroTextBox_NewPass.Size = new System.Drawing.Size(183, 23);
            this.metroTextBox_NewPass.TabIndex = 4;
            this.metroTextBox_NewPass.UseSystemPasswordChar = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(177, 175);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 32);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Reset Password";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(107, 70);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(109, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Enter Username :";
            // 
            // metroTextBox_Username
            // 
            this.metroTextBox_Username.Location = new System.Drawing.Point(220, 70);
            this.metroTextBox_Username.Name = "metroTextBox_Username";
            this.metroTextBox_Username.Size = new System.Drawing.Size(183, 23);
            this.metroTextBox_Username.TabIndex = 7;
            // 
            // Frogot_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(458, 244);
            this.Controls.Add(this.metroTextBox_Username);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox_NewPass);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBox_Pincode);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frogot_Pass";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Load += new System.EventHandler(this.Frogot_Pass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Pincode;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox_NewPass;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Username;
    }
}