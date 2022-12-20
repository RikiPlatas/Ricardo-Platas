using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacroExamenDI
{
    public partial class FParte6 : Form
    {
        public FParte6()
        {
            InitializeComponent();
        }

        private void FParte6_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Image img1 = pictureBox1.Image;
            Image img2 = pictureBox2.Image;
            Image img3 = pictureBox3.Image;

            pictureBox1.Image = img3;
            pictureBox2.Image = img1;
            pictureBox3.Image = img2;


        }
    }
}
