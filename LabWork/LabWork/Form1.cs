using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public UInt32[,] Pixel;
        public static Bitmap image1;
        public static Bitmap image2;
        public static int rs;
        public static int bs;
        public static int gs;

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Open_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.ShowDialog();
            var imageOi = openFile.FileName;
            image1 = new Bitmap (imageOi);
            image2 = new Bitmap(imageOi);
            pictureBox1.Image = image1;
            pictureBox2.Image = image2;
           
            FileInfo.Text = "Path: " + imageOi;
            FileInfo2.Text = "Height: " + image1.Height;
            FileInfo3.Text = "Width: " + image1.Width;
            FileInfo4.Text = "Format: " + imageOi.Substring(imageOi.LastIndexOf(".") + 1);
            
            if (image1 == null)
            {
                Save.Enabled = false;
                Clear.Enabled = false;
                checkedListBox1.Enabled = false;

            }
            else
            {
                Save.Enabled = true;
                Clear.Enabled = true;
                checkedListBox1.Enabled = true;

            }

//            Pixel = new UInt32[image1.Width, image1.Height];
//            for(int y = 0; y < image1.Width; y++)
//                for (int x = 0; x < image1.Height; x++)
//                    Pixel[x, y] = (UInt32) (image1.GetPixel(x, y).ToArgb());
        }

//        public void FromBitmapToScreen()
//        {
//            pictureBox1.Image = image1;
//        }

        public void Save_Click(object sender, EventArgs e)
        {
            Bitmap bmpSave = (Bitmap) pictureBox2.Image;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "bmp";
            sfd.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
                bmpSave.Save(sfd.FileName, ImageFormat.Bmp);

        }


        public void Clear_Click(object sender, EventArgs e)
        {
            string image = "OpenFile.bmp";
            pictureBox1.ImageLocation = image;

            FileInfo.Text = "Path ";
            FileInfo2.Text = "Height ";
            FileInfo3.Text = "Width ";
            FileInfo4.Text = "Format ";

            if (image1 != null)
            {
                Save.Enabled = false;
                Clear.Enabled = false;
                checkedListBox1.Enabled = false;
            }
            else
            {
                Save.Enabled = true;
                Clear.Enabled = true;
                checkedListBox1.Enabled = true;
            }
        }

        public void Apply_Click(object sender, EventArgs e)
        {
            int i = checkedListBox1.SelectedIndex;
            
            if(i == 1 )
            {
                image1 = BlurFilter.Blur(image1,image2);
                pictureBox2.Image = image2;
            }
            if (i == 2)
            {
                image1 = InversFilter.Invers(image1, image2);
                pictureBox2.Image = image2;
            }
            if (i == 3)
            {
                image1 = ColorShiftFilter.Cshift(image1, rs, gs, bs, image2);
                pictureBox2.Image = image2;
            }
//            image1 = BlurFilter.Blur(image1);
//            pictureBox1.Image = image1;
        }
        

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


            if (checkedListBox1.SelectedIndex != 0)
                {
                    ApplyFilter.Enabled = true;
                }
                else
                {
                    ApplyFilter.Enabled = false;
                }
            if (checkedListBox1.SelectedIndex == 3)
            {
                RedChange.Visible = true;
                GreenChange.Visible = true;
                BlueChange.Visible = true;
                RGBlabel1.Visible = true;
                
            }
            else
            {
                RedChange.Visible = false;
                GreenChange.Visible = false;
                BlueChange.Visible = false;
                
            }

        }

        public void ChangeShift()
        {
            
            RedChange.BackColor = Color.FromArgb(255 - Math.Abs(RedChange.Value), Math.Abs(GreenChange.Value), Math.Abs(BlueChange.Value));
            GreenChange.BackColor = Color.FromArgb(Math.Abs(RedChange.Value), 255 - Math.Abs(GreenChange.Value), Math.Abs(BlueChange.Value));
            BlueChange.BackColor = Color.FromArgb(Math.Abs(RedChange.Value), Math.Abs(GreenChange.Value), 255 - Math.Abs(BlueChange.Value));

        }

        public void RgbLabel()
        {
            RGBlabel1.Text = "Red: " + RedChange.Value + ", Green: " + GreenChange.Value + ", Blue: " + BlueChange.Value;
        }

        

        public void RedChange_Scroll(object sender, EventArgs e)
        {
           
            ChangeShift();
            RgbLabel();
            
            int r = RedChange.Value;
            rs = r;



        }
        
        public void GreenChange_Scroll(object sender, EventArgs e)
        {
            ChangeShift();
            RgbLabel();
            int g = GreenChange.Value;
            gs = g;
        }

        public void BlueChange_Scroll(object sender, EventArgs e)
        {
            ChangeShift();
            RgbLabel();
            int b = BlueChange.Value;
            bs = b;
        }

        

       


    }
}
