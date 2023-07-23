namespace Wordpad_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mM_File = new System.Windows.Forms.ToolStripMenuItem();
            this.file_New = new System.Windows.Forms.ToolStripMenuItem();
            this.file_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.file_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.file_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mM_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mM_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.tools_Customisation = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.tb_New = new System.Windows.Forms.ToolStripButton();
            this.tb_Open = new System.Windows.Forms.ToolStripButton();
            this.tb_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Cut = new System.Windows.Forms.ToolStripButton();
            this.tb_Copy = new System.Windows.Forms.ToolStripButton();
            this.tb_Paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Bold = new System.Windows.Forms.ToolStripButton();
            this.tb_Italic = new System.Windows.Forms.ToolStripButton();
            this.tb_UnderLine = new System.Windows.Forms.ToolStripButton();
            this.tb_Strike = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_AlignLeft = new System.Windows.Forms.ToolStripButton();
            this.tb_AlignCenter = new System.Windows.Forms.ToolStripButton();
            this.tb_AlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_UpperCase = new System.Windows.Forms.ToolStripButton();
            this.tb_LowerCase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_ZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tb_ZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Font = new System.Windows.Forms.ToolStripComboBox();
            this.tb_FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.charCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.khali_jagya = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_Zoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.Document = new System.Windows.Forms.RichTextBox();
            this.rcMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rc_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.rc_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.rc_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.rc_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.rc_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openWork = new System.Windows.Forms.OpenFileDialog();
            this.saveWork = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu.SuspendLayout();
            this.Tools.SuspendLayout();
            this.Status.SuspendLayout();
            this.rcMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mM_File,
            this.mM_Edit,
            this.mM_Tools});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(943, 25);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // mM_File
            // 
            this.mM_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_New,
            this.file_Open,
            this.toolStripSeparator,
            this.file_Save,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.file_Exit});
            this.mM_File.Name = "mM_File";
            this.mM_File.Size = new System.Drawing.Size(39, 21);
            this.mM_File.Text = "&File";
            // 
            // file_New
            // 
            this.file_New.Image = ((System.Drawing.Image)(resources.GetObject("file_New.Image")));
            this.file_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_New.Name = "file_New";
            this.file_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.file_New.Size = new System.Drawing.Size(155, 22);
            this.file_New.Text = "&New";
            this.file_New.Click += new System.EventHandler(this.file_New_Click);
            // 
            // file_Open
            // 
            this.file_Open.Image = ((System.Drawing.Image)(resources.GetObject("file_Open.Image")));
            this.file_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_Open.Name = "file_Open";
            this.file_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.file_Open.Size = new System.Drawing.Size(155, 22);
            this.file_Open.Text = "&Open";
            this.file_Open.Click += new System.EventHandler(this.file_Open_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(152, 6);
            // 
            // file_Save
            // 
            this.file_Save.Image = ((System.Drawing.Image)(resources.GetObject("file_Save.Image")));
            this.file_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_Save.Name = "file_Save";
            this.file_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.file_Save.Size = new System.Drawing.Size(155, 22);
            this.file_Save.Text = "&Save";
            this.file_Save.Click += new System.EventHandler(this.file_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // file_Exit
            // 
            this.file_Exit.Name = "file_Exit";
            this.file_Exit.Size = new System.Drawing.Size(155, 22);
            this.file_Exit.Text = "E&xit";
            this.file_Exit.Click += new System.EventHandler(this.file_Exit_Click);
            // 
            // mM_Edit
            // 
            this.mM_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_Undo,
            this.edit_Redo,
            this.toolStripSeparator3,
            this.edit_Cut,
            this.edit_Copy,
            this.edit_Paste,
            this.toolStripSeparator4,
            this.edit_SelectAll});
            this.mM_Edit.Name = "mM_Edit";
            this.mM_Edit.Size = new System.Drawing.Size(42, 21);
            this.mM_Edit.Text = "&Edit";
            // 
            // edit_Undo
            // 
            this.edit_Undo.Name = "edit_Undo";
            this.edit_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.edit_Undo.Size = new System.Drawing.Size(152, 22);
            this.edit_Undo.Text = "&Undo";
            this.edit_Undo.Click += new System.EventHandler(this.edit_Undo_Click);
            // 
            // edit_Redo
            // 
            this.edit_Redo.Name = "edit_Redo";
            this.edit_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.edit_Redo.Size = new System.Drawing.Size(152, 22);
            this.edit_Redo.Text = "&Redo";
            this.edit_Redo.Click += new System.EventHandler(this.edit_Redo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // edit_Cut
            // 
            this.edit_Cut.Image = ((System.Drawing.Image)(resources.GetObject("edit_Cut.Image")));
            this.edit_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Cut.Name = "edit_Cut";
            this.edit_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.edit_Cut.Size = new System.Drawing.Size(152, 22);
            this.edit_Cut.Text = "Cu&t";
            this.edit_Cut.Click += new System.EventHandler(this.edit_Cut_Click);
            // 
            // edit_Copy
            // 
            this.edit_Copy.Image = ((System.Drawing.Image)(resources.GetObject("edit_Copy.Image")));
            this.edit_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Copy.Name = "edit_Copy";
            this.edit_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.edit_Copy.Size = new System.Drawing.Size(152, 22);
            this.edit_Copy.Text = "&Copy";
            this.edit_Copy.Click += new System.EventHandler(this.edit_Copy_Click);
            // 
            // edit_Paste
            // 
            this.edit_Paste.Image = ((System.Drawing.Image)(resources.GetObject("edit_Paste.Image")));
            this.edit_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Paste.Name = "edit_Paste";
            this.edit_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.edit_Paste.Size = new System.Drawing.Size(152, 22);
            this.edit_Paste.Text = "&Paste";
            this.edit_Paste.Click += new System.EventHandler(this.edit_Paste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // edit_SelectAll
            // 
            this.edit_SelectAll.Name = "edit_SelectAll";
            this.edit_SelectAll.Size = new System.Drawing.Size(152, 22);
            this.edit_SelectAll.Text = "Select &All";
            this.edit_SelectAll.Click += new System.EventHandler(this.edit_SelectAll_Click);
            // 
            // mM_Tools
            // 
            this.mM_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tools_Customisation});
            this.mM_Tools.Name = "mM_Tools";
            this.mM_Tools.Size = new System.Drawing.Size(52, 21);
            this.mM_Tools.Text = "&Tools";
            // 
            // tools_Customisation
            // 
            this.tools_Customisation.Name = "tools_Customisation";
            this.tools_Customisation.Size = new System.Drawing.Size(136, 22);
            this.tools_Customisation.Text = "&Customize";
            this.tools_Customisation.Click += new System.EventHandler(this.tools_Customisation_Click_1);
            // 
            // Tools
            // 
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_New,
            this.tb_Open,
            this.tb_Save,
            this.toolStripSeparator6,
            this.tb_Cut,
            this.tb_Copy,
            this.tb_Paste,
            this.toolStripSeparator7,
            this.tb_Bold,
            this.tb_Italic,
            this.tb_UnderLine,
            this.tb_Strike,
            this.toolStripSeparator5,
            this.tb_AlignLeft,
            this.tb_AlignCenter,
            this.tb_AlignRight,
            this.toolStripSeparator8,
            this.tb_UpperCase,
            this.tb_LowerCase,
            this.toolStripSeparator9,
            this.tb_ZoomIn,
            this.tb_ZoomOut,
            this.toolStripSeparator10,
            this.tb_Font,
            this.tb_FontSize,
            this.toolStripSeparator11});
            this.Tools.Location = new System.Drawing.Point(0, 25);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(943, 25);
            this.Tools.TabIndex = 1;
            this.Tools.Text = "Tools";
            // 
            // tb_New
            // 
            this.tb_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_New.Image = ((System.Drawing.Image)(resources.GetObject("tb_New.Image")));
            this.tb_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_New.Name = "tb_New";
            this.tb_New.Size = new System.Drawing.Size(23, 22);
            this.tb_New.Text = "&New";
            this.tb_New.Click += new System.EventHandler(this.tb_New_Click);
            // 
            // tb_Open
            // 
            this.tb_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Open.Image = ((System.Drawing.Image)(resources.GetObject("tb_Open.Image")));
            this.tb_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Open.Name = "tb_Open";
            this.tb_Open.Size = new System.Drawing.Size(23, 22);
            this.tb_Open.Text = "&Open";
            this.tb_Open.Click += new System.EventHandler(this.tb_Open_Click);
            // 
            // tb_Save
            // 
            this.tb_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Save.Image = ((System.Drawing.Image)(resources.GetObject("tb_Save.Image")));
            this.tb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Save.Name = "tb_Save";
            this.tb_Save.Size = new System.Drawing.Size(23, 22);
            this.tb_Save.Text = "&Save";
            this.tb_Save.Click += new System.EventHandler(this.tb_Save_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_Cut
            // 
            this.tb_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Cut.Image = ((System.Drawing.Image)(resources.GetObject("tb_Cut.Image")));
            this.tb_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Cut.Name = "tb_Cut";
            this.tb_Cut.Size = new System.Drawing.Size(23, 22);
            this.tb_Cut.Text = "C&ut";
            this.tb_Cut.Click += new System.EventHandler(this.tb_Cut_Click);
            // 
            // tb_Copy
            // 
            this.tb_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Copy.Image = ((System.Drawing.Image)(resources.GetObject("tb_Copy.Image")));
            this.tb_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Copy.Name = "tb_Copy";
            this.tb_Copy.Size = new System.Drawing.Size(23, 22);
            this.tb_Copy.Text = "&Copy";
            this.tb_Copy.Click += new System.EventHandler(this.tb_Copy_Click);
            // 
            // tb_Paste
            // 
            this.tb_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Paste.Image = ((System.Drawing.Image)(resources.GetObject("tb_Paste.Image")));
            this.tb_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Paste.Name = "tb_Paste";
            this.tb_Paste.Size = new System.Drawing.Size(23, 22);
            this.tb_Paste.Text = "&Paste";
            this.tb_Paste.Click += new System.EventHandler(this.tb_Paste_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_Bold
            // 
            this.tb_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_Bold.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bold.Image = ((System.Drawing.Image)(resources.GetObject("tb_Bold.Image")));
            this.tb_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Bold.Name = "tb_Bold";
            this.tb_Bold.Size = new System.Drawing.Size(23, 22);
            this.tb_Bold.Text = "&B";
            this.tb_Bold.ToolTipText = "Press Ctrl + B";
            this.tb_Bold.Click += new System.EventHandler(this.tb_Bold_Click);
            // 
            // tb_Italic
            // 
            this.tb_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_Italic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Italic.Image = ((System.Drawing.Image)(resources.GetObject("tb_Italic.Image")));
            this.tb_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Italic.Name = "tb_Italic";
            this.tb_Italic.Size = new System.Drawing.Size(23, 22);
            this.tb_Italic.Text = "&I";
            this.tb_Italic.ToolTipText = "Press Ctrl + I";
            this.tb_Italic.Click += new System.EventHandler(this.tb_Italic_Click);
            // 
            // tb_UnderLine
            // 
            this.tb_UnderLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_UnderLine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UnderLine.Image = ((System.Drawing.Image)(resources.GetObject("tb_UnderLine.Image")));
            this.tb_UnderLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_UnderLine.Name = "tb_UnderLine";
            this.tb_UnderLine.Size = new System.Drawing.Size(23, 22);
            this.tb_UnderLine.Text = "&U";
            this.tb_UnderLine.ToolTipText = "Press Ctrl + U";
            this.tb_UnderLine.Click += new System.EventHandler(this.tb_UnderLine_Click);
            // 
            // tb_Strike
            // 
            this.tb_Strike.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_Strike.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Strike.Image = ((System.Drawing.Image)(resources.GetObject("tb_Strike.Image")));
            this.tb_Strike.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Strike.Name = "tb_Strike";
            this.tb_Strike.Size = new System.Drawing.Size(23, 22);
            this.tb_Strike.Text = "S";
            this.tb_Strike.Click += new System.EventHandler(this.tb_Strike_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_AlignLeft
            // 
            this.tb_AlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_AlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("tb_AlignLeft.Image")));
            this.tb_AlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_AlignLeft.Name = "tb_AlignLeft";
            this.tb_AlignLeft.Size = new System.Drawing.Size(23, 22);
            this.tb_AlignLeft.Text = "L";
            this.tb_AlignLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_AlignLeft.Click += new System.EventHandler(this.tb_AlignLeft_Click);
            // 
            // tb_AlignCenter
            // 
            this.tb_AlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_AlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("tb_AlignCenter.Image")));
            this.tb_AlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_AlignCenter.Name = "tb_AlignCenter";
            this.tb_AlignCenter.Size = new System.Drawing.Size(23, 22);
            this.tb_AlignCenter.Text = "C";
            this.tb_AlignCenter.Click += new System.EventHandler(this.tb_AlignCenter_Click);
            // 
            // tb_AlignRight
            // 
            this.tb_AlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_AlignRight.Image = ((System.Drawing.Image)(resources.GetObject("tb_AlignRight.Image")));
            this.tb_AlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_AlignRight.Name = "tb_AlignRight";
            this.tb_AlignRight.Size = new System.Drawing.Size(23, 22);
            this.tb_AlignRight.Text = "R";
            this.tb_AlignRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tb_AlignRight.Click += new System.EventHandler(this.tb_AlignRight_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_UpperCase
            // 
            this.tb_UpperCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_UpperCase.Image = ((System.Drawing.Image)(resources.GetObject("tb_UpperCase.Image")));
            this.tb_UpperCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_UpperCase.Name = "tb_UpperCase";
            this.tb_UpperCase.Size = new System.Drawing.Size(23, 22);
            this.tb_UpperCase.Text = "A";
            this.tb_UpperCase.Click += new System.EventHandler(this.tb_UpperCase_Click);
            // 
            // tb_LowerCase
            // 
            this.tb_LowerCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_LowerCase.Image = ((System.Drawing.Image)(resources.GetObject("tb_LowerCase.Image")));
            this.tb_LowerCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_LowerCase.Name = "tb_LowerCase";
            this.tb_LowerCase.Size = new System.Drawing.Size(23, 22);
            this.tb_LowerCase.Text = "a";
            this.tb_LowerCase.Click += new System.EventHandler(this.tb_LowerCase_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_ZoomIn
            // 
            this.tb_ZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_ZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tb_ZoomIn.Image")));
            this.tb_ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_ZoomIn.Name = "tb_ZoomIn";
            this.tb_ZoomIn.Size = new System.Drawing.Size(23, 22);
            this.tb_ZoomIn.Text = "+";
            this.tb_ZoomIn.Click += new System.EventHandler(this.tb_ZoomIn_Click);
            // 
            // tb_ZoomOut
            // 
            this.tb_ZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tb_ZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tb_ZoomOut.Image")));
            this.tb_ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_ZoomOut.Name = "tb_ZoomOut";
            this.tb_ZoomOut.Size = new System.Drawing.Size(23, 22);
            this.tb_ZoomOut.Text = "-";
            this.tb_ZoomOut.Click += new System.EventHandler(this.tb_ZoomOut_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_Font
            // 
            this.tb_Font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_Font.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tb_Font.Name = "tb_Font";
            this.tb_Font.Size = new System.Drawing.Size(121, 25);
            this.tb_Font.SelectedIndexChanged += new System.EventHandler(this.tb_Font_SelectedIndexChanged);
            // 
            // tb_FontSize
            // 
            this.tb_FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_FontSize.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tb_FontSize.Name = "tb_FontSize";
            this.tb_FontSize.Size = new System.Drawing.Size(75, 25);
            this.tb_FontSize.SelectedIndexChanged += new System.EventHandler(this.tb_FontSize_SelectedIndexChanged);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charCount,
            this.khali_jagya,
            this.Status_Zoom});
            this.Status.Location = new System.Drawing.Point(0, 376);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(943, 22);
            this.Status.TabIndex = 2;
            this.Status.Text = "Status";
            // 
            // charCount
            // 
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(67, 17);
            this.charCount.Text = "charCount";
            // 
            // khali_jagya
            // 
            this.khali_jagya.Name = "khali_jagya";
            this.khali_jagya.Size = new System.Drawing.Size(819, 17);
            this.khali_jagya.Spring = true;
            // 
            // Status_Zoom
            // 
            this.Status_Zoom.Name = "Status_Zoom";
            this.Status_Zoom.Size = new System.Drawing.Size(42, 17);
            this.Status_Zoom.Text = "Zoom";
            // 
            // Document
            // 
            this.Document.ContextMenuStrip = this.rcMenu;
            this.Document.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Document.Location = new System.Drawing.Point(0, 50);
            this.Document.Name = "Document";
            this.Document.Size = new System.Drawing.Size(943, 326);
            this.Document.TabIndex = 3;
            this.Document.Text = "";
            this.Document.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.Document_LinkClicked);
            this.Document.TextChanged += new System.EventHandler(this.Document_TextChanged);
            // 
            // rcMenu
            // 
            this.rcMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rc_Undo,
            this.rc_Redo,
            this.rc_Cut,
            this.rc_Copy,
            this.rc_Paste});
            this.rcMenu.Name = "rcMenu";
            this.rcMenu.Size = new System.Drawing.Size(109, 114);
            // 
            // rc_Undo
            // 
            this.rc_Undo.Name = "rc_Undo";
            this.rc_Undo.Size = new System.Drawing.Size(108, 22);
            this.rc_Undo.Text = "Undo";
            this.rc_Undo.Click += new System.EventHandler(this.rc_Undo_Click);
            // 
            // rc_Redo
            // 
            this.rc_Redo.Name = "rc_Redo";
            this.rc_Redo.Size = new System.Drawing.Size(108, 22);
            this.rc_Redo.Text = "Redo";
            this.rc_Redo.Click += new System.EventHandler(this.rc_Redo_Click);
            // 
            // rc_Cut
            // 
            this.rc_Cut.Name = "rc_Cut";
            this.rc_Cut.Size = new System.Drawing.Size(108, 22);
            this.rc_Cut.Text = "Cut";
            this.rc_Cut.Click += new System.EventHandler(this.rc_Cut_Click);
            // 
            // rc_Copy
            // 
            this.rc_Copy.Name = "rc_Copy";
            this.rc_Copy.Size = new System.Drawing.Size(108, 22);
            this.rc_Copy.Text = "Copy";
            this.rc_Copy.Click += new System.EventHandler(this.rc_Copy_Click);
            // 
            // rc_Paste
            // 
            this.rc_Paste.Name = "rc_Paste";
            this.rc_Paste.Size = new System.Drawing.Size(108, 22);
            this.rc_Paste.Text = "Paste";
            this.rc_Paste.Click += new System.EventHandler(this.rc_Paste_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openWork
            // 
            this.openWork.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            this.openWork.Title = "Open Your Document";
            // 
            // saveWork
            // 
            this.saveWork.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            this.saveWork.Title = "Save Your Document";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 398);
            this.Controls.Add(this.Document);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Wordpad-131040107039";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.rcMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mM_File;
        private System.Windows.Forms.ToolStripMenuItem file_New;
        private System.Windows.Forms.ToolStripMenuItem file_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem file_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem file_Exit;
        private System.Windows.Forms.ToolStripMenuItem mM_Edit;
        private System.Windows.Forms.ToolStripMenuItem edit_Undo;
        private System.Windows.Forms.ToolStripMenuItem edit_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem edit_Cut;
        private System.Windows.Forms.ToolStripMenuItem edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem edit_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem edit_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem mM_Tools;
        private System.Windows.Forms.ToolStripMenuItem tools_Customisation;
        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.ToolStripButton tb_New;
        private System.Windows.Forms.ToolStripButton tb_Open;
        private System.Windows.Forms.ToolStripButton tb_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tb_Cut;
        private System.Windows.Forms.ToolStripButton tb_Copy;
        private System.Windows.Forms.ToolStripButton tb_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.RichTextBox Document;
        private System.Windows.Forms.ToolStripButton tb_Bold;
        private System.Windows.Forms.ToolStripButton tb_Italic;
        private System.Windows.Forms.ToolStripButton tb_UnderLine;
        private System.Windows.Forms.ToolStripButton tb_Strike;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tb_AlignLeft;
        private System.Windows.Forms.ToolStripButton tb_AlignCenter;
        private System.Windows.Forms.ToolStripButton tb_AlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tb_UpperCase;
        private System.Windows.Forms.ToolStripButton tb_LowerCase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton tb_ZoomIn;
        private System.Windows.Forms.ToolStripButton tb_ZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripComboBox tb_Font;
        private System.Windows.Forms.ToolStripComboBox tb_FontSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripStatusLabel charCount;
        private System.Windows.Forms.ToolStripStatusLabel khali_jagya;
        private System.Windows.Forms.ToolStripStatusLabel Status_Zoom;
        private System.Windows.Forms.ContextMenuStrip rcMenu;
        private System.Windows.Forms.ToolStripMenuItem rc_Undo;
        private System.Windows.Forms.ToolStripMenuItem rc_Redo;
        private System.Windows.Forms.ToolStripMenuItem rc_Cut;
        private System.Windows.Forms.ToolStripMenuItem rc_Copy;
        private System.Windows.Forms.ToolStripMenuItem rc_Paste;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openWork;
        private System.Windows.Forms.SaveFileDialog saveWork;
    }
}

