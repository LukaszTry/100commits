using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SonicFlow
{
    public partial class Form1 : Form
    {

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            //Czemu ty skurwysynu nie bierzesz tej piosenki do kurwy
            player.URL = "song1.mp3";
        }


        private void Play_Click(object sender, EventArgs e)
        {
            try
            {
                
                player.controls.play();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void MXP_Enter(object sender, EventArgs e)
        {

        }
    }
}
