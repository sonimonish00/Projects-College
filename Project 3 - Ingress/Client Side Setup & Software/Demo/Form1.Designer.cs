namespace Demo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.TabCont = new MaterialSkin.Controls.MaterialTabControl();
            this.login = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnConnect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtip = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtenroll = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btnshutdown = new MaterialSkin.Controls.MaterialFlatButton();
            this.forgotpass = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtguestno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtguestpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnGuest = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtTimer = new System.Windows.Forms.Label();
            this.LblRemaining = new System.Windows.Forms.Label();
            this.TabCont.SuspendLayout();
            this.login.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.forgotpass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TabCont
            // 
            this.TabCont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabCont.Controls.Add(this.login);
            this.TabCont.Controls.Add(this.forgotpass);
            this.TabCont.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.TabCont.Depth = 0;
            this.TabCont.Location = new System.Drawing.Point(-1, 79);
            this.TabCont.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabCont.Name = "TabCont";
            this.TabCont.SelectedIndex = 0;
            this.TabCont.Size = new System.Drawing.Size(1276, 851);
            this.TabCont.TabIndex = 22;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login.Controls.Add(this.panel2);
            this.login.Controls.Add(this.panel1);
            this.login.Controls.Add(this.label4);
            this.login.Controls.Add(this.Btnshutdown);
            this.login.Location = new System.Drawing.Point(4, 22);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(3);
            this.login.Size = new System.Drawing.Size(1268, 825);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnConnect);
            this.panel2.Controls.Add(this.txtip);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(111, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 237);
            this.panel2.TabIndex = 24;
            this.panel2.Visible = false;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConnect.Depth = 0;
            this.BtnConnect.Location = new System.Drawing.Point(350, 143);
            this.BtnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Primary = true;
            this.BtnConnect.Size = new System.Drawing.Size(164, 49);
            this.BtnConnect.TabIndex = 22;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // txtip
            // 
            this.txtip.Depth = 0;
            this.txtip.Hint = "IP Address";
            this.txtip.Location = new System.Drawing.Point(263, 93);
            this.txtip.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtip.Name = "txtip";
            this.txtip.PasswordChar = '\0';
            this.txtip.SelectedText = "";
            this.txtip.SelectionLength = 0;
            this.txtip.SelectionStart = 0;
            this.txtip.Size = new System.Drawing.Size(437, 23);
            this.txtip.TabIndex = 5;
            this.txtip.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(166, 97);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(81, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "IP Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(830, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "(There is error with IP configuration of server. Please ask to admin for IP ADDRE" +
    "SS and enter it in below textbox)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtenroll);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.BtnSubmit);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(60, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 214);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtenroll
            // 
            this.txtenroll.Depth = 0;
            this.txtenroll.Enabled = false;
            this.txtenroll.Hint = "e.g. 123456";
            this.txtenroll.Location = new System.Drawing.Point(438, 74);
            this.txtenroll.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtenroll.Name = "txtenroll";
            this.txtenroll.PasswordChar = '\0';
            this.txtenroll.SelectedText = "";
            this.txtenroll.SelectionLength = 0;
            this.txtenroll.SelectionStart = 0;
            this.txtenroll.Size = new System.Drawing.Size(419, 23);
            this.txtenroll.TabIndex = 26;
            this.txtenroll.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Demo.Properties.Resources.GPERI_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(4, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(353, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(58, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "User ID";
            // 
            // txtpass
            // 
            this.txtpass.Depth = 0;
            this.txtpass.Hint = "e.g. ******";
            this.txtpass.Location = new System.Drawing.Point(438, 115);
            this.txtpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.Size = new System.Drawing.Size(419, 23);
            this.txtpass.TabIndex = 2;
            this.txtpass.UseSystemPasswordChar = false;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubmit.Depth = 0;
            this.BtnSubmit.Location = new System.Drawing.Point(438, 155);
            this.BtnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Primary = true;
            this.BtnSubmit.Size = new System.Drawing.Size(152, 46);
            this.BtnSubmit.TabIndex = 21;
            this.BtnSubmit.Text = "Login";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(336, 119);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(459, 31);
            this.label4.TabIndex = 24;
            this.label4.Text = "Welcome Entry Management System";
            // 
            // Btnshutdown
            // 
            this.Btnshutdown.AutoSize = true;
            this.Btnshutdown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btnshutdown.Depth = 0;
            this.Btnshutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnshutdown.Location = new System.Drawing.Point(1157, 6);
            this.Btnshutdown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btnshutdown.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btnshutdown.Name = "Btnshutdown";
            this.Btnshutdown.Primary = false;
            this.Btnshutdown.Size = new System.Drawing.Size(91, 36);
            this.Btnshutdown.TabIndex = 23;
            this.Btnshutdown.Text = "Shut down";
            this.Btnshutdown.UseVisualStyleBackColor = true;
            this.Btnshutdown.Click += new System.EventHandler(this.Btnshutdown_Click);
            // 
            // forgotpass
            // 
            this.forgotpass.BackColor = System.Drawing.Color.White;
            this.forgotpass.Controls.Add(this.label2);
            this.forgotpass.Controls.Add(this.txtguestno);
            this.forgotpass.Controls.Add(this.materialLabel4);
            this.forgotpass.Controls.Add(this.txtguestpass);
            this.forgotpass.Controls.Add(this.BtnGuest);
            this.forgotpass.Controls.Add(this.materialLabel5);
            this.forgotpass.Controls.Add(this.label6);
            this.forgotpass.Controls.Add(this.pictureBox2);
            this.forgotpass.Controls.Add(this.materialFlatButton1);
            this.forgotpass.Controls.Add(this.materialLabel6);
            this.forgotpass.Location = new System.Drawing.Point(4, 22);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Padding = new System.Windows.Forms.Padding(3);
            this.forgotpass.Size = new System.Drawing.Size(1268, 825);
            this.forgotpass.TabIndex = 1;
            this.forgotpass.Text = "Login As Guest";
            this.forgotpass.Click += new System.EventHandler(this.forgotpass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(582, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "(You are guest user)";
            // 
            // txtguestno
            // 
            this.txtguestno.Depth = 0;
            this.txtguestno.Hint = "e.g. 123456";
            this.txtguestno.Location = new System.Drawing.Point(520, 247);
            this.txtguestno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtguestno.Name = "txtguestno";
            this.txtguestno.PasswordChar = '\0';
            this.txtguestno.SelectedText = "";
            this.txtguestno.SelectionLength = 0;
            this.txtguestno.SelectionStart = 0;
            this.txtguestno.Size = new System.Drawing.Size(419, 23);
            this.txtguestno.TabIndex = 28;
            this.txtguestno.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(439, 251);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(58, 19);
            this.materialLabel4.TabIndex = 29;
            this.materialLabel4.Text = "User ID";
            // 
            // txtguestpass
            // 
            this.txtguestpass.Depth = 0;
            this.txtguestpass.Hint = "e.g. *******";
            this.txtguestpass.Location = new System.Drawing.Point(520, 288);
            this.txtguestpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtguestpass.Name = "txtguestpass";
            this.txtguestpass.PasswordChar = '*';
            this.txtguestpass.SelectedText = "";
            this.txtguestpass.SelectionLength = 0;
            this.txtguestpass.SelectionStart = 0;
            this.txtguestpass.Size = new System.Drawing.Size(419, 23);
            this.txtguestpass.TabIndex = 30;
            this.txtguestpass.UseSystemPasswordChar = false;
            // 
            // BtnGuest
            // 
            this.BtnGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuest.Depth = 0;
            this.BtnGuest.Location = new System.Drawing.Point(520, 330);
            this.BtnGuest.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGuest.Name = "BtnGuest";
            this.BtnGuest.Primary = true;
            this.BtnGuest.Size = new System.Drawing.Size(152, 46);
            this.BtnGuest.TabIndex = 33;
            this.BtnGuest.Text = "Login ";
            this.BtnGuest.UseVisualStyleBackColor = true;
            this.BtnGuest.Click += new System.EventHandler(this.BtnGuest_Click_1);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(422, 292);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(75, 19);
            this.materialLabel5.TabIndex = 31;
            this.materialLabel5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(552, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 31);
            this.label6.TabIndex = 32;
            this.label6.Text = "Login As Guest";
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
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(397, 357);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(0, 19);
            this.materialLabel6.TabIndex = 5;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = null;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector2.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(1276, 34);
            this.materialTabSelector2.TabIndex = 23;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.materialTabSelector1.BaseTabControl = this.TabCont;
            this.materialTabSelector1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-5, 24);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1318, 57);
            this.materialTabSelector1.TabIndex = 21;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtTimer
            // 
            this.txtTimer.AutoSize = true;
            this.txtTimer.BackColor = System.Drawing.Color.Black;
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimer.Location = new System.Drawing.Point(1143, 45);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(120, 31);
            this.txtTimer.TabIndex = 23;
            this.txtTimer.Text = "00:15:00";
            // 
            // LblRemaining
            // 
            this.LblRemaining.AutoSize = true;
            this.LblRemaining.BackColor = System.Drawing.Color.Black;
            this.LblRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRemaining.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblRemaining.Location = new System.Drawing.Point(1169, 26);
            this.LblRemaining.Name = "LblRemaining";
            this.LblRemaining.Size = new System.Drawing.Size(67, 17);
            this.LblRemaining.TabIndex = 24;
            this.LblRemaining.Text = "Time Left";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 773);
            this.Controls.Add(this.LblRemaining);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.TabCont);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.Form1_GiveFeedback);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.TabCont.ResumeLayout(false);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.forgotpass.ResumeLayout(false);
            this.forgotpass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl TabCont;
        private System.Windows.Forms.TabPage login;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSubmit;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtpass;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton Btnshutdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton BtnConnect;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtip;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage forgotpass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtguestno;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtguestpass;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGuest;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label txtTimer;
        private System.Windows.Forms.Label LblRemaining;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtenroll;
    }
}

