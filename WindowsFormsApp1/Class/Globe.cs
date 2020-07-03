using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    class Globe
    {
        private Point I;
        private int r;
       
        public Globe(int r, int x, int y, int z)
        {
            this.r = r/2;
            this.I = new Point(Pixel.changeX3Dto2D(x, y, z), Pixel.changeY3Dto2D(x, y, z));
        }

        public void Draw(Graphics g)
        {
            HinhTron ht = new HinhTron(this.r, this.I, Color.Black);
            ht.Draw(g);

            Elip he = new Elip(this.I, this.r, this.r * 1 / 4, Color.Black);
            he.Draw3d(g);
        }
    }
}
