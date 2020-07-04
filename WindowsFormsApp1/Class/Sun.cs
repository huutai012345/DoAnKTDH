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
        private HinhTron hinhTron;
        private Elip mieng;
        private HinhTron mat1;
        private HinhTron mat2;

        public HinhTron hc { get => hinhTron; set => hinhTron = value; }

        public Sun(Point p1,int radius)
        {
            hinhTron = new HinhTron(radius, p1, Color.Black);
            mieng = new Elip(new Point(this.hinhTron.Point.X,this.hinhTron.Point.Y+30), 25, 10, Color.Black);
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
            HinhTron ht1 = new HinhTron(this.hinhTron.Radius, Transformations.TinhTien(this.hinhTron.Point,3,-3), Color.FromArgb(62, 155, 244));
            ht1.Draw(g);
            
        }

        public void DeleteDem(Graphics g)
        {
            HinhTron ht1 = new HinhTron(this.hinhTron.Radius, Transformations.TinhTien(this.hinhTron.Point, 3, -3), Color.FromArgb(30, 46, 60));
            ht1.Draw(g);


        }

    }
}
