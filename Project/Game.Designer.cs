namespace Project
{
    partial class Game
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
            this.kitty = new System.Windows.Forms.PictureBox();
            this.pipe = new System.Windows.Forms.PictureBox();
            this.pipedown = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kitty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // kitty
            // 
            this.kitty.Image = global::Project.Properties.Resources.kitty1;
            this.kitty.Location = new System.Drawing.Point(93, 359);
            this.kitty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kitty.Name = "kitty";
            this.kitty.Size = new System.Drawing.Size(194, 177);
            this.kitty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kitty.TabIndex = 0;
            this.kitty.TabStop = false;
            // 
            // pipe
            // 
            this.pipe.Image = global::Project.Properties.Resources.pipe;
            this.pipe.Location = new System.Drawing.Point(770, 598);
            this.pipe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pipe.Name = "pipe";
            this.pipe.Size = new System.Drawing.Size(200, 352);
            this.pipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe.TabIndex = 1;
            this.pipe.TabStop = false;
            // 
            // pipedown
            // 
            this.pipedown.Image = global::Project.Properties.Resources.pipedown;
            this.pipedown.Location = new System.Drawing.Point(770, -88);
            this.pipedown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(200, 353);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown.TabIndex = 2;
            this.pipedown.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Project.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-18, 830);
            this.ground.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1350, 138);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.Gametimerevent);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(38, 33);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(288, 73);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score : 0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1266, 945);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipedown);
            this.Controls.Add(this.pipe);
            this.Controls.Add(this.kitty);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.kitty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kitty;
        private System.Windows.Forms.PictureBox pipe;
        private System.Windows.Forms.PictureBox pipedown;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label lblScore;
    }
}