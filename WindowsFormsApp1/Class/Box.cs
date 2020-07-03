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
      
      
        public Box(int leng, int x, int y, int z, Color color)
        {
            this.color = color;
         
            this.p1 = new Point(Pixel.changeX3Dto2D(x, y, z), Pixel.changeY3Dto2D(x, y, z));
            this.p2 = new Point(Pixel.changeX3Dto2D(x, y, z + leng), Pixel.changeY3Dto2D(x, y, z+leng));
            this.p3 = new Point(Pixel.changeX3Dto2D(x, y+leng, z), Pixel.changeY3Dto2D(x, y+leng, z));
            this.p4 = new Point(Pixel.changeX3Dto2D(x, y+leng, z+leng), Pixel.changeY3Dto2D(x, y+leng, z+leng));
            this.p5 = new Point(Pixel.changeX3Dto2D(x+leng, y, z), Pixel.changeY3Dto2D(x+leng, y, z));
            this.p6 = new Point(Pixel.changeX3Dto2D(x+leng, y+leng, z), Pixel.changeY3Dto2D(x+leng, y+leng, z));
            this.p7 = new Point(Pixel.changeX3Dto2D(x+leng, y, z+leng), Pixel.changeY3Dto2D(x+leng, y, z+leng));
            this.p8 = new Point(Pixel.changeX3Dto2D(x+leng, y+leng, z+leng), Pixel.changeY3Dto2D(x+leng, y+leng, z+leng)); 
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
