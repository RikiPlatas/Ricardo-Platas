using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using WFEjercicios.Resources;

namespace WFEjercicios
{
    public partial class Ejercicio10 : Form
    {

       
        

        public Ejercicio10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == ("Ingles"))
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

                label1.Text = ("Language");
                button1.Text = ("Greet");

                comboBox1.Items.Clear();

                

                comboBox1.Items.Add("Spanish");
                comboBox1.Items.Add("English");

                comboBox1.SelectedIndex = 1;

                MessageBox.Show(Generico.Saludo);


            }
            else if(comboBox1.Text == ("Español")){
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");

                label1.Text = ("Idioma");
                button1.Text = ("Saludar");

                comboBox1.Items.Clear();



                comboBox1.Items.Add("Español");
                comboBox1.Items.Add("Inlges");

                comboBox1.SelectedIndex = 0;

                MessageBox.Show(Generico.Saludo);

                
            }
        }
    }
}
