using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace SonicFlow
{
    public partial class Form1 : Form
    {

        private MediaPlayer mediaPlayer;

        public Form1()
        {
            InitializeComponent();
            mediaPlayer = new MediaPlayer();
            mediaPlayer.Open(new Uri("Feed the Machine.mp3", UriKind.Relative));
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MXP.Ctlcontrols.play();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
