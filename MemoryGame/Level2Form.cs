using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoryGame.Properties;

namespace MemoryGame
{
    public partial class Level2Form : Form
    {
        #region Fields
        //Array of Random Number
        int[] arrayNumbers = new int[24];

        //Help Value
        int k = 0;
        int end;

        //Array of Pictures
        Image[] addressPics = {
            Resources.F2I1,
            Resources.F2I2,
            Resources.F2I3,
            Resources.F2I4,
            Resources.F2I5,
            Resources.F2I6,
            Resources.F2I7,
            Resources.F2I8,
            Resources.F2I9,
            Resources.F2I10,
            Resources.F2I11,
            Resources.F2I12
        };

        //Click Counter
        public int cntClick = 0;

        //Helper PictureBoxes
        public PictureBox picBox1, picBox2;

        //Array of PicturBoxes
        public PictureBox[] PicBoxForm2 = new PictureBox[24];

        //Index of PictureBoxes
        public int index1, index2;

        //Help Value
        public bool checker;
        bool pause = false;
        #endregion

        #region Constructors
        public Level2Form()
        {
            InitializeComponent();
            PicBox();
        }
        #endregion

        #region Events
        //Load Form Event:
        private void Level2Form_Load(object sender, EventArgs e)
        {
            lblNameOne.Text = Player.name;
            btnTime.Enabled = false;
            iconName.Enabled = false;
            btnClick.Enabled = false;
            btnLevelOneRestart.Enabled = false;
            btnStopTime.Enabled = false;
            Player.countClick = 0;
            lblFinish.Text = "";
            lblFinish2.Text = "";
            end = 0;
            MainForm.song.Stop();
        }

        //Start Button Event:
        public void btnStart_Click(object sender, EventArgs e)
        {
            timerPics.Enabled = true;
            btnStart.Enabled = false;
            lblClick.Text = Player.countClick.ToString();
            GetRandom();
            for (int z = 0; z < 24; z++)
                PicBoxForm2[z].Image = addressPics[arrayNumbers[z]];
        }

        //Card Click Events:
        public void Check_Click(object sender, EventArgs e)
        {
            if (timerTime.Enabled)
            {
                Card_Click(sender, e);
            }
        }
        public void Card_Click(object sender, EventArgs e)
        {

            //Show Cards
            ((PictureBox)sender).Image = addressPics[arrayNumbers[Convert.ToInt32(((PictureBox)sender).Name.Substring(1))]];

            //All Click Counter
            Player.countClick += 1;
            lblClick.Text = Player.countClick.ToString();
            if (cntClick == 0)
            {
                picBox1 = (PictureBox)sender;
                picBox1.Enabled = false;
                cntClick++;
            }
            else if (cntClick == 1)
            {
                cntClick = 0;
                picBox2 = (PictureBox)sender;
                picBox2.Enabled = false;
                index1 = Convert.ToInt32(picBox1.Name.Substring(1));
                index2 = Convert.ToInt32(picBox2.Name.Substring(1));
                if (!Bitmap.Equals(addressPics[arrayNumbers[index1]], addressPics[arrayNumbers[index2]]))
                {
                    foreach (var box in PicBoxForm2)
                        box.Enabled = false;
                    timerRefresh.Enabled = true;
                }
                else
                {
                    foreach (var box in PicBoxForm2)
                        box.Enabled = false;
                    Animate(picBox1, picBox2);
                    foreach (var box in PicBoxForm2)
                        box.Enabled = true;
                    end++;
                }
                if (end == 12)
                {
                    timerTime.Enabled = false;
                    btnStopTime.Enabled = false;
                    lblFinish.Text = "بازی رو بردی !";
                    lblFinish2.Text = "اگه دوست داشتی دوباره همین سطح رو بازی کن یا که سطح بعدی رو امتحان کن ";
                }

            }
        }


        //Back Button Event:
        private void btnBackLevel2_Click(object sender, EventArgs e)
        {
            this.Close();
            Autorun.FormMain.Show();
            MainForm.song.Play();
        }

        //Close Form Event:
        #endregion

        #region Timer
        //Timer for Time Starting:
        private void timerTime_Tick(object sender, EventArgs e)
        {

            lblTimeSadom.Text = (Convert.ToInt32(lblTimeSadom.Text) + 1).ToString();
            if (Convert.ToInt32(lblTimeSadom.Text) == 60)
            {
                lblTimeSadom.Text = "0";
                lblTimeSanie.Text = (Convert.ToInt32(lblTimeSanie.Text) + 1).ToString();
            }
            if (Convert.ToInt32(lblTimeSanie.Text) == 60)
            {
                lblTimeSanie.Text = "0";
                lblTimeDaqiqe.Text = (Convert.ToInt32(lblTimeDaqiqe.Text) + 1).ToString();
            }
            if (Convert.ToInt32(lblTimeDaqiqe.Text) == 60)
            {
                lblTimeDaqiqe.Text = "0";
            }

        }

