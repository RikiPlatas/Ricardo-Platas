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
    public partial class FParte4 : Form
    {
        public FParte4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0 && radioButton1.Checked)
            {
                MessageBox.Show("Hola "+comboBox1.SelectedItem);
            }
            else if(comboBox1.SelectedIndex == 1 && radioButton1.Checked)
            {
                MessageBox.Show("Hola " + comboBox1.SelectedItem);
            }
            else if (comboBox1.SelectedIndex == 2 && radioButton1.Checked)
            {
                MessageBox.Show("Hola " + comboBox1.SelectedItem);
            }
            else if (comboBox1.SelectedIndex == 3 && radioButton1.Checked)
            {
                MessageBox.Show("Hola " + comboBox1.SelectedItem);
            }


            if (comboBox1.SelectedIndex == 0 && radioButton2.Checked)
            {
                MessageBox.Show("Adios " + comboBox1.SelectedItem);
            }
            else if (comboBox1.SelectedIndex == 1 && radioButton2.Checked)
            {
                MessageBox.Show("Adios " + comboBox1.SelectedItem);
            }
            else if (comboBox1.SelectedIndex == 2 && radioButton2.Checked)
            {
                MessageBox.Show("Adios " + comboBox1.SelectedItem);
            }
            else if (comboBox1.SelectedIndex == 3 && radioButton2.Checked)
            {
                MessageBox.Show("Adios " + comboBox1.SelectedItem);
            }


        }

        private void FParte4_Load(object sender, EventArgs e)
        {
            //si quieres tener un indice por defecto en el combobox
           // comboBox1.SelectedIndex = 0;
        }
    }
}
