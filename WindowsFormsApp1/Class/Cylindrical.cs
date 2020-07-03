using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    class Cylindrical
    {
        private Point p1, p2, p3, p4, p5, p6;
        int r;
       

        public Cylindrical(int h, int r, int x, int y, int z)
        {
            this.r = r / 2;
           
            this.p1 = new Point(Pixel.changeX3Dto2D(x, y, z), Pixel.changeY3Dto2D(x, y, z));
            this.p2 = new Point(Pixel.changeX3Dto2D(x, y, z + h), Pixel.changeY3Dto2D(x, y, z + h));
            this.p3 = new Point(Pixel.changeX3Dto2D(x - r / 2, y, z), Pixel.changeY3Dto2D(x - r / 2, y, z));
            this.p4 = new Point(Pixel.changeX3Dto2D(x + r / 2, y, z), Pixel.changeY3Dto2D(x + r / 2, y, z));
            this.p5 = new Point(Pixel.changeX3Dto2D(x - r / 2, y, z + h), Pixel.changeY3Dto2D(x - r / 2, y, z + h));
            this.p6 = new Point(Pixel.changeX3Dto2D(x + r / 2, y, z + h), Pixel.changeY3Dto2D(x + r / 2, y, z + h));
        }

        public void Draw(Graphics g)
        {
            Line l;
            Elip e;

            e = new Elip(this.p1, r, r / 2, Color.Black);
            e.Draw3d(g);

            e = new Elip(this.p2, r, r / 2, Color.Black);
            e.Draw(g);

            l = new Line(this.p3, this.p5, Color.Black);
            l.Draw(g);

            l = new Line(this.p4, this.p6, Color.Black);
            l.Draw(g);
        }
    }
}
