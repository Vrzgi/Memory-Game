namespace MemoryGame
{
    partial class Autorun
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prgRun = new ns1.BunifuProgressBar();
            this.timerStarter = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MemoryGame.Properties.Resources.brand_logos_memory;
            this.pictureBox1.Location = new System.Drawing.Point(14, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // prgRun
            // 
            this.prgRun.BackColor = System.Drawing.Color.Silver;
            this.prgRun.BorderRadius = 5;
            this.prgRun.Location = new System.Drawing.Point(97, 237);
            this.prgRun.MaximumValue = 100;
            this.prgRun.Name = "prgRun";
            this.prgRun.ProgressColor = System.Drawing.Color.Teal;
            this.prgRun.Size = new System.Drawing.Size(576, 22);
            this.prgRun.TabIndex = 2;
            this.prgRun.Value = 0;
            // 
            // timerStarter
            // 
            this.timerStarter.Enabled = true;
            this.timerStarter.Interval = 31;
            this.timerStarter.Tick += new System.EventHandler(this.timerStarter_Tick);
            // 
            // Autorun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 268);
            this.Controls.Add(this.prgRun);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autorun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorun";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuProgressBar prgRun;
        private System.Windows.Forms.Timer timerStarter;
    }
}