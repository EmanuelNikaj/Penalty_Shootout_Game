using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Shootout_Penalty_Football_Game
{
    public partial class Form1 : Form
    {
        private List<string> KeeperPosition = new List<string> { "left", "right", "top", "topLeft", "topRight" };
        private List<PictureBox> goalTarget;
        private int ballX = 0;
        private int ballY = 0;
        private int goal = 0;
        private int miss = 0;
        private string state;
        private string playerTarget;
        private bool aimSet = false;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            goalTarget = new List<PictureBox> { left, right, top, topLeft, topRight };
        }

        private void SetGoalTargetEvent(object sender, EventArgs e)
        {
            if (aimSet) return;

            BallTimer.Start();
            KeeperTimer.Start();
            ChangeGoalKeeperImage();

            var senderObject = (PictureBox)sender;
            senderObject.BackColor = Color.Beige;
            playerTarget = senderObject.Tag.ToString();

            switch (playerTarget)
            {
                case "topRight":
                    ballX = -7;
                    ballY = 15;
                    break;
                case "right":
                    ballX = -11;
                    ballY = 15;
                    break;
                case "top":
                    ballX = 0;
                    ballY = 20;
                    break;
                case "topLeft":
                    ballX = 8;
                    ballY = 15;
                    break;
                case "left":
                    ballX = 7;
                    ballY = 8;
                    break;
            }

            aimSet = true;
            CheckScore();
        }

        private void KeeperTimerEvent(object sender, EventArgs e)
        {
            switch (state)
            {
                case "left":
                    goalKeeper.Left -= 6;
                    goalKeeper.Top = 204;
                    break;
                case "right":
                    goalKeeper.Left += 6;
                    goalKeeper.Top = 204;
                    break;
                case "top":
                    goalKeeper.Top -= 6;
                    break;
                case "topLeft":
                    goalKeeper.Left -= 6;
                    goalKeeper.Top -= 3;
                    break;
                case "topRight":
                    goalKeeper.Left += 6;
                    goalKeeper.Top -= 3;
                    break;
            }

            foreach (PictureBox x in goalTarget)
            {
                if (goalKeeper.Bounds.IntersectsWith(x.Bounds))
                {
                    KeeperTimer.Stop();
                    goalKeeper.Location = new Point(418, 169);
                    goalKeeper.Image = Properties.Resources.stand_small;
                }
            }
        }

        private void BallTimerEvent(object sender, EventArgs e)
        {
            football.Left -= ballX;
            football.Top -= ballY;

            foreach (PictureBox x in goalTarget)
            {
                if (football.Bounds.IntersectsWith(x.Bounds))
                {
                    football.Location = new Point(430, 500);
                    ballX = 0;
                    ballY = 0;
                    aimSet = false;
                    BallTimer.Stop();
                }
            }
        }

        private void CheckScore()
        {
            if (state == playerTarget)
            {
                miss++;
                lblMissed.Text = "Missed: " + miss;
            }
            else
            {
                goal++;
                lblScore.Text = "Scored: " + goal;
            }
        }

        private void ChangeGoalKeeperImage()
        {
            KeeperTimer.Start();
            int i = random.Next(0, KeeperPosition.Count);
            state = KeeperPosition[i];
            switch (i)
            {
                case 0:
                    goalKeeper.Image = Properties.Resources.left_save_small;
                    break;
                case 1:
                    goalKeeper.Image = Properties.Resources.right_save_small;
                    break;
                case 2:
                    goalKeeper.Image = Properties.Resources.top_save_small;
                    break;
                case 3:
                    goalKeeper.Image = Properties.Resources.top_left_save_small;
                    break;
                case 4:
                    goalKeeper.Image = Properties.Resources.top_right_save_small;
                    break;
            }
        }
    }
}
