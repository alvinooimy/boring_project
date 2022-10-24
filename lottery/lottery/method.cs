using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    class method
    {
        public static double speedcalculation(double speed, int numb)
        {
            try
            {
                double orilength = data.horsespeed[Convert.ToString(numb)];
                double newlength = orilength + speed;

                data.horsespeed.Remove(Convert.ToString(numb));
                data.horsespeed.Add(Convert.ToString(numb), newlength);
                return 0;
            }
            catch
            {
                double newlength = 1 + speed;
                data.horsespeed.Add(Convert.ToString(numb), newlength);

                return 0;
            }
        }
    }
}
