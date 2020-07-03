using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    class Car3d
    {
        private bool chopDen = true;
        private Point A = new Point(-1, -1);
        private Point B = new Point(-1, -1);
        private Point C = new Point(-1, -1);

        private Line truc1;
        private Line truc2;
        private Line truc3;
        private Line truc4;
        private Line truc5;
        private Line truc6;

        private Elip banhTrc = new Elip();
        private Elip banhSau = new Elip();

        public Car3d()
        {
            A = new Point(-1, -1);
            B = new Point(-1, -1);
            C = new Point(-1, -1);
            banhTrc = new Elip();
            banhSau = new Elip();
            truc1 = new Line();
            truc2 = new Line();
            truc3 = new Line();
            truc4 = new Line();
            truc5 = new Line();
            truc6 = new Line();
        }

        public void DrawEllipse(Point p1, Graphics g, int x, int y)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create rectangle for ellipse.
            Rectangle rect = new Rectangle(p1.X, p1.Y, x, y);

            // Draw ellipse to screen.
            g.DrawEllipse(blackPen, rect);
        }

        public void DrawLightGray(Graphics g)
        {
            A.X = 230 - 100; A.Y = 530;
            SolidBrush solidBrush = new SolidBrush(Color.Gray);
            g.FillEllipse(solidBrush, A.X, A.Y, 40, 60);
            B.X = 430 - 100; B.Y = 560; DrawEllipse(B, g, 45, 65);
            g.FillEllipse(solidBrush, B.X, B.Y, 45, 65);
        }

        public void DrawLightYellow(Graphics g)
        {
            A.X = 230 - 100; A.Y = 530;
            SolidBrush solidBrush = new SolidBrush(Color.Yellow);
            g.FillEllipse(solidBrush, A.X, A.Y, 40, 60);
            B.X = 430 - 100; B.Y = 560; DrawEllipse(B, g, 45, 65);
            g.FillEllipse(solidBrush, B.X, B.Y, 45, 65);
        }

        public void fillColorRight(Graphics g, Color c)
        {
            A = new Point(850, 150); 
            B = new Point(900, 160); 
            C = new Point(870, 180);
            Point[] curvePoints = { A, B, C };
            g.FillPolygon(new SolidBrush(c), curvePoints);
            A = new Point(850, 150); 
            B = new Point(820, 170); 
            C = new Point(870, 180);
            curvePoints = new Point[] { A, B, C };
            g.FillPolygon(new SolidBrush(c), curvePoints);
        }

        public void fillColorLeft(Graphics g, Color r)
        {
            A = new Point(925, 162); 
            B = new Point(890, 185); 
            C = new Point(970, 170);
            Point[] curvePoints = { A, B, C };
            g.FillPolygon(new SolidBrush(r), curvePoints);
            A = new Point(950, 195); 
            B = new Point(890, 185); 
            C = new Point(970, 170);
            curvePoints = new Point[] { A, B, C };
            g.FillPolygon(new SolidBrush(r), curvePoints);
        }

        public void RotateBanhXe(Graphics g)
        {
            banhTrc.FillColor(g, Color.White);
            banhSau.FillColor(g, Color.White);

            truc1.B = Transformations.Quay(truc1.B, truc1.A,30);
            truc2.B = Transformations.Quay(truc2.B, truc1.A, 30);
            truc3.B = Transformations.Quay(truc3.B, truc1.A, 30);

            truc4.B = Transformations.Quay(truc4.B, truc4.A, 30);
            truc5.B = Transformations.Quay(truc5.B, truc4.A, 30);
            truc6.B = Transformations.Quay(truc6.B, truc4.A, 30);

            truc1.Draw(g);
            truc2.Draw(g);
            truc3.Draw(g);
            truc4.Draw(g);
            truc5.Draw(g);
            truc6.Draw(g);

            if(chopDen)
            {
                this.fillColorRight(g, Color.Red);
                this.fillColorLeft(g, Color.Blue);

                chopDen = false;
            }
            else
            {
                this.fillColorRight(g, Color.Blue);
                this.fillColorLeft(g, Color.Red);

                chopDen = true;
            }
            

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
            A.X = 730 - temp;
            A.Y = 610;

            banhTrc = new Elip(A, 60, 70, Color.Black);
            banhTrc.Draw(g);
            banhTrc.FillColor(g, Color.Black);
           
            banhTrc = new Elip(A, 40, 50, Color.Black);
            banhTrc.Draw(g);
            banhTrc.FillColor(g, Color.White);


            B.X = 740 - temp; 
            B.Y = 560;
           
            truc1 = new Line(A, B, Color.Black);
            truc1.Draw(g);
           
            B.X = 785 - temp; 
            B.Y = 625; 
            truc2 = new Line(A, B, Color.Black);
            truc2.Draw(g);
            
            B.X = 690 - temp; 
            B.Y = 650;
            truc3 = new Line(A, B, Color.Black);
            truc3.Draw(g);

            //banh sau
            
            A.X = 1360 - temp; 
            A.Y = 420; 
          

            banhSau = new Elip(A, 60, 70, Color.Black);
            banhSau.Draw(g);
            banhSau.FillColor(g, Color.Black);

            banhSau = new Elip(A, 40, 50, Color.Black);
            banhSau.Draw(g);
            banhSau.FillColor(g, Color.White);

            B.X = 1360 - temp;
            B.Y = 360;
            truc4 = new Line(A, B, Color.Black);
            truc4.Draw(g);

            B.X = 1410 - temp; 
            B.Y = 430; 
            truc5 = new Line(A, B, Color.Black);
            truc5.Draw(g);
            
            B.X = 1310 - temp; 
            B.Y = 430; 
            truc6 = new Line(A, B, Color.Black);
            truc6.Draw(g);

            //đèn
            A.X = 230 - temp; A.Y = 530; 
            DrawEllipse(A, g, 40, 60);
            A.X = 430 - temp; A.Y = 560; 
            DrawEllipse(A, g, 45, 65);

            fillColorRight(g, Color.Blue);
            fillColorLeft(g, Color.Red);




        }
    }
}
