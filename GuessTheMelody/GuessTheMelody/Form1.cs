﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheMelody
{
    public partial class fMain : Form
    {

        fParam param = new fParam();
        fGame fg = new fGame();

        public fMain()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            param.ShowDialog();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            Victorina.ReadParam();
            Victorina.RealMusic();
        }
    }
}
