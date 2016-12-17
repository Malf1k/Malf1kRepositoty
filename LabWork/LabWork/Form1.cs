using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.ShowDialog();
            var imageOi = openFile.FileName;
            var image1 = new Bitmap(imageOi);
            pictureBox1.Image = image1;



            FileInfo.Text = "Path: " + imageOi;
            FileInfo2.Text = "Height: " + image1.Height;
            FileInfo3.Text = "Width: " + image1.Width;
            FileInfo4.Text = "Format: " + imageOi.Substring(imageOi.LastIndexOf(".") + 1);
        }

        
            
        private void Save_Click(object sender, EventArgs e)
        {
            Bitmap bmpSave = (Bitmap) pictureBox1.Image;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "bmp";
            sfd.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
                bmpSave.Save(sfd.FileName, ImageFormat.Bmp);

        }


        private void Clear_Click(object sender, EventArgs e)
        {
            string FileName = "OpenFile.bmp";
            pictureBox1.ImageLocation = FileName;

            FileInfo.Text = "Path ";
            FileInfo2.Text = "Height ";
            FileInfo3.Text = "Width ";
            FileInfo4.Text = "Format ";
        }

        private void Apply_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }


        







    }
}
