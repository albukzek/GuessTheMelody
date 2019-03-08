using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessTheMelody
{
    public partial class fParam : Form
    {
        public fParam()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {

            Set();
            this.Hide();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            Victorina.allDirectories = checkBoxAllDirectory.Checked;
            Victorina.gameDuration = Convert.ToInt32(comboBoxGameDuration.Text);
            Victorina.musicDuration = Convert.ToInt32(comboBoxMusicDuration.Text);
            Victorina.randomStart = checkBoxRandomSrart.Checked;
            Victorina.WriteParam();
            this.Hide();
        }

        private void bSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog()==DialogResult.OK)
            {
                string[] musicList = Directory.GetFiles(fbd.SelectedPath, "*.mp3",
                    checkBoxAllDirectory.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                Victorina.lastFolder = fbd.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(musicList);
                Victorina.msc.Clear();
                Victorina.msc.AddRange(musicList);
            }
        }

        private void bClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        void Set()
        {
            checkBoxAllDirectory.Checked = Victorina.allDirectories;
            checkBoxRandomSrart.Checked = Victorina.randomStart;
            comboBoxGameDuration.Text = Victorina.gameDuration.ToString();
            comboBoxMusicDuration.Text = Victorina.musicDuration.ToString();

        }


        private void fParam_Load(object sender, EventArgs e)
        {
            Set();
        }
    }
}
