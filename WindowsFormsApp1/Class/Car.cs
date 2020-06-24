using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    class Car
    {
        private Point A = new Point(-1, -1);
        private Point B = new Point(-1, -1);

        public void DrawEllipse(Point p1, Graphics g, int x, int y)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create rectangle for ellipse.
            Rectangle rect = new Rectangle(p1.X, p1.Y, x, y);

            // Draw ellipse to screen.
            g.DrawEllipse(blackPen, rect);
        }


      
        public void Draw(Graphics g)
        {
            A.X = 200; A.Y = 500; B.X = 200; B.Y = 600;
            Line l = new Line(A, B, Color.Black);
            l.Draw(g);

            A.X = 500; A.Y = 650; 
            l = new Line(A, B, Color.Black);
            l.Draw(g);
            B.X = 500; B.Y = 550; 
            l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 200; A.Y = 500; B.X = 500; B.Y = 550; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 200; A.Y = 500; B.X = 500; B.Y = 400; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 500; A.Y = 550; B.X = 800; B.Y = 450; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 200; A.Y = 570; B.X = 180; B.Y = 590; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 180; A.Y = 610; l = new Line(A, B, Color.Black);
            l.Draw(g);
            B.X = 520; B.Y = 670; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 650; A.Y = 650; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 500; A.Y = 650; B.X = 670; B.Y = 630; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 650; A.Y = 650; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 630; A.Y = 630; B.X = 630; B.Y = 600; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 680; A.Y = 580; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 785; A.Y = 555; B.X = 800; B.Y = 550; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 800; A.Y = 600; l = new Line(A, B, Color.Black);
            l.Draw(g);
            B.X = 1300; B.Y = 450; l = new Line(A, B, Color.Black);
            l.Draw(g);

            //mat truoc
            A.X = 500; A.Y = 400; B.X = 800; B.Y = 440; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 920; A.Y = 250; l = new Line(A, B, Color.Black);
            l.Draw(g);
            B.X = 620; B.Y = 210; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 500; A.Y = 400; l = new Line(A, B, Color.Black);
            l.Draw(g);

            //noc xe
            A.X = 620; A.Y = 210; B.X = 1100; B.Y = 100; 
            l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 1320; A.Y = 140; l = new Line(A, B, Color.Black);
            l.Draw(g);
            B.X = 920; B.Y = 250; l = new Line(A, B, Color.Black);
            l.Draw(g);

            //thanh kinh
            A.X = 800; A.Y = 450; B.X = 1400; B.Y = 280; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 1320; A.Y = 140; B.X = 1400; B.Y = 200; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 1400; A.Y = 280; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 1120; A.Y = 195; B.X = 1100; B.Y = 365; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 1080; A.Y = 370; B.X = 1100; B.Y = 520; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 1400; A.Y = 280; B.X = 1430; B.Y = 320; l = new Line(A, B, Color.Black);
            l.Draw(g);
            A.X = 1430; A.Y = 400; l = new Line(A, B, Color.Black);
            l.Draw(g);
            B.X = 1420; B.Y = 410; l = new Line(A, B, Color.Black);
            l.Draw(g);

            //banh truoc
            A.X = 680; A.Y = 540;

            DrawEllipse(A, g, 120, 140);
            A.X = 700; A.Y = 560; 
            DrawEllipse(A, g, 80, 100); 
            //solidBrush = new SolidBrush(Color.White); e.Graphics.FillEllipse(solidBrush, A.X, A.Y, 80, 100);
            A.X = 740; A.Y = 610; B.X = 740; B.Y = 560; l = new Line(A, B, Color.Black);
            l.Draw(g);
            B.X = 770; B.Y = 620; 
            l = new Line(A, B, Color.Black);
            l.Draw(g);
            B.X = 700; B.Y = 620;
            l = new Line(A, B, Color.Black); l = new Line(A, B, Color.Black);
            l.Draw(g);

            //banh sau
            A.X = 1300; A.Y = 350; 
            DrawEllipse(A, g, 120, 140); 
            //solidBrush = new SolidBrush(Color.Black); e.Graphics.FillEllipse(solidBrush, A.X, A.Y, 120, 140);
            A.X = 1320; A.Y = 370; 
            DrawEllipse(A, g, 80, 100); 
            //solidBrush = new SolidBrush(Color.White); e.Graphics.FillEllipse(solidBrush, A.X, A.Y, 80, 100);
            A.X = 1360; A.Y = 420; B.X = 1360; B.Y = 370;
            l = new Line(A, B, Color.Black);
            l.Draw(g);
            B.X = 1390; B.Y = 430; l = new Line(A, B, Color.Black);
            l.Draw(g);
            B.X = 1320; B.Y = 430; l = new Line(A, B, Color.Black);
            l.Draw(g);

            //đèn
            A.X = 230; A.Y = 530; 
            DrawEllipse(A, g, 40, 60);
            A.X = 430; A.Y = 560; 
            DrawEllipse(A, g, 45, 65);

            //while (true)
            {
                A.X = 230; A.Y = 530; 
                DrawEllipse(A, g, 40, 60);
              
                //e.Graphics.FillEllipse(solidBrush, A.X, A.Y, 40, 60);
                B.X = 430; B.Y = 560; 
                DrawEllipse(B, g, 45, 65);
               // e.Graphics.FillEllipse(solidBrush, B.X, B.Y, 45, 65);
                //Thread.Sleep(2000);
                A.X = 230; A.Y = 530; 
                DrawEllipse(A, g, 40, 60);
                //solidBrush = new SolidBrush(Color.Gray); 
                //e.Graphics.FillEllipse(solidBrush, A.X, A.Y, 40, 60);
                B.X = 430; B.Y = 560; DrawEllipse(B, g, 45, 65);
                //e.Graphics.FillEllipse(solidBrush, B.X, B.Y, 45, 65);
                //Thread.Sleep(2000);
            }
        }
    }
}
