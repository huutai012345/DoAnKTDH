using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    class Pixel
    {   
        public static int RoundPixel(double x)
        {
            int tdm;
            double sodu = x % 5;
            if (sodu != 0)
            {
                if (sodu >= 3) tdm = (int)(x + 5 - sodu);
                else tdm = (int)(x - sodu);
            }
            else tdm = (int)x;
            if (tdm > 1600) tdm = 1600;
            return tdm;
        }

        public static string chuyenToaDoNgDg(Point p)
        {
            return  "( "+(p.X - 680)/5 +" , "+ (-(p.Y - 385)) / 5 +" )";
        }

        public static int changeX3Dto2D(int x, int y, int z)
        {
            return RoundPixel(x - y * (Math.Sqrt(2) / 2) + 680);
        }

        public static int changeY3Dto2D(int x, int y, int z)
        {
            return RoundPixel(385 - (z - y * (Math.Sqrt(2) / 2)));
        }

        public static Point RoundPixel(Point p)
        {
            int x = p.X % 5,
                y = p.Y % 5;

            x = (x >= 3 ? p.X - x + 5 : p.X - x);
            y = (y >= 3 ? p.Y - y + 5 : p.Y - y);

            return new Point(x, y);
        }

        public static void HienThi(Point p, Graphics g, Color color)
        {
            if (g == null)
                return;
            int pointX = RoundPixel(p.X),
                pointY = RoundPixel(p.Y);
            Pen p1 = new Pen(color);
            SolidBrush b = new SolidBrush(color);

            //g.DrawEllipse(p1, pointX, pointY, 2, 2);
            //g.FillEllipse(b, pointX, pointY, 2, 2);
            //g.DrawEllipse(p1, pointX - 2, pointY - 2, 2, 2);
            //g.FillEllipse(b, pointX - 2, pointY - 2, 2, 2);
            //g.DrawEllipse(p1, pointX, pointY - 2, 2, 2);
            //g.FillEllipse(b, pointX, pointY - 2, 2, 2);
            //g.DrawEllipse(p1, pointX - 2, pointY, 2, 2);
            //g.FillEllipse(b, pointX - 2, pointY, 2, 2);

            //g.FillRectangle(b, pointX - 4, pointY - 4, 4, 4);

            g.FillRectangle(b, p.X - 4, p.Y - 4, 4, 4);
        }
        
        public static void HienThi(float x, float y, Graphics g, Color color)
        {
          
            int pointX = RoundPixel(x),
                pointY = RoundPixel(y);
            Pen p1 = new Pen(color);
            SolidBrush b = new SolidBrush(color);

            //g.DrawEllipse(p1, pointX, pointY, 2, 2);
            //g.FillEllipse(b, pointX, pointY, 2, 2);
            //g.DrawEllipse(p1, pointX - 2, pointY - 2, 2, 2);
            //g.FillEllipse(b, pointX - 2, pointY - 2, 2, 2);
            //g.DrawEllipse(p1, pointX, pointY - 2, 2, 2);
            //g.FillEllipse(b, pointX, pointY - 2, 2, 2);
            //g.DrawEllipse(p1, pointX - 2, pointY, 2, 2);
            //g.FillEllipse(b, pointX - 2, pointY, 2, 2);

            //g.FillRectangle(b, pointX -4, pointY-4 , 4, 4);

            g.FillRectangle(b, x - 4, y - 4, 4, 4);
        }

        public static int distancePoint(Point p1,Point p2)
        {
            double Dx, Dy;
            Dx = Math.Pow( p2.X - p1.X,2);
            Dy = Math.Pow(p2.Y - p1.Y,2);

            return Pixel.RoundPixel((float)Math.Sqrt(Dx + Dy));
        }
    }
}
