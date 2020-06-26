using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    class HinhThangCan
    {
        private Point p1;
        private Point p2;
        private Point p3;
        private Point p4;
        private Color color;
        private int line;

        public Point A { get => p1; set => p1 = value; }
        public Point B { get => p2; set => p2 = value; }
        public Point C { get => p3; set => p3 = value; }
        public Point D { get => p4; set => p4 = value; }
     
        public void Draw(Graphics g)
        {
            Line line;
            line = new Line(this.A, this.B, color);
            line.Draw(g);
            line = new Line(this.B, this.C, color);
            line.Draw(g);
            line = new Line(this.D, this.C, color);
            line.Draw(g);
            line = new Line(this.A, this.D, color);
            line.Draw(g);
        }


        public void FillColor(Graphics g, Color c)
        {
            Point[] curvePoints = { this.A, this.B, this.C, this.D };
            g.FillPolygon(new SolidBrush(c), curvePoints);
        }

        public HinhThangCan(Point start, Point end, Color color,int line)
        {
            this.line = line;
            this.A = start;
            this.B = new Point(end.X -line, start.Y);
            this.C = end;
            this.D = new Point(start.X-line, end.Y);
            this.color = color;
        }
    }
}
