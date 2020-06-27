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
        private bool checkNgay = false;
        private Graphics g;
        private Car2d c;
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

        //nha cao nhat
        private HinhChuNhat house1;
        private HinhChuNhat house2;
        private HinhChuNhat house3;
        private HinhChuNhat windowns1;
        private HinhChuNhat windowns2;
        private HinhChuNhat windowns3;
        private HinhChuNhat windowns4;
        private HinhChuNhat windowns5;
        private HinhChuNhat windowns6;
        private HinhChuNhat windowns7;
        private HinhChuNhat windowns8;
        //windowns ringht
        private HinhChuNhat windowns11;
        private HinhChuNhat windowns12;
        private HinhChuNhat windowns13;
        private HinhChuNhat windowns14;
        private HinhChuNhat windowns15;
        private HinhChuNhat windowns16;
        private HinhChuNhat windowns17;
        private HinhChuNhat windowns18;
        //nha cao 2
        private HinhChuNhat windowns21;
        private HinhChuNhat windowns22;
        private HinhChuNhat windowns23;
        private HinhChuNhat windowns24;
        private HinhChuNhat windowns25;
        private HinhChuNhat windowns26;
        //nha cao tang so 1, thap nhat
        private HinhChuNhat windowns31;
        private HinhChuNhat windowns32;
        private HinhChuNhat windowns33;
        private HinhChuNhat windowns34;
        //casi cay xanh xanh
        private HinhChuNhat thanCay;
        private HinhTamGiac laCay;
        //cot den
        private HinhChuNhat trafficlights1;
        private HinhChuNhat trafficlights2;
        //bong den
        private HinhTron lightbulbL;
        private HinhTron lightbulbR;
        //may
        private HinhTron cloud1;
        private HinhTron cloud2;
        private HinhTron cloud3;
        private HinhTron cloud4;
        private HinhTron cloud5;
        private HinhTron cloud6;
        private HinhTron cloud7;
        private HinhTron cloud8;

        private int toadoY = 700;
        private int toadoXMax = 1350;
        private int speed = 15;
       
        public Hinh1(Graphics g)
        {
            this.g = g;
            c = new Car2d(this.g);
            sun = new Sun(new Point(130, 130),70);
            nenTroi = new HinhChuNhat(new Point(0, 0), new Point(1350, 600), Color.FromArgb(62, 155, 244));

            d = new HinhChuNhat(new Point(0, 600), new Point(toadoXMax, 800), Color.Black);
            vachkeDuong1 = new Line(new Point(136, toadoY), new Point(340, toadoY), Color.Black);
            vachkeDuong2 = new Line(new Point(476, toadoY), new Point(680, toadoY), Color.Black);
            vachkeDuong3 = new Line(new Point(816, toadoY), new Point(1020, toadoY), Color.Black);
            vachkeDuong4 = new Line(new Point(1156, toadoY), new Point(1360, toadoY), Color.Black);

            vachkeDuong5 = new Line(Transformations.TinhTien(vachkeDuong1.A,-toadoXMax,0), Transformations.TinhTien(vachkeDuong1.B, -toadoXMax, 0),Color.Black);
            vachkeDuong6 = new Line(Transformations.TinhTien(vachkeDuong2.A, -toadoXMax, 0), Transformations.TinhTien(vachkeDuong2.B, -toadoXMax, 0), Color.Black);
            vachkeDuong7 = new Line(Transformations.TinhTien(vachkeDuong3.A, -toadoXMax, 0), Transformations.TinhTien(vachkeDuong3.B, -toadoXMax, 0), Color.Black);
            vachkeDuong8 = new Line(Transformations.TinhTien(vachkeDuong4.A, -toadoXMax, 0), Transformations.TinhTien(vachkeDuong4.B, -toadoXMax, 0), Color.Black);

            house1 = new HinhChuNhat(new Point(350, 220), new Point(500, 600), Color.Black);
            house2 = new HinhChuNhat(new Point(270, 400), new Point(200, 600), Color.Black);
            house3 = new HinhChuNhat(new Point(340, 300), new Point(280, 600), Color.Black);

            windowns1 = new HinhChuNhat(new Point(370, 580), new Point(400, 600), Color.Black);
            windowns2 = new HinhChuNhat(new Point(370, 530), new Point(400, 550), Color.Black);
            windowns3 = new HinhChuNhat(new Point(370, 480), new Point(400, 500), Color.Black);
            windowns4 = new HinhChuNhat(new Point(370, 430), new Point(400, 450), Color.Black);
            windowns5 = new HinhChuNhat(new Point(370, 380), new Point(400, 400), Color.Black);
            windowns6 = new HinhChuNhat(new Point(370, 330), new Point(400, 350), Color.Black);
            windowns7 = new HinhChuNhat(new Point(370, 280), new Point(400, 300), Color.Black);
            windowns8 = new HinhChuNhat(new Point(370, 230), new Point(400, 250), Color.Black);

            windowns11 = new HinhChuNhat(new Point(450, 580), new Point(480, 600), Color.Black);
            windowns12 = new HinhChuNhat(new Point(450, 530), new Point(480, 550), Color.Black);
            windowns13 = new HinhChuNhat(new Point(450, 480), new Point(480, 500), Color.Black);
            windowns14 = new HinhChuNhat(new Point(450, 430), new Point(480, 450), Color.Black);
            windowns15 = new HinhChuNhat(new Point(450, 380), new Point(480, 400), Color.Black);
            windowns16 = new HinhChuNhat(new Point(450, 330), new Point(480, 350), Color.Black);
            windowns17 = new HinhChuNhat(new Point(450, 280), new Point(480, 300), Color.Black);
            windowns18 = new HinhChuNhat(new Point(450, 230), new Point(480, 250), Color.Black);


            windowns21 = new HinhChuNhat(new Point(330, 580), new Point(290, 600), Color.Black);
            windowns22 = new HinhChuNhat(new Point(330, 530), new Point(290, 550), Color.Black);
            windowns23 = new HinhChuNhat(new Point(330, 480), new Point(290, 500), Color.Black);
            windowns24 = new HinhChuNhat(new Point(330, 430), new Point(290, 450), Color.Black);
            windowns25 = new HinhChuNhat(new Point(330, 380), new Point(290, 400), Color.Black);
            windowns26 = new HinhChuNhat(new Point(330, 330), new Point(290, 350), Color.Black);


            windowns31 = new HinhChuNhat(new Point(250, 580), new Point(220, 600), Color.Black);
            windowns32 = new HinhChuNhat(new Point(250, 530), new Point(220, 550), Color.Black);
            windowns33 = new HinhChuNhat(new Point(250, 480), new Point(220, 500), Color.Black);
            windowns34 = new HinhChuNhat(new Point(250, 430), new Point(220, 450), Color.Black);

            //cai cay xanhxanh
            thanCay = new HinhChuNhat(new Point(820, 480), new Point(850, 600), Color.Black);
            laCay = new HinhTamGiac(new Point(835, 300), new Point(750, 495), new Point(920, 495),Color.Black);
            //cot den
            trafficlights1 = new HinhChuNhat(new Point(1100, 400), new Point(1110, 600), Color.Black);
            trafficlights2 = new HinhChuNhat(new Point(1050, 390), new Point(1160, 400), Color.Black);
            //bong den
            lightbulbL = new HinhTron(15, new Point(1050, 405), Color.Black);
            lightbulbR = new HinhTron(15, new Point(1160, 405), Color.Black);
            //Cloud
            cloud1 = new HinhTron(35, new Point(900, 100), Color.Black);
            cloud2 = new HinhTron(35, new Point(950, 100), Color.Black);
            cloud3 = new HinhTron(35, new Point(1000, 100), Color.Black);
            cloud4 = new HinhTron(35, new Point(950, 125), Color.Black);
            cloud5 = new HinhTron(28, new Point(400, 80), Color.Black);
            cloud6 = new HinhTron(28, new Point(430, 80), Color.Black);
            cloud7 = new HinhTron(28, new Point(460, 80), Color.Black);
            cloud8 = new HinhTron(28, new Point(430, 100), Color.Black);
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



                if (checkNgay)
                {
                    DrawNgay();
                    checkNgay = false;
                }
                else
                {
                    DrawDem();
                    checkNgay = true;
                }

            }
        }

        public void DrawNgay()
        {
            nenTroi.FillColor(g, Color.FromArgb(62, 155, 244));
            sun.Draw(g);


            thanCay.FillColor(g, Color.DarkOliveGreen);
            laCay.FillColor(g, Color.Green);
            house1.FillColor(g, Color.Gray);
            house2.FillColor(g, Color.Gray);
            house3.FillColor(g, Color.Gray);

            //windowns1.FillColor(g, Color.White);
            windowns2.FillColor(g, Color.White);
            windowns3.FillColor(g, Color.White);
            windowns4.FillColor(g, Color.White);
            windowns5.FillColor(g, Color.White);
            windowns6.FillColor(g, Color.White);
            windowns7.FillColor(g, Color.White);
            windowns8.FillColor(g, Color.White);

            //windowns11.FillColor(g, Color.White);
            windowns12.FillColor(g, Color.White);
            windowns13.FillColor(g, Color.White);
            windowns14.FillColor(g, Color.White);
            windowns15.FillColor(g, Color.White);
            windowns16.FillColor(g, Color.White);
            windowns17.FillColor(g, Color.White);
            windowns18.FillColor(g, Color.White);

            //windowns21.FillColor(g, Color.White);
            windowns22.FillColor(g, Color.White);
            windowns23.FillColor(g, Color.White);
            windowns24.FillColor(g, Color.White);
            windowns25.FillColor(g, Color.White);
            windowns26.FillColor(g, Color.White);

            //windowns31.FillColor(g, Color.White);
            windowns32.FillColor(g, Color.White);
            windowns33.FillColor(g, Color.White);
            windowns34.FillColor(g, Color.White);


            trafficlights1.FillColor(g, Color.Pink);
            trafficlights2.FillColor(g, Color.Pink);
            lightbulbL.FillColor(g, Color.Yellow);
            lightbulbR.FillColor(g, Color.Yellow);

            cloud1.FillColor(g, Color.LightPink);
            cloud2.FillColor(g, Color.LightPink);
            cloud3.FillColor(g, Color.LightPink);
            cloud4.FillColor(g, Color.LightPink);
            cloud5.FillColor(g, Color.BlueViolet);
            cloud6.FillColor(g, Color.BlueViolet);
            cloud7.FillColor(g, Color.BlueViolet);
            cloud8.FillColor(g, Color.BlueViolet);


            house1.Draw(g);
            house2.Draw(g);
            house3.Draw(g);

            //windowns1.Draw(g);
            windowns2.Draw(g);
            windowns3.Draw(g);
            windowns4.Draw(g);
            windowns5.Draw(g);
            windowns6.Draw(g);
            windowns7.Draw(g);
            windowns8.Draw(g);

            //windowns11.Draw(g);
            windowns12.Draw(g);
            windowns13.Draw(g);
            windowns14.Draw(g);
            windowns15.Draw(g);
            windowns16.Draw(g);
            windowns17.Draw(g);
            windowns18.Draw(g);

            //windowns21.Draw(g);
            windowns22.Draw(g);
            windowns23.Draw(g);
            windowns24.Draw(g);
            windowns25.Draw(g);
            windowns26.Draw(g);

            //windowns31.Draw(g);
            windowns32.Draw(g);
            windowns33.Draw(g);
            windowns34.Draw(g);

           
            d.FillColor(g, Color.FromArgb(127, 127, 127));
            vachkeDuong1.Draw(g);
            vachkeDuong2.Draw(g);
            vachkeDuong3.Draw(g);
            vachkeDuong4.Draw(g);
            c.Draw();
        }

        public void DrawDem()
        {
            nenTroi.FillColor(g, Color.FromArgb(30, 46, 60));
            d.FillColor(g, Color.FromArgb(127, 127, 127));
            sun.Draw(g);
            vachkeDuong1.Draw(g);
            vachkeDuong2.Draw(g);
            vachkeDuong3.Draw(g);
            vachkeDuong4.Draw(g);
            c.Draw();
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
            for(int i=4;i<=speed;i++)
            {
                Pixel.HienThi(new Point(this.vachkeDuong1.A.X - i, this.vachkeDuong1.A.Y), g, Color.FromArgb(127, 127, 127));
                Pixel.HienThi(new Point(this.vachkeDuong2.A.X - i, this.vachkeDuong2.A.Y), g, Color.FromArgb(127, 127, 127));
                Pixel.HienThi(new Point(this.vachkeDuong3.A.X - i, this.vachkeDuong3.A.Y), g, Color.FromArgb(127, 127, 127));
                Pixel.HienThi(new Point(this.vachkeDuong4.A.X - i, this.vachkeDuong4.A.Y), g, Color.FromArgb(127, 127, 127));
                Pixel.HienThi(new Point(this.vachkeDuong5.A.X - i, this.vachkeDuong5.A.Y), g, Color.FromArgb(127, 127, 127));
                Pixel.HienThi(new Point(this.vachkeDuong6.A.X - i, this.vachkeDuong6.A.Y), g, Color.FromArgb(127, 127, 127));
                Pixel.HienThi(new Point(this.vachkeDuong7.A.X - i, this.vachkeDuong7.A.Y), g, Color.FromArgb(127, 127, 127));
                Pixel.HienThi(new Point(this.vachkeDuong8.A.X - i, this.vachkeDuong8.A.Y), g, Color.FromArgb(127, 127, 127));
            }

            if(this.checkNgay)
            {
                this.sun.DeleteNgay(g);
            }
            else
            {
                this.sun.DeleteDem(g);
            }
          
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

            sun =new Sun(Transformations.TinhTien(this.sun.point,1,0),70);
        }

        public void run()
        {
            this.Draw1();
            this.TinhTien();
            this.Delete();
            this.Reset();
            c.run();
        }

      
    }
}
