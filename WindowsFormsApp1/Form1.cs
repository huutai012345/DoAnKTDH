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
        public Form1()
        {
            InitializeComponent();
            g = this.panel2.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!timer1.Enabled)
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
            // SolidBrush brush = new SolidBrush(Color.DarkSlateBlue);
          
            //g.DrawLine(new Pen(Color.Red), 0, 330, 1230, 330);
            //g.DrawLine(new Pen(Color.Red), 470, 0, 470, 1230);

            

            
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            this.drawHeToaDo();
            Car c= new Car();
            c.Draw(g);
        }

        Point p1 = new Point(200, 200);
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            //HinhTron ht = new HinhTron(50, p1, Color.Black);
            //ht.Delete(g);
            //HinhTron ht1 = new HinhTron(50, p1, Color.Black);
            //ht1.Draw(g);


            //Transformations.TinhTien(p1, 5, 0);
        }
    }
}
