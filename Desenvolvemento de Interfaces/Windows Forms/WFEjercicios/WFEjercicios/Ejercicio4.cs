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
    public partial class Ejercicio4 : Form
    {
        WMPLib.WindowsMediaPlayer wpplayer = new WMPLib.WindowsMediaPlayer();
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            if(comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add("(Clasica)A Little Bit of Rhythm");
                wpplayer.URL = @"C:\\Users\\FP\\Downloads\\(Clasica)A Little Bit of Rhythm.mp3";
                wpplayer.controls.play();
                wpplayer.controls.stop();
                wpplayer.controls.pause();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("(Pop)Spirit of Fire.mp3");
                wpplayer.URL = @"C:\Users\FP\Downloads\(Pop)Spirit of Fire.mp3";
                wpplayer.controls.play();
                wpplayer.controls.stop();
                wpplayer.controls.pause();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Add("(Electronica)Neon Lights.mp3");
                wpplayer.URL = @"C:\Users\FP\Downloads\(Electronica)Neon Lights.mp3";
                wpplayer.controls.play();
                wpplayer.controls.stop();
                wpplayer.controls.pause();
            }

        }
    }
}
