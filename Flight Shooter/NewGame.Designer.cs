
namespace Flight_Shooter
{
    partial class NewGame
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
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("SPACE MISSION", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.Gold;
            this.txtScore.Location = new System.Drawing.Point(13, 323);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(1064, 185);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.MediumBlue;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player.Image = global::Flight_Shooter.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(484, 725);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 92);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.Transparent;
            this.bullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bullet.Image = global::Flight_Shooter.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(313, 389);
            this.bullet.Margin = new System.Windows.Forms.Padding(4);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(58, 62);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 0;
            this.bullet.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            this.enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemy3.Image = global::Flight_Shooter.Properties.Resources.enemy;
            this.enemy3.Location = new System.Drawing.Point(914, 76);
            this.enemy3.Margin = new System.Windows.Forms.Padding(4);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(100, 92);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 0;
            this.enemy3.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemy2.Image = global::Flight_Shooter.Properties.Resources.enemy;
            this.enemy2.Location = new System.Drawing.Point(484, 76);
            this.enemy2.Margin = new System.Windows.Forms.Padding(4);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(100, 92);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 0;
            this.enemy2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemy1.Image = global::Flight_Shooter.Properties.Resources.enemy;
            this.enemy1.Location = new System.Drawing.Point(35, 76);
            this.enemy1.Margin = new System.Windows.Forms.Padding(4);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(100, 92);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 0;
            this.enemy1.TabStop = false;
            this.enemy1.Click += new System.EventHandler(this.enemy1_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(1067, 830);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.txtScore);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Shooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

