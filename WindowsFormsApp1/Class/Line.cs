using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    class Line
    {
        private Point p1, p2;
        private Color color;

        public Point A { get => p1; set => p1 = value; }
        public Point B { get => p2; set => p2 = value; }
        public Color ColorOfLine { get => color; set => color = value; }

        public Line()
        {

        }

        public Line(Point a, Point b, Color color)
        {
            this.A = a;
            this.B = b;
            this.ColorOfLine = color;
        }

        public void Delete(Graphics g )
        {
            int Dx, Dy, step;
            Dx = p2.X - p1.X;
            Dy = p2.Y - p1.Y;
            if (Math.Abs(Dy) > Math.Abs(Dx)) step = Math.Abs(Dy);
            else step = Math.Abs(Dx);

            float x, y, delta_X, delta_Y;

            if (step > 0)
            {
                delta_X = Dx;
                delta_X /= step;

                delta_Y = Dy;
                delta_Y /= step;

                x = p1.X;
                y = p1.Y;
                while (step > 0)
                {

                    Pixel.HienThi(x, y, g, Color.White);
                    x += delta_X;
                    y += delta_Y;
                    step--;

                }
            }
        }

        public void DeleteCus(Graphics g,Color color)
        {
            int Dx, Dy, step;
            Dx = p2.X - p1.X;
            Dy = p2.Y - p1.Y;
            if (Math.Abs(Dy) > Math.Abs(Dx)) step = Math.Abs(Dy);
            else step = Math.Abs(Dx);

            float x, y, delta_X, delta_Y;

            if (step > 0)
            {
                delta_X = Dx;
                delta_X /= step;

                delta_Y = Dy;
                delta_Y /= step;

                x = p1.X;
                y = p1.Y;
                while (step > 0)
                {

                    Pixel.HienThi(x, y, g, color);
                    x += delta_X;
                    y += delta_Y;
                    step--;

                }
            }


        }

        public void Draw(Graphics g)
        {
            int Dx, Dy, step;
            Dx = p2.X - p1.X;
            Dy = p2.Y - p1.Y;
            if (Math.Abs(Dy) > Math.Abs(Dx)) step = Math.Abs(Dy);
            else step = Math.Abs(Dx);

            float x, y, delta_X, delta_Y;

            if (step > 0)
            {
                delta_X = Dx;
                delta_X /= step;

                delta_Y = Dy;
                delta_Y /= step;

                x = p1.X;
                y = p1.Y;
                while (step > 0)
                {

                    Pixel.HienThi(x, y, g, color);
                    x += delta_X;
                    y += delta_Y;
                    step--;

                }
            }
        }

        public void DrawNetChamDut(Graphics g)
        {
                        int Dx, Dy, step;
            Dx = p2.X - p1.X;
            Dy = p2.Y - p1.Y;
            if (Math.Abs(Dy) > Math.Abs(Dx)) step = Math.Abs(Dy);
            else step = Math.Abs(Dx);

            float x, y, delta_X, delta_Y;
            if (step > 0)
            {
                delta_X = Dx;
                delta_X /= step;

                delta_Y = Dy;
                delta_Y /= step;

                x = p1.X;
                y = p1.Y;
                int k = 0;
                while (step > 0)
                {
                    if (k < 10)
                    {
                        Pixel.HienThi(x, y, g, color);
                    }
                    else if (k == 20)
                    {
                        k = 0;
                    }

                    x += delta_X;
                    y += delta_Y;
                    step--;
                    k++;
                }
            }
        }
    }
}
