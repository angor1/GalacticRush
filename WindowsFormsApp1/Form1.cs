using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rnd;
        int playerSpeed;
        PictureBox[] bullets;
        int bulletsSpeed;
        PictureBox[] enemies;
        int sizeEnemy;
        int enemiesSpeed;

        int Score;
        int Level;



        public Form1()
        {
            InitializeComponent();
        }

        private void LeftMoveT_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.Left > 10)
            {
                mainPlayer.Left -= playerSpeed;

            }
        }

        private void RightMoveT_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.Left < 1150)
            {
                mainPlayer.Left += playerSpeed;

            }
        }

        private void UpMoveT_Tick(object sender, EventArgs e)
        {
            mainPlayer.Top -= playerSpeed;
        }

        private void DownMoveT_Tick(object sender, EventArgs e)
        {
            mainPlayer.Top += playerSpeed;
        }

        //ходьба
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                LeftMoveT.Start();
            }

            if (e.KeyCode == Keys.Right)
            {
                RightMoveT.Start();
            }

            if (e.KeyCode == Keys.Up)
            {
                UpMoveT.Start();
            }

            if (e.KeyCode == Keys.Down)
            {
                DownMoveT.Start();
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            LeftMoveT.Stop();
            RightMoveT.Stop();
            UpMoveT.Stop();
            DownMoveT.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        //движение пули
        private void MoveBulletT_Tick(object sender, EventArgs e)
        {
            for ( int i = 0; i < bullets.Length; i++ )
            {
                bullets[i].Left += bulletsSpeed;
            } 
        }
        
        //клавиша выстрела
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < bullets.Length; i++)
                {
                    Intersect();
                    if (bullets[i].Left > 1280)
                    {
                        bullets[i].Location = new Point(mainPlayer.Location.X + 100 + i * 50, mainPlayer.Location.Y + 25);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Score = 0;
            Level = 1;


            rnd = new Random();
            playerSpeed = 6;

            //кол-во одновременно появл. мобов
            enemies = new PictureBox[5];
            //размер мобов
            int sizeEnemy = rnd.Next(80, 100);
            enemiesSpeed = 4;

            Image easyEnemies = Image.FromFile("Assets\\protivnik.png");

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(sizeEnemy, sizeEnemy);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BackColor = Color.Transparent;
                enemies[i].Image = easyEnemies;
                //локация повяления врагов
                enemies[i].Location = new Point((i + 1) * rnd.Next(150, 250) + 1080, rnd.Next(100, 300));

                this.Controls.Add(enemies[i]); 
            }





            bullets = new PictureBox[1];
            //скорость пули
            bulletsSpeed = 50;
            //рмер,цвет пули
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new PictureBox();
                bullets[i].BorderStyle = BorderStyle.None;
                bullets[i].Size = new Size(30, 7);
                bullets[i].BackColor = Color.Red;

                this.Controls.Add(bullets[i]);  

            }
        }
        private void timer1_Tick_2(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemiesSpeed);
        }

        //искривление, не линейность появления противников
        private void MoveEnemies(PictureBox[] enemies, int speed)
        {
            for ( int i = 0; i < enemies.Length; i++ )
            {
                enemies[i].Left -= speed + (int)(Math.Sin(enemies[i].Left * Math.PI / 180) + Math.Cos(enemies[i].Left * Math.PI / 180));

                Intersect();
            }

        }

        private void Intersect()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (bullets[0].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    Score += 1;
                    labelScore.Text = ((Score < 10) ? "0" + Score.ToString() : Score.ToString());

                    if (Score % 10 == 0)
                    {
                        Level += 1;
                        labelLevel.Text = (Level < 10) ? "0" + Level.ToString() : Level.ToString();

                        if (enemiesSpeed <= 9)
                        {
                            enemiesSpeed++;
                        }

                        if (Level == 9)
                        {
                            GameOver("You win");
                        }
                    }

                    enemies[i].Location = new Point((i+1) * rnd.Next(150, 250) + 1280, rnd.Next(100, 300));
                    bullets[0].Location = new Point (2000, mainPlayer.Location.Y + 50);
                }

                if (mainPlayer.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    mainPlayer.Visible = false;
              
                    GameOver("Game Over");
                }

                if (mainPlayer2.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    mainPlayer2.Visible = false;
                    GameOver("Game Over");
                }
            }
        }

        private void GameOver(string str)
        {
            label1.Text = str;
            label1.Location = new Point(245, 200);
            label1.Visible = true;

            label4.Location = new Point(25, 20);
            label4.Visible = true;
            enemiesSpeed = 0;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Menu hawkeye = new Menu();
                this.Hide();
                Close();
                hawkeye.ShowDialog();
                bool create = false;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из игры", "Выход", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.No)
            {
                Menu form = new Menu();
                form.Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
