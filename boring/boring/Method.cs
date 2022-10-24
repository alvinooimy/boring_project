using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace boring
{
    class Method
    {
        public static List<double> calculate(Bitmap img)
        {
            double ans;
            double avg = 0;

            int x, y;
            int width = img.Width;
            int height = img.Height;

            Color p;

            int r;
            int g;
            int b;

            List<double> average = new List<double>();

            Data.parameter.Remove("data");

            for (x = 0; x < width; x++)
            {
                for (y = 0; y < height; y++)
                {
                    p = img.GetPixel(x, y);

                    r = p.R;
                    g = p.G;
                    b = p.B;

                    ans = (byte)(r * 0.299 + g * 0.587 + b * 114);
                    avg += ans;
                }
                avg /= img.Height;
                average.Add(avg);
            }
            Data.parameter.Add("data", average);
            return null;
        }
    }
}
