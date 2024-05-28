namespace Shootout_Penalty_Football_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblScore = new Label();
            lblMissed = new Label();
            left = new PictureBox();
            topLeft = new PictureBox();
            topRight = new PictureBox();
            right = new PictureBox();
            top = new PictureBox();
            goalKeeper = new PictureBox();
            football = new PictureBox();
            KeeperTimer = new System.Windows.Forms.Timer(components);
            BallTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)right).BeginInit();
            ((System.ComponentModel.ISupportInitialize)top).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goalKeeper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)football).BeginInit();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.ForeColor = SystemColors.ButtonHighlight;
            lblScore.Location = new Point(12, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(128, 35);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score:0";
            // 
            // lblMissed
            // 
            lblMissed.AutoSize = true;
            lblMissed.BackColor = Color.Transparent;
            lblMissed.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMissed.ForeColor = SystemColors.ButtonHighlight;
            lblMissed.Location = new Point(757, 9);
            lblMissed.Name = "lblMissed";
            lblMissed.Size = new Size(141, 35);
            lblMissed.TabIndex = 0;
            lblMissed.Text = "Missed:0";
            // 
            // left
            // 
            left.BackColor = Color.OrangeRed;
            left.BackgroundImage = Properties.Resources.Target_icon;
            left.Image = Properties.Resources.Target_icon;
            left.Location = new Point(195, 237);
            left.Name = "left";
            left.Size = new Size(40, 40);
            left.SizeMode = PictureBoxSizeMode.StretchImage;
            left.TabIndex = 1;
            left.TabStop = false;
            left.Tag = "left";
            left.Click += SetGoalTargetEvent;
            // 
            // topLeft
            // 
            topLeft.BackColor = Color.OrangeRed;
            topLeft.BackgroundImage = Properties.Resources.Target_icon;
            topLeft.Image = Properties.Resources.Target_icon;
            topLeft.Location = new Point(195, 73);
            topLeft.Name = "topLeft";
            topLeft.Size = new Size(40, 40);
            topLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            topLeft.TabIndex = 1;
            topLeft.TabStop = false;
            topLeft.Tag = "topLeft";
            topLeft.Click += SetGoalTargetEvent;
            // 
            // topRight
            // 
            topRight.BackColor = Color.OrangeRed;
            topRight.BackgroundImage = Properties.Resources.Target_icon;
            topRight.Image = Properties.Resources.Target_icon;
            topRight.Location = new Point(677, 73);
            topRight.Name = "topRight";
            topRight.Size = new Size(40, 40);
            topRight.SizeMode = PictureBoxSizeMode.StretchImage;
            topRight.TabIndex = 1;
            topRight.TabStop = false;
            topRight.Tag = "topRight";
            topRight.Click += SetGoalTargetEvent;
            // 
            // right
            // 
            right.BackColor = Color.OrangeRed;
            right.BackgroundImage = Properties.Resources.Target_icon;
            right.Image = Properties.Resources.Target_icon;
            right.Location = new Point(677, 237);
            right.Name = "right";
            right.Size = new Size(40, 40);
            right.SizeMode = PictureBoxSizeMode.StretchImage;
            right.TabIndex = 1;
            right.TabStop = false;
            right.Tag = "right";
            right.Click += SetGoalTargetEvent;
            // 
            // top
            // 
            top.BackColor = Color.OrangeRed;
            top.BackgroundImage = Properties.Resources.Target_icon;
            top.Image = Properties.Resources.Target_icon;
            top.Location = new Point(436, 73);
            top.Name = "top";
            top.Size = new Size(40, 40);
            top.SizeMode = PictureBoxSizeMode.StretchImage;
            top.TabIndex = 1;
            top.TabStop = false;
            top.Tag = "top";
            top.Click += SetGoalTargetEvent;
            // 
            // goalKeeper
            // 
            goalKeeper.BackColor = Color.Transparent;
            goalKeeper.Image = Properties.Resources.stand_small;
            goalKeeper.Location = new Point(417, 151);
            goalKeeper.Name = "goalKeeper";
            goalKeeper.Size = new Size(82, 126);
            goalKeeper.SizeMode = PictureBoxSizeMode.AutoSize;
            goalKeeper.TabIndex = 2;
            goalKeeper.TabStop = false;
            // 
            // football
            // 
            football.BackColor = Color.Transparent;
            football.Image = Properties.Resources.football;
            football.Location = new Point(436, 497);
            football.Name = "football";
            football.Size = new Size(50, 51);
            football.SizeMode = PictureBoxSizeMode.AutoSize;
            football.TabIndex = 3;
            football.TabStop = false;
            // 
            // KeeperTimer
            // 
            KeeperTimer.Interval = 20;
            KeeperTimer.Tick += KeeperTimerEvent;
            // 
            // BallTimer
            // 
            BallTimer.Interval = 20;
            BallTimer.Tick += BallTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(897, 670);
            Controls.Add(football);
            Controls.Add(goalKeeper);
            Controls.Add(right);
            Controls.Add(top);
            Controls.Add(topRight);
            Controls.Add(topLeft);
            Controls.Add(left);
            Controls.Add(lblMissed);
            Controls.Add(lblScore);
            Name = "Form1";
            Text = "Shootout Penalty Footbl Game";
            ((System.ComponentModel.ISupportInitialize)left).EndInit();
            ((System.ComponentModel.ISupportInitialize)topLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)topRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)right).EndInit();
            ((System.ComponentModel.ISupportInitialize)top).EndInit();
            ((System.ComponentModel.ISupportInitialize)goalKeeper).EndInit();
            ((System.ComponentModel.ISupportInitialize)football).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private Label lblMissed;
        private PictureBox left;
        private PictureBox topLeft;
        private PictureBox topRight;
        private PictureBox right;
        private PictureBox top;
        private PictureBox goalKeeper;
        private PictureBox football;
        private System.Windows.Forms.Timer KeeperTimer;
        private System.Windows.Forms.Timer BallTimer;
    }
}
