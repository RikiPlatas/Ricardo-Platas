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
    public partial class FParte3 : Form
    {
        public FParte3()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                radioButton1.Checked = true;

                //trackBar1.Value += 1;
            }
            if (listBox1.SelectedIndex == 1)
            {
                radioButton2.Checked = true;
            }
            if (listBox1.SelectedIndex == 2)
            {
                radioButton3.Checked = true;
            }

            if (listBox1.SelectedIndex == 0 || radioButton1.Checked == true)
            {
                trackBar1.Value += 1;
            }
        }

        private void FParte3_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listBox1.SelectedIndex = 0;
                //trackBar1.Value += 1;
            }
            if (radioButton2.Checked)
            {
                listBox1.SelectedIndex = 1;
            }
            if (radioButton3.Checked)
            {
                listBox1.SelectedIndex = 2;
            }

            
        }

       
    }
}
