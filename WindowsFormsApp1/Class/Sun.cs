using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    class Sun
    {
        private Point p1;
        private int radius;
        private HinhTron hinhTron;
        private HinhElip mieng;
        private HinhTron mat1;
        private HinhTron mat2;

        public Point point { get => p1; set => p1 = value; }

        public Sun(Point p1,int radius)
        {
            this.p1 = p1;
            this.radius = radius;
            hinhTron = new HinhTron(radius, p1, Color.Black);
            mieng = new HinhElip(new Point(this.hinhTron.Point.X,this.hinhTron.Point.Y+30), 25, 10, Color.Black);
            mat1 = new HinhTron(10,new Point(p1.X-40, p1.Y-15), Color.Black);
            mat2 = new HinhTron(10,new Point(p1.X+40, p1.Y - 15), Color.Black);
        }
        
        public void Draw(Graphics g)
        {
           // hinhTron.Draw(g);
            hinhTron.FillColor(g, Color.Yellow);
            mieng.Draw(g);
            mat1.Draw(g);
            mat2.Draw(g);
        }

        public void DeleteNgay(Graphics g)
        {
            HinhTron ht1 = new HinhTron(this.radius, Transformations.TinhTien(p1, -1, 0), Color.FromArgb(30, 46, 60));
            ht1.Draw(g);
            
        }

        public void DeleteDem(Graphics g)
        {
            HinhTron ht1 = new HinhTron(this.radius, Transformations.TinhTien(p1, -1, 0), Color.FromArgb(62, 155, 244));
            ht1.Draw(g);
            
        }

    }
}
