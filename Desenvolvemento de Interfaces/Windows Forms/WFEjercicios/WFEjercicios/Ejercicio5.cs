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
    public partial class Ejercicio5 : Form
    {
        int a = 0;
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a--;
            label1.Text = a.ToString();
             

            if(a == 0)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            a = Int32.Parse(textBox1.Text);
                label1.Text = a.ToString();
                
                

            

        }
    }
}
