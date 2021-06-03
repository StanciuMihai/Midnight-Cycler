using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Midnight_Cycler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Speed = 12;
        int gravity = 0;
        int points = 0;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            //Play background music
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\Joshua_McLean-Mountain_Trials.wav";
            sp.PlayLooping();
            //Display start screen
            DialogResult res = MessageBox.Show("Hold down space bar to accelerate, release to slow down, press Ok when ready!", "Welocme to Midnight Cycler!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                timer1.Start();
            }
            if (res == DialogResult.Cancel)
            {
                Application.Exit();
            }

        }
        private async Task EndGameAsync() //Game over function
        {
            timer1.Stop();

            Point.Visible = true;
            await Task.Delay(5 * 100);
            DialogResult result;
            result = MessageBox.Show($"Final score: {points} points. Would you like to try again?", "Game Over!", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.No)
            {
                
                Application.Exit();
            }
            if (result == DialogResult.Yes)
            {
                
                Application.Restart();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pipe_1.Left -= Speed;
            pipe_2.Left -= Speed;
            pipe_3.Left -= Speed;
            pipe_4.Left -= Speed;
            pipe_5.Left -= Speed;
            pipe_7.Left -= Speed;
            base_3.Left -= Speed;
            base_4.Left -= Speed;
            base_5.Left -= Speed;
            base_2.Left -= Speed;
            player.Top += gravity;
            Point.Text = "Score: " + points;
            if(pipe_1.Left<100)
            {
                pipe_1.Left = 1000;
                points += 5;
            }
            else if(pipe_2.Left<100)
            {
                pipe_2.Left = 1000;
                points += 5;
            }
            else if (pipe_3.Left < 100)
            {
                pipe_3.Left = 1000;
                points += 5;
            }
            else if (pipe_4.Left < 100)
            {
                pipe_4.Left = 1000;
                points += 5;
            }
            else if (pipe_5.Left < 100)
            {
                pipe_5.Left = 1000;
                points += 5;
            }
            else if (pipe_7.Left < 100)
            {
                pipe_7.Left = 1000;
                points += 5;
            }
            else if (base_2.Left < 100)
            {
                base_2.Left = 1000;
                points += 5;
            }
            else if (base_3.Left < 100)
            {
                base_3.Left = 1000;
                points += 5;
            }
            else if (base_4.Left < 100)
            {
                base_4.Left = 1000;
                points += 5;
            }
            else if (base_5.Left < 100)
            {
                base_5.Left = 1000;
                points += 5;
            }

            else if (player.Bounds.IntersectsWith(pipe_1.Bounds))
            {
                EndGameAsync();
                Point.Text = "Game-Over! Score: " + points;
            }
            else if (player.Bounds.IntersectsWith(pipe_2.Bounds))
            {
                EndGameAsync();
                Point.Text = "Game-Over! Score: " + points;
            }
            else if (player.Bounds.IntersectsWith(pipe_3.Bounds))
            {
                EndGameAsync();
                Point.Text = "Game-Over! Score: " + points;
            }
            else if (player.Bounds.IntersectsWith(pipe_4.Bounds))
            {
                EndGameAsync();
                Point.Text = "Game-Over! Score: " + points;
            }
            else if (player.Bounds.IntersectsWith(pipe_5.Bounds))
            {
                EndGameAsync();
                Point.Text = "Game-Over! Score: " + points;
            }
            else if (player.Bounds.IntersectsWith(pipe_6.Bounds))
            {
                EndGameAsync();
                Point.Text = "Game-Over! Score: " + points;
            }
            else if (player.Bounds.IntersectsWith(pipe_7.Bounds))
            {
                EndGameAsync();
                Point.Text = "Game-Over! Score: " + points;
            }
            else if (player.Bounds.IntersectsWith(base_1.Bounds) )
            {
                player.Top = base_1.Top - player.Height;
            }
            else if (player.Bounds.IntersectsWith(base_2.Bounds) )
            {
                player.Top = base_2.Top - player.Height;
            }
            else if (player.Bounds.IntersectsWith(base_3.Bounds) )
            {
                player.Top = base_3.Top - player.Height;
            }
            else if (player.Bounds.IntersectsWith(base_4.Bounds) )
            {
                player.Top = base_4.Top - player.Height;
            }
            else if (player.Bounds.IntersectsWith(base_5.Bounds) )
            {
                player.Top = base_5.Top - player.Height;
            }
        }

       
    }
}
