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
    public partial class FParte1 : Form
    {
        public FParte1()
        {
            InitializeComponent();
        }
        private void lblDinamica()
        {
            Label lblDinamica = new Label();
            lblDinamica.Name = "lblDinamica";
            lblDinamica.Text = "Examen Windows Forms";
            this.panel1.Controls.Add(lblDinamica);
        }

        private void FParte1_Load(object sender, EventArgs e)
        {
            lblDinamica();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FParte2 fParte2 = new FParte2();
            fParte2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FParte3 fParte3 = new FParte3();
            fParte3.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FParte4 fParte4 = new FParte4();
            fParte4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FParte5 fParte5 = new FParte5();
            fParte5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FParte6 fParte6 = new FParte6();
            fParte6.ShowDialog();
        }
    }


    
}
