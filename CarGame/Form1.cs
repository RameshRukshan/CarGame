using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class CarGame : Form
    {
        public CarGame()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveRoad(gameSpeed);
            enemyFowerd(1+gameSpeed);
            playerOut();
        }

        Random rand = new Random();
        int x;

        void playerOut()
        {
            gameOvercs go = new gameOvercs();
            if (player.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                timer1.Enabled = false;
                go.ShowDialog();
            }
            else if (player.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                timer1.Enabled = false;
                go.ShowDialog();
            }
            else if (player.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                timer1.Enabled = false;
                go.ShowDialog();
            }
        }

        void enemyFowerd(int speed)
        {
            if (enemyOne.Top >= 700)
            {
                x = rand.Next(0, 250);
                enemyOne.Location = new Point(x,0);
            }
            else
            {
                enemyOne.Top += speed;
            }

            if (enemyTwo.Top >= 700)
            {
                if(rand.Next(0,5) == 2)
                {
                    x = rand.Next(250, 400);
                    enemyTwo.Location = new Point(x, 0);
                }
            }
            else
            {
                enemyTwo.Top += speed;
            }

            if (enemyThree.Top >= 700)
            {
                x = rand.Next(400, 600);
                enemyThree.Location = new Point(x, 0);
            }
            else
            {
                enemyThree.Top += speed;
            }
        }

        public void moveRoad(int speed)
        {
            if (pictureBox1.Top >= 700)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 700)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 700)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 700)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            if (pictureBox5.Top >= 700)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }

            if (pictureBox6.Top >= 700)
            {
                pictureBox6.Top = 0;
            }
            else
            {
                pictureBox6.Top += speed;
            }

            if (pictureBox7.Top >= 700)
            {
                pictureBox7.Top = 0;
            }
            else
            {
                pictureBox7.Top += speed;
            }
            if (pictureBox8.Top >= 700)
            {
                pictureBox8.Top = 0;
            }
            else
            {
                pictureBox8.Top += speed;
            }
            if (pictureBox9.Top >= 700)
            {
                pictureBox9.Top = 0;
            }
            else
            {
                pictureBox9.Top += speed;
            }

            //-------------------------------------

            if (pictureBox10.Top >= 700)
            {
                pictureBox10.Top = 0;
            }
            else
            {
                pictureBox10.Top += speed;
            }

            if (pictureBox11.Top >= 700)
            {
                pictureBox11.Top = 0;
            }
            else
            {
                pictureBox11.Top += speed;
            }

            if (pictureBox12.Top >= 700)
            {
                pictureBox12.Top = 0;
            }
            else
            {
                pictureBox12.Top += speed;
            }

            if (pictureBox13.Top >= 700)
            {
                pictureBox13.Top = 0;
            }
            else
            {
                pictureBox13.Top += speed;
            }

            if (pictureBox14.Top >= 700)
            {
                pictureBox14.Top = 0;
            }
            else
            {
                pictureBox14.Top += speed;
            }

            if (pictureBox15.Top >= 700)
            {
                pictureBox15.Top = 0;
            }
            else
            {
                pictureBox15.Top += speed;
            }

            if (pictureBox16.Top >= 700)
            {
                pictureBox16.Top = 0;
            }
            else
            {
                pictureBox16.Top += speed;
            }
            if (pictureBox17.Top >= 700)
            {
                pictureBox17.Top = 0;
            }
            else
            {
                pictureBox17.Top += speed;
            }
            if (pictureBox18.Top >= 700)
            {
                pictureBox18.Top = 0;
            }
            else
            {
                pictureBox18.Top += speed;
            }
        }

        private void player_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        int gameSpeed = 3;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(player.Left > 0)
                {
                    player.Left += -10;
                }
            }

            if(e.KeyCode == Keys.Right)
            {
                if (player.Left < 625)
                {
                    player.Left += 10;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if(gameSpeed <= 20)
                {
                    gameSpeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if(gameSpeed > 0)
                {
                    gameSpeed--;
                }
            }
        }
    }
}
