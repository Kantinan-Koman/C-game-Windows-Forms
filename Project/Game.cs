using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Game : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        public Game()
        {
            InitializeComponent();
        }

        private void Gametimerevent(object sender, EventArgs e)
        {
            kitty.Top += gravity;
            pipe.Left -= pipeSpeed;

            pipedown.Left -= pipeSpeed;
            lblScore.Text = "Score: " + score;

            if (pipe.Left < -150)
            {

                pipe.Left = 800;
                score++;
            }
            if (pipedown.Left < -180)
            {

                pipedown.Left = 950;
                score++;
            }

            if (kitty.Bounds.IntersectsWith(pipe.Bounds) ||
                kitty.Bounds.IntersectsWith(pipedown.Bounds) ||
                kitty.Bounds.IntersectsWith(ground.Bounds) || kitty.Top < -25
                )
            {

                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 5;
            }
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;x
            }
        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void endGame()
        {
            gametimer.Stop();
            lblScore.Text += " Game over!!!";
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}