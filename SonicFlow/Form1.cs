﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SonicFlow
{
    public partial class Form1 : Form
    {
        bool play = true;
        
        public Form1()
        {
            InitializeComponent();
            MXP.URL = @"C:\Users\MSI\Desktop\Projects\Competition\SonicFlow\SonicFlow\bin\Debug\song1.mp3";
            MXP.Visible = true;
            MXP.Ctlcontrols.stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MXP.Ctlcontrols.play();

        }
    }
}
