using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Class
{
    class Universe
    {
        private HinhChuNhat space;
        private Point tam;
        private HinhTron sun;
        private HinhTron quydao;
        private HinhTron earth;
        private Graphics g;
        private Line truc;

        public Universe(Graphics g)
        {
            this.g = g;
            space = new HinhChuNhat(new Point(5, 5), new Point(1340,770), Color.Black);
            tam = new Point(680, 385);
            quydao = new HinhTron(300, tam, Color.White);
            sun = new HinhTron(100, tam, Color.FromArgb(246, 166, 0));
            earth = new HinhTron(50, new Point(tam.X + 300, tam.Y), Color.White);
            truc = new Line(new Point(earth.Point.X - earth.Radius, earth.Point.Y ), new Point(earth.Point.X + earth.Radius, earth.Point.Y ), Color.White);
        }

        public void draw()
        {
            space.Draw(g);
            space.FillColor(g, Color.Black);
            quydao.Draw(g);
            earth.Draw(g);
            truc.Draw(g);
            sun.Draw(g);
            sun.FillColor(g, Color.FromArgb(246, 166, 0));
        }

        public void run()
        {
            earth.DeleteCus(g,Color.Black);
            earth.Point = Transformations.Quay(earth.Point, tam, -5);
            truc.DeleteCus(g, Color.Black);
            truc.A = Transformations.Quay(truc.A, tam, -5);
            truc.B = Transformations.Quay(truc.B, tam, -5);
            earth.Draw(g);
         
            truc.A = Transformations.Quay(truc.A, earth.Point, 10);
            truc.B = Transformations.Quay(truc.B, earth.Point, 10);
            truc.Draw(g);
           
            quydao.Draw(g);
        }
    }
}
