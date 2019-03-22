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
        int musicDuration = Victorina.musicDuration;
        bool[] gamers = new bool[2];

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
                musicDuration = Victorina.musicDuration;
                int x = rnd.Next(0, Victorina.msc.Count());
                WMP.URL = Victorina.msc[x];
                Victorina.msc.RemoveAt(x);
                lblMelodyCount.Text = Victorina.msc.Count.ToString();
                gamers[0] = false;
                gamers[1] = false;
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
            labelMusicDuration.Text = musicDuration.ToString();
        }

        void EndGame()
        {
            timer1.Start();
            WMP.Ctlcontrols.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            labelMusicDuration.Text = musicDuration.ToString();
            if (progressBar1.Value==progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if (musicDuration == 0) MakeMusic();
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
            if (timer1.Enabled==true)
            {


                if (gamers[0]==false && e.KeyData == Keys.A)
                {
                    GamePause();
                    fMessage fm = new fMessage();
                    fm.lGamer.Text = "Игрок 1";
                    gamers[0] = true;
                    if (fm.ShowDialog() == DialogResult.Yes)
                    {
                        labelGamer1.Text = Convert.ToString(Convert.ToInt32(labelGamer1.Text) + 1);
                        MakeMusic();
                    }
                    GamePlay();
                }
                if (gamers[1]==false && e.KeyData == Keys.P)
                {
                    GamePause();
                    fMessage fm = new fMessage();
                    fm.lGamer.Text = "Игрок 2";
                    gamers[1] = true;
                    if (fm.ShowDialog() == DialogResult.Yes)
                    {
                        labelGamer2.Text = Convert.ToString(Convert.ToInt32(labelGamer2.Text) + 1);
                        MakeMusic();
                    }
                    GamePlay();
                }
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

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart)

                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)WMP.currentMedia.duration / 2);
                    
        }
    }
}
