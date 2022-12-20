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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FParte1 FParte1 = new FParte1();
            FParte1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FParte2 FParte2 = new FParte2();
            FParte2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FParte3 FParte3 = new FParte3();
            FParte3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FParte4 FParte4 = new FParte4();
            FParte4.ShowDialog();
        }
    }
}
