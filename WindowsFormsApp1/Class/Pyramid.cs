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
      
        //height, leng, x, y, z là tọa độ truyền vào
        public Pyramid(int height, int leng, int x, int y, int z)
        {
            leng = leng / 2;
          
            this.I = new Point(Pixel.changeX3Dto2D(x, y, z + height), Pixel.changeY3Dto2D(x, y, z + height));
            this.p1 = new Point(Pixel.changeX3Dto2D(x + leng, y - leng, z), Pixel.changeY3Dto2D(x + leng, y - leng,z));
            this.p2 = new Point(Pixel.changeX3Dto2D(x - leng, y - leng, z), Pixel.changeY3Dto2D(x - leng, y - leng, z));
            this.p3 = new Point(Pixel.changeX3Dto2D(x - leng, y + leng, z), Pixel.changeY3Dto2D(x - leng, y + leng, z));
            this.p4 = new Point(Pixel.changeX3Dto2D(x + leng, y + leng, z), Pixel.changeY3Dto2D(x + leng, y + leng, z));
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
