using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_v0._0
{
    class Character
    {
        public enum Direction { N, E, S, W };
        bool ghost = true;
        public int x;
        public int y;
        public uint order;
        public int cX;
        public int cY;
        // фото в диалогах
        public object photo = Properties.Resources.ResourceManager.GetObject("anon");

        public Character()
        {
        }

        public Character(string photo)
        {
            this.photo = Properties.Resources.ResourceManager.GetObject(photo);
        }

        public Character(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Character(int x, int y, bool ghost)
        {
            this.x = x;
            this.y = y;
            this.cX = x * Settings.gridSize + Settings.gridSize / 2 + Settings.gridSize % 2;
            this.cY = y * Settings.gridSize + Settings.gridSize / 2 + Settings.gridSize % 2;

            this.ghost = ghost;
        }

        public Character(int x, int y, bool ghost, string photo)
        {
            this.x = x;
            this.y = y;
            this.cX = x * Settings.gridSize + Settings.gridSize / 2 + Settings.gridSize % 2;
            this.cY = y * Settings.gridSize + Settings.gridSize / 2 + Settings.gridSize % 2;
            this.photo = Properties.Resources.ResourceManager.GetObject(photo);
            this.ghost = ghost;
        }

        //передвинуть персонажа на x пикселей вправо и на y вниз
        public void move(int x, int y, ref Bitmap bmp, ref Bitmap visibleZone, ref Bitmap rezMap)
        {
            x += this.cX;
            y += this.cY;
            drawCharacter(x, y, ref bmp, ref rezMap);
            drawVisibleZone(x, y, ref bmp, ref visibleZone);
            this.cX = x;
            this.cY = y;
            this.x = x / Settings.gridSize;
            this.y = y / Settings.gridSize;
        }
        // рисует ноги персонажа :)
        public void drawLegs(ref Bitmap visZone, Direction dir)
        {
            switch (dir)
            {
                case Direction.N:
                case Direction.S:
                    if (order % 3 == 0)
                    {
                        for (int i = cX + Settings.characterSize % 2; i <= cX + Settings.characterSize / 2; i++)
                        {
                            for (int j = cY - Settings.characterSize; j <= cY - Settings.characterSize / 2; j++)
                            {
                                visZone.SetPixel(i, j, Color.Green);
                            }
                        }
                        for (int i = cX - Settings.characterSize % 2; i >= cX - Settings.characterSize / 2; i--)
                        {
                            for (int j = cY + Settings.characterSize; j >= cY + Settings.characterSize / 2; j--)
                            {
                                visZone.SetPixel(i, j, Color.Green);
                            }
                        }
                    }
                    else if (order % 3 == 1)
                    {
                        for (int i = cX + Settings.characterSize % 2; i <= cX + Settings.characterSize / 2; i++)
                        {
                            for (int j = cY + Settings.characterSize; j >= cY + Settings.characterSize / 2; j--)
                            {
                                visZone.SetPixel(i, j, Color.Green);
                            }
                        }
                        for (int i = cX - Settings.characterSize % 2; i >= cX - Settings.characterSize / 2; i--)
                        {
                            for (int j = cY - Settings.characterSize; j <= cY - Settings.characterSize / 2; j++)
                            {
                                visZone.SetPixel(i, j, Color.Green);
                            }
                        }

                    }
                    break;
                case Direction.W:
                case Direction.E:
                    if (order % 3 == 0)
                    {
                        for (int i = cX - Settings.characterSize; i <= cX - Settings.characterSize / 2; i++)
                        {
                            for (int j = cY + Settings.characterSize % 2; j <= cY + Settings.characterSize / 2; j++)
                            {
                                visZone.SetPixel(i, j, Color.Green);
                            }
                        }
                        for (int i = cX + Settings.characterSize; i >= cX + Settings.characterSize / 2; i--)
                        {
                            for (int j = cY - Settings.characterSize % 2; j >= cY - Settings.characterSize / 2; j--)
                            {
                                visZone.SetPixel(i, j, Color.Green);
                            }
                        }
                    }
                    else if (order % 3 == 1)
                    {
                        for (int i = cX - Settings.characterSize; i <= cX - Settings.characterSize / 2; i++)
                        {
                            for (int j = cY - Settings.characterSize % 2; j >= cY - Settings.characterSize / 2; j--)
                            {
                                visZone.SetPixel(i, j, Color.Green);
                            }
                        }
                        for (int i = cX + Settings.characterSize; i >= cX + Settings.characterSize / 2; i--)
                        {
                            for (int j = cY + Settings.characterSize % 2; j <= cY + Settings.characterSize / 2; j++)
                            {
                                visZone.SetPixel(i, j, Color.Green);
                            }
                        }
                    }
                    break;
            }
        }
        // рисyет зону, видимою персонажем
        /*public void drawVisibleZone(int x, int y, ref Bitmap bmp, ref Bitmap visZone)
        {
            int visiblePx = Settings.visibleZone * Settings.gridSize;

            for (int i = this.cX - visiblePx - 1; i < this.cX + visiblePx + Settings.characterSize; i++)
            {
                for (int j = this.cY - visiblePx - 1; j < this.cY + visiblePx + 1; j++)
                {
                    if (i >= 0 && j >= 0 && i < visZone.Width && j < visZone.Height)
                    {
                        visZone.SetPixel(i, j, Color.Black);
                    }
                }
            }
            int alpha = 10;
            for (int i = x - visiblePx; i < x + Settings.characterSize + visiblePx; i++)
            {
                for (int j = y - visiblePx; j < y + visiblePx; j++)
                {
                    if ((i - cX) * (i - cX) + (j - cY) * (j - cY) <= (visiblePx + Settings.gridSize / 2) * (visiblePx + Settings.gridSize / 2) && i >= 0 && j >= 0 && i < visZone.Width && j < visZone.Height)
                    {
                        //попытка сделать края зоны менее резкими
                        alpha = 255 - 9 * (int)Math.Sqrt((i - x) * (i - x) + (j - y) * (j - y));

                        if (alpha < 0)
                        {
                            alpha = 0;
                        }
                        else if (alpha > 255)
                        {
                            alpha = 255;
                        }
                        visZone.SetPixel(i, j, Color.FromArgb(alpha, bmp.GetPixel(i, j)));
                    }
                }
            }
        }
        public void drawVisibleZone(ref Bitmap bmp, ref Bitmap visZone)
        {
            int visiblePx = Settings.visibleZone * Settings.gridSize;
            int alpha = 10;
            for (int i = this.cX - visiblePx; i < this.cX + visiblePx; i++)
            {
                for (int j = this.cY - visiblePx; j < this.cY + visiblePx; j++)
                {
                    if ((i - cX) * (i - cX) + (j - cY) * (j - cY) <= (visiblePx + Settings.gridSize / 2) * (visiblePx + Settings.gridSize / 2) && i >= 0 && j >= 0 && i < visZone.Width && j < visZone.Height)
                    {
                        alpha = 255 - 9 * (int)Math.Sqrt((i - cX) * (i - cX) + (j - cY) * (j - cY));
                        if (alpha < 0)
                        {
                            alpha = 0;
                        }
                        else if (alpha > 255)
                        {
                            alpha = 255;
                        }
                        visZone.SetPixel(i, j, Color.FromArgb(alpha, bmp.GetPixel(i, j)));
                    }
                }
            }
        }
        */
        // рисует самого персонажа в виде квадратика. 
        public void drawCharacter(ref Bitmap bmp)
        {
            for (int i = this.cX - Settings.characterSize / 2; i < this.cX + Settings.characterSize / 2; i++)
            {
                for (int j = this.cY - Settings.characterSize / 2; j < this.cY + Settings.characterSize / 2; j++)
                {
                    bmp.SetPixel(i, j, Color.Green);
                }
            }
        }
        public void drawCharacter(int x, int y, ref Bitmap bmp, ref Bitmap rezMap)
        {
            for (int i = this.cX - Settings.characterSize / 2; i < this.cX + Settings.characterSize / 2; i++)
            {
                for (int j = this.cY - Settings.characterSize / 2; j < this.cY + Settings.characterSize / 2; j++)
                {
                    bmp.SetPixel(i, j, rezMap.GetPixel(i, j));
                }
            }
            for (int i = x - Settings.characterSize / 2; i < x + Settings.characterSize / 2; i++)
            {
                for (int j = y - Settings.characterSize / 2; j < y + Settings.characterSize / 2; j++)
                {
                    bmp.SetPixel(i, j, Color.Green);
                }
            }
        }
    }
}
