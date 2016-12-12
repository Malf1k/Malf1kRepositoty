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
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            string FileName = openFile.FileName;
            pictureBox1.ImageLocation = FileName;
            

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

        }

        private void Apply_Click(object sender, EventArgs e)
        {

        }
        public int GetIntensivity(Bitmap bmpConvert, int x, int y)
        {
            Color c = bmpConvert.GetPixel(x, y);
            byte rgb = (byte)(0.3 * c.R + 0.59 * c.G + 0.11 * c.B);
            return rgb;
        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        

        

       
    }
}
