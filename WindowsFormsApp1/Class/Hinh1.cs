using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Class
{
    class Hinh1
    {
        private Graphics g;
        private HinhChuNhat d;
        private Line vachkeDuong1;
        private Line vachkeDuong2;
        private Line vachkeDuong3;
        private Line vachkeDuong4;

        private Line vachkeDuong5;
        private Line vachkeDuong6;
        private Line vachkeDuong7;
        private Line vachkeDuong8;

        private Sun sun;
        private HinhChuNhat nenTroi;

        private int toadoY = 700;
        private int toadoXMax = 1350;
        private int speed =15;
       

        public Hinh1(Graphics g)
        {
            this.g = g;
            sun = new Sun(new Point(130, 130),70);
            nenTroi = new HinhChuNhat(new Point(0, 0), new Point(1350, 600), Color.FromArgb(62, 155, 244));

            d = new HinhChuNhat(new Point(0, 600), new Point(toadoXMax, 950), Color.Black);
            vachkeDuong1 = new Line(new Point(136, toadoY), new Point(340, toadoY), Color.Black);
            vachkeDuong2 = new Line(new Point(476, toadoY), new Point(680, toadoY), Color.Black);
            vachkeDuong3 = new Line(new Point(816, toadoY), new Point(1020, toadoY), Color.Black);
            vachkeDuong4 = new Line(new Point(1156, toadoY), new Point(1360, toadoY), Color.Black);

            vachkeDuong5 = new Line(Transformations.TinhTien(vachkeDuong1.A,-toadoXMax,0), Transformations.TinhTien(vachkeDuong1.B, -toadoXMax, 0),Color.Black);
            vachkeDuong6 = new Line(Transformations.TinhTien(vachkeDuong2.A, -toadoXMax, 0), Transformations.TinhTien(vachkeDuong2.B, -toadoXMax, 0), Color.Black);
            vachkeDuong7 = new Line(Transformations.TinhTien(vachkeDuong3.A, -toadoXMax, 0), Transformations.TinhTien(vachkeDuong3.B, -toadoXMax, 0), Color.Black);
            vachkeDuong8 = new Line(Transformations.TinhTien(vachkeDuong4.A, -toadoXMax, 0), Transformations.TinhTien(vachkeDuong4.B, -toadoXMax, 0), Color.Black);
        }


        public void Reset()
        {
            if (vachkeDuong1.A.X >= toadoXMax)
            {
                vachkeDuong1.A = Transformations.TinhTien(vachkeDuong5.A, -toadoXMax, 0);
                vachkeDuong1.B = Transformations.TinhTien(vachkeDuong5.B, -toadoXMax, 0);
            }

            if (vachkeDuong2.A.X >= toadoXMax)
            {
                vachkeDuong2.A = Transformations.TinhTien(vachkeDuong6.A, -toadoXMax, 0);
                vachkeDuong2.B = Transformations.TinhTien(vachkeDuong6.B, -toadoXMax, 0);
            }

            if (vachkeDuong3.A.X >= toadoXMax)
            {
                vachkeDuong3.A = Transformations.TinhTien(vachkeDuong7.A, -toadoXMax, 0);
                vachkeDuong3.B = Transformations.TinhTien(vachkeDuong7.B, -toadoXMax, 0);
            }

            if (vachkeDuong4.A.X >= toadoXMax)
            {
                vachkeDuong4.A = Transformations.TinhTien(vachkeDuong8.A, -toadoXMax, 0);
                vachkeDuong4.B = Transformations.TinhTien(vachkeDuong8.B, -toadoXMax, 0);
            }

            if (vachkeDuong5.A.X >= toadoXMax)
            {
                vachkeDuong5.A = Transformations.TinhTien(vachkeDuong1.A, -toadoXMax, 0);
                vachkeDuong5.B = Transformations.TinhTien(vachkeDuong1.B, -toadoXMax, 0);
            }

            if (vachkeDuong6.A.X >= toadoXMax)
            {
                vachkeDuong6.A = Transformations.TinhTien(vachkeDuong2.A, -toadoXMax, 0);
                vachkeDuong6.B = Transformations.TinhTien(vachkeDuong2.B, -toadoXMax, 0);
            }

            if (vachkeDuong7.A.X >= toadoXMax)
            {
                vachkeDuong7.A = Transformations.TinhTien(vachkeDuong3.A, -toadoXMax, 0);
                vachkeDuong7.B = Transformations.TinhTien(vachkeDuong3.B, -toadoXMax, 0);
            }

            if (vachkeDuong8.A.X >= toadoXMax)
            {
                vachkeDuong8.A = Transformations.TinhTien(vachkeDuong4.A, -toadoXMax, 0);
                vachkeDuong8.B = Transformations.TinhTien(vachkeDuong4.B, -toadoXMax, 0);
            }
        }

        public void Draw()
        {
            nenTroi.FillColor(g, Color.FromArgb(62, 155, 244));
            d.FillColor(g, Color.FromArgb(127, 127, 127));
            sun.Draw(g);
            vachkeDuong1.Draw(g);
            vachkeDuong2.Draw(g);
            vachkeDuong3.Draw(g);
            vachkeDuong4.Draw(g);

        }

        public void Draw1()
        {
            vachkeDuong1.Draw(g);
            vachkeDuong2.Draw(g);
            vachkeDuong3.Draw(g);
            vachkeDuong4.Draw(g);

            vachkeDuong5.Draw(g);
            vachkeDuong6.Draw(g);
            vachkeDuong7.Draw(g);
            vachkeDuong8.Draw(g);

            sun.Draw(g);
        }

        public void Delete()
        {
            for(int i=5;i<=speed;i=i+5)
            {
                ToaDo.HienThi(new Point(this.vachkeDuong1.A.X - i, this.vachkeDuong1.A.Y), g, Color.FromArgb(127, 127, 127));
                ToaDo.HienThi(new Point(this.vachkeDuong2.A.X - i, this.vachkeDuong2.A.Y), g, Color.FromArgb(127, 127, 127));
                ToaDo.HienThi(new Point(this.vachkeDuong3.A.X - i, this.vachkeDuong3.A.Y), g, Color.FromArgb(127, 127, 127));
                ToaDo.HienThi(new Point(this.vachkeDuong4.A.X - i, this.vachkeDuong4.A.Y), g, Color.FromArgb(127, 127, 127));
                ToaDo.HienThi(new Point(this.vachkeDuong5.A.X - i, this.vachkeDuong5.A.Y), g, Color.FromArgb(127, 127, 127));
                ToaDo.HienThi(new Point(this.vachkeDuong6.A.X - i, this.vachkeDuong6.A.Y), g, Color.FromArgb(127, 127, 127));
                ToaDo.HienThi(new Point(this.vachkeDuong7.A.X - i, this.vachkeDuong7.A.Y), g, Color.FromArgb(127, 127, 127));
                ToaDo.HienThi(new Point(this.vachkeDuong8.A.X - i, this.vachkeDuong8.A.Y), g, Color.FromArgb(127, 127, 127));
            }
           this.sun.Delete(g);
        }

        public void TinhTien()
        {
            vachkeDuong1.A = Transformations.TinhTien(vachkeDuong1.A, speed, 0);
            vachkeDuong1.B = Transformations.TinhTien(vachkeDuong1.B, speed, 0);
            vachkeDuong2.A = Transformations.TinhTien(vachkeDuong2.A, speed, 0);
            vachkeDuong2.B = Transformations.TinhTien(vachkeDuong2.B, speed, 0);
            vachkeDuong3.A = Transformations.TinhTien(vachkeDuong3.A, speed, 0);
            vachkeDuong3.B = Transformations.TinhTien(vachkeDuong3.B, speed, 0);
            vachkeDuong4.A = Transformations.TinhTien(vachkeDuong4.A, speed, 0);
            vachkeDuong4.B = Transformations.TinhTien(vachkeDuong4.B, speed, 0);

            vachkeDuong5.A = Transformations.TinhTien(vachkeDuong5.A, speed, 0);
            vachkeDuong5.B = Transformations.TinhTien(vachkeDuong5.B, speed, 0);
            vachkeDuong6.A = Transformations.TinhTien(vachkeDuong6.A, speed, 0);
            vachkeDuong6.B = Transformations.TinhTien(vachkeDuong6.B, speed, 0);
            vachkeDuong7.A = Transformations.TinhTien(vachkeDuong7.A, speed, 0);
            vachkeDuong7.B = Transformations.TinhTien(vachkeDuong7.B, speed, 0);
            vachkeDuong8.A = Transformations.TinhTien(vachkeDuong8.A, speed, 0);
            vachkeDuong8.B = Transformations.TinhTien(vachkeDuong8.B, speed, 0);

            sun =new Sun(Transformations.TinhTien(this.sun.point,5,0),70);
        }


        public void run()
        {
            this.Draw1();
            this.TinhTien();
            this.Delete();
            this.Reset();
        }

      
    }
}
