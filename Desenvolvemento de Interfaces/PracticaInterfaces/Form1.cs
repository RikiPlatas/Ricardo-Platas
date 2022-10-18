using PracticaInterfaces.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //comprobar sin son iguales o diferentes
            comprobarImg(Pb1Select, Pb2Select);

            //asignar
            imagenAsig(15, pictureBox1);
            if(Pb1Select == null )
            {
                Pb1Select = pictureBox1;
            }
            else
            {
                Pb2Select = pictureBox1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(14, pictureBox2);

            if (Pb1Select == null)
            {
                Pb1Select = pictureBox2;
            }
            else
            {
                Pb2Select = pictureBox2;
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(13, pictureBox3);
            if (Pb1Select == null)
            {
                Pb1Select = pictureBox3;
            }
            else
            {
                Pb2Select = pictureBox3;
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(12, pictureBox4);
            if (Pb1Select == null)
            {
                Pb1Select = pictureBox4;
            }
            else
            {
                Pb2Select = pictureBox4;
            }

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(11, pictureBox5);
            if (Pb1Select == null)
            {
                Pb1Select = pictureBox5;
            }
            else
            {
                Pb2Select = pictureBox5;
            }

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(10, pictureBox6);
            if (Pb1Select == null)
            {
                Pb1Select = pictureBox6;
            }
            else
            {
                Pb2Select = pictureBox6;
            }

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(9, pictureBox7);
            if (Pb1Select == null)
            {
                Pb1Select = pictureBox7;
            }
            else
            {
                Pb2Select = pictureBox7;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(8, pictureBox8);
            if (Pb1Select == null)
            {
                Pb1Select = pictureBox8;
            }
            else
            {
                Pb2Select = pictureBox8;
            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(7, pictureBox9);
            if (Pb1Select == null)
            {
                Pb1Select = pictureBox9;
            }
            else
            {
                Pb2Select = pictureBox9;
            }
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(6, pictureBox10);
            if (Pb1Select == null)
            {
                Pb1Select = pictureBox10;
            }
            else
            {
                Pb2Select = pictureBox10;
            }

        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(5, pictureBox11);
            if (Pb1Select == null)
            {
                Pb1Select = pictureBox11;
            }
            else
            {
                Pb2Select = pictureBox11;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(4, pictureBox12);
            if (Pb1Select == null)
            {
                Pb1Select = pictureBox12;
            }
            else
            {
                Pb2Select = pictureBox12;
            }
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(3, pictureBox13);
            if (Pb1Select == null)
            {
                Pb1Select = pictureBox13;
            }
            else
            {
                Pb2Select = pictureBox13;
            }

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(2, pictureBox14);
            if (Pb1Select == null)
            {
                Pb1Select = pictureBox14;
            }
            else
            {
                Pb2Select = pictureBox14;
            }

        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(1, pictureBox15);
            if (Pb1Select == null)
            {
                Pb1Select = pictureBox15;
            }
            else
            {
                Pb2Select = pictureBox15;
            }

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            comprobarImg(Pb1Select, Pb2Select);
            imagenAsig(0, pictureBox16);
            if (Pb1Select == null)
            {
                Pb1Select = pictureBox16;
            }
            else
            {
                Pb2Select = pictureBox16;
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

        private void comprobarImg(PictureBox pb1 , PictureBox pb2)
        {

            if(pb1 != null && pb2 != null)
            {

           
            if(pb1.Image.Tag != pb2.Image.Tag)
                {
                    if(pb1.Enabled == true)
                    {
                        pb1.Image = Resources._default;

                        pb1 = null;

                    }
                    if (pb2.Enabled == true)
                    {
                        pb2.Image = Resources._default;

                        pb2 = null;

                    }

                    

                }
                else
            {
                pb1.Enabled = false;
                pb2.Enabled = false;


            }
           }
        }

 
    }



 

}
