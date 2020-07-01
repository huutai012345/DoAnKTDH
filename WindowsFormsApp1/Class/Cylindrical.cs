using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    class Cylindrical
    {
        private Point p1, p2, p3, p4, p5, p6;
        int r;
        public int round(double x)
        {
            int tdm;
            double sodu = x % 5;
            if (sodu != 0)
            {
                if (sodu >= 3) tdm = (int)(x + 5 - sodu);
                else tdm = (int)(x - sodu);
            }
            else tdm = (int)x;
            if (tdm > 1600) tdm = 1600;
            return tdm;
        }

        public int changeX3Dto2D(int x, int y, int z)
        {
            return round(x - y * (Math.Sqrt(2) / 2) + 680);
        }

        public int changeY3Dto2D(int x, int y, int z)
        {
            return round(385 - (z - y * (Math.Sqrt(2) / 2)));
        }

        public Cylindrical(int h, int r, int x, int y, int z)
        {
            this.r = r / 2;
            x = x * 5; y = y * 5; z = z * 5; r = r * 5; h = h * 5;
            this.p1 = new Point(changeX3Dto2D(x, y, z), changeY3Dto2D(x, y, z));
            this.p2 = new Point(changeX3Dto2D(x, y, z + h), changeY3Dto2D(x, y, z + h));
            this.p3 = new Point(changeX3Dto2D(x - r/2, y, z), changeY3Dto2D(x - r/2, y, z));
            this.p4 = new Point(changeX3Dto2D(x + r/2, y, z), changeY3Dto2D(x + r/2, y, z));
            this.p5 = new Point(changeX3Dto2D(x - r/2, y, z + h), changeY3Dto2D(x - r/2, y, z + h));
            this.p6 = new Point(changeX3Dto2D(x + r/2, y, z + h), changeY3Dto2D(x + r/2, y, z + h));
        }

        public void Draw(Graphics g)
        {
            Line l;
            HinhElip e;

            e = new HinhElip(this.p1, r, r / 2, Color.Black);
            e.Draw(g);

            e = new HinhElip(this.p2, r, r / 2, Color.Black);
            e.Draw(g);

            l = new Line(this.p3, this.p5, Color.Black);
            l.Draw(g);

            l = new Line(this.p4, this.p6, Color.Black);
            l.Draw(g);
        }
    }
}
