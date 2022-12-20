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
    public partial class FParte5 : Form
    {
        public FParte5()
        {
            InitializeComponent();
        }

        private void btnDinamica()
        {
            Button btnDinamica = new Button();
            btnDinamica.Name = "btnDinamica";
            btnDinamica.Text = "Cambiar";
            btnDinamica.Click += new EventHandler(btnDinamico_Click);
            btnDinamica.Location = new System.Drawing.Point(344, 297);
            this.Controls.Add(btnDinamica);
        }

        private void FParte5_Load(object sender, EventArgs e)
        {
            btnDinamica();
        }

        private void btnDinamico_Click (object sender, EventArgs e)
        {

            Image img1 = pictureBox1.Image;
            Image img2 = pictureBox2.Image;

            pictureBox1.Image = img2;
            pictureBox2.Image = img1;


        }
    }
}
