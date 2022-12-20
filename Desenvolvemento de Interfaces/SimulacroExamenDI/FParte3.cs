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
    public partial class FParte3 : Form
    {
        public FParte3()
        {
            InitializeComponent();
        }

        private void FParte3_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(progressBar1.Value != 0)
            {
                progressBar1.Value = progressBar1.Value - 1;

            }
            else
            {
                Close();
            }
        }
    }
}
