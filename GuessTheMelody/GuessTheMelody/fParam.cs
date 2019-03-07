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
            this.Hide();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog()==DialogResult.OK)
            {
                string[] musicList = Directory.GetFiles(fbd.SelectedPath, "*.mp3",
                    checkBoxAllDirectory.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
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
    }
}
