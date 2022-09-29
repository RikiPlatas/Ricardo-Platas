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

    public partial class Ejercicio7 : Form
    {
        BindingList<Alumno> listado = new BindingList<Alumno>();

        

        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio7_Load(object sender, EventArgs e)
        {
            listado.Add(new Alumno{
                Nombre = "Pedro",
            Edad = 32,
            Alta = DateTime.Parse("5/12/2001"),
            Comedor = true, Turno = "Mañana"
            });

            dataGridView1.DataSource = listado;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int a = 0;

            bool exito = int.TryParse(textBox2.Text, out a);
            if (exito)
            {
                Alumno objeto = new Alumno
                {
                    Nombre = textBox1.Text,
                    Edad = int.Parse(textBox2.Text),
                    Alta = dateTimePicker1.Value.Date,
                    Turno = comboBox1.Text,
                    Comedor = checkBox1.Checked
                };
                listado.Add(objeto);
            }
            else
            {
                MessageBox.Show("Has introducido mal la edad");
            }

           

          



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if(listado.Count> 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
            else
            {
                MessageBox.Show("No puede eliminar, no hay registros");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
