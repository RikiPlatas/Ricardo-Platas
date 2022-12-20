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
    public partial class FParte2 : Form
    {
        public FParte2()
        {
            InitializeComponent();
        }

        private void FParte2_Load(object sender, EventArgs e)
        {
            

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String a = "";

            if (checkBox1.Checked)
            {
                if (a.Equals(""))
                {
                    a = checkBox1.Text;
                }
                /*
                else
                {
                    a += " + " + checkBox1.Text;
                }
                */

            }

            if (checkBox2.Checked)
            {
                if (a.Equals(""))
                {
                    a = checkBox2.Text;
                }
                else
                {
                    a += " + " + checkBox2.Text;
                }

            }

            if (checkBox3.Checked)
            {
                if (a.Equals(""))
                {
                    a = checkBox3.Text;
                }
                else
                {
                    a += " + " + checkBox3.Text;
                }

            }



            listBox1.Items.Add(a);
            a = "";
        }
    }
}
