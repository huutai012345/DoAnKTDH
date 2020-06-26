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
        private Graphics g ;
        private Car2d c ;
        private Hinh1 d;
        public Form1()
        {
            InitializeComponent();
            g = this.panel2.CreateGraphics();
            c = new Car2d(this.g);
            d = new Hinh1(this.g);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!timer1.Enabled)
            {
                this.timer1.Start();
                this.timer2.Start();
            }
            else
            {
                this.timer1.Stop();
                this.timer2.Stop();
            }
            
        }

        public void drawHeToaDo()
        {
            Graphics g = this.panel2.CreateGraphics();
            // SolidBrush brush = new SolidBrush(Color.DarkSlateBlue);

            //g.DrawLine(new Pen(Color.Red), 0, 330, 1230, 330);
            //g.DrawLine(new Pen(Color.Red), 470, 0, 470, 1230);
        }
       // Car3d c = new Car3d();
        Point p1 = new Point(200, 200);
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            this.drawHeToaDo();
           
            d.Draw();
            c.Draw();
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Console.WriteLine("a");
            //c.DrawLightYellow(g);
            c.run();
            d.run();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("b");
            //c.DrawLightGray(g);

        }

      
    }
}
