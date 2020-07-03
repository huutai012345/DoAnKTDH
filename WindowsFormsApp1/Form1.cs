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

        private void rsPoint()
        {
            this.AX.Text = "-";


            this.BX.Text = "-";


            this.CX.Text = "-";


            this.DX.Text = "-";


            this.EX.Text = "-";


            this.FX.Text = "-";


            this.HX.Text = "-";


            this.JX.Text = "-";
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

         
            g.DrawLine(new Pen(Color.Red,4), 678, 0, 678, 385);
            g.DrawLine(new Pen(Color.Red,4), 678, 383, 1360, 383);
         
        }

        public void drawHeToaDo3D()
        {
            Graphics g = this.panel2.CreateGraphics();

            for (int i = 0; i <= 320; i++)
            {
                g.DrawLine(new Pen(Color.Pink), 5 * i, 0, 5 * i, 1360);
                g.DrawLine(new Pen(Color.Pink), 0, 5 * i, 1360, 5 * i);
            }

            g.DrawLine(new Pen(Color.Red, 4), 678, 0, 678, 385);
            g.DrawLine(new Pen(Color.Red, 4), 678, 383, 1360, 383);
            g.DrawLine(new Pen(Color.Red,4), 678, 383, 0, 1048);
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
            this.rsPoint();
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
            this.rsPoint();
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
            this.rsPoint();
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
            this.rsPoint();
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
            if (chedo != 1)
            {
                this.panel2.Refresh();
                drawHeToaDo2D();
                this.chedo = 1;
            }
            this.hinh = 1;
        }

        private void button8_Click(object sender, EventArgs e) // hinh eclip
        {
            if (chedo != 1)
            {
                this.panel2.Refresh();
                drawHeToaDo2D();
                this.chedo = 1;
            }
            this.hinh = 2;
        }

        private void button7_Click(object sender, EventArgs e) //hinh tron
        {
            if (chedo != 1)
            {
                this.panel2.Refresh();
                drawHeToaDo2D();
                this.chedo = 1;
            }
            this.hinh = 3;
        }

        private void button9_Click(object sender, EventArgs e) //hinh tam giac
        {
            if (chedo != 1)
            {
                this.panel2.Refresh();
                drawHeToaDo2D();
                this.chedo = 1;
            }
            this.hinh = 4;
        }

        private void button11_Click(object sender, EventArgs e) //duong thang
        {
            if (chedo != 1)
            {
                this.panel2.Refresh();
                drawHeToaDo2D();
                this.chedo = 1;
            }
            this.hinh = 5;
        }

        private void button2_Click_1(object sender, EventArgs e) // ngoi sao
        {
            if (chedo != 1)
            {
                this.panel2.Refresh();
                drawHeToaDo2D();
                this.chedo = 1;
            }
            this.hinh = 6;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            if (chedo == 1)
            {
                this.rsPoint();
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

                        //this.AX.Text = "( " + hcn.A.X/5 + " , " + hcn.A.Y/5 + " )";
                        //this.BX.Text = "( " + hcn.B.X/5 + " , " + hcn.B.Y/5 + " )";
                        //this.CX.Text = "( " + hcn.C.X/5 + " , " + hcn.C.Y/5 + " )";
                        //this.DX.Text = "( " + hcn.D.X/5 + " , " + hcn.D.Y/5 + " )";

                        this.AX.Text = Pixel.chuyenToaDoNgDg(hcn.A);
                        this.BX.Text = Pixel.chuyenToaDoNgDg(hcn.B);
                        this.CX.Text = Pixel.chuyenToaDoNgDg(hcn.C);
                        this.DX.Text = Pixel.chuyenToaDoNgDg(hcn.D);

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

                        this.AX.Text = Pixel.chuyenToaDoNgDg(p1);
                        this.BX.Text = Pixel.chuyenToaDoNgDg(p2);
                        this.CX.Text = Pixel.chuyenToaDoNgDg(p3);

                        Pixel.HienThi(p1, g, color);
                        int a = Pixel.distancePoint(p1, p2);
                        int b = Pixel.distancePoint(p1, p3);
                        Elip el = new Elip(p1, a, b, this.color);
                      


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

                        this.AX.Text = Pixel.chuyenToaDoNgDg(p1);
                        this.BX.Text = Pixel.chuyenToaDoNgDg(p2);

                        Pixel.HienThi(p1, g, color);
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

                        this.AX.Text = Pixel.chuyenToaDoNgDg(p1);
                        this.BX.Text = Pixel.chuyenToaDoNgDg(p2);
                        this.BX.Text = Pixel.chuyenToaDoNgDg(p3);
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

                        this.AX.Text = Pixel.chuyenToaDoNgDg(p1);
                        this.BX.Text = Pixel.chuyenToaDoNgDg(p2);
                        Line l = new Line(p1, p2, color);
                        l.Draw(g);
                        p1.X = -1;
                        p2.X = -1;
                       
                    }
                }
                else if(hinh==6)
                {
                    if (p1.X == -1)
                    {
                        p1.X = Pixel.RoundPixel(x);
                        p1.Y = Pixel.RoundPixel(y);
                        Pixel.HienThi(p1, g, color);
                    }
                    else if (p2.X == -1)
                    {
                        p2.X = p1.X;
                        p2.Y = Pixel.RoundPixel(y);

                        this.AX.Text = Pixel.chuyenToaDoNgDg(p1);
                        this.BX.Text = Pixel.chuyenToaDoNgDg(p2);

                        Pixel.HienThi(p1, g, Color.White);
                        Star star = new Star(p1, Math.Abs(p1.Y-p2.Y) , color);
                        star.Draw(g);

                        p1.X = -1;
                        p2.X = -1;

                    }
                   
                }
            }
            else if(chedo==2)
            {
                
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (chedo != 2)
            {
                this.panel2.Refresh();
                drawHeToaDo3D();
                this.chedo = 2;
            }
            Form2 form2 = new Form2(g, 1, this);
            form2.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(chedo!=2)
            {
                this.panel2.Refresh();
                drawHeToaDo3D();
                this.chedo = 2;
            }
            Form2 form2 = new Form2(g,2, this);
            form2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (chedo != 2)
            {
                this.panel2.Refresh();
                drawHeToaDo3D();
                this.chedo = 2;
            }
            Form2 form2 = new Form2(g, 3, this);
            form2.Show();
        }


        private void buttonHinhChop_Click(object sender, EventArgs e)
        {
            if (chedo != 2)
            {
                this.panel2.Refresh();
                drawHeToaDo3D();
                this.chedo = 2;
            }
            Form2 form2 = new Form2(g,4, this);
            form2.Show();
        }

        private void buttonHinhCau_Click(object sender, EventArgs e)
        {
            if (chedo != 2)
            {
                this.panel2.Refresh();
                drawHeToaDo3D();
                this.chedo = 2;
            }
            Form2 form2 = new Form2(g,5, this);
            form2.Show();

        }
    }
}
