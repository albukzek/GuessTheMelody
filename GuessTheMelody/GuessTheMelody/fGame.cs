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
            if (Victorina.msc.Count == 0) EndGame();
            else
            {
                int x = rnd.Next(0, Victorina.msc.Count());
                WMP.URL = Victorina.msc[x];
                Victorina.msc.RemoveAt(x);
                lblMelodyCount.Text = Victorina.msc.Count.ToString();
            }
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            GamePause();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblMelodyCount.Text = Victorina.msc.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.gameDuration;
;        }

        void EndGame()
        {
            timer1.Start();
            WMP.Ctlcontrols.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if(progressBar1.Value==progressBar1.Maximum)
            {
                EndGame();
            }
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                GamePause();
                if (MessageBox.Show("Правильный ответ?", "Игрок 1", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    labelGamer1.Text = Convert.ToString(Convert.ToInt32(labelGamer1.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
            if (e.KeyData == Keys.P)
            {
                GamePause();
                if (MessageBox.Show("Правильный ответ?", "Игрок 2", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    labelGamer2.Text = Convert.ToString(Convert.ToInt32(labelGamer2.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }



        }

        void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }
        void GamePlay()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }
    }
}
