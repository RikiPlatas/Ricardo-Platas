using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEx
{
    public partial class FParte1 : Form
    {

        bool a = false;
        int cont = 0;
        public FParte1()
        {
            InitializeComponent();

            int cont = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!a)
            {
                cont++;
            }
            else
            {
                cont--;
            }

            label1.Text = cont.ToString();
        }

        private void FParte1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = true;
        }
    }
}
