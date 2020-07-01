using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private int x;
        private int y;
        private int z;
        private int height;
        private int lenght;

        public Form2()
        {
            InitializeComponent();
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }
        public int Height1 { get => height; set => height = value; }
        public int Lenght { get => lenght; set => lenght = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.X =Int16.Parse(this.textBoxX.Text);
            this.Y = Int16.Parse(this.textBoxY.Text);
            this.Z = Int16.Parse(this.textBoxZ.Text);
            this.Height1 = Int16.Parse(this.textBoxHeight.Text);
            this.Lenght = Int16.Parse(this.textBoxLength.Text);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
