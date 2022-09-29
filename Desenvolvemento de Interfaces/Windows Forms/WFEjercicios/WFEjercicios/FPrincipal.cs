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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ejercicio1 Ejer1 = new Ejercicio1();
            Ejer1.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Ejercicio2 Ejer2 = new Ejercicio2();
            Ejer2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ejercicio3 Ejer3 = new Ejercicio3();
            Ejer3.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ejercicio4 Ejer4 = new Ejercicio4();
            Ejer4.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ejercicio5 Ejer5 = new Ejercicio5();
            Ejer5.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ejercicio6 Ejer6 = new Ejercicio6();
            Ejer6.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ejercicio7 Ejer7 = new Ejercicio7();
            Ejer7.ShowDialog();
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
