using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private int chedo;
        private int hinh;
        private int play;
        private Color color;

        private Point p1;
        private Point p2;
        private Point p3;

        private Hinh1 hinh1;
        private Universe hinh2;
        private Car3d hinh3;
        private AirLane hinh4;
        public Form1()
        {
            InitializeComponent();
            g = this.panel2.CreateGraphics();
            hinh1 = new Hinh1(this.g);
            hinh2 = new Universe(this.g);
            hinh3 = new Car3d();
            hinh4 = new AirLane();

            this.chedo = 0;
            this.hinh = 0;
            this.play = 0;
            this.color = Color.Black;

            this.p1 = new Point(-1, -1);
            this.p2 = new Point(-1, -1);
            this.p3 = new Point(-1, -1);
          
        }

        private void button1_Click(object sender, EventArgs e) // run
        {

            if(this.play==1)
            {

            }
            else if (this.play == 2)
            {
                

                if (!timer4.Enabled)
                {
                    this.timer4.Start();
                }
                else
                {
                    this.timer4.Stop();
                    
                }
            }
            else if (this.play == 3) //car 2d
            {
                if (!timer1.Enabled)
                {
                    this.timer1.Start();
                }
                else
                {
                    this.timer1.Stop();
                    
                }
            }
            else if(this.play ==4) // car3d
            {
                if (!timer2.Enabled)
                {
                    this.timer2.Start();
                    this.timer3.Start();
                }
                else
                {
                    this.timer2.Stop();
                    this.timer3.Stop();
                    
                }
            }
         
        }

        public void drawHeToaDo2D()
        {
            Graphics g = this.panel2.CreateGraphics();

            for (int i = 0; i <= 320; i++)
            {
                g.DrawLine(new Pen(Color.Pink), 5 * i, 0, 5 * i, 1360);
                g.DrawLine(new Pen(Color.Pink), 0, 5 * i, 1360, 5 * i);
            }

            g.DrawLine(new Pen(Color.Red), 680, 0, 680, 385);
            g.DrawLine(new Pen(Color.Red), 680, 385, 1360, 385);
         
        }

        public void drawHeToaDo3D()
        {
            Graphics g = this.panel2.CreateGraphics();

            for (int i = 0; i <= 320; i++)
            {
                g.DrawLine(new Pen(Color.Pink), 5 * i, 0, 5 * i, 1360);
                g.DrawLine(new Pen(Color.Pink), 0, 5 * i, 1360, 5 * i);
            }

            g.DrawLine(new Pen(Color.Red), 680, 0, 680, 385);
            g.DrawLine(new Pen(Color.Red), 680, 385, 1360, 385);
            g.DrawLine(new Pen(Color.Red), 680, 385, 0, 1050);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hinh1.run();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            hinh3.DrawLightGray(g);
            hinh3.DrawLightYellow(g);
            hinh3.RotateBanhXe(g);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            hinh3.DrawLightGray(g);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            hinh2.run();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.panel2.Refresh();
            if(play==0)
            {
                if (chedo == 1)
                {
                    drawHeToaDo2D();
                }
                else
                {
                    drawHeToaDo3D();
                }
            }
           
        }

        private void button5_Click(object sender, EventArgs e) //3d
        {
            this.panel2.Refresh();
            this.drawHeToaDo3D();
            this.chedo = 2;
        }

        private void button6_Click(object sender, EventArgs e) //2d
        {
            this.panel2.Refresh();
            this.drawHeToaDo2D();
            this.chedo = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.timer2.Stop();
            this.timer3.Stop();
            this.timer4.Stop();

            this.panel2.Refresh();
            this.play = 3;
            hinh1 = new Hinh1(g);
            hinh1.DrawNgay();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.timer2.Stop();
            this.timer3.Stop();
            this.timer4.Stop();

            this.panel2.Refresh();
            this.play = 4;
            hinh3 = new Car3d();
            hinh3.Draw(g);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.timer2.Stop();
            this.timer3.Stop();
            this.timer4.Stop();

            this.panel2.Refresh();
            this.play = 1;
            hinh4 = new AirLane();
            hinh4.Draw(g);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.timer2.Stop();
            this.timer3.Stop();
            this.timer4.Stop();

            this.panel2.Refresh();
            this.play = 2;
            hinh2 = new Universe(g);
            hinh2.draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!timer2.Enabled)
            {
                timer2.Start();
                timer3.Start();
            }
            else
            {
                timer2.Stop();
                timer3.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e) //hinh cn
        {
            this.hinh = 1;
        }

        private void button8_Click(object sender, EventArgs e) // hinh eclip
        {
            this.hinh = 2;
        }

        private void button7_Click(object sender, EventArgs e) //hinh tron
        {
            this.hinh = 3;
        }

        private void button9_Click(object sender, EventArgs e) //hinh tam giac
        {
            this.hinh = 4;
        }

        private void button11_Click(object sender, EventArgs e) //duong thang
        {
            this.hinh = 5;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            if (chedo == 1)
            {
                if (hinh == 1) //hcn
                {
                    if(p1.X==-1)
                    {
                        p1.X = Pixel.RoundPixel(x);
                        p1.Y = Pixel.RoundPixel(y);
                        Pixel.HienThi(p1, g, this.color);
                    }
                    else if (p2.X == -1)
                    {
                        p2.X = Pixel.RoundPixel(x);
                        p2.Y = Pixel.RoundPixel(y);
                       

                        HinhChuNhat hcn = new HinhChuNhat(p1, p2, this.color);
                        hcn.Draw(g);
                        p1.X = -1;
                        p2.X = -1;
                        
                    }
                }
                else if (hinh == 2) //eclip
                {
                    if (p1.X == -1)
                    {
                        p1.X = Pixel.RoundPixel(x);
                        p1.Y = Pixel.RoundPixel(y);
                        Pixel.HienThi(p1, g, this.color);
                    }
                    else if (p2.X == -1)
                    {
                        p2.X = Pixel.RoundPixel(x);
                        p2.Y = p1.Y;
                        Pixel.HienThi(p2, g, this.color);

                    }
                    else if (p3.X == -1)
                    {
                        p3.X = p1.X;
                        p3.Y = Pixel.RoundPixel(y);


                        int a = Pixel.distancePoint(p1, p2);
                        int b = Pixel.distancePoint(p1, p3);
                        HinhElip el = new HinhElip(p1, a, b, this.color);
                        el.Draw(g);
                       
                        
                        p1.X = -1;
                        p2.X = -1;
                        p3.X = -1;

                    }
                }
                else if (hinh == 3) //tron
                {
                    if (p1.X == -1)
                    {
                        p1.X = Pixel.RoundPixel(x);
                        p1.Y = Pixel.RoundPixel(y);
                        Pixel.HienThi(p1, g, this.color);
                    }
                    else if (p2.X == -1)
                    {
                        p2.X = Pixel.RoundPixel(x);
                        p2.Y = Pixel.RoundPixel(y);


                        HinhTron ht = new HinhTron(Pixel.distancePoint(p1,p2), p1, this.color);
                        ht.Draw(g);
                        p1.X = -1;
                        p2.X = -1;
                       
                    }
                }
                else if (hinh == 4) //tam giac
                {
                    if (p1.X == -1)
                    {
                        p1.X = Pixel.RoundPixel(x);
                        p1.Y = Pixel.RoundPixel(y);
                        Pixel.HienThi(p1, g, this.color);
                    }
                    else if (p2.X == -1)
                    {
                        p2.X = Pixel.RoundPixel(x);
                        p2.Y = Pixel.RoundPixel(y);
                        Pixel.HienThi(p2, g, this.color);

                    }
                    else if (p3.X == -1)
                    {
                        p3.X = Pixel.RoundPixel(x);
                        p3.Y = Pixel.RoundPixel(y);

                        HinhTamGiac htg = new HinhTamGiac(p1, p2, p3, color);
                        htg.Draw(g);

                        p1.X = -1;
                        p2.X = -1;
                        p3.X = -1;

                    }
                }
                else if(hinh==5) //line
                {
                    if (p1.X == -1)
                    {
                        p1.X = Pixel.RoundPixel(x);
                        p1.Y = Pixel.RoundPixel(y);
                        Pixel.HienThi(p1, g, color);
                    }
                    else if (p2.X == -1)
                    {
                        p2.X = Pixel.RoundPixel(x);
                        p2.Y = Pixel.RoundPixel(y);

                        Line l = new Line(p1, p2, color);
                        l.Draw(g);
                        p1.X = -1;
                        p2.X = -1;
                       
                    }
                }
            }
            else if(chedo==2)
            {

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
