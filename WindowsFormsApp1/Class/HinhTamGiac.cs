using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    class HinhTamGiac
    {
        private Point p1;
        private Point p2;
        private Point p3;
        private Color color;

        public Point A { get => p1; set => p1 = value; }
        public Point B { get => p2; set => p2 = value; }
        public Point C { get => p3; set => p3 = value; }
       
        public HinhTamGiac(Point point1, Point point2, Point point3)
        {
            this.p1 = point1;
            this.p2 = point2;
            this.p3 = point3;
        }
        public void Draw(Graphics g)
        {
            FillColor(g, color);
            Line line;
            line = new Line(this.p1, this.p2, color);
            line.Draw(g);
            line = new Line(this.p2, this.p3, Color.Black);
            line.Draw(g);
            line = new Line(this.p3, this.p1, Color.Black);
            line.Draw(g);
        }

        
        private void FillColor(Graphics g, Color c)
        {

            Point[] curvePoints = { this.p1, this.p2, this.p3 };
            g.FillPolygon(new SolidBrush(c), curvePoints);
        }
    }
}
