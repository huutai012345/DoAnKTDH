using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    class ToaDo
    {   
        public static int RoundPixel(float p)
        {
            float d = p % 5;
            if (d >= 3)
                return (int)(p - d + 5);

            return (int)(p - d);
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

            g.FillRectangle(b, p.X - 2, p.Y - 2, 5, 5);
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

            g.FillRectangle(b, x -2, y-2 , 5, 5);
        }
    }
}
