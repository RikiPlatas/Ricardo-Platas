using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFEjercicios
{
    public partial class Ejercicio9 : Form
    {

        
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            String s = textBox2.Text;
            int num = 0;
            errorProvider1 = new ErrorProvider();

            if (!textBox3.Text.Contains("@"))
            {
                errorProvider1.SetError(textBox3, "Formato invalido");

            }
            
            //if (!textBox1.Text.ToUpper().Equals(textBox1.Text)){
              //  errorProvider1.SetError(textBox1, "Formato invalido");
            //}

            if(int.TryParse(s, out num) == false){
                errorProvider1.SetError(textBox2, "Formato invalido");
            }
            
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if(c < 'A' || c > 'W')
            {
                if(c!= 'Ñ')
                {
                    e.Handled = true;
                }
            }
        }
    }
}
