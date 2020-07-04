using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Class
{
    class Moon
    {
        private Point p;
        private int r;

        public Moon(Point p,int r)
        {
            this.P = p;
            this.R = r;
        }

        public Point P { get => p; set => p = value; }
        public int R { get => r; set => r = value; }

        public void Draw(Graphics g)
        {
            HinhTron ht1 = new HinhTron(r, p, Color.FromArgb(242, 222, 168));
            ht1.FillColor(g, Color.FromArgb(242, 222, 168));

            HinhTron ht2 = new HinhTron(r-2, new Point(p.X+10,p.Y+2), Color.FromArgb(30, 46, 60));
            ht2.FillColor(g, Color.FromArgb(30, 46, 60));

        }
    }
}
