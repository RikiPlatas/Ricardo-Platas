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
    public partial class Ejercicio8 : Form
    {
        TextBox txtDinamica = new TextBox();
        public Ejercicio8()
        {
            InitializeComponent();

            
        }
        private void agregarLabelDinamica()
        {
            Label lblDinamica = new Label();
            lblDinamica.Text = "Nombre";
            lblDinamica.Location = new System.Drawing.Point(12,45);
            lblDinamica.Font = new Font("Arial", 20);
            this.Controls.Add(lblDinamica);
        }

        private void agregarTextBoxDinamico()
        {
            TextBox textBoxDinamica = new TextBox();
            txtDinamica.Location = new System.Drawing.Point(120, 52);
            txtDinamica.Width = 150;
            txtDinamica.MaxLength = 20;
            this.Controls.Add(txtDinamica);

        }

        private void agregarBtnDinamico()
        {
            Button btnDinamica = new Button();
            btnDinamica.Text = "Saludo";
            btnDinamica.Location = new System.Drawing.Point(20, 100);
            btnDinamica.Width = 80;
            btnDinamica.Height = 30;
            btnDinamica.BackColor = Color.AliceBlue;
            btnDinamica.Click += new EventHandler(Click);
            this.Controls.Add(btnDinamica);
            
        }

        private void Ejercicio8_Load(object sender, EventArgs e)
        {
            agregarLabelDinamica();
            agregarTextBoxDinamico();
            agregarBtnDinamico();
        }

        private void Click (object sender, EventArgs e)
        {
            MessageBox.Show("Hola " + txtDinamica.Text , "Saludo",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information);
        }
    }
}
