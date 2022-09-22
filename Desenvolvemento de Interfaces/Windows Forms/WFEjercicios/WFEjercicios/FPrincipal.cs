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
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.LimeGreen;
            this.Text = "Este es el titulo en ejecucion";
            // this.agregarBotonDinamico();
            this.agregarLabelDinamica();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void agregarLabelDinamica()
        {
            Label lblDinamica = new Label();
            lblDinamica.Name = "LblDinamica";
            lblDinamica.Text = "Ejercicios Windows Forms";
            lblDinamica.Location = new System.Drawing.Point(25, 25);
            lblDinamica.Size = new System.Drawing.Size(300, 250);
            Font miFuente = new Font("Arial", 20);
            lblDinamica.Font = miFuente;
            this.panel5.Controls.Add(lblDinamica);
            
        }
        /*
private void agregarBotonDinamico()
{
Button btnDinamico = new Button();
btnDinamico.Name = "btnDinamico";
btnDinamico.Text = "Mangui Boton";
btnDinamico.Location = new System.Drawing.Point(25, 25);
btnDinamico.Size = new System.Drawing.Size(100, 25);
this.Controls.Add(btnDinamico);
}
*/


    }
}
