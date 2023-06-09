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
    public partial class Level3Form : Form
    {
        #region Fields
        //Array of Random Number
        int[] arrayNumbers = new int[36];

        //Help Value
        int k = 0;
        int end;

        //Array of Pictures
        Image[] addressPics = {
            Resources.F3I1,
            Resources.F3I2,
            Resources.F3I3,
            Resources.F3I4,
            Resources.F3I5,
            Resources.F3I6,
            Resources.F3I7,
            Resources.F3I8,
            Resources.F3I9,
            Resources.F3I10,
            Resources.F3I11,
            Resources.F3I12,
            Resources.F3I13,
            Resources.F3I14,
            Resources.F3I15,
            Resources.F3I16,
            Resources.F3I17,
            Resources.F3I18
        };

        //Click Counter
        public int cntClick = 0;

        //Helper PictureBoxes
        public PictureBox picBox1, picBox2;

        //Array of PicturBoxes
        public PictureBox[] PicBoxForm3 = new PictureBox[36];

        //Index of PictureBoxes
        public int index1, index2;

        //Help Value
        public bool checker;
        bool pause = false;
        #endregion

        #region Constructors
        public Level3Form()
        {
            InitializeComponent();
            PicBox();
        }
        #endregion

        #region Events
        //Load Form Event:
        private void Level3Form_Load(object sender, EventArgs e)
        {
            MainForm.song.Stop();
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
        }

        //Start Button Event:
        public void btnStart_Click(object sender, EventArgs e)
        {
            timerPics.Enabled = true;
            btnStart.Enabled = false;
            lblClick.Text = Player.countClick.ToString();
            GetRandom();
            for (int z = 0; z < 36; z++)
                PicBoxForm3[z].Image = addressPics[arrayNumbers[z]];
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
                    foreach (var box in PicBoxForm3)
                        box.Enabled = false;
                    timerRefresh.Enabled = true;
                }
                else
                {
                    foreach (var box in PicBoxForm3)
                        box.Enabled = false;
                    Animate(picBox1, picBox2);
                    foreach (var box in PicBoxForm3)
                        box.Enabled = true;
                    end++;
                }
                if (end == 18)
                {
                    timerTime.Enabled = false;
                    btnStopTime.Enabled = false;
                    lblFinish.Text = "بازی رو بردی !";
                    lblFinish2.Text = "اگه دوست داشتی دوباره همین سطح رو بازی کن یا به سطح‌های قبل برگرد ";
                }
            }
        }


        //Back Button Event:
        private void btnBackLevel3_Click(object sender, EventArgs e)
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
            foreach (var box in PicBoxForm3)
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
            timerRefresh.Enabled = false;
            foreach (var box in PicBoxForm3)
                box.Enabled = true;
        }

        #endregion

        #region Methods

        //Make Array of PictureBoxes:
        public void PicBox()
        {
            PicBoxForm3[0] = p0;
            PicBoxForm3[1] = p1;
            PicBoxForm3[2] = p2;
            PicBoxForm3[3] = p3;
            PicBoxForm3[4] = p4;
            PicBoxForm3[5] = p5;
            PicBoxForm3[6] = p6;
            PicBoxForm3[7] = p7;
            PicBoxForm3[8] = p8;
            PicBoxForm3[9] = p9;
            PicBoxForm3[10] = p10;
            PicBoxForm3[11] = p11;
            PicBoxForm3[12] = p12;
            PicBoxForm3[13] = p13;
            PicBoxForm3[14] = p14;
            PicBoxForm3[15] = p15;
            PicBoxForm3[16] = p16;
            PicBoxForm3[17] = p17;
            PicBoxForm3[18] = p18;
            PicBoxForm3[19] = p19;
            PicBoxForm3[20] = p20;
            PicBoxForm3[21] = p21;
            PicBoxForm3[22] = p22;
            PicBoxForm3[23] = p23;
            PicBoxForm3[24] = p24;
            PicBoxForm3[25] = p25;
            PicBoxForm3[26] = p26;
            PicBoxForm3[27] = p27;
            PicBoxForm3[28] = p28;
            PicBoxForm3[29] = p29;
            PicBoxForm3[30] = p30;
            PicBoxForm3[31] = p31;
            PicBoxForm3[32] = p32;
            PicBoxForm3[33] = p33;
            PicBoxForm3[34] = p34;
            PicBoxForm3[35] = p35;
        }

        private void btnStopTime_Click(object sender, EventArgs e)
        {
            if (!pause)
            {
                timerTime.Enabled = false;
                foreach (var box in PicBoxForm3)
                    box.Enabled = false;
                pause = true;
            }
            else
            {
                timerTime.Enabled = true;
                foreach (var box in PicBoxForm3)
                    box.Enabled = true;
                pause = false;
            }
        }
        private void btnLevelThreeRestart_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.Form3 = new Level3Form();
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
                while (i < 18)
                {
                    int rnumber = RandomNumbers.Next(0, 18);
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
