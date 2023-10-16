using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Shooter
{
    public partial class NewGame : Form
    {
        bool moveLeft, moveRight, shooting, isGameOver;
        int score;
        int playerSpeed = 12;
        int enemySpeed;
        int bulletSpeed;
        Random rnd = new Random();
        public NewGame()
        {
            InitializeComponent();
            resetGame();
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = score.ToString();
            enemy1.Top += enemySpeed;
            enemy2.Top += enemySpeed;
            enemy3.Top += enemySpeed;
            if (enemy1.Top > 710 || enemy2.Top > 710 || enemy3.Top > 710)
            {
                gameOver();
            }

            // player movement logic starts

            if (moveLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (moveRight == true && player.Left < 688)
            {
                player.Left += playerSpeed;
            }

            // player movement logic ends
            if(shooting == true)
            {
                bulletSpeed = 20;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }

            if(bullet.Top <-30)
            {
                shooting = false;
            }

            if(bullet.Top < -30)
            {
                shooting = false;
            }

            if(bullet.Bounds.IntersectsWith(enemy1.Bounds))
            {
                score += 1;
                enemy1.Top = -450;
                enemy1.Left = rnd.Next(20, 600);
                shooting = false;
            }
            if(bullet.Bounds.IntersectsWith(enemy2.Bounds))
            {
                score += 1;
                enemy2.Top = -650;
                enemy2.Left = rnd.Next(20, 600);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemy3.Bounds))
            {
                score += 1;
                enemy3.Top = -750;
                enemy3.Left = rnd.Next(20, 600);
                shooting = false;
            }


            SpeedIncrement();
        }
        private void SpeedIncrement()
        {
            enemySpeed = 3;
            foreach (int value in Enumerable.Range(0, 10).Select(x => x * 5))
            {
                if (score >= value)
                {
                    enemySpeed = enemySpeed + 2;
                }
            }
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
        }

        private void enemy1_Click(object sender, EventArgs e)
        {

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

                bullet.Top = player.Top - 30;
                bullet.Left = player.Left + ((player.Width - 44) / 2);
            }
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                resetGame();
                isGameOver = false;
            }
            if (e.KeyCode == Keys.E && isGameOver == true)
            {
                Application.Exit();
            }
        }

        private void resetGame()
        {
            gameTimer.Start();
            enemySpeed = 6;
            enemy1.Left = rnd.Next(20, 600);
            enemy2.Left = rnd.Next(20, 600);
            enemy3.Left = rnd.Next(20, 600);
            enemy1.Top = rnd.Next(0, 200) * -1;
            enemy2.Top = rnd.Next(0, 500) * -1;
            enemy3.Top = rnd.Next(0, 900) * -1;
            score = 0;
            bulletSpeed = 0;
            bullet.Left = -300;
            shooting = false;
            txtScore.Text = score.ToString();
        }
        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            txtScore.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine + "GAME OVER" + Environment.NewLine + "Press R to play again" + Environment.NewLine + "Press E to exit game";
        }
    }
    }

