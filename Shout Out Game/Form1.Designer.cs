namespace Shout_Out_Game
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
            txtAmmo = new Label();
            txtScore = new Label();
            label3 = new Label();
            healthBar = new ProgressBar();
            player = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // txtAmmo
            // 
            txtAmmo.AutoSize = true;
            txtAmmo.Font = new Font("Snap ITC", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAmmo.ForeColor = SystemColors.ButtonFace;
            txtAmmo.Location = new Point(28, 24);
            txtAmmo.Name = "txtAmmo";
            txtAmmo.Size = new Size(126, 29);
            txtAmmo.TabIndex = 0;
            txtAmmo.Text = "Ammo: 0";
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Snap ITC", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.ForeColor = SystemColors.ButtonFace;
            txtScore.Location = new Point(369, 24);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(118, 29);
            txtScore.TabIndex = 1;
            txtScore.Text = "Kills: 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(642, 24);
            label3.Name = "label3";
            label3.Size = new Size(132, 31);
            label3.TabIndex = 2;
            label3.Text = "Health: ";
            // 
            // healthBar
            // 
            healthBar.BackColor = Color.White;
            healthBar.ForeColor = Color.Green;
            healthBar.Location = new Point(769, 30);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(143, 23);
            healthBar.TabIndex = 3;
            healthBar.Click += healthBar_Click;
            // 
            // player
            // 
            player.Image = Properties.Resources.up;
            player.Location = new Point(369, 493);
            player.Name = "player";
            player.Size = new Size(71, 100);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 4;
            player.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += MainTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(924, 661);
            Controls.Add(player);
            Controls.Add(healthBar);
            Controls.Add(label3);
            Controls.Add(txtScore);
            Controls.Add(txtAmmo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtAmmo;
        private Label txtScore;
        private Label label3;
        private ProgressBar healthBar;
        private PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
    }
}