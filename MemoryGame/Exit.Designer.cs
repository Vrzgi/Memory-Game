namespace MemoryGame
{
    partial class Exit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoard = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnYes = new ns1.BunifuThinButton2();
            this.btnNo = new ns1.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MemoryGame.Properties.Resources.Hashie;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picBoard
            // 
            this.picBoard.Image = global::MemoryGame.Properties.Resources.Hashie;
            this.picBoard.Location = new System.Drawing.Point(0, 1);
            this.picBoard.Name = "picBoard";
            this.picBoard.Size = new System.Drawing.Size(401, 147);
            this.picBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoard.TabIndex = 12;
            this.picBoard.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("AFSANEH", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblExit.Location = new System.Drawing.Point(72, 20);
            this.lblExit.Name = "lblExit";
            this.lblExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblExit.Size = new System.Drawing.Size(261, 53);
            this.lblExit.TabIndex = 13;
            this.lblExit.Text = "واقعا می ‌خوای بری ؟!";
            // 
            // btnYes
            // 
            this.btnYes.ActiveBorderThickness = 1;
            this.btnYes.ActiveCornerRadius = 20;
            this.btnYes.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnYes.ActiveForecolor = System.Drawing.Color.White;
            this.btnYes.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnYes.BackColor = System.Drawing.Color.Silver;
            this.btnYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYes.BackgroundImage")));
            this.btnYes.ButtonText = "فعلا آره !";
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnYes.IdleBorderThickness = 1;
            this.btnYes.IdleCornerRadius = 20;
            this.btnYes.IdleFillColor = System.Drawing.Color.White;
            this.btnYes.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnYes.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnYes.Location = new System.Drawing.Point(275, 93);
            this.btnYes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnYes.Name = "btnYes";
            this.btnYes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnYes.Size = new System.Drawing.Size(113, 52);
            this.btnYes.TabIndex = 14;
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYes.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnNo
            // 
            this.btnNo.ActiveBorderThickness = 1;
            this.btnNo.ActiveCornerRadius = 20;
            this.btnNo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnNo.ActiveForecolor = System.Drawing.Color.White;
            this.btnNo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNo.BackColor = System.Drawing.Color.Silver;
            this.btnNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNo.BackgroundImage")));
            this.btnNo.ButtonText = "پشیمون شدم !";
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNo.IdleBorderThickness = 1;
            this.btnNo.IdleCornerRadius = 20;
            this.btnNo.IdleFillColor = System.Drawing.Color.White;
            this.btnNo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNo.Location = new System.Drawing.Point(12, 93);
            this.btnNo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnNo.Name = "btnNo";
            this.btnNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNo.Size = new System.Drawing.Size(113, 52);
            this.btnNo.TabIndex = 15;
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNo.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.picBoard);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBoard;
        private System.Windows.Forms.Label lblExit;
        private ns1.BunifuThinButton2 btnYes;
        private ns1.BunifuThinButton2 btnNo;
    }
}