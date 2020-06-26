using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    class Car2d
    {
        private HinhTron banh1;
        private HinhTron banh2;
        private HinhTron vanh1;
        private HinhTron vanh2;
        private Line trucBanh1;
        private Line trucBanh2;
        private HinhChuNhat thanxe;
        private HinhThangCan nocxe;
        private Graphics g;
        private Line l1;
        private HinhTron light;

        public Car2d(Graphics g)
        {
            this.g = g;

            banh1 = new HinhTron(25, new Point(550, 650), Color.Black);
            banh2 = new HinhTron(25, new Point(700, 650), Color.Black);

            vanh1 = new HinhTron(banh1.Radius+10, banh1.Point, Color.Black);
            vanh2 = new HinhTron(banh2.Radius + 10, banh2.Point, Color.Black);

            trucBanh1 = new Line(new Point(banh1.Point.X, banh1.Point.Y-banh1.Radius), new Point(banh1.Point.X, banh1.Point.Y + banh1.Radius), Color.Black);
            trucBanh2 = new Line(new Point(banh2.Point.X, banh2.Point.Y - banh2.Radius), new Point(banh2.Point.X, banh2.Point.Y + banh2.Radius), Color.Black);

            thanxe = new HinhChuNhat(new Point(banh1.Point.X-100, banh1.Point.Y-70), new Point(banh2.Point.X+100, banh2.Point.Y), Color.Black);
            nocxe = new HinhThangCan(new Point(banh1.Point.X+20 , banh1.Point.Y - 140), new Point(banh2.Point.X +20, banh2.Point.Y-70), Color.Black,30);

            l1 = new Line(new Point(banh1.Point.X + 80, banh1.Point.Y - 135), new Point(banh1.Point.X + 80, banh2.Point.Y-75), Color.Red);

            light = new HinhTron(10, new Point(banh1.Point.X - 70, banh1.Point.Y - 40), Color.Black);
        }
        public void Draw()
        {
            thanxe.FillColor(g, Color.FromArgb(255, 255, 0));
            thanxe.Draw(g);
            nocxe.FillColor(g, Color.FromArgb(1, 244, 198));
            nocxe.Draw(g);

            vanh1.Draw(g);
            vanh2.Draw(g);

            vanh1.FillColor(g,Color.FromArgb(174, 162, 121));
            vanh2.FillColor(g, Color.FromArgb(174, 162, 121));

            banh1.Draw(g);
            banh2.Draw(g);

            banh1.FillColor(g, Color.White);
            banh2.FillColor(g, Color.White);

            trucBanh1.Draw(g);
            trucBanh2.Draw(g);

            l1.Draw(g);
            light.Draw(g);
            light.FillColor(g, Color.Red);
        }

        public void Draw1()
        {
            banh1.Draw(g);
            banh2.Draw(g);

            trucBanh1.Draw(g);
            trucBanh2.Draw(g);

        }

        public void Delete()
        {
            trucBanh1.Delete(g);
            trucBanh2.Delete(g);
        }

        public void TinhTien()
        {
            banh1.Point = Transformations.TinhTien(banh1.Point, 5, 0);
            banh2.Point = Transformations.TinhTien(banh2.Point, 5, 0);
        }

        public void Quay()
        {
            trucBanh1.A = Transformations.Quay(trucBanh1.A, banh1.Point, 10);
            trucBanh1.B = Transformations.Quay(trucBanh1.B, banh1.Point,10);

            trucBanh2.A = Transformations.Quay(trucBanh2.A, banh2.Point, 10);
            trucBanh2.B = Transformations.Quay(trucBanh2.B, banh2.Point, 10);
        }

        public void run()
        {
            //this.TinhTien();
            this.Delete();
            this.Quay();
            this.Draw1();
        }
    }
}
