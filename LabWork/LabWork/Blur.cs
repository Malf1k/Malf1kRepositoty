using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork
{
    public class BlurFilter
    {

        public static Bitmap Blur(Bitmap image1)
        {
           
            int x;
            int y;

            for (x = 2; x < image1.Width - 2; x++)
                for (y = 2; y < image1.Height - 2; y++)
                {
                    Color c1 = image1.GetPixel(x - 1, y - 1);
                    Color c2 = image1.GetPixel(x, y - 1);
                    Color c3 = image1.GetPixel(x + 1, y - 1);
                    Color c4 = image1.GetPixel(x - 1, y);
                    Color c5 = image1.GetPixel(x, y);
                    Color c6 = image1.GetPixel(x + 1, y);
                    Color c7 = image1.GetPixel(x - 1, y + 1);
                    Color c8 = image1.GetPixel(x, y + 1);
                    Color c9 = image1.GetPixel(x + 1, y + 1);
                    Color c10 = image1.GetPixel(x - 2, y - 2);
                    Color c11 = image1.GetPixel(x - 1, y - 2);
                    Color c12 = image1.GetPixel(x, y - 2);
                    Color c13 = image1.GetPixel(x + 1, y - 2);
                    Color c14 = image1.GetPixel(x + 2, y - 2);
                    Color c15 = image1.GetPixel(x - 2, y - 1);
                    Color c16 = image1.GetPixel(x - 2, y);
                    Color c17 = image1.GetPixel(x - 2, y + 1);
                    Color c18 = image1.GetPixel(x - 2, y + 2);
                    Color c19 = image1.GetPixel(x - 1, y + 2);
                    Color c20 = image1.GetPixel(x, y + 2);
                    Color c21 = image1.GetPixel(x + 1, y + 2);
                    Color c22 = image1.GetPixel(x + 1, y + 2);
                    Color c23 = image1.GetPixel(x + 2, y + 1);
                    Color c24 = image1.GetPixel(x + 2, y);
                    Color c25 = image1.GetPixel(x + 2, y - 1);


                    byte bR =
                        (byte)
                            ((c1.R + c2.R + c3.R + c4.R + c5.R + c6.R + c7.R + c8.R + c9.R + c10.R + c11.R + c12.R +
                              c13.R + c14.R + c15.R + c16.R + c17.R + c18.R + c19.R + c20.R + c21.R + c22.R + c23.R +
                              c24.R + c25.R)/25);
                    byte bG =
                        (byte)
                            ((c1.G + c2.G + c3.G + c4.G + c5.G + c6.G + c7.G + c8.G + c9.G + c10.G + c11.G + c12.G +
                              c13.G + c14.G + c15.G + c16.G + c17.G + c18.G + c19.G + c20.G + c21.G + c22.G + c23.G +
                              c24.G + c25.G)/25);
                    byte bB =
                        (byte)
                            ((c1.B + c2.B + c3.B + c4.B + c5.B + c6.B + c7.B + c8.B + c9.B + c10.B + c11.B + c12.B +
                              c13.B + c14.B + c15.B + c16.B + c17.B + c18.B + c19.B + c20.B + c21.B + c22.B + c23.B +
                              c24.B + c25.B)/25);



                    Color cBlered = Color.FromArgb(bR, bG, bB);

                    image1.SetPixel(x, y, cBlered);

                    
                }
            return image1;
        }
    }
}
