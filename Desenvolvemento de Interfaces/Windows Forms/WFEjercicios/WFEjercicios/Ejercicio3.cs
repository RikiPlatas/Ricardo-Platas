using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WFEjercicios
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            eleccionColor();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            eleccionColor();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            eleccionColor();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            eleccionColor();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            eleccionColor();


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            eleccionColor();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void eleccionColor()

        {

            //pictureBox1.Visible = true;
            if (radioButton1.Checked && radioButton4.Checked)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\FP\\Pictures\\marcas\\nissanRojo.jpg");
                pictureBox1.Visible = true;
            }
            if (radioButton1.Checked && radioButton5.Checked)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\FP\\Pictures\\marcas\\nissanNegro.jpg");
                pictureBox1.Visible = true;
            }
            if (radioButton1.Checked && radioButton6.Checked)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\FP\\Pictures\\marcas\\nissanAzul.jpg");
                pictureBox1.Visible = true;
            }

            if (radioButton2.Checked && radioButton4.Checked)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\FP\\Pictures\\marcas\\supraRojo.jpg");
                pictureBox1.Visible = true;
            }
            if (radioButton2.Checked && radioButton5.Checked)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\FP\\Pictures\\marcas\\supraNegro.jpg");
                pictureBox1.Visible = true;
            }
            if (radioButton2.Checked && radioButton6.Checked)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\FP\\Pictures\\marcas\\supraAzul.jpg");
                pictureBox1.Visible = true;
            }
            if (radioButton3.Checked && radioButton4.Checked)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\FP\\Pictures\\marcas\\mazdaRojo.jpg");
                pictureBox1.Visible = true;
            }
            if (radioButton3.Checked && radioButton5.Checked)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\FP\\Pictures\\marcas\\mazdaNegro.jpg");
                pictureBox1.Visible = true;
            }
            if (radioButton3.Checked && radioButton6.Checked)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\FP\\Pictures\\marcas\\mazdaAzul.jpg");
                pictureBox1.Visible = true;
            }
        }
    }

 
}
