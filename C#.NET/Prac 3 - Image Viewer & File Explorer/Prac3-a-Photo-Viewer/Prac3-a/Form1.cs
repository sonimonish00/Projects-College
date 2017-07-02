using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Prac3_a
{
    public partial class Form1 : Form
    {
        Bitmap img = null;
        double zoom = 1;
        int defImgWidth;
        int defImgHeight;
        public Form1()
        {
            InitializeComponent();
        }
        public int count = 0;
        String[] list;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            object sender = null;
            EventArgs e = null;
            //capture up arrow key
            if (keyData == Keys.Up)
            {
                MessageBox.Show("Restricted !!");
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                MessageBox.Show("Restricted !!");
                return true;
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {

                btnPrev_Click(sender, e);
                //MessageBox.Show("You pressed Left arrow key");
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {

                btnNext_Click(sender, e);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            count++;
            if (count == list.Length) { count = 0; } //Looping from last element
            pictureBox.Image = Image.FromFile(list[count]);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            count--;
            if (count == -1)
            {
                count = list.Length - 1;
            }  //Looping from last element
            pictureBox.Image = Image.FromFile(list[count]);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName; //Data type
                int val = path.LastIndexOf(@"\");
                string newpath = path.Substring(0, val); //Data type
                list = Directory.GetFiles(newpath, "*.jpg");   //Class Name
                pictureBox.Image = Image.FromFile(path);
                btnNext.Enabled = true;
                btnPrev.Enabled = true;
                btnLeft.Enabled = true;
                btnRight.Enabled = true;
                btnzoomin.Enabled = true;
                btnzoomout.Enabled = true;
                btnFit.Enabled = true;

                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                img = new Bitmap(path);
                pictureBox.Image = img;
                defImgHeight = img.Height;
                defImgWidth = img.Width;

            }
        }
        Bitmap bm; //We have to Initialize Outside
        private void btnLeft_Click(object sender, EventArgs e)
        {
            bm = (Bitmap)pictureBox.Image;
            bm.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox.Image = bm;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            bm = (Bitmap)pictureBox.Image;
            bm.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox.Image = bm;
        }

        private void btnzoomin_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
                zoom = zoom + 0.2;
                Bitmap bmp = new Bitmap(img, Convert.ToInt32(pictureBox.Width * zoom), Convert.ToInt32(pictureBox.Width * zoom * defImgHeight / defImgWidth));
                pictureBox.Image = bmp;


            }
        }

        private void btnzoomout_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
                if (zoom > 0.3)
                {
                    zoom = zoom - 0.2;
                    Bitmap bmp = new Bitmap(img, Convert.ToInt32(pictureBox.Width * zoom), Convert.ToInt32(pictureBox.Width * zoom * defImgHeight / defImgWidth));
                    pictureBox.Image = bmp;
                }

            }
        }

        private void btnFit_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap bmp = new Bitmap(img, Convert.ToInt32(pictureBox.Width), Convert.ToInt32(pictureBox.Width * defImgHeight / defImgWidth));
                pictureBox.Image = bmp;


            }
        }
    }
}
