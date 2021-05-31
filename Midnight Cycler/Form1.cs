﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        bool jump = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void EndGame() //Game over function
        {
            timer1.Stop();

            Point.Visible = true;
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
            base_3.Left -= Speed;
            base_4.Left -= Speed;
            base_2.Left -= Speed;
            player.Top += gravity;
            Point.Text = "Score -" + points;
            

        }
    }
}
