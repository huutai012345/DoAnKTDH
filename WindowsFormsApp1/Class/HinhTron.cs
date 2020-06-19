using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    class HinhTron
    {
        private Point p;
        private int radius;
        private Color color;

        public Point Point
        {
            get => p;
            set => p = value;
        }

        public int Radius
        {
            get => radius;
            set => radius = value;
        }

        public void Drawn8Point(int x, int y, Graphics g, Color color)
        {
            ToaDo.HienThi(x + p.X, y + p.Y, g, color);
            ToaDo.HienThi(y + p.X, x + p.Y, g, color);
            ToaDo.HienThi(-x + p.X, -y + p.Y, g, color);
            ToaDo.HienThi(-y + p.X, -x + p.Y, g, color);
            ToaDo.HienThi(-x + p.X, y + p.Y, g, color);
            ToaDo.HienThi(-y + p.X, x + p.Y, g, color);
            ToaDo.HienThi(x + p.X, -y + p.Y, g, color);
            ToaDo.HienThi(y + p.X, -x + p.Y, g, color);
        }

        public HinhTron(int bk, Point tamht, Color m)
        {
            Radius = bk;
            p = new Point(tamht.X, tamht.Y);
            color = m;
        }

       
        public void Draw(Graphics g)
        {
            int x = 0,
             y = Radius,
             p = 3 - 2 * Radius;
            while (x <= y)
            {
                if (p < 0)
                    p = p + 4 * x - 6;
                else
                {
                    y -= 5;
                    p = p + 4 * (x - y) + 10;
                }
                Drawn8Point(x, y, g, color);
                x += 5;
            }
        }


        private void FillColor(Graphics g,Color color)
        {
            //Point p = ToaDo
            g.FillEllipse(new SolidBrush(color), this.p.X - radius, this.p.Y - radius, radius * 2 + 3, radius * 2 + 3);
        }
    }
}
