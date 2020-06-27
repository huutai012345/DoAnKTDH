using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Graphics g;

        private Hinh1 hinh1;
        private Car3d hinh3;
        private AirLane hinh4;
        public Form1()
        {
            InitializeComponent();
            g = this.panel2.CreateGraphics();
            hinh1 = new Hinh1(this.g);
            hinh3 = new Car3d();
            hinh4 = new AirLane();
        }

        private void button1_Click(object sender, EventArgs e)
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

        public void drawHeToaDo()
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

        public void drawHeToaDo3d()
        {
            Graphics g = this.panel2.CreateGraphics();

            for (int i = 0; i <= 320; i++)
            {
                g.DrawLine(new Pen(Color.Pink), 5 * i, 0, 5 * i, 1360);
                g.DrawLine(new Pen(Color.Pink), 0, 5 * i, 1360, 5 * i);
            }

            g.DrawLine(new Pen(Color.Red), 680, 0, 680, 385);
            g.DrawLine(new Pen(Color.Red), 680, 385, 1360, 385);
            g.DrawLine(new Pen(Color.Red), 680, 385, 0, 770);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          //  this.drawHeToaDo();
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
            hinh3.DrawLightGray(g);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.panel2.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel2.Refresh();
            this.drawHeToaDo();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.panel2.Refresh();
            this.drawHeToaDo3d();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel2.Refresh();
            hinh1.DrawNgay();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel2.Refresh();
            hinh3.Draw(g);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hinh1.DrawNgay();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hinh3.Draw(g);
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

        private void button17_Click(object sender, EventArgs e)
        {
            hinh4.Draw(g);
        }
    }
}
