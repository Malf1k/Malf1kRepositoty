using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork
{
    public class ColorShiftFilter
    {
        
        public static Bitmap Cshift(Bitmap image1, int rs, int gs, int bs )
        {
  
            int x;
            int y;
            
            for(x = 0; x < image1.Width; x++)
            {
                for (y = 0; y < image1.Height; y++)
                {
                    Color cs = image1.GetPixel(x, y);
                    
                    int csR = (cs.R + rs*128/100);
                    if (csR > 255)
                    {
                        csR = 255;
                    }
                    if (csR < 0)
                    {
                        csR = 0;
                    }
                    
                    int csG = (cs.G + gs);
                    if (csG > 255)
                    {
                        csG = 255;
                    }
                    if (csG < 0)
                    {
                        csG = 0;
                    }
                    
                   
                    int csB = (cs.B + bs);
                    if (csB > 255)
                    {
                        csB = 255;
                    }
                    if (csB < 0)
                    {
                        csB = 0;
                    }
                   

                    Color cCshift = Color.FromArgb(csR, csB, csG);
                    image1.SetPixel(x,y,cCshift);
                }
                
            }

            return image1;

            
        }
    }
}
