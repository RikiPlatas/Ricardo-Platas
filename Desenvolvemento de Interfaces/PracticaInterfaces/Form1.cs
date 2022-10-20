using PracticaInterfaces.Idiomas;
using PracticaInterfaces.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;
using Image = System.Drawing.Image;

namespace PracticaInterfaces
{
    public partial class Form1 : Form
    {
        int cont = 0;

        // Variables:
        // Para crear numeros random del 1-16 y luego asignarlos a las imagenes
        Random rdn = new Random();

        //Guardar nums random para asignar luego a imagenes
        List<int> listaRandom = new List<int>();

        // Asginar un num a cada imagen para poder relazionar de forma aleatoria con la listaRandom
        List<int> listaImagenes = new List<int>();

        // Lista de todos los picturebox
        List<PictureBox> listaPictureBox = new List<PictureBox>();

        PictureBox Pb1Select;
        PictureBox Pb2Select;


        // Inicio las imagenes
        Image azul;
        Image rojo;
        Image verde;
        Image negro;
        Image blanco;
        Image pirexia;
        Image incoloro;
        Image x;


        List<PictureBox> pbSeleccionados = new List<PictureBox>();


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {



            //Relleno lista de picturebox
            listaPictureBox.Add(pictureBox1);
            listaPictureBox.Add(pictureBox2);
            listaPictureBox.Add(pictureBox3);
            listaPictureBox.Add(pictureBox4);
            listaPictureBox.Add(pictureBox5);
            listaPictureBox.Add(pictureBox6);
            listaPictureBox.Add(pictureBox7);
            listaPictureBox.Add(pictureBox8);
            listaPictureBox.Add(pictureBox9);
            listaPictureBox.Add(pictureBox10);
            listaPictureBox.Add(pictureBox11);
            listaPictureBox.Add(pictureBox12);
            listaPictureBox.Add(pictureBox13);
            listaPictureBox.Add(pictureBox14);
            listaPictureBox.Add(pictureBox15);
            listaPictureBox.Add(pictureBox16);





            //Asigno imagenes
            azul = Resources.azul;
            rojo = Resources.rojo;
            verde = Resources.verde;
            negro = Resources.negro;
            blanco = Resources.blanco;
            pirexia = Resources.pirexiano;
            incoloro = Resources.incoloro;
            x = Resources.x;

            comboBox1.SelectedIndex = 0;

            comboBox2.SelectedIndex = 0;



        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)

