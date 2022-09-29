using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFEjercicios
{
    public partial class Ejercicio6 : Form
    {
        int a = 0;
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Ejercicio6_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            label1.Text = trackBar1.Value.ToString();
            progressBar1.Value = trackBar1.Value;
            timer1.Enabled = true;
            a = trackBar1.Value;
            label2.Text = a.ToString();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            a--;

            label2.Text = a.ToString();
            progressBar1.Value = a;
            if(a == 0)
            {
                timer1.Enabled = false;
            }

        }
    }
}
