using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsEx.idiomas;

namespace WinFormsEx
{
    public partial class FParte4 : Form
    {

        bool a = true;
        public FParte4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (a)
            {
                button1.Text = ("Salir");
                a = false;

            }
            else
            {
                button1.Text = ("Acceder");
                a = true;
            }

           





            if (checkBox1.Checked && button1.Text == "Acceder")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
                MessageBox.Show(Resource.Despedida + " " + comboBox1.SelectedItem.ToString());


            }
            if (checkBox1.Checked && button1.Text == "Salir")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
                MessageBox.Show(Resource.Saludo + " " + comboBox1.SelectedItem.ToString());
                button1.Text = (Resource.Salir);

            }



            if (checkBox2.Checked && button1.Text == "Acceder")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                MessageBox.Show(Resource.Despedida + " " + comboBox1.SelectedItem.ToString());
                button1.Text = (Resource.Acceder);


            }
            if (checkBox2.Checked && button1.Text == "Salir")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                MessageBox.Show(Resource.Saludo + " " + comboBox1.SelectedItem.ToString());
                button1.Text = (Resource.Salir);


            }





        }

        private void FParte4_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            checkBox2.Checked = false;

        }

     

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }
    }
}
