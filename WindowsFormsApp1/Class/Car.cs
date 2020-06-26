using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    class Car
    {
        private Point A = new Point(-1, -1);
        private Point B = new Point(-1, -1);
        private Point C = new Point(-1, -1);
        public void DrawEllipse(Point p1, Graphics g, int x, int y)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create rectangle for ellipse.
            Rectangle rect = new Rectangle(p1.X, p1.Y, x, y);

            // Draw ellipse to screen.
            g.DrawEllipse(blackPen, rect);
        }

        public void fillColorBlue(Graphics g, Color c)
        {
            A = new Point(850, 150); B = new Point(900, 160); C = new Point(870, 180);
            Point[] curvePoints = {A, B, C};
            g.FillPolygon(new SolidBrush(c), curvePoints);
            A = new Point(850, 150); B = new Point(820, 170); C = new Point(870, 180);
            curvePoints = new Point[] { A, B, C };
            g.FillPolygon(new SolidBrush(c), curvePoints);           
        }

        public void fillColorRed(Graphics g, Color r)
        {
            A = new Point(925, 162); B = new Point(890, 185); C = new Point(970, 170);
            Point[] curvePoints = { A, B, C };
            g.FillPolygon(new SolidBrush(r), curvePoints);
            A = new Point(950, 195); B = new Point(890, 185); C = new Point(970, 170);
            curvePoints = new Point[] { A, B, C };
            g.FillPolygon(new SolidBrush(r), curvePoints);
        }
      
        public void Draw(Graphics g)
        {
            int temp = 100;
            A.X = 200 - temp; A.Y = 500; B.X = 200 - temp; B.Y = 600;
            Line l = new Line(A, B, Color.Black); l.Draw(g);

            A.X = 500 - temp; A.Y = 650; 
            l = new Line(A, B, Color.Black); l.Draw(g);
            B.X = 500 - temp; B.Y = 550; 
            l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 200 - temp; A.Y = 500; B.X = 500 - temp; B.Y = 550; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 200 - temp; A.Y = 500; B.X = 500 - temp; B.Y = 400; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 500 - temp; A.Y = 550; B.X = 800 - temp; B.Y = 450; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 200 - temp; A.Y = 570; B.X = 180 - temp; B.Y = 590; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 180 - temp; A.Y = 610; l = new Line(A, B, Color.Black); l.Draw(g);
            B.X = 520 - temp; B.Y = 670; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 650 - temp; A.Y = 650; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 500 - temp; A.Y = 650; B.X = 670 - temp; B.Y = 630; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 650 - temp; A.Y = 650; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 630 - temp; A.Y = 630; B.X = 630 - temp; B.Y = 600; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 670 - temp; A.Y = 585; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 775 - temp; A.Y = 560; B.X = 800 - temp; B.Y = 550; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 800 - temp; A.Y = 600; l = new Line(A, B, Color.Black); l.Draw(g);
            B.X = 1305 - temp; B.Y = 450; l = new Line(A, B, Color.Black); l.Draw(g);

            //mat truoc
            A.X = 500 - temp; A.Y = 400; B.X = 800 - temp; B.Y = 440; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 920 - temp; A.Y = 250; l = new Line(A, B, Color.Black); l.Draw(g);
            B.X = 620 - temp; B.Y = 210; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 500 - temp; A.Y = 400; l = new Line(A, B, Color.Black); l.Draw(g);

            //noc xe
            A.X = 620 - temp; A.Y = 210; B.X = 1100 - temp; B.Y = 100; 
            l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 1320 - temp; A.Y = 140; l = new Line(A, B, Color.Black); l.Draw(g);
            B.X = 920 - temp; B.Y = 250; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 850; A.Y = 150; B.X = 970; B.Y = 170; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 850; A.Y = 150; B.X = 820; B.Y = 170; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 950; A.Y = 195; l = new Line(B, A, Color.Black); l.Draw(g);
            B.X = 970; B.Y = 170; l = new Line(A, B, Color.Black); l.Draw(g);
            B.X = 1000; B.Y = 180; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 970; A.Y = 170; l = new Line(B, A, Color.Black); l.Draw(g);
            A.X = 900; A.Y = 160; B.X = 870; B.Y = 180; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 920; A.Y = 165; B.X = 890; B.Y = 185; l = new Line(A, B, Color.Black); l.Draw(g);



            //thanh kinh
            A.X = 800 - temp; A.Y = 450; B.X = 1400 - temp; B.Y = 280; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 1320 - temp; A.Y = 140; B.X = 1400 - temp; B.Y = 200; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 1400 - temp; A.Y = 280; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 1120 - temp; A.Y = 195; B.X = 1100 - temp; B.Y = 365; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 1080 - temp; A.Y = 370; B.X = 1100 - temp; B.Y = 510; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 1400 - temp; A.Y = 280; B.X = 1430 - temp; B.Y = 320; l = new Line(A, B, Color.Black); l.Draw(g);
            A.X = 1430 - temp; A.Y = 400; l = new Line(A, B, Color.Black); l.Draw(g);
            B.X = 1420 - temp; B.Y = 410; l = new Line(A, B, Color.Black); l.Draw(g);

            //banh truoc
            A.X = 670 - temp; A.Y = 540;

            DrawEllipse(A, g, 120, 140);
            A.X = 690 - temp; A.Y = 560; 
            DrawEllipse(A, g, 80, 100); 
            A.X = 730 - temp; A.Y = 610; B.X = 730 - temp; B.Y = 560; l = new Line(A, B, Color.Black);
            l.Draw(g);
            B.X = 770 - temp; B.Y = 620; 
            l = new Line(A, B, Color.Black);
            l.Draw(g);
            B.X = 690 - temp; B.Y = 620;
            l = new Line(A, B, Color.Black); l = new Line(A, B, Color.Black);
            l.Draw(g);

            //banh sau
            A.X = 1300 - temp; A.Y = 350;  DrawEllipse(A, g, 120, 140); 
            A.X = 1320 - temp; A.Y = 370;  DrawEllipse(A, g, 80, 100); 
            A.X = 1360 - temp; A.Y = 420; B.X = 1360 - temp; B.Y = 370;

            l = new Line(A, B, Color.Black); l.Draw(g);
            B.X = 1400 - temp; B.Y = 430; l = new Line(A, B, Color.Black); l.Draw(g);
            B.X = 1320 - temp; B.Y = 430; l = new Line(A, B, Color.Black); l.Draw(g);

            //đèn
            A.X = 230 - temp; A.Y = 530;  DrawEllipse(A, g, 40, 60);
            A.X = 430 - temp; A.Y = 560;  DrawEllipse(A, g, 45, 65);

            //tô màu đèn
            fillColorBlue(g, Color.Blue);
            fillColorRed(g, Color.Red);
        }
    }
}
