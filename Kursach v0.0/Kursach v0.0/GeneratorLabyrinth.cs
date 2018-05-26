using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_v0._0
{
    public class GenerateLabyrinth
    {
        public int mashtab; // масштаб
        public bool[,] horisontalWalls; // матрица для горизонтальных стен
        public bool[,] verticalWalls; // матрица для вертикальных стен
        public static int[,] cells; // матрица для множеств
        /// <summary>
        /// Установить переданный масштаб
        /// </summary>
        /// <param name="mashtab"></param>
        public GenerateLabyrinth(int mashtab)
        {
            this.mashtab = mashtab;
        } 
        /// <summary>
        /// Метод генерации лабиринта
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void generateLabirynth(int width, int height)
        {
            horisontalWalls = new bool[width, height];
            verticalWalls = new bool[width, height];
            cells = new int[width, height];
            System.Random rnd = new System.Random();
            //заполнение первой строки 12345...
            for (int i = 0; i < width; i++)
                cells[i, 0] = i + 1;

            //основной цикл
            for (int y = 0; y < height; y++)
            {
                //перенос предидущей строки на текущую за исключением тех ячеек где есть горизотальная стена
                carryLine(width, y);
                //заполнение оставшихся пустых ячеек
                fillingEmpty(width, y);
                //обьявление вертикальных стен
                for (int x = 0; x < width - 1; x++)
                {
                    //если ячейка и ячека справа равны то раздеяем их
                    if (cells[x, y] == cells[x + 1, y])
                        verticalWalls[x, y] = true;
                    else
                    {
                        int r = rnd.Next(0, 2);
                        if (r != 1)
                            //Если не создаем стену то обьеденяем множества
                            cells[x + 1, y] = cells[x, y];
                        else
                            verticalWalls[x, y] = true;
                    }
                }

                //удаление ненужных горизонтальных стен
                deleteGorisontal(width, y);
            }

            //обработка завершающей строки
            for (int x = 0; x < width - 1; x++)
                if (cells[x, height - 1] != cells[x + 1, height - 1])
                    verticalWalls[x, height - 1] = false;
        }
        /// <summary>
        /// Заполнить пустые ячейки новыми множествами
        /// </summary>
        /// <param name="width"></param>
        /// <param name="y"></param>
        public void fillingEmpty(int width, int y)
        {
            List<int> temp = new List<int>();
            for (int x = 0; x < width && y > 0; x++)
            {
                temp.Clear();
                if (cells[x, y] == -1)
                {
                    //заполняем массив существующими числами ячеек из всей строки
                    for (int k = 0; k < width; k++)
                        temp.Add(cells[k, y]);
                    for (int k = 0; k < width; k++)
                    {
                        //если в массиве нет числа равного i + 1 то добавляем ячейке такoе число
                        if (!temp.Contains(k + 1))
                        {
                            cells[x, y] = k + 1;
                            break;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Переос множества из предыдущей строки на текущую
        /// </summary>
        /// <param name="width"></param>
        /// <param name="y"></param>
        public void carryLine(int width, int y)
        {
            for (int x = 0; x < width && y > 0; x++)
                if (!horisontalWalls[x, y - 1])
                    cells[x, y] = cells[x, y - 1];
                else
                    cells[x, y] = -1;
        }
        /// <summary>
        /// Удаление ненужных горизонтальых стен
        /// </summary>
        /// <param name="width"></param>
        /// <param name="y"></param>
        public void deleteGorisontal(int width, int y)
        {
            Random rnd = new Random();
            List<int> indexes = new List<int>();
            for (int x = 0; x < width; x++)
            {
                horisontalWalls[x, y] = true;
                bool needDel1HorisotalWall = true;
                for (int k = 0; k < width; k++)
                {
                    if (cells[k, y] == cells[x, y])
                    {
                        //заносим ячейки множества x в список
                        indexes.Add(k);
                        if (!horisontalWalls[k, y])
                        {
                            //если ячейка k без нижней границы то переходим к следующему множеству не удаляя границу
                            needDel1HorisotalWall = false;
                            break;
                        }
                    }
                }
                if (needDel1HorisotalWall)
                {
                    byte r = (byte)rnd.Next(indexes.Count);
                    horisontalWalls[indexes[r], y] = false;
                }
                indexes.Clear();
            }
        }
        /// <summary>
        /// Нарисовать лабиринт на форме
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="MyFormGrap"></param>
        public void toScreen(int width, int height, Graphics MyFormGrap)
        {
            Pen koord = new Pen(Color.Black, 1);
            MyFormGrap.DrawRectangle(koord, 10, 10, width, height);
            for (int x = 0; x < (width / mashtab); x++)
            {
                for (int y = 0; y < (height / mashtab); y++)
                {
                    int paramX = x * mashtab + mashtab + 10;
                    int paramY = y * mashtab + mashtab + 10;
                    if (verticalWalls[x, y])
                        MyFormGrap.DrawLine(koord, paramX, paramY - mashtab, paramX, paramY);
                    if (horisontalWalls[x, y])
                        MyFormGrap.DrawLine(koord, paramX - mashtab, paramY, paramX, paramY);
                }
            }
            SolidBrush myBrush = new SolidBrush(Color.Green);
            Random rnd = new Random();
            int pX = rnd.Next((width / mashtab) / 2, width / mashtab);
            int pY = rnd.Next((height / mashtab) / 2);

            MyFormGrap.FillRectangle(myBrush, pX*mashtab+20, pY*mashtab+20, mashtab/2, mashtab/2);
            
            koord.Dispose(); 
            myBrush.Dispose();
            MyFormGrap.Dispose();
        }
    }
}
