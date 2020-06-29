using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    class Box
    {
        private Point p1, p2, p3, p4, p5,p6,p7,p8;
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
            return round(x - y *(Math.Sqrt(2)/2) + 680);
        }

        public int changeY3Dto2D(int x, int y, int z)
        {
            return round(385 - (z - y * (Math.Sqrt(2) / 2)));
        }

        public Box(int leng, int x, int y, int z, Color color)
        {
            this.color = color;
            x = x * 5; y = y * 5; z = z * 5; leng = leng * 5;
            this.p1 = new Point(changeX3Dto2D(x, y, z), changeY3Dto2D(x, y, z));
            this.p2 = new Point(changeX3Dto2D(x, y, z + leng), changeY3Dto2D(x, y, z+leng));
            this.p3 = new Point(changeX3Dto2D(x, y+leng, z), changeY3Dto2D(x, y+leng, z));
            this.p4 = new Point(changeX3Dto2D(x, y+leng, z+leng), changeY3Dto2D(x, y+leng, z+leng));
            this.p5 = new Point(changeX3Dto2D(x+leng, y, z), changeY3Dto2D(x+leng, y, z));
            this.p6 = new Point(changeX3Dto2D(x+leng, y+leng, z), changeY3Dto2D(x+leng, y+leng, z));
            this.p7 = new Point(changeX3Dto2D(x+leng, y, z+leng), changeY3Dto2D(x+leng, y, z+leng));
            this.p8 = new Point(changeX3Dto2D(x+leng, y+leng, z+leng), changeY3Dto2D(x+leng, y+leng, z+leng)); 
        }

        public void Draw(Graphics g)
        {           
            Line l = new Line(new Point(-1, -1), new Point(-2, -2), color);

            l = new Line(this.p1, this.p2, color);
            l.DrawNetChamDut(g);

            l = new Line(this.p1, this.p3, color);
            l.DrawNetChamDut(g);

            l = new Line(this.p1, this.p5, color);
            l.DrawNetChamDut(g);

            l = new Line(this.p2, this.p4, color);
            l.Draw(g);

            l = new Line(this.p2, this.p7, color);
            l.Draw(g);

            l = new Line(this.p3, this.p4, color);
            l.Draw(g);

            l = new Line(this.p3, this.p6, color);
            l.Draw(g);

            l = new Line(this.p4, this.p8, color);
            l.Draw(g);

            l = new Line(this.p5, this.p6, color);
            l.Draw(g);

            l = new Line(this.p5, this.p7, color);
            l.Draw(g);

            l = new Line(this.p6, this.p8, color);
            l.Draw(g);

            l = new Line(this.p7, this.p8, color);
            l.Draw(g);
        }
    }
}
