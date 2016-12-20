using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    class InversFilter
    {

        public static Bitmap Invers(Bitmap image1, Bitmap image2)
        {
            
            int x;
            int y;
            
            for (x = 0; x < image1.Width; x++)
                for (y = 0; y < image1.Height; y++)
                {
                    Color color = image1.GetPixel(x, y);
                    byte iR = (byte) (255 - color.R);
                    byte iG = (byte) (255 - color.G);
                    byte iB = (byte) (255 - color.B);

                    Color cInversed = Color.FromArgb(iR, iG, iB);
                    image2.SetPixel(x, y, cInversed);
                }
            
            return image2;
        }
    }
}
