using System;
using System.Drawing;

namespace Arkanoid
{
    class MapController
    {
        public const int mapWidth = 20;
        public const int mapHeight = 30;
        public int[,] map = new int[mapHeight, mapWidth];

        private Image arcanoidSet, arcanoidSet1, bg;

        public MapController()
        {
            arcanoidSet = new Bitmap("D:\\university\\3\\1sem\\OOP\\kurs\\Arkanoid\\arc1.png");
            arcanoidSet1 = new Bitmap("D:\\university\\3\\1sem\\OOP\\kurs\\Arkanoid\\arc.png");
            bg = new Bitmap("D:\\university\\3\\1sem\\OOP\\kurs\\Arkanoid\\space.png");
        }

        //отрисовка границ
        public void drawArea(Graphics g)
        {
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, mapWidth * 20, mapHeight * 20));
            g.DrawImageUnscaledAndClipped(bg, new Rectangle(0, 0, mapWidth * 20, mapHeight * 20));
        }

        //отрисовка объектов
        public void drawMap(Graphics g)
        {
            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    if (map[i, j] == 9)
                        g.DrawImage(arcanoidSet, new Rectangle(new Point(j * 20, i * 20), new Size(100, 20)), 115, 72, 65, 20, GraphicsUnit.Pixel);
                    if (map[i, j] == 8)
                        g.DrawImage(arcanoidSet1, new Rectangle(new Point(j * 20, i * 20), new Size(20, 20)), 806, 548, 73, 73, GraphicsUnit.Pixel);
                    if (map[i, j] == 1)
                        g.DrawImage(arcanoidSet1, new Rectangle(new Point(j * 20, i * 20), new Size(40, 20)), 20, 93, 170, 58, GraphicsUnit.Pixel);
                    if (map[i, j] == 2)
                        g.DrawImage(arcanoidSet1, new Rectangle(new Point(j * 20, i * 20), new Size(40, 20)), 20, 244, 169, 55, GraphicsUnit.Pixel);
                    if (map[i, j] == 3)
                        g.DrawImage(arcanoidSet1, new Rectangle(new Point(j * 20, i * 20), new Size(40, 20)), 20, 319, 169, 55, GraphicsUnit.Pixel);
                    if (map[i, j] == 4)
                        g.DrawImage(arcanoidSet1, new Rectangle(new Point(j * 20, i * 20), new Size(40, 20)), 20, 394, 169, 55, GraphicsUnit.Pixel);
                }
            }
        }

        //добавление линии вниз
        public void addLine()
        {
            for (int i = mapHeight - 2; i > 4; i--)
            {
                for (int j = 1; j < mapWidth - 1; j += 2)
                {
                    map[i, j] = map[i - 1, j];
                }
            }
            Random r = new Random();
            for (int j = 1; j < mapWidth - 1; j += 2)
            {
                int currPlatform = r.Next(1, 5);
                map[1, j] = currPlatform;
                map[1, j + 1] = currPlatform + currPlatform * 10;
            }
        }

    }
}
