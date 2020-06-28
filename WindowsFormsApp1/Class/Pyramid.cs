using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    class Pyramid
    {
        private Point I, p1, p2, p3, p4;
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

        //height, leng, x, y, z là tọa độ truyền vào
        public Pyramid(int height, int leng, int x, int y, int z)
        {
            leng = leng / 2;
            x = x * 5; y = y * 5; z = z * 5; leng = leng * 5; height = height * 5;
            this.I = new Point(changeX3Dto2D(x, y, z + height), changeY3Dto2D(x, y, z + height));
            this.p1 = new Point(changeX3Dto2D(x + leng, y - leng, z), changeY3Dto2D(x + leng, y - leng,z));
            this.p2 = new Point(changeX3Dto2D(x - leng, y - leng, z), changeY3Dto2D(x - leng, y - leng, z));
            this.p3 = new Point(changeX3Dto2D(x - leng, y + leng, z), changeY3Dto2D(x - leng, y + leng, z));
            this.p4 = new Point(changeX3Dto2D(x + leng, y + leng, z), changeY3Dto2D(x + leng, y + leng, z));
        }

        public void Draw(Graphics g)
        {
            Line l;

            l = new Line(this.I, this.p1, Color.Black);
            l.Draw(g);

            l = new Line(this.I, this.p2, Color.Black);
            l.DrawNetChamDut(g);

            l = new Line(this.I, this.p3, Color.Black);
            l.Draw(g);

            l = new Line(this.I, this.p4, Color.Black);
            l.Draw(g);

            l = new Line(this.p1, this.p2, Color.Black);
            l.DrawNetChamDut(g);

            l = new Line(this.p1, this.p4, Color.Black);
            l.Draw(g);

            l = new Line(this.p2, this.p3, Color.Black);
            l.DrawNetChamDut(g);

            l = new Line(this.p3, this.p4, Color.Black);
            l.Draw(g);


        }
    }
}
