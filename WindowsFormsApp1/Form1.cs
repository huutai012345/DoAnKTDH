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
      
        private Hinh1 d;
        private Car3d c3d;
        public Form1()
        {
            InitializeComponent();
            g = this.panel2.CreateGraphics();
         
            d = new Hinh1(this.g);
            c3d = new Car3d();
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
        
            for (int i = 0; i <= 320; i++)
            {
                g.DrawLine(new Pen(Color.Pink), 5 * i, 0, 5 * i, 1360);
                g.DrawLine(new Pen(Color.Pink), 0, 5 * i, 1360, 5 * i);
            }

            g.DrawLine(new Pen(Color.Red), 680, 0, 680, 385);
            g.DrawLine(new Pen(Color.Red), 680, 385, 1360, 385);
            g.DrawLine(new Pen(Color.Red), 680, 385, 0, 770);
            // SolidBrush brush = new SolidBrush(Color.DarkSlateBlue);

            //g.DrawLine(new Pen(Color.Red), 0, 330, 1230, 330);
            //g.DrawLine(new Pen(Color.Red), 470, 0, 470, 1230);
        }
      
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            this.drawHeToaDo();

            //d.DrawNgay();
            c3d.Draw(g);
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Console.WriteLine("a");
            c3d.DrawLightYellow(g);
            c3d.RotateBanhTrc(g);
           // d.run();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("b");
            c3d.DrawLightGray(g);

        }

      
    }
}
