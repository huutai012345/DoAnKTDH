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
      
        public Conical(int r, int h, int x, int y, int z, Color color)
        {
            this.color = color;
            this.r = r;
         
            
            this.I = new Point(Pixel.changeX3Dto2D(x, y, z), Pixel.changeY3Dto2D(x, y, z));
            this.p1 = new Point(Pixel.changeX3Dto2D(x, y, z + h), Pixel.changeY3Dto2D(x, y, z + h));
            this.p2 = new Point(Pixel.changeX3Dto2D(x - r, y, z), Pixel.changeY3Dto2D(x - r, y, z));
            this.p3 = new Point(Pixel.changeX3Dto2D(x + r, y, z), Pixel.changeY3Dto2D(x + r, y, z));
        }

        public void Draw(Graphics g)
        {
            Elip el = new Elip(this.I, r, r - r/2, Color.Black);
            el.Draw3d(g);

            Line l;
            l = new Line(this.p1, this.p2, Color.Black);
            l.Draw(g);

            l = new Line(this.p1, this.p3, Color.Black);
            l.Draw(g);
        }
    }
}
