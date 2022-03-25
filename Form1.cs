using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class form1 : Form
    {
        private int i;
        private int mx;
        private int[] vals = new int[] { -1, 1 };
        private Random r = new Random();
        private MapController map;
        private Player player = new Player();
        private Physics2DController physics;
        private AddComp ac = new AddComp();

        public form1(int ind, int m)
        {
            i = ind;
            mx = m;

            InitializeComponent();

            ac.maxL.Text = "Рекорд: " + mx;
            Controls.Add(ac.scoreL);
            Controls.Add(ac.livesL);
            Controls.Add(ac.maxL);

            timer1.Tick += new EventHandler(update);
            KeyUp += new KeyEventHandler(inputCheck);

            player.dirX = vals[r.Next(vals.Length)];
            player.dirY = -1;

            init(mx);
        }
        private void init(int m)
        {
            map = new MapController();
            physics = new Physics2DController();

            Width = (MapController.mapWidth + 5) * 20;
            Height = (MapController.mapHeight + 2) * 20;

            if (i == 1)
            {
                ac.maxL.Text = "Рекорд: " + m;
                timer1.Interval = 65;
            }
            else if (i== 2)
            {
                ac.maxL.Text = "Рекорд: " + m;
                timer1.Interval = 55;
            }
            else if (i == 3)
            {
                ac.maxL.Text = "Рекорд: " + m;
                timer1.Interval = 40;
            }

            player.score = 0;
            player.lives = 3;
            ac.scoreL.Text = "Счет: " + player.score;
            ac.livesL.Text = "Жизни: " + player.lives;

            player.platformX = (MapController.mapWidth) / 2 - 4;
            player.platformY = MapController.mapHeight - 1;

            //добавление информации об платформе (состоит из 4-х ячеек) для последующего вывода
            map.map[player.platformY, player.platformX] = 9;
            map.map[player.platformY, player.platformX + 1] = 99;
            map.map[player.platformY, player.platformX + 2] = 99;
            map.map[player.platformY, player.platformX + 3] = 99;

            //начальное расположение шарика
            player.ballX = (MapController.mapWidth) / 2 - 2;
            player.ballY = MapController.mapHeight - 2;

            //добавление информации о шарике для последующего вывода
            map.map[player.ballY, player.ballX] = 8;

            GeneratePlatforms();

            timer1.Start();
        }

        //генерация препятствий
        private void GeneratePlatforms()
        {
            Random r = new Random();
            for (int i = 1; i < MapController.mapHeight / 3; i++)
            {
                for (int j = 1; j < MapController.mapWidth - 1; j += 2)
                {
                    int curPlatform = r.Next(1, 5);
                    map.map[i, j] = curPlatform;
                    //распознование частей препятствия
                    map.map[i, j + 1] = curPlatform + curPlatform * 10;
                }
            }
        }

        //продолжение игры, если жизни не потрачены
        private void contin()
        {
            ac.scoreL.Text = "Счет: " + player.score;
            ac.livesL.Text = "Жизни: " + player.lives;
            ac.maxL.Text = "Рекорд: " + mx;
            
            //добавление информации об платформе (состоит из 4-х ячеек) для последующего вывода
            map.map[player.platformY, player.platformX] = 9;
            map.map[player.platformY, player.platformX + 1] = 99;
            map.map[player.platformY, player.platformX + 2] = 99;
            map.map[player.platformY, player.platformX + 3] = 99;
            map.map[player.ballY, player.ballX] = 0;

            //начальное расположение шарика
            player.ballX = (MapController.mapWidth) / 2 - 2;
            player.ballY = MapController.mapHeight - 2;

            //добавление информации о шарике для последующего вывода
            map.map[player.ballY, player.ballX] = 8;

            player.dirX = vals[r.Next(vals.Length)];
            player.dirY = -1;

            timer1.Start();
        }

        //обновление жизней
        private void update(object sender, EventArgs e)
        {            
            if (player.ballY + player.dirY > MapController.mapHeight - 1)
            {
                player.lives--;
                if (player.lives == 0)
                {
                    Hide();
                    Mess m;
                    if (i == 1)
                    {
                        if (player.score > mx)
                            mx = player.score;
                        m = new Mess(i, mx);
                        m.Show();
                    }
                    else if (i == 2)
                    {
                        if (player.score > mx)
                            mx = player.score;
                        m = new Mess(i, mx);
                        m.Show();
                    }
                    else if (i == 3)
                    {
                        if (player.score > mx)
                            mx = player.score;
                        m = new Mess(i, mx);
                        m.Show();
                    }
                    player.dirX = vals[r.Next(vals.Length)];
                    player.dirY = -1;
                }
                else
                    contin();
            }

            map.map[player.ballY, player.ballX] = 0;
            if (!physics.isCollide(player, map, ac.scoreL, player.score))
                player.ballX += player.dirX;
            if (!physics.isCollide(player, map, ac.scoreL, player.score))
                player.ballY += player.dirY;
            map.map[player.ballY, player.ballX] = 8;

            map.map[player.platformY, player.platformX] = 9;
            map.map[player.platformY, player.platformX + 1] = 99;
            map.map[player.platformY, player.platformX + 2] = 99;
            map.map[player.platformY, player.platformX + 3] = 99;

            //перерисовка
            Invalidate();
        }

        //движение платформы
        private void inputCheck(object sender, KeyEventArgs e)
        {
            map.map[player.platformY, player.platformX] = 0;
            map.map[player.platformY, player.platformX + 1] = 0;
            map.map[player.platformY, player.platformX + 2] = 0;
            map.map[player.platformY, player.platformX + 3] = 0;

            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (player.platformX < MapController.mapWidth - 6)
                        player.platformX += 3;
                    break;
                case Keys.Left:
                    if (player.platformX > 0)
                        player.platformX -= 3;
                    break;
            }

            map.map[player.platformY, player.platformX] = 9;
            map.map[player.platformY, player.platformX + 1] = 99;
            map.map[player.platformY, player.platformX + 2] = 99;
            map.map[player.platformY, player.platformX + 3] = 99;
        }

        private void onPaint(object sender, PaintEventArgs e)
        {
            map.drawArea(e.Graphics);
            map.drawMap(e.Graphics);
        }

    }
}
