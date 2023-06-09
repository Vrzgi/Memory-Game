using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Autorun : Form
    {
        public static MainForm FormMain = new MainForm();
        public Autorun()
        {
            InitializeComponent();
        }

        private void timerStarter_Tick(object sender, EventArgs e)
        {
            prgRun.Value += 1;
            if (prgRun.Value == 100)
            {
                timerStarter.Stop();
                this.Hide();
                FormMain.ShowDialog();
            }
        }
    }
}
