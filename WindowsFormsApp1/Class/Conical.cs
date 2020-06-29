using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    class Conical
    {
        private Point I, p1, p2, p3;
        private int r;
        private Color color;
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

        public Conical(int r, int h, int x, int y, int z, Color color)
        {
            this.color = color;
            this.r = r;
            x = x * 5; y = y * 5; z = z * 5; h = h * 5; r = r * 5;
            this.I = new Point(changeX3Dto2D(x, y, z), changeY3Dto2D(x, y, z));
            this.p1 = new Point(changeX3Dto2D(x, y, z + h), changeY3Dto2D(x, y, z + h));
            this.p2 = new Point(changeX3Dto2D(x - r, y, z), changeY3Dto2D(x - r, y, z));
            this.p3 = new Point(changeX3Dto2D(x + r, y, z), changeY3Dto2D(x + r, y, z));
        }

        public void Draw(Graphics g)
        {
            HinhElip el = new HinhElip(this.I, r, r - r/2, Color.Black);
            el.Draw3d(g);

            Line l;
            l = new Line(this.p1, this.p2, Color.Black);
            l.Draw(g);

            l = new Line(this.p1, this.p3, Color.Black);
            l.Draw(g);
        }
    }
}
