namespace User_Management_System
{
    partial class Modal_Forgot
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
            this.lblUsername_Forgot_Password = new System.Windows.Forms.Label();
            this.txtBox_Forgot_Password = new System.Windows.Forms.TextBox();
            this.btn_Go_Forgot = new System.Windows.Forms.Button();
            this.lbl_SecretQ = new System.Windows.Forms.Label();
            this.lbl_SecretA = new System.Windows.Forms.Label();
            this.txtBox_SecretQ = new System.Windows.Forms.TextBox();
            this.txtBox_SecretA = new System.Windows.Forms.TextBox();
            this.btn_Forgot_OK = new System.Windows.Forms.Button();
            this.btn_forgot_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxResetPass = new System.Windows.Forms.TextBox();
            this.btnFinalOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername_Forgot_Password
            // 
            this.lblUsername_Forgot_Password.AutoSize = true;
            this.lblUsername_Forgot_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername_Forgot_Password.Location = new System.Drawing.Point(44, 22);
            this.lblUsername_Forgot_Password.Name = "lblUsername_Forgot_Password";
            this.lblUsername_Forgot_Password.Size = new System.Drawing.Size(101, 20);
            this.lblUsername_Forgot_Password.TabIndex = 0;
            this.lblUsername_Forgot_Password.Text = "Username :";
            // 
            // txtBox_Forgot_Password
            // 
            this.txtBox_Forgot_Password.Location = new System.Drawing.Point(151, 24);
            this.txtBox_Forgot_Password.Name = "txtBox_Forgot_Password";
            this.txtBox_Forgot_Password.Size = new System.Drawing.Size(158, 20);
            this.txtBox_Forgot_Password.TabIndex = 1;
            // 
            // btn_Go_Forgot
            // 
            this.btn_Go_Forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Go_Forgot.Location = new System.Drawing.Point(330, 22);
            this.btn_Go_Forgot.Name = "btn_Go_Forgot";
            this.btn_Go_Forgot.Size = new System.Drawing.Size(56, 23);
            this.btn_Go_Forgot.TabIndex = 2;
            this.btn_Go_Forgot.Text = "GO";
            this.btn_Go_Forgot.UseVisualStyleBackColor = true;
            this.btn_Go_Forgot.Click += new System.EventHandler(this.btn_Go_Forgot_Click);
            // 
            // lbl_SecretQ
            // 
            this.lbl_SecretQ.AutoSize = true;
            this.lbl_SecretQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SecretQ.Location = new System.Drawing.Point(3, 84);
            this.lbl_SecretQ.Name = "lbl_SecretQ";
            this.lbl_SecretQ.Size = new System.Drawing.Size(126, 16);
            this.lbl_SecretQ.TabIndex = 3;
            this.lbl_SecretQ.Text = "Secret Question :";
            // 
            // lbl_SecretA
            // 
            this.lbl_SecretA.AutoSize = true;
            this.lbl_SecretA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SecretA.Location = new System.Drawing.Point(3, 113);
            this.lbl_SecretA.Name = "lbl_SecretA";
            this.lbl_SecretA.Size = new System.Drawing.Size(115, 16);
            this.lbl_SecretA.TabIndex = 4;
            this.lbl_SecretA.Text = "Secret Answer :";
            this.lbl_SecretA.Click += new System.EventHandler(this.lbl_SecretA_Click);
            // 
            // txtBox_SecretQ
            // 
            this.txtBox_SecretQ.Location = new System.Drawing.Point(135, 84);
            this.txtBox_SecretQ.Name = "txtBox_SecretQ";
            this.txtBox_SecretQ.ReadOnly = true;
            this.txtBox_SecretQ.Size = new System.Drawing.Size(466, 20);
            this.txtBox_SecretQ.TabIndex = 5;
            // 
            // txtBox_SecretA
            // 
            this.txtBox_SecretA.Location = new System.Drawing.Point(135, 109);
            this.txtBox_SecretA.Name = "txtBox_SecretA";
            this.txtBox_SecretA.Size = new System.Drawing.Size(466, 20);
            this.txtBox_SecretA.TabIndex = 6;
            // 
            // btn_Forgot_OK
            // 
            this.btn_Forgot_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Forgot_OK.Location = new System.Drawing.Point(320, 135);
            this.btn_Forgot_OK.Name = "btn_Forgot_OK";
            this.btn_Forgot_OK.Size = new System.Drawing.Size(66, 23);
            this.btn_Forgot_OK.TabIndex = 7;
            this.btn_Forgot_OK.Text = "READY";
            this.btn_Forgot_OK.UseVisualStyleBackColor = true;
            this.btn_Forgot_OK.Click += new System.EventHandler(this.btn_Forgot_OK_Click);
            // 
            // btn_forgot_Cancel
            // 
            this.btn_forgot_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forgot_Cancel.Location = new System.Drawing.Point(340, 214);
            this.btn_forgot_Cancel.Name = "btn_forgot_Cancel";
            this.btn_forgot_Cancel.Size = new System.Drawing.Size(56, 23);
            this.btn_forgot_Cancel.TabIndex = 8;
            this.btn_forgot_Cancel.Text = "Cancel";
            this.btn_forgot_Cancel.UseVisualStyleBackColor = true;
            this.btn_forgot_Cancel.Click += new System.EventHandler(this.btn_forgot_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reset Password:";
            // 
            // txtboxResetPass
            // 
            this.txtboxResetPass.Enabled = false;
            this.txtboxResetPass.Location = new System.Drawing.Point(315, 175);
            this.txtboxResetPass.Name = "txtboxResetPass";
            this.txtboxResetPass.Size = new System.Drawing.Size(158, 20);
            this.txtboxResetPass.TabIndex = 10;
            this.txtboxResetPass.UseSystemPasswordChar = true;
            // 
            // btnFinalOK
            // 
            this.btnFinalOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalOK.Location = new System.Drawing.Point(278, 214);
            this.btnFinalOK.Name = "btnFinalOK";
            this.btnFinalOK.Size = new System.Drawing.Size(56, 23);
            this.btnFinalOK.TabIndex = 11;
            this.btnFinalOK.Text = "OK";
            this.btnFinalOK.UseVisualStyleBackColor = true;
            this.btnFinalOK.Click += new System.EventHandler(this.btnFinalOK_Click);
            // 
            // Modal_Forgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 242);
            this.Controls.Add(this.btnFinalOK);
            this.Controls.Add(this.txtboxResetPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_forgot_Cancel);
            this.Controls.Add(this.btn_Forgot_OK);
            this.Controls.Add(this.txtBox_SecretA);
            this.Controls.Add(this.txtBox_SecretQ);
            this.Controls.Add(this.lbl_SecretA);
            this.Controls.Add(this.lbl_SecretQ);
            this.Controls.Add(this.btn_Go_Forgot);
            this.Controls.Add(this.txtBox_Forgot_Password);
            this.Controls.Add(this.lblUsername_Forgot_Password);
            this.MaximizeBox = false;
            this.Name = "Modal_Forgot";
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername_Forgot_Password;
        private System.Windows.Forms.TextBox txtBox_Forgot_Password;
        private System.Windows.Forms.Button btn_Go_Forgot;
        private System.Windows.Forms.Label lbl_SecretQ;
        private System.Windows.Forms.Label lbl_SecretA;
        private System.Windows.Forms.TextBox txtBox_SecretQ;
        private System.Windows.Forms.TextBox txtBox_SecretA;
        private System.Windows.Forms.Button btn_Forgot_OK;
        private System.Windows.Forms.Button btn_forgot_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxResetPass;
        private System.Windows.Forms.Button btnFinalOK;
    }
}