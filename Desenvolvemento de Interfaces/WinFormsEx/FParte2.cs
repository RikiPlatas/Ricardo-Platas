using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEx
{
    public partial class FParte2 : Form
    {
        BindingList<Persona> listado = new BindingList<Persona>();

        public FParte2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            /*
            if (textBox1 = Validate())
            {
                listado.Add(new Persona
                {
                    Nombre = textBox1.Text,
                    Edad = int.Parse(textBox2.Text),
                });

            }
            */
        }

        private void FParte2_Load(object sender, EventArgs e)
        {

            


            

            if (!textBox2.Focus())
            {
                listado.Add(new Persona
                {
                    Nombre = textBox1.Text,
                    Edad = int.Parse(textBox2.Text)
                });

            }


            dataGridView1.DataSource = listado;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

