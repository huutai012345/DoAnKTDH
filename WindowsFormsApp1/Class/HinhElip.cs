using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    class HinhElip
    {
        private Point point { get; set; }
        private int a { get; set; }
        private int b { get; set; }

        private Color color { get; set; }
        public void Drawn4Point(int x, int y, Graphics g)
        {
            ToaDo.HienThi(new Point(point.X + x, point.Y + y), g, color);
            ToaDo.HienThi(new Point(point.X - x, point.Y + y), g, color);
            ToaDo.HienThi(new Point(point.X - x, point.Y - y), g, color);
            ToaDo.HienThi(new Point(point.X + x, point.Y - y), g, color);
        }
        public void Drawn4Point_3D(int x, int y, Graphics g)
        {
            if (x % 10 != 0)
            {
                ToaDo.HienThi(new Point(point.X - x, point.Y - y), g, color);
                ToaDo.HienThi(new Point(point.X + x, point.Y - y), g, color);
            }

            ToaDo.HienThi(new Point(point.X + x, point.Y + y), g, color);
            ToaDo.HienThi(new Point(point.X - x, point.Y + y), g, color);
        }
        public void Draw(Graphics g)
        {
            int x, y, cx, cy, a, b;
            cx = this.point.X;
            cy = this.point.Y;
            a = this.a;
            b = this.b;
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
            Drawn4Point(x, y, g);

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
                if (x % 5 == 0)
                    Drawn4Point(x, ToaDo.RoundPixel(y), g);


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
                if (x % 5 == 0)
                    Drawn4Point(x, ToaDo.RoundPixel(y), g);

            }
        }
        public void DrawNetDut(Graphics g)
        {
            int x, y, cx, cy, a, b;
            cx = this.point.X;
            cy = this.point.Y;
            a = this.a;
            b = this.b;
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
                if (x % 5 == 0)
                    Drawn4Point_3D(x, ToaDo.RoundPixel(y), g);


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
                if (x % 5 == 0)
                    Drawn4Point_3D(x, ToaDo.RoundPixel(y), g);

            }
        }
        public HinhElip(Point point, int a, int b, Color color)
        {
            this.point = point;
            this.a = a * 5;
            this.b = b * 5;
            this.color = color;
        }
    }
}
