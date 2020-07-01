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
    public partial class Form2 : Form
    {
        private int x;
        private int y;
        private int z;
        private int height;
        private int lentgh;
        private Graphics g;
        private int chedo;

        public Form2()
        {
            this.chedo = 0;
            InitializeComponent();
        }

        public Form2(Graphics g,int chedo)
        {
            this.g = g;
            this.chedo = chedo;
            InitializeComponent();
        }

        public void Draw()
        {
            if(chedo == 1) // hinh tru
            {
                
                Cylindrical c = new Cylindrical(Height1, Length, X, Y, Z);
                c.Draw(g);

                //AX.Text = x + ""; AY.Text = y + ""; AZ.Text = z + "";
                //BX.Text = x + ""; BY.Text = y + ""; BZ.Text = (z + h) + "";
                //CX.Text = "-"; CY.Text = "-"; CZ.Text = "-";
                //DX.Text = "-"; DY.Text = "-"; DZ.Text = "-";
                //EX.Text = "-"; EY.Text = "-"; EZ.Text = "-";
                //FX.Text = "-"; FY.Text = "-"; FZ.Text = "-";
                //HX.Text = "-"; HY.Text = "-"; HZ.Text = "-";
                //JX.Text = "-"; JY.Text = "-"; JZ.Text = "-";
            }
            else if(chedo == 2)//hinh non
            {
                Conical c = new Conical(Length, Height1, x, y, z, Color.Black);
                c.Draw(g);
            }
            else if(chedo==3)//box
            {
                Box b = new Box(Length, X, Y, Z, Color.Black);
                b.Draw(g);
            }
            else if(chedo==4)
            {
                Pyramid p = new Pyramid(Height1, Length, x, y, z);
                p.Draw(g);
            }
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }
        public int Height1 { get => height; set => height = value; }
        public int Length { get => lentgh; set => lentgh = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.X =Int16.Parse(this.textBoxX.Text);
            this.Y = Int16.Parse(this.textBoxY.Text);
            this.Z = Int16.Parse(this.textBoxZ.Text);
            this.Height1 = Int16.Parse(this.textBoxHeight.Text);
            this.Length = Int16.Parse(this.textBoxLength.Text);

            this.Draw();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
