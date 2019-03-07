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
            int x = rnd.Next(0, Victorina.msc.Count());
            WMP.URL = Victorina.msc[x];
        }
    }
}
