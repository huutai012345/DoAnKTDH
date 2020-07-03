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

        private Form1 form1;
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

        public Form2(Graphics g, int chedo,Form1 form1)
        {
            this.g = g;
            this.chedo = chedo;
            this.form1 = form1;
            InitializeComponent();
        }

        public void DrawToaTo()
        {
            
        }

        public void Draw()
        {
            if(chedo == 1) // hinh tru
            {
                
                Cylindrical c = new Cylindrical(Height1 * 5, Length * 5, X * 5, Y * 5, Z * 5);
                c.Draw(g);

                this.form1.AX1.Text = "( "+x + " , " + y +" , "+ z+" )";
               

                this.form1.BX1.Text = "( " + x + " , " + y + " , " + (z + Height1) + " )";
              

                this.form1.CX1.Text = "-";
               

                this.form1.DX1.Text = "-";
               

                this.form1.EX1.Text = "-";
               

                this.form1.FX1.Text = "-";
               

                this.form1.HX1.Text = "-";
               

                this.form1.JX1.Text = "-";
                
            }
            else if(chedo == 2)//hinh non
            {
                Conical c = new Conical(Length*5, Height1 * 5, x * 5, y * 5, z * 5, Color.Black);
                c.Draw(g);

                this.form1.AX1.Text = "( " + x + " , " + y + " , " + (z + Height1) + " )";
                

                this.form1.BX1.Text = "-";
               

                this.form1.CX1.Text = "-";
                

                this.form1.DX1.Text = "-";
               

                this.form1.EX1.Text = "-";
                

                this.form1.FX1.Text = "-";
               

                this.form1.HX1.Text = "-";
                

                this.form1.JX1.Text = "-";
                
            }
            else if(chedo==3)//box
            {
                Box b = new Box(Length * 5, X * 5, Y * 5, Z * 5, Color.Black);
                b.Draw(g);

                this.form1.AX1.Text = "( " + x + " , " + y + " , " + z + " )";

                this.form1.BX1.Text = "( " + x + " , " + y + " , " + (z + Length) + " )";

                this.form1.CX1.Text = "( " + x + " , " + (y + Length) + " , " + z + " )";

                this.form1.DX1.Text = "( " + x + " , " + (y + Length) + " , " + (z + Length) + " )";

                this.form1.EX1.Text = "( " + (x + Length) + " , " + y  + " , " + z + " )";

                this.form1.FX1.Text = "( " + (x + Length) + " , " + (y + Length) + " , " + z + " )";

                this.form1.HX1.Text = "( " + (x + Length) + " , " + y + " , " + (z + Length) + " )";

                this.form1.JX1.Text = "( " + (x + Length) + " , " + (y + Length) + " , " + (z + Length) + " )";
          
            }
            else if(chedo==4)
            {
                Pyramid p = new Pyramid(Height1 * 5, Length * 5, x * 5, y * 5, z * 5);
                p.Draw(g);

                this.form1.AX1.Text = "( " + x + " , " + y + " , " + (z + Length) + " )";

                this.form1.BX1.Text = "( "+ (x + Length) +" , "+ (y - Length) + " , "+ (z) + " )";
              
                this.form1.CX1.Text = "( " + (x - Length) +" , "+ (y - Length) + " , "+ (z) + " )";
              
                this.form1.DX1.Text = "( " + (x - Length) + " , "+ (y + Length) + " , "+ (z) + " )";
               
                this.form1.EX1.Text = "( " + (x + Length) + " , "+ (y + Length) + " , "+ (z) + " )";
             
                this.form1.FX1.Text = "-";
              
                this.form1.HX1.Text = "-";
              
                this.form1.JX1.Text = "-";
            }
            else if (chedo == 5)
            {
                Globe p = new Globe(Length * 5, x * 5, y * 5, z * 5);
                p.Draw(g);

                this.form1.AX1.Text = "( " + x + " , " + y + " , " + z + " )";

                this.form1.BX1.Text = "-";

                this.form1.CX1.Text = "-";

                this.form1.DX1.Text = "-";

                this.form1.EX1.Text = "-";

                this.form1.FX1.Text = "-";

                this.form1.HX1.Text = "-";

                this.form1.JX1.Text = "-";
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
