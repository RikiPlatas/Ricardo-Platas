using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaInterfaces
{
    public partial class Form1 : Form
    {
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)

        {
            

         

            if (comboBox1.SelectedIndex == 0)
            {
                label3.Visible = true;
                cont = 60;
                timer1.Enabled = true;

            }else if (comboBox1.SelectedIndex == 1)
            {
                label3.Visible = true;
                cont = 45;
                timer1.Enabled = true;
            }else if(comboBox1.SelectedIndex == 2)
            {
                label3.Visible = true;
                cont = 30;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                label3.Text = cont.ToString();
                cont--;

            }
        }
    }
}
