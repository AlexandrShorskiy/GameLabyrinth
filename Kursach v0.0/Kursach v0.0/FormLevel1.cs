using Kursach_v0._0.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kursach_v0._0
{
    public partial class FormLevel1 : Form
    {
        static int width, height, sizeble;// ширина, высота и масштаб лабиринта
        static string level; // уровень
        static GenerateLabyrinth gen, gl;// объект класса для генерации лабиринта
        public static Settings setting; // объект класса настроек

        public static bool flags = false; // флаг для закрытия текущей формы
        public static int time = 0; // время
        public static string timeResult; // результат прохождения
        public static System.Windows.Forms.Timer timerParam, timer2Param; // таймеры для измерения времени прохождения и мигание после 55 секунды

        public FormLevel1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Инициализация начальных переменных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLevel1_Load(object sender, EventArgs e)
        {
            width = setting.width;
            height = setting.height;
            sizeble = setting.sizeble;
            level = setting.level;
            this.pB_Person.Size = new Size(sizeble/2, sizeble/2);
            time = 0;
            timer1.Start();
            timer2.Start();
            timer2Param = timer2;
            timerParam = timer1;
            l_time.Text = "00:00";
            l_level.Text = level;
            timeResult = l_time.Text;
            gl = new GenerateLabyrinth(sizeble);
            
        }
        /// <summary>
        /// Выход в главное меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_menu_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
        /// <summary>
        /// Открывает форму, показывающую результаты прохождения уровня
        /// </summary>
        static void endGame()
        {
            FormEndGame end = new FormEndGame();
            timerParam.Stop();
            timer2Param.Stop();
            end.settings = setting;
            end.ShowDialog();
            time = 0;
        }
        /// <summary>
        /// Определяет можно ли передвигаться персонажу в заданную точку
        /// </summary>
        /// <param name="point"></param>
        /// <param name="pole"></param>
        /// <param name="person"></param>
        /// <returns></returns>
        static bool getColor(Point point, PictureBox pole, PictureBox person)
        {
            for (int i = point.X; i < person.Width + point.X; i++)
                for (int j = point.Y; j < person.Height + point.Y; j++)
                {
                    if (((Bitmap)pole.Image).GetPixel(i, j).Name == "ff008000")
                    { endGame(); return true; }
                    else if (((Bitmap)pole.Image).GetPixel(i, j).Name != "0")
                        return true;
                }
            return false;
        }
        /// <summary>
        /// Обработчик для управления персонажем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_menu_KeyDown(object sender, KeyEventArgs e)
        {
            ControlPerson((int)e.KeyCode, pB_Person);
        }
        /// <summary>
        /// Функция управления персонажем
        /// </summary>
        /// <param name="codeButton"></param>
        /// <param name="pb_person"></param>
        public void ControlPerson(int codeButton, PictureBox pb_person)
        {
            switch (codeButton)
            {
                case 65: if (!getColor(new Point(pB_Person.Location.X - sizeble / 5, pB_Person.Location.Y), pB_POLE, pB_Person))
                        pB_Person.Location = new Point(pB_Person.Location.X - sizeble / 5, pB_Person.Location.Y); break;

                case 87: if (!getColor(new Point(pB_Person.Location.X, pB_Person.Location.Y - sizeble / 5), pB_POLE, pB_Person))
                        pB_Person.Location = new Point(pB_Person.Location.X, pB_Person.Location.Y - sizeble / 5); break;

                case 68: if (!getColor(new Point(pB_Person.Location.X + sizeble / 5, pB_Person.Location.Y), pB_POLE, pB_Person))
                        pB_Person.Location = new Point(pB_Person.Location.X + sizeble / 5, pB_Person.Location.Y); break;

                case 83: if (!getColor(new Point(pB_Person.Location.X, pB_Person.Location.Y + sizeble / 5), pB_POLE, pB_Person))
                        pB_Person.Location = new Point(pB_Person.Location.X, pB_Person.Location.Y + sizeble / 5); break;
            }
        }
        /// <summary>
        /// Закрывает текущую форму, если установлен флаг
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLevel1_Paint(object sender, PaintEventArgs e)
        {
            if (flags)
            { flags = false; Close(); }
        }
        /// <summary>
        /// Отсчет времени - 60 секунд
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeResult = l_time.Text;
            if (time < 60)
            {
                if (time < 10) l_time.Text = "00:0" + time;
                else l_time.Text = "00:" + time;
            }
            else endGame();
            time++;
        }
        /// <summary>
        /// Мигание времени после 55 секунды
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (time > 55) 
            {
                l_time.Visible = !l_time.Visible;
                l_time.ForeColor = Color.Red; 
            }

        }
        /// <summary>
        /// Рисует лабиринт и персонажа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLevel1_Activated(object sender, EventArgs e)
        {
            gen = gl;
            Bitmap flag = new Bitmap(pB_POLE.Width, pB_POLE.Height);
            Graphics flagGraphics = Graphics.FromImage(flag);
            gl.generateLabirynth(width, height);
            gl.toScreen(width * sizeble, height * sizeble, flagGraphics);
            pB_POLE.Image = flag;
            pB_Person.Location = new Point(20,20);
        }


    }

}
