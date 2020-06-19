using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    public static class Transformations
    {
        public static Point ToSmall(this Point p)
        {
            return (new Point(p.X / 5 - 40, 40 - p.Y / 5));//voi x va y deu chia het cho 5
        }

        public static Point ToBig(this Point p)//nho ra lon
        {

            return (new Point(p.X * 5 + 200, 200 - 5 * p.Y));
        }


    }
}
