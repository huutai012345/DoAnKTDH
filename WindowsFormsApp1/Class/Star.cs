using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Class
{
    class Star
    {
        private Point point;
        private Point p1;
        private Point p2;
        private Point p3;
        private Point p4;
        private Point p5;
        private int r;
        private Color color;

        public Point Point { get => point; set => point = value; }
        public int R { get => r; set => r = value; }

        public void Draw(Graphics g)
        {
            Line l1= new Line(p1, p3, color);
            Line l2 = new Line(p1, p4, color);
            Line l3 = new Line(p3, p5, color);
            Line l4 = new Line(p4, p2, color);
            Line l5 = new Line(p2, p5, color);

            l1.Draw(g);
            l2.Draw(g);
            l3.Draw(g);
            l4.Draw(g);
            l5.Draw(g);
        }

        public Star(Point point,int r,Color color)
        {
            this.point = point;
            this.r = r;
            this.color = color;

            this.p1 = new Point(this.point.X, this.point.Y - r);
            this.p2 = Transformations.Quay(p1, point, 72);
            this.p3 = Transformations.Quay(p2, point, 72);
            this.p4 = Transformations.Quay(p3, point, 72);
            this.p5 = Transformations.Quay(p4, point, 72);
        }


    }
}
