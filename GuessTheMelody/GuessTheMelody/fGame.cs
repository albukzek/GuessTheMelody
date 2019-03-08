using System;
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
    public partial class fGame : Form
    {
        Random rnd = new Random();
        public fGame()
        {
            InitializeComponent();
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Value = 0;
            MakeMusic();
        }
        void MakeMusic()
        {
            int x = rnd.Next(0, Victorina.msc.Count());
            WMP.URL = Victorina.msc[x];
            Victorina.msc.RemoveAt(x);
            lblMelodyCount.Text = Victorina.msc.Count.ToString();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblMelodyCount.Text = Victorina.msc.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.gameDuration;
;        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if(progressBar1.Value==progressBar1.Maximum)
            { timer1.Start(); }
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            timer1.Start();
            WMP.Ctlcontrols.pause();
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }
    }
}
