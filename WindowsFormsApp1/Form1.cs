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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void drawHeToaDo()
        {
            Graphics g = this.panel2.CreateGraphics();
            // SolidBrush brush = new SolidBrush(Color.DarkSlateBlue);
          
            g.DrawLine(new Pen(Color.Red), 0, 330, 1230, 330);
            g.DrawLine(new Pen(Color.Red), 470, 0, 470, 1230);

            Line l = new Line(new Point(10, 10), new Point(10, 200),Color.Black);
            l.Draw(g);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.drawHeToaDo();
           
        }
    }
}
