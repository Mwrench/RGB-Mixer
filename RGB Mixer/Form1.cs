using System;
using System.Drawing;
using System.Windows.Forms;

namespace RGB_Mixer
{
    public partial class Form1 : Form
    {
        int r, g, b;

        private void Mudarcor()
        {
            r = Slidervermelho.Value;
            g = Sliderverde.Value;
            b = Sliderazul.Value;
            pictureBox4.BackColor = Color.FromArgb(r, g, b);
            if (r == 0 & g == 0 & b == 0)
            {
                pictureBox4.BackColor = Color.Black;

            }
        }
        private void Slidervermelho_Scroll(object sender, EventArgs e)
        {
            Mudarcor();
            r = Slidervermelho.Value;
            pictureBox1.BackColor = Color.FromArgb(r, 0, 0);
            if (r == 0)
            {
                pictureBox1.BackColor = Color.Black;
            }
        }

        private void Sliderverde_Scroll(object sender, EventArgs e)
        {
            Mudarcor();
            g = Sliderverde.Value;
            pictureBox2.BackColor = Color.FromArgb(0, g, 0);
            if (g == 0)
            {
                pictureBox2.BackColor = Color.Black;
            }
        }

        private void Sliderazul_Scroll(object sender, EventArgs e)
        {
            Mudarcor();
            b = Sliderazul.Value;
            pictureBox3.BackColor = Color.FromArgb(0, 0, b);
            if (b == 0)
            {
                pictureBox3.BackColor = Color.Black;
            }
        }

        private void Ajuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Application.StartupPath + "\\Resources\\ajuda.chm");
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