        //Timer for Active BackPics:
        private void timerPics_Tick(object sender, EventArgs e)
        {
            foreach (var box in PicBoxForm2)
                box.Image = Resources.BackPic;
            timerTime.Enabled = true;
            btnStopTime.Enabled = true;
            btnLevelOneRestart.Enabled = true;
            timerPics.Stop();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            picBox1.Image = Resources.BackPic;
            picBox2.Image = Resources.BackPic;
            picBox1.Enabled = true;
            picBox2.Enabled = true;
            timerRefresh.Enabled = false;
            foreach (var box in PicBoxForm2)
                box.Enabled = true;
        }

        #endregion

        #region Methods

        //Make Array of PictureBoxes:
        public void PicBox()
        {
            PicBoxForm2[0] = p0;
            PicBoxForm2[1] = p1;
            PicBoxForm2[2] = p2;
            PicBoxForm2[3] = p3;
            PicBoxForm2[4] = p4;
            PicBoxForm2[5] = p5;
            PicBoxForm2[6] = p6;
            PicBoxForm2[7] = p7;
            PicBoxForm2[8] = p8;
            PicBoxForm2[9] = p9;
            PicBoxForm2[10] = p10;
            PicBoxForm2[11] = p11;
            PicBoxForm2[12] = p12;
            PicBoxForm2[13] = p13;
            PicBoxForm2[14] = p14;
            PicBoxForm2[15] = p15;
            PicBoxForm2[16] = p16;
            PicBoxForm2[17] = p17;
            PicBoxForm2[18] = p18;
            PicBoxForm2[19] = p19;
            PicBoxForm2[20] = p20;
            PicBoxForm2[21] = p21;
            PicBoxForm2[22] = p22;
            PicBoxForm2[23] = p23;
        }

        private void btnStopTime_Click(object sender, EventArgs e)
        {
            if (!pause)
            {
                timerTime.Enabled = false;
                foreach (var box in PicBoxForm2)
                    box.Enabled = false;
                pause = true;
            }
            else
            {
                timerTime.Enabled = true;
                foreach (var box in PicBoxForm2)
                    box.Enabled = true;
                pause = false;
            }
        }
        private void btnLevelTwoRestart_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.Form2 = new Level2Form();
            MainForm.Form2.Show();
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            MainForm.Form3 = new Level3Form();
            MainForm.Form2.Close();
            MainForm.Form3.Show();
        }

        //End Make Array of PictureBoxes.

        //Make Random Numbers:
        public int[] GetRandom()
        {
            Random RandomNumbers = new Random();
            int i = k = 0, q = 0;
            bool zero = false, zeroCheck, repeat = true;
            for (int z = 0; z < 2; z++)
            {
                zeroCheck = false;
                i = 0;
                while (i < 12)
                {
                    int rnumber = RandomNumbers.Next(0, 12);
                    for (int j = q; j <= k; j++)
                    {
                        if (rnumber == 0)
                            if (zeroCheck == false)
                            {
                                zero = true;
                                zeroCheck = true;
                                repeat = true;
                                break;
                            }
                        if (arrayNumbers[j] == rnumber)
                        {
                            repeat = true;
                            break;
                        }
                    }
                    if (zero == true)
                    {
                        arrayNumbers[k] = rnumber;
                        i++;
                        k++;
                        zero = false;
                    }
                    if (repeat == false)
                    {
                        arrayNumbers[k] = rnumber;
                        i++;
                        k++;
                    }
                    repeat = false;
                }
                q = k;
            }
            return arrayNumbers;
        }
        //End Make Random Number.

        //Animate Method:
        private void Animate(PictureBox box1, PictureBox box2)
        {
            if (box1.Width != 0 && box2.Width != 0)
            {
                for (int i = box1.Width; i >= 0; i--)
                {
                    box1.Width -= 2;
                    box1.Left += 1;
                    box2.Width -= 2;
                    box2.Left += 1;
                    for (int j = 0; j <= 500000; j++) ;
                }
            }
            else
            {
                for (int i = 0; i < 65; i++)
                {
                    box1.Width += 1;
                    box1.Left -= 1;
                    box2.Width += 1;
                    box2.Left -= 1;
                    for (int j = 0; j <= 500000; j++) ;
                }
                box1.Left -= 1;
                box2.Left -= 1;
            }
        }
        #endregion
    }
}
