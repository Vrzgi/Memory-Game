namespace MemoryGame
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new ns1.BunifuMaterialTextbox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLevelThree = new ns1.BunifuTileButton();
            this.btnLevelTwo = new ns1.BunifuTileButton();
            this.btnLevelOne = new ns1.BunifuTileButton();
            this.btnHelp = new ns1.BunifuTileButton();
            this.btnCreators = new ns1.BunifuTileButton();
            this.btnExit = new ns1.BunifuTileButton();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picPause = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HintForeColor = System.Drawing.Color.Black;
            this.txtName.HintText = "نام خود را برای شروع بازی وارد کنید";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtName.LineIdleColor = System.Drawing.Color.Green;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtName.LineThickness = 5;
            this.txtName.Location = new System.Drawing.Point(323, 312);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(444, 57);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            this.txtName.MouseEnter += new System.EventHandler(this.txtName_MouseEnter);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("AFSANEH", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(246, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(495, 170);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "بازی حافظه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(270, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "ورژن یک";
            // 
            // btnLevelThree
            // 
            this.btnLevelThree.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLevelThree.color = System.Drawing.Color.SeaGreen;
            this.btnLevelThree.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnLevelThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevelThree.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelThree.ForeColor = System.Drawing.Color.White;
            this.btnLevelThree.Image = global::MemoryGame.Properties.Resources.lvl3;
            this.btnLevelThree.ImagePosition = 22;
            this.btnLevelThree.ImageZoom = 50;
            this.btnLevelThree.LabelPosition = 44;
            this.btnLevelThree.LabelText = "دشوار";
            this.btnLevelThree.Location = new System.Drawing.Point(323, 406);
            this.btnLevelThree.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btnLevelThree.Name = "btnLevelThree";
            this.btnLevelThree.Size = new System.Drawing.Size(140, 140);
            this.btnLevelThree.TabIndex = 7;
            this.btnLevelThree.Click += new System.EventHandler(this.btnLevelThree_Click);
            // 
            // btnLevelTwo
            // 
            this.btnLevelTwo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLevelTwo.color = System.Drawing.Color.SeaGreen;
            this.btnLevelTwo.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnLevelTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevelTwo.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelTwo.ForeColor = System.Drawing.Color.White;
            this.btnLevelTwo.Image = global::MemoryGame.Properties.Resources.lvl2;
            this.btnLevelTwo.ImagePosition = 22;
            this.btnLevelTwo.ImageZoom = 50;
            this.btnLevelTwo.LabelPosition = 44;
            this.btnLevelTwo.LabelText = "سخت";
            this.btnLevelTwo.Location = new System.Drawing.Point(475, 406);
            this.btnLevelTwo.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btnLevelTwo.Name = "btnLevelTwo";
            this.btnLevelTwo.Size = new System.Drawing.Size(140, 140);
            this.btnLevelTwo.TabIndex = 7;
            this.btnLevelTwo.Click += new System.EventHandler(this.btnLevelTwo_Click);
            // 
            // btnLevelOne
            // 
            this.btnLevelOne.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLevelOne.color = System.Drawing.Color.SeaGreen;
            this.btnLevelOne.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnLevelOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevelOne.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelOne.ForeColor = System.Drawing.Color.White;
            this.btnLevelOne.Image = global::MemoryGame.Properties.Resources.lvl1;
            this.btnLevelOne.ImagePosition = 22;
            this.btnLevelOne.ImageZoom = 50;
            this.btnLevelOne.LabelPosition = 44;
            this.btnLevelOne.LabelText = "آسان";
            this.btnLevelOne.Location = new System.Drawing.Point(627, 406);
            this.btnLevelOne.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btnLevelOne.Name = "btnLevelOne";
            this.btnLevelOne.Size = new System.Drawing.Size(140, 140);
            this.btnLevelOne.TabIndex = 7;
            this.btnLevelOne.Click += new System.EventHandler(this.btnLevelOne_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.AutoSize = true;
            this.btnHelp.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHelp.color = System.Drawing.Color.SeaGreen;
            this.btnHelp.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::MemoryGame.Properties.Resources.Help;
            this.btnHelp.ImagePosition = 22;
            this.btnHelp.ImageZoom = 50;
            this.btnHelp.LabelPosition = 44;
            this.btnHelp.LabelText = "راهنمای بازی";
            this.btnHelp.Location = new System.Drawing.Point(15, 189);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(6);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(108, 111);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnCreators
            // 
            this.btnCreators.AutoSize = true;
            this.btnCreators.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCreators.color = System.Drawing.Color.SeaGreen;
            this.btnCreators.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCreators.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreators.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreators.ForeColor = System.Drawing.Color.White;
            this.btnCreators.Image = global::MemoryGame.Properties.Resources.About;
            this.btnCreators.ImagePosition = 22;
            this.btnCreators.ImageZoom = 50;
            this.btnCreators.LabelPosition = 44;
            this.btnCreators.LabelText = "سازندگان";
            this.btnCreators.Location = new System.Drawing.Point(15, 312);
            this.btnCreators.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreators.Name = "btnCreators";
            this.btnCreators.Size = new System.Drawing.Size(108, 111);
            this.btnCreators.TabIndex = 2;
            this.btnCreators.Click += new System.EventHandler(this.btnCreators_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExit.color = System.Drawing.Color.SeaGreen;
            this.btnExit.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::MemoryGame.Properties.Resources.exit;
            this.btnExit.ImagePosition = 16;
            this.btnExit.ImageZoom = 50;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btnExit.LabelPosition = 40;
            this.btnExit.LabelText = "خروج";
            this.btnExit.Location = new System.Drawing.Point(15, 435);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 111);
            this.btnExit.TabIndex = 2;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picPlay
            // 
            this.picPlay.Image = global::MemoryGame.Properties.Resources.play_button;
            this.picPlay.Location = new System.Drawing.Point(12, 12);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(29, 28);
            this.picPlay.TabIndex = 10;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // picPause
            // 
            this.picPause.Image = global::MemoryGame.Properties.Resources.round_pause_button;
            this.picPause.Location = new System.Drawing.Point(43, 12);
            this.picPause.Name = "picPause";
            this.picPause.Size = new System.Drawing.Size(31, 31);
            this.picPause.TabIndex = 11;
            this.picPause.TabStop = false;
            this.picPause.Click += new System.EventHandler(this.picPause_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.picPause);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLevelThree);
            this.Controls.Add(this.btnLevelTwo);
            this.Controls.Add(this.btnLevelOne);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCreators);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuMaterialTextbox txtName;
        private ns1.BunifuTileButton btnExit;
        private ns1.BunifuTileButton btnCreators;
        private ns1.BunifuTileButton btnHelp;
        private ns1.BunifuTileButton btnLevelOne;
        private ns1.BunifuTileButton btnLevelTwo;
        private ns1.BunifuTileButton btnLevelThree;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picPause;
    }
}