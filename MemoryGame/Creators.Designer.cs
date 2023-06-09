namespace MemoryGame
{
    partial class Creators
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creators));
            this.btnBack = new ns1.BunifuThinButton2();
            this.picCreators = new System.Windows.Forms.PictureBox();
            this.picBoard = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCreators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.ActiveBorderThickness = 1;
            this.btnBack.ActiveCornerRadius = 20;
            this.btnBack.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnBack.ActiveForecolor = System.Drawing.Color.White;
            this.btnBack.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.ButtonText = "بازگشت";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBack.IdleBorderThickness = 1;
            this.btnBack.IdleCornerRadius = 20;
            this.btnBack.IdleFillColor = System.Drawing.Color.White;
            this.btnBack.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnBack.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnBack.Location = new System.Drawing.Point(12, 340);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 52);
            this.btnBack.TabIndex = 9;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Click += new System.EventHandler(this.btnBackCreator_Click);
            // 
            // picCreators
            // 
            this.picCreators.Image = global::MemoryGame.Properties.Resources.CreatorsIMG;
            this.picCreators.Location = new System.Drawing.Point(12, 12);
            this.picCreators.Name = "picCreators";
            this.picCreators.Size = new System.Drawing.Size(476, 376);
            this.picCreators.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCreators.TabIndex = 8;
            this.picCreators.TabStop = false;
            // 
            // picBoard
            // 
            this.picBoard.Image = global::MemoryGame.Properties.Resources.Hashie;
            this.picBoard.Location = new System.Drawing.Point(0, 0);
            this.picBoard.Name = "picBoard";
            this.picBoard.Size = new System.Drawing.Size(500, 400);
            this.picBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoard.TabIndex = 6;
            this.picBoard.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Creators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picCreators);
            this.Controls.Add(this.picBoard);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Creators";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creators";
            ((System.ComponentModel.ISupportInitialize)(this.picCreators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picCreators;
        private ns1.BunifuThinButton2 btnBack;
        private System.Windows.Forms.PictureBox picBoard;
    }
}