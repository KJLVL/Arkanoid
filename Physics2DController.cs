using System.Windows.Forms;

namespace Arkanoid
{
    class Physics2DController
    {
        //проверка нахождения шарика в пределах границ
        public bool isCollide(Player player, MapController map, Label scoreL, int m)
        {
            bool isColliding = false;
            //проверка на выхода за границу
            if (player.ballX + player.dirX > MapController.mapWidth - 1 || player.ballX + player.dirX < 0)
            {
                player.dirX *= -1;
                isColliding = true;
            }
            if (player.ballY + player.dirY < 0)
            {
                player.dirY *= -1;
                isColliding = true;
            }

            //если произошло касание препятствия сверху
            if (map.map[player.ballY + player.dirY, player.ballX] != 0)
            {
                bool addScore = false;
                isColliding = true;

                //шарик попал на правую часть препятствия => обнуляем препятствие (препятствие состоит из 2-х ячеек)
                if (map.map[player.ballY + player.dirY, player.ballX] > 10 && map.map[player.ballY + player.dirY, player.ballX] < 99)
                {
                    map.map[player.ballY + player.dirY, player.ballX] = 0;
                    map.map[player.ballY + player.dirY, player.ballX - 1] = 0;
                    addScore = true;
                }
                //шарик попал на левую часть
                else if (map.map[player.ballY + player.dirY, player.ballX] < 9)
                {
                    map.map[player.ballY + player.dirY, player.ballX] = 0;
                    map.map[player.ballY + player.dirY, player.ballX + 1] = 0;
                    addScore = true;
                }
                if (addScore)
                {
                    player.score += 10;
                    if (player.score % 90 == 0 && player.score > 0)
                        map.addLine();
                }
                player.dirY *= -1;
            }
            //если произошло касание препятствия сбоку
            if (map.map[player.ballY, player.ballX + player.dirX] != 0)
            {
                bool addScore = false;
                isColliding = true;

                if (map.map[player.ballY, player.ballX + player.dirX] > 10 && map.map[player.ballY + player.dirY, player.ballX] < 99)
                {
                    map.map[player.ballY, player.ballX + player.dirX] = 0;
                    map.map[player.ballY, player.ballX + player.dirX - 1] = 0;
                    addScore = true;
                }
                else if (map.map[player.ballY, player.ballX + player.dirX] < 9)
                {
                    map.map[player.ballY, player.ballX + player.dirX] = 0;
                    map.map[player.ballY, player.ballX + player.dirX + 1] = 0;
                    addScore = true;
                }
                if (addScore)
                {
                    player.score += 10;
                    if (player.score % 90 == 0 && player.score > 0)
                    {
                        map.addLine();
                    }
                }
                player.dirX *= -1;
            }

            scoreL.Text = "Счет: " + player.score;

            return isColliding;
        }
    }
}
