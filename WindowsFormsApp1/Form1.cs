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
        public Form1()
        {
            InitializeComponent();
            g = this.panel2.CreateGraphics();
            hinh1 = new Hinh1(this.g);
            hinh3 = new Car3d();
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
            g.DrawLine(new Pen(Color.Red), 680, 385, 0, 1050);
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

        private void Box_Click(object sender, EventArgs e)
        {
            this.panel2.Refresh();
            this.drawHeToaDo3d();
            int x = int.Parse(textX.Text);
            int y = int.Parse(textY.Text);
            int z = int.Parse(textZ.Text);
            int length = int.Parse(textLength.Text);
            Box b = new Box(length, x, y, z, Color.Black);
            b.Draw(g);
            AX.Text = x + ""; AY.Text = y + ""; AZ.Text = z + "";
            BX.Text = x + ""; BY.Text = y + ""; BZ.Text = (z + length) + "";
            CX.Text = (x) + ""; CY.Text = (y + length) + ""; CZ.Text = (z) + "";
            DX.Text = (x) + ""; DY.Text = (y + length) + ""; DZ.Text = (z + length) + "";
            EX.Text = (x + length) + ""; EY.Text = (y) + ""; EZ.Text = (z) + "";
            FX.Text = (x + length) + ""; FY.Text = (y + length) + ""; FZ.Text = (z) + "";
            HX.Text = (x + length) + ""; HY.Text = (y) + ""; HZ.Text = (z + length) + "";
            JX.Text = (x + length) + ""; JY.Text = (y + length) + ""; JZ.Text = (z + length) + "";
        }

        private void Pyramid_Click(object sender, EventArgs e)
        {
            this.panel2.Refresh();
            this.drawHeToaDo3d();
            int x = int.Parse(textX.Text);
            int y = int.Parse(textY.Text);
            int z = int.Parse(textZ.Text);
            int length = int.Parse(textLength.Text);
            int height = int.Parse(textHeight.Text);
            Pyramid p = new Pyramid(height, length, x, y, z);
            p.Draw(g);
            length = length / 2;
            AX.Text = (x) + ""; AY.Text = (y) + ""; AZ.Text = (z + length) + "";
            BX.Text = (x + length) + ""; BY.Text = (y - length) + ""; BZ.Text = (z) + "";
            CX.Text = (x - length) + ""; CY.Text = (y - length) + ""; CZ.Text = (z) + "";
            DX.Text = (x - length) + ""; DY.Text = (y + length) + ""; DZ.Text = (z) + "";
            EX.Text = (x + length) + ""; EY.Text = (y + length) + ""; EZ.Text = (z) + "";
            FX.Text = "-"; FY.Text = "-"; FZ.Text = "-";
            HX.Text = "-"; HY.Text = "-"; HZ.Text = "-";
            JX.Text = "-"; JY.Text = "-"; JZ.Text = "-";
        }

        private void Conical_Click(object sender, EventArgs e)
        {
            this.panel2.Refresh();
            this.drawHeToaDo3d();
            int x = int.Parse(textX.Text);
            int y = int.Parse(textY.Text);
            int z = int.Parse(textZ.Text);
            int r = int.Parse(textLength.Text) / 2;
            int h = int.Parse(textHeight.Text);
            Conical c = new Conical(r, h, x, y, z, Color.Black);
            c.Draw(g);
            AX.Text = (x) + ""; AY.Text = (y) + ""; AZ.Text = (z + h) + "";
            BX.Text = "-"; BY.Text = "-"; BZ.Text = "-";
            CX.Text = "-"; CY.Text = "-"; CZ.Text = "-";
            DX.Text = "-"; DY.Text = "-"; DZ.Text = "-";
            EX.Text = "-"; EY.Text = "-"; EZ.Text = "-";
            FX.Text = "-"; FY.Text = "-"; FZ.Text = "-";
            HX.Text = "-"; HY.Text = "-"; HZ.Text = "-";
            JX.Text = "-"; JY.Text = "-"; JZ.Text = "-";
        }
    }
}
