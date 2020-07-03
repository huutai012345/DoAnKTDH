using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    class AirLane
    {
        private Point A = new Point(-1, -1);
        private Point B = new Point(-1, -1);

        public void Plane(Graphics g)
        {
            Line l = new Line(A, B, Color.Black);
            HinhTron circle = new HinhTron(10, A, Color.Black);

            //mat truoc
            A.X = 300; A.Y = 550; B.X = 520; B.Y = 540; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 500; A.Y = 450; B.X = 550; B.Y = 650; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 670; A.Y = 530; B.X = 850; B.Y = 520; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 850; A.Y = 520; B.X = 950; B.Y = 500; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 950; A.Y = 500; B.X = 1000; B.Y = 450; l = new Line(A, B, Color.Black); l.Draw(g);

            //kính trước
            A.X = 290; A.Y = 330; B.X = 350; B.Y = 330; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 350; A.Y = 330; B.X = 350; B.Y = 400; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 350; A.Y = 400; B.X = 200; B.Y = 400; l = new Line(A, B, Color.Black); l.Draw(g);

            //khung tròn
            A.X = 420; A.Y = 400; circle = new HinhTron(20, A, Color.Black); circle.Draw(g);
            A.X = 480; A.Y = 400; circle = new HinhTron(20, A, Color.Black); circle.Draw(g);
            A.X = 540; A.Y = 400; circle = new HinhTron(20, A, Color.Black); circle.Draw(g);
            A.X = 860; A.Y = 400; circle = new HinhTron(20, A, Color.Black); circle.Draw(g);
            A.X = 920; A.Y = 400; circle = new HinhTron(20, A, Color.Black); circle.Draw(g);

            //cánh trái
            A.X = 550; A.Y = 650; B.X = 620; B.Y = 630; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 620; A.Y = 630; B.X = 700; B.Y = 450; l = new Line(A, B, Color.Black); l.Draw(g);

            //cánh phải
            A.X = 550; A.Y = 320; B.X = 610; B.Y = 210; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 610; A.Y = 210; B.X = 680; B.Y = 240; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 680; A.Y = 240; B.X = 700; B.Y = 340; l = new Line(A, B, Color.Black); l.Draw(g);

            //cánh đuôi
            A.X = 950; A.Y = 410; B.X = 1050; B.Y = 480; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 1050; A.Y = 480; B.X = 1070; B.Y = 480; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 1070; A.Y = 480; B.X = 1000; B.Y = 410; l = new Line(A, B, Color.Black); l.Draw(g);

            //đuôi
            A.X = 1020; A.Y = 430; B.X = 1070; B.Y = 380; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 1070; A.Y = 380; B.X = 1070; B.Y = 250; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 1070; A.Y = 250; B.X = 1040; B.Y = 270; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 1040; A.Y = 270; B.X = 1000; B.Y = 370; l = new Line(A, B, Color.Black); l.Draw(g);

            //nóc
            A.X = 1000; A.Y = 370; B.X = 320; B.Y = 300; l = new Line(A, B, Color.Black); l.Draw(g);

            //đầu
            A.X = 320; A.Y = 300; B.X = 200; B.Y = 400; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 200; A.Y = 400; B.X = 180; B.Y = 450; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 180; A.Y = 450; B.X = 180; B.Y = 480; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 180; A.Y = 480; B.X = 250; B.Y = 530; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 250; A.Y = 530; B.X = 300; B.Y = 550; l = new Line(A, B, Color.Black); l.Draw(g);

            //động cơ
            A.X = 500; A.Y = 580; circle = new HinhTron(15, A, Color.Black); circle.Draw(g);
            A.X = 500; A.Y = 565; B.X = 530; B.Y = 565; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 500; A.Y = 595; B.X = 535; B.Y = 595; l = new Line(A, B, Color.Black); l.Draw(g);

            A.X = 520; A.Y = 620; circle = new HinhTron(12, A, Color.Black); circle.Draw(g);
            A.X = 520; A.Y = 608; B.X = 540; B.Y = 608; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 520; A.Y = 632; B.X = 545; B.Y = 632; l = new Line(A, B, Color.Black); l.Draw(g);
        }

        public void Cloud(Graphics g)
        {
            int a = -1, b = -1;
            Elip e = new Elip(A, a, b, Color.Black);

            A = new Point(100, 100); a = 200; b = 100; e = new Elip(A, a, b, Color.Black); e.Draw(g); e.FillColor(g, Color.Aqua);
            A = new Point(500, 200); a = 100; b = 50; e = new Elip(A, a, b, Color.Black); e.Draw(g); e.FillColor(g, Color.Aqua);
            A = new Point(1000, 700); a = 150; b = 75; e = new Elip(A, a, b, Color.Black); e.Draw(g); e.FillColor(g, Color.Aqua);
        }

        public void Sun(Graphics g)
        {
            A = new Point(1400, 0);
            HinhTron circle = new HinhTron(200, A, Color.Black);
            circle.Draw(g);
            circle.FillColor(g, Color.Red);
        }

        public void Draw(Graphics g)
        {
            Plane(g);
            Cloud(g);
            Sun(g);
        }
    }
}
