using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;
using MemoryGame.Properties;

namespace MemoryGame
{
    public partial class MainForm : Form
    {
        public static Level1Form Form1 = new Level1Form();
        public static Level2Form Form2 = new Level2Form();
        public static Level3Form Form3 = new Level3Form();
        public static SoundPlayer song = new SoundPlayer();
        public MainForm()
        {
            InitializeComponent();
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.ShowDialog();
        }

        private void btnCreators_Click(object sender, EventArgs e)
        {
            Creators creators = new Creators();
            creators.ShowDialog();
        }

        private void btnLevelOne_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text == "نام خود را برای شروع بازی وارد کنید")
            {
                txtName.LineIdleColor = Color.Red;
            }
            else
            {
                MainForm.Form1 = new Level1Form();
                Player.name = txtName.Text;
                this.Hide();
                MainForm.Form1.ShowDialog();
            }

        }

        private void txtName_MouseEnter(object sender, EventArgs e)
        {
            txtName.LineIdleColor = Color.Green;
        }

        private void btnLevelTwo_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text == "نام خود را برای شروع بازی وارد کنید")
            {
                txtName.LineIdleColor = Color.Red;
            }
            else
            {
                MainForm.Form2 = new Level2Form();
                Player.name = txtName.Text;
                this.Hide();
                MainForm.Form2.ShowDialog();
            }
        }

        private void btnLevelThree_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text == "نام خود را برای شروع بازی وارد کنید")
            {
                txtName.LineIdleColor = Color.Red;
            }
            else
            {
                MainForm.Form3 = new Level3Form();
                Player.name = txtName.Text;
                this.Hide();
                MainForm.Form3.ShowDialog();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Player.name != "وارد نشده")
                txtName.Text = Player.name;
            
            song.SoundLocation = "MM.wav";
            song.Load();
            song.Play();
            picPlay.Enabled = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            song.Play();
        }

        private void picPause_Click(object sender, EventArgs e)
        {
            song.Stop();
            picPlay.Enabled = true;
        }
    }
}
