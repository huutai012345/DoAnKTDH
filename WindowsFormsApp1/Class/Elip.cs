using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    class Elip
    {
        private Point point;
        private int a;
        private int b;
        private Color color;

        public Point Point { get => point; set => point = value; }
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public Color Color { get => color; set => color = value; }

        public void Drawn4Point(int x, int y, Graphics g)
        {
            Pixel.HienThi(new Point(Point.X + x, Point.Y + y), g, Color);
            Pixel.HienThi(new Point(Point.X - x, Point.Y + y), g, Color);
            Pixel.HienThi(new Point(Point.X - x, Point.Y - y), g, Color);
            Pixel.HienThi(new Point(Point.X + x, Point.Y - y), g, Color);
        }
        public void Drawn4Point_3D(int x, int y, Graphics g,int k=-1)
        {
            if(k==-1)
            {
               // if (x % 5 != 0)
                {
                    Pixel.HienThi(new Point(Point.X - x, Point.Y - y), g, Color);
                    Pixel.HienThi(new Point(Point.X + x, Point.Y - y), g, Color);
                }

                Pixel.HienThi(new Point(Point.X + x, Point.Y + y), g, Color);
                Pixel.HienThi(new Point(Point.X - x, Point.Y + y), g, Color);
            }
            else
            {
                if (0 >= k && k <= 5)
                {
                    Pixel.HienThi(new Point(Point.X - x, Point.Y - y), g, Color);
                    Pixel.HienThi(new Point(Point.X + x, Point.Y - y), g, Color);
                }
              

                Pixel.HienThi(new Point(Point.X + x, Point.Y + y), g, Color);
                Pixel.HienThi(new Point(Point.X - x, Point.Y + y), g, Color);
            }
           
        }
        public void Draw(Graphics g)
        {
            int x, y ;
          
            x = 0; y = this.B;
            int A, B;
            A = this.A * this.A;
            B = this.B * this.B;
            double p = B + A / 4 - A * this.B;
            x = 0;
            y = this.B;
            int Dx = 0;
            int Dy = 2 * A * y;
            Drawn4Point(x, y,g);

            while (Dx < Dy)
            {
                x++;
                Dx += 2 * B;
                if (p < 0)
                    p += B + Dx;
                else
                {
                    y--;
                    Dy -= 2 * A;
                    p += B + Dx - Dy;
                }
               
               // if (x % 5 == 0)
                    Drawn4Point(x, y, g);


            }
            p = Math.Round(B * (x + 0.5f) * (x + 0.5f) + A * (y - 1) * (y - 1) - A * B);
            while (y > 0)
            {
                y--;
                Dy -= A * 2;
                if (p > 0)
                    p += A - Dy;
                else
                {
                    x++;
                    Dx += B * 2;
                    p += A - Dy + Dx;
                }
               
               // if (x % 5 == 0)
                    Drawn4Point(x, y, g);

            }
        }

        public void FillColor(Graphics g, Color color)
        {
            g.FillEllipse(new SolidBrush(color), Point.X - A-5, Point.Y - B-5, 2 * A+5, 2 * B+5);
        }
        public void Draw3d(Graphics g)
        {
            int k = 0;
            int x, y, cx, cy, a, b;
            cx = this.Point.X;
            cy = this.Point.Y;
            a = this.A;
            b = this.B;
            x = 0;
            y = b;
            int A, B;
            A = a * a;
            B = b * b;
            double p = B + A / 4 - A * b;
            x = 0;
            y = b;
            int Dx = 0;
            int Dy = 2 * A * y;
            Drawn4Point_3D(x, y, g);

            while (Dx <= Dy)
            {
                x += 1;
                Dx += 2 * B;
                if (p < 0)
                    p += B + Dx;
                else
                {
                    y -= 1;
                    Dy -= 2 * A;
                    p += B + Dx - Dy;
                }
                //if (x % 5 == 0)
             
                Drawn4Point_3D(x,y, g,k);
                if (k == 10)
                {
                    k = 0;
                }
                else
                    k++;


            }
            p = Math.Round(B * (x + 0.5f) * (x + 0.5f) + A * (y - 1) * (y - 1) - A * B);
            while (y >= 0)
            {
                y -= 1;
                Dy -= A * 2;
                if (p > 0)
                    p += A - Dy;
                else
                {
                    x += 1;
                    Dx += B * 2;
                    p += A - Dy + Dx;
                }
               //if (x % 5 == 0)
                    Drawn4Point_3D(x, y, g);

            }
        }
        public Elip(Point point, int a, int b, Color color)
        {
            this.Point = point;
            this.A = a ;
            this.B = b ;
            this.Color = color;
        }

        public Elip()
        {
            
        }
    }
}
