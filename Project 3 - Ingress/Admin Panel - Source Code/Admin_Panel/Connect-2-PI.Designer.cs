namespace Admin_Panel
{
    partial class Connect_2_PI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect_2_PI));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label_IP_Connect_PI = new MetroFramework.Controls.MetroLabel();
            this.txtBox_IP = new MetroFramework.Controls.MetroTextBox();
            this.Btn_Connect = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Chocolate;
            this.metroLabel1.Location = new System.Drawing.Point(103, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(343, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Connection With Server [Raspberry PI]";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Red;
            this.metroLabel2.Location = new System.Drawing.Point(23, 70);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(573, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Seems There is Error While Connecting To Server !! Please Enter IP Address Of Ser" +
    "ver Below :";
            // 
            // label_IP_Connect_PI
            // 
            this.label_IP_Connect_PI.AutoSize = true;
            this.label_IP_Connect_PI.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label_IP_Connect_PI.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label_IP_Connect_PI.Location = new System.Drawing.Point(215, 160);
            this.label_IP_Connect_PI.Name = "label_IP_Connect_PI";
            this.label_IP_Connect_PI.Size = new System.Drawing.Size(106, 25);
            this.label_IP_Connect_PI.TabIndex = 3;
            this.label_IP_Connect_PI.Text = "IP Address :";
            // 
            // txtBox_IP
            // 
            this.txtBox_IP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBox_IP.Location = new System.Drawing.Point(317, 162);
            this.txtBox_IP.Name = "txtBox_IP";
            this.txtBox_IP.PromptText = "Eg: 172.168.10.1";
            this.txtBox_IP.Size = new System.Drawing.Size(259, 23);
            this.txtBox_IP.TabIndex = 4;
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(317, 203);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(112, 33);
            this.Btn_Connect.TabIndex = 5;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Admin_Panel.Properties.Resources.INGRESS_FINAL_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(6, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Connect_2_PI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 259);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.txtBox_IP);
            this.Controls.Add(this.label_IP_Connect_PI);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Connect_2_PI";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Connect_2_PI_FormClosing);
            this.Load += new System.EventHandler(this.Connect_2_PI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel label_IP_Connect_PI;
        private MetroFramework.Controls.MetroTextBox txtBox_IP;
        private MetroFramework.Controls.MetroButton Btn_Connect;
    }
}