        {

            if (comboBox1.SelectedIndex == 0)
            {
                label3.Visible = true;
                cont = 60;
                timer1.Enabled = true;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label3.Visible = true;
                cont = 45;
                timer1.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label3.Visible = true;
                cont = 30;
                timer1.Enabled = true;
            }


            //rellenar la lista de imagenes con numeros del 1-16
            for (int i = 0; i < 16; i++)
            {
                listaImagenes.Add(i + 1);
                // Pos 5: 6
            }

            for (int i = 0; i < 16; i++)
            {
                int num = 0;
                listaRandom.Add(num);
            }


            //crear nums aleatorios para relacionar la imagen con una posicion random y despues eliminarla de las lista para que no se repita
            for (int i = 0; i < listaRandom.Count; i++)
            {
                // Creo numeros aleatorios
                int numeroRandom = rdn.Next(0, listaImagenes.Count); //Random te da la posicion -> 5
                // ListaRandom [0] = listaImagenes[5] -> ListaRandom [0] = 6
                listaRandom[i] = listaImagenes[numeroRandom];
                listaImagenes.RemoveAt(numeroRandom);
            }







        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                label3.Text = cont.ToString();
                cont--;

            }
            if (cont == 0)
            {
                terminar();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imagenAsig(15, pictureBox1);

            //comprobar sin son iguales o diferentes

            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox1);
            }
            else
            {
                pbSeleccionados.Add(pictureBox1);
                comprobarImg(pbSeleccionados);
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            imagenAsig(14, pictureBox2);
            Thread.Sleep(2000);


            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox2);
            }
            else
            {
                pbSeleccionados.Add(pictureBox2);
                comprobarImg(pbSeleccionados);
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            imagenAsig(13, pictureBox3);


            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox3);
            }
            else
            {
                pbSeleccionados.Add(pictureBox3);
                comprobarImg(pbSeleccionados);
            }

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            imagenAsig(12, pictureBox4);

            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox4);
            }
            else
            {
                pbSeleccionados.Add(pictureBox4);
                comprobarImg(pbSeleccionados);
            }

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            imagenAsig(11, pictureBox5);

            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox5);
            }
            else
            {
                pbSeleccionados.Add(pictureBox5);
                comprobarImg(pbSeleccionados);
            }


        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            imagenAsig(10, pictureBox6);

            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox6);
            }
            else
            {
                pbSeleccionados.Add(pictureBox6);
                comprobarImg(pbSeleccionados);
            }


        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            imagenAsig(9, pictureBox7);

            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox7);
            }
            else
            {
                pbSeleccionados.Add(pictureBox7);
                comprobarImg(pbSeleccionados);
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            imagenAsig(8, pictureBox8);

            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox8);
            }
            else
            {
                pbSeleccionados.Add(pictureBox8);
                comprobarImg(pbSeleccionados);
            }


        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            imagenAsig(7, pictureBox9);

            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox9);
            }
            else
            {
                pbSeleccionados.Add(pictureBox9);
                comprobarImg(pbSeleccionados);
            }

        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            imagenAsig(6, pictureBox10);

            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox10);
            }
            else
            {
                pbSeleccionados.Add(pictureBox10);
                comprobarImg(pbSeleccionados);
            }


        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            imagenAsig(5, pictureBox11);

            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox11);
            }
            else
            {
                pbSeleccionados.Add(pictureBox11);
                comprobarImg(pbSeleccionados);
            }

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            imagenAsig(4, pictureBox12);

            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox12);
            }
            else
            {
                pbSeleccionados.Add(pictureBox12);
                comprobarImg(pbSeleccionados);
            }

        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            imagenAsig(3, pictureBox13);

            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox13);
            }
            else
            {
                pbSeleccionados.Add(pictureBox13);
                comprobarImg(pbSeleccionados);
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            imagenAsig(2, pictureBox14);

            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox14);
            }
            else
            {
                pbSeleccionados.Add(pictureBox14);
                comprobarImg(pbSeleccionados);
            }


        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            imagenAsig(1, pictureBox15);


            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox15);
            }
            else
            {
                pbSeleccionados.Add(pictureBox15);
                comprobarImg(pbSeleccionados);
            }


        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            imagenAsig(0, pictureBox16);

            if (pbSeleccionados.Count == 0)
            {
                pbSeleccionados.Add(pictureBox16);
            }
            else
            {
                pbSeleccionados.Add(pictureBox16);
                comprobarImg(pbSeleccionados);
            }


        }

        private void imagenAsig(int num, PictureBox pb)
        {
            if (listaRandom[num] == 1 || listaRandom[num] == 9)
            {
                pb.Image = azul;
                pb.Image.Tag = "azul";

            }
            else if (listaRandom[num] == 2 || listaRandom[num] == 10)
            {
                pb.Image = rojo;
                pb.Image.Tag = "rojo";
            }
            else if (listaRandom[num] == 3 || listaRandom[num] == 11)
            {
                pb.Image = verde;
                pb.Image.Tag = "verde";
            }
            else if (listaRandom[num] == 4 || listaRandom[num] == 12)
            {
                pb.Image = blanco;
                pb.Image.Tag = "blanco";
            }
            else if (listaRandom[num] == 5 || listaRandom[num] == 13)
            {
                pb.Image = negro;
                pb.Image.Tag = "negro";
            }
            else if (listaRandom[num] == 6 || listaRandom[num] == 14)
            {
                pb.Image = x;
                pb.Image.Tag = "x";
            }
            else if (listaRandom[num] == 7 || listaRandom[num] == 15)
            {
                pb.Image = incoloro;
                pb.Image.Tag = "incoloro";
            }
            else if (listaRandom[num] == 8 || listaRandom[num] == 16)
            {
                pb.Image = pirexia;
                pb.Image.Tag = "pirexia";

            }

        }

        private void comprobarImg(List<PictureBox> pbSeleccionados)
        {

            if (pbSeleccionados[0].Image == pbSeleccionados[1].Image)
            {
                pbSeleccionados[0].Enabled = false;
                pbSeleccionados[1].Enabled = false;

            }
            else if (pbSeleccionados[0].Image != pbSeleccionados[1].Image)
            {

                pbSeleccionados[0].Refresh();
                pbSeleccionados[1].Refresh();

                Thread.Sleep(1000);

                pbSeleccionados[0].Image = Resources._default;

                pbSeleccionados[1].Image = Resources._default;


            }


            pbSeleccionados.Clear();

        }
        private void terminar()
        {
            MessageBox.Show("Ha terminado la partida");
            Application.Exit();
            Environment.Exit(1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == ("Ingles"))
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

                label1.Text = Idiomas.Generico.jugador;
                label2.Text = Idiomas.Generico.dificultad;
                label3.Text = Idiomas.Generico.tiempo;
                label4.Text = Idiomas.Generico.idioma;
                button1.Text = Idiomas.Generico.comenzar;
                button2.Text = Idiomas.Generico.cambiar;


                comboBox2.Items.Clear();
                comboBox2.Items.Add("Spanish");
                comboBox2.Items.Add("English");

                comboBox2.SelectedIndex = 1;

                comboBox1.Items.Clear();
                comboBox1.Items.Add("Easy");
                comboBox1.Items.Add("Medium");
                comboBox1.Items.Add("Hard");


                comboBox1.SelectedIndex = 0;




            }
            else if (comboBox2.Text == ("Español")|| comboBox2.Text == ("Spanish"))
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");

                label1.Text = Idiomas.Generico.jugador;
                label2.Text = Idiomas.Generico.dificultad;
                label3.Text = Idiomas.Generico.tiempo;
                label4.Text = Idiomas.Generico.idioma;
                button1.Text = Idiomas.Generico.comenzar;
                button2.Text = Idiomas.Generico.cambiar;


                comboBox2.Items.Clear();



                comboBox2.Items.Add("Español");
                comboBox2.Items.Add("Ingles");


                comboBox2.SelectedIndex = 0;


                comboBox1.Items.Clear();
                comboBox1.Items.Add("Facil");
                comboBox1.Items.Add("Normal");
                comboBox1.Items.Add("Dificil");


                comboBox1.SelectedIndex = 0;
            }
        }


    }
}


