using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Wordpad_New
{
    public partial class Form1 : Form
    {

        public string contents = string.Empty;
        string currentFileLoc;

        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            object sender = null;
            EventArgs e = null;
            if (keyData == (Keys.Control | Keys.B))
            {
                tb_Bold_Click(sender,e);
                return true;
            }

            if (keyData == (Keys.Control | Keys.I))
            {
                tb_Italic_Click(sender, e);
                return true;
            }

            if (keyData == (Keys.Control | Keys.U))
            {
                tb_UnderLine_Click(sender, e);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region Editor and General
        private void Document_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            FontSize();
            InstalledFonts();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            charCount.Text = "Characters in the current document: " + Document.TextLength.ToString();
            Status_Zoom.Text = Document.ZoomFactor.ToString();
        }

        #endregion


        #region MainMenu 
        //FILE  //JUST DECLARATION

        private void file_New_Click(object sender, EventArgs e)
        {
            New();
        }

        private void file_Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void file_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void file_Exit_Click(object sender, EventArgs e)
        {
            exitprompt();
        }


        // EDIT MENU

        private void edit_Undo_Click(object sender, EventArgs e)
        {
            Undo();

        }

        private void edit_Redo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void edit_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void edit_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void edit_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void edit_SelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        
        //TOOLS MENU

        private void tools_Customisation_Click_1(object sender, EventArgs e)
        {
            customise();
        }
        #endregion

        
        #region Toolbar
        private void tb_New_Click(object sender, EventArgs e)
        {
            New();
        }

        private void tb_Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void tb_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void tb_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void tb_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void tb_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void tb_ZoomIn_Click(object sender, EventArgs e)
        {
            if (Document.ZoomFactor == 63)
            {

                return;

            }
            else
                Document.ZoomFactor = Document.ZoomFactor + 1;
        }

        private void tb_ZoomOut_Click(object sender, EventArgs e)
        {
            if (Document.ZoomFactor == 1)
            {

                return;


            }
            else
                Document.ZoomFactor = Document.ZoomFactor - 1;
        }



        private void tb_Bold_Click(object sender, EventArgs e)
        {
            if (Document.SelectionFont != null)
            {
                System.Drawing.Font currentFont = Document.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (Document.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }

                Document.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void tb_Italic_Click(object sender, EventArgs e)
        {
            if (Document.SelectionFont != null)
            {
                System.Drawing.Font currentFont = Document.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (Document.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                }

                Document.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void tb_UnderLine_Click(object sender, EventArgs e)
        {
            if (Document.SelectionFont != null)
            {
                System.Drawing.Font currentFont = Document.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (Document.SelectionFont.Underline == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Underline;
                }

                Document.SelectionFont = new Font(currentFont.FontFamily,currentFont.Size,newFontStyle);
            }


        }

        private void tb_Strike_Click(object sender, EventArgs e)
        {
            Font Sfont = new Font(Document.Font, FontStyle.Strikeout);
            Font rfont = new Font(Document.Font, FontStyle.Regular);


            if (Document.SelectedText.Length == 0)
                return;
            if (Document.SelectionFont.Strikeout)
            {
                Document.SelectionFont = rfont;
            }
            else
            {
                Document.SelectionFont = Sfont;
            }
        }

        private void tb_AlignLeft_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void tb_AlignCenter_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void tb_AlignRight_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void tb_UpperCase_Click(object sender, EventArgs e)
        {
            Document.SelectedText = Document.SelectedText.ToUpper();
        }

        private void tb_LowerCase_Click(object sender, EventArgs e)
        {
            Document.SelectedText = Document.SelectedText.ToLower();
            
        }



        private void tb_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.Font ComboFonts = null;

            try
            {
                ComboFonts = Document.SelectionFont;
                Document.SelectionFont = new System.Drawing.Font(tb_Font.Text, Document.SelectionFont.Size, Document.SelectionFont.Style);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Document.SelectionFont = new Font(tb_FontSize.SelectedItem.ToString(), int.Parse(tb_FontSize.SelectedItem.ToString()), Document.SelectionFont.Style);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion


        #region contextmenu
        private void rc_Undo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void rc_Redo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void rc_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void rc_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void rc_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }
        #endregion


        //Method region Starts Here - All Codes Definition are Given Below
        #region Methods

        #region file

        void exitprompt()
        {
            if (Document.Text != contents)
            {
                DialogResult dr = MessageBox.Show("Do You want to save the changes made to " + this.Text, "Save", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes) //YES SAVE CHANGES
                {
                    saveWork.Title = "Save";
                    if (SaveFile() == 0)
                        return;
                    else
                    {
                        Document.Text = "";
                        this.Text = "Untitled";
                    }
                    contents = "";
                }
                else if (dr == DialogResult.No) //NO DONT SAVE CHANGES
                {
                    Application.Exit();
                }
                else   //CANCEL BUTTONS - AS IT IS
                {
                    Document.Focus();
                 
                }
            }
            else
            {
                Application.Exit();
            }
        }
        void New()  //New Function To Declare
        {
            
            if (Document.Text != contents)
            {
                DialogResult dr = MessageBox.Show("Do You want to save the changes made to " + this.Text, "Save", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    saveWork.Title = "Save";
                    if (SaveFile() == 0)
                        return;
                    else
                    {
                        Document.Text = "";
                        this.Text = "Untitled";
                    }
                    contents = "";
                }
                else if (dr == DialogResult.No)
                {
                    Document.Text = "";
                    this.Text = "Untitled";
                    contents = "";
                }
                else
                {
                    Document.Focus();
                }
            }
            else
            {
                this.Text = "Untitled";
                Document.Text = "";
                contents = "";
            }
        }

        private void OpenFile()  //For Open Function - Orginal
        {
            openWork.Filter = "Text Documents|*.txt";
            if (openWork.ShowDialog() == DialogResult.Cancel)
                Document.Focus();
            else
            {
                Document.LoadFile(openWork.FileName, RichTextBoxStreamType.PlainText);
                this.Text = openWork.FileName;
                contents = Document.Text;
            }

            currentFileLoc = openWork.FileName;
            this.Text = currentFileLoc;
        }

        void Open()  //For OPEN FUNCTION
        {
            if (Document.Text != contents)
            {
                DialogResult dr = MessageBox.Show("Do You want to save the changes made to " + this.Text, "Save", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    SaveFile();
                    OpenFile();
                }
                else if (dr == DialogResult.No)
                {
                    OpenFile();
                }
                else
                {
                    Document.Focus();
                }
            }
            else
                OpenFile();
        }
        
        private int SaveFile()  //For SAVE Function - STARTS HERE
        {
            saveWork.Filter = "Text Documents|*.txt";
            saveWork.DefaultExt = "txt";
            if (saveWork.ShowDialog() == DialogResult.Cancel)
            {
                Document.Focus();
                return 0;
            }
            else //If Someone Wants to Save
            {
                contents = Document.Text;
                if (this.Text == "Untitled")
                    Document.SaveFile(saveWork.FileName, RichTextBoxStreamType.PlainText);
                else
                {
                    saveWork.FileName = this.Text;
                    Document.SaveFile(saveWork.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = saveWork.FileName;
                currentFileLoc = saveWork.FileName;
                return 1;
            }
        }

        void Save() //For Save Function
        {
            if (contents == string.Empty)
            {
                if (saveWork.ShowDialog() == DialogResult.OK)
                    contents = saveWork.FileName;
            }
            if (contents != string.Empty)
            {
                try
                {
                    Document.SaveFile(contents, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                SaveFile();
        }
        
        #endregion

        #region edit
        void Undo()
        {
            Document.Undo();
        }
        void Redo()
        {
            Document.Redo();
        }
        void Cut()
        {
            Document.Cut();
        }
        void Copy()
        {
            Document.Copy();
        }
        void Paste()
        {
            Document.Paste();
        }
        void SelectAll()
        {
            Document.SelectAll();
        }



        #endregion

        #region tools
        void customise()
        {
            ColorDialog myDialog = new ColorDialog();
            myDialog.Color = Document.SelectionColor;
            if (myDialog.ShowDialog() == DialogResult.OK && myDialog.Color!=Document.SelectionColor)
            {
                Document.SelectionColor = myDialog.Color;
               // mainMenu.BackColor = myDialog.Color;
               // Status.BackColor = myDialog.Color;
               // Tools.BackColor = myDialog.Color;
            }
        }

        #endregion 
        
        #endregion
        //Method Region End here

        void FontSize()
            {
                for (int fntSize = 10; fntSize <= 75; fntSize++)
                {
                    tb_FontSize.Items.Add(fntSize.ToString());
                }
            }

        void InstalledFonts()
            {
                InstalledFontCollection fonts = new InstalledFontCollection();
                for (int i = 0; i < fonts.Families.Length; i++)
                {
                    tb_Font.Items.Add(fonts.Families[i].Name);
                }
            }

        private void Document_TextChanged(object sender, EventArgs e)
        {
            //Nothing - Just as it is
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            exitprompt();
        }
    }
}
