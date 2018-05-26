using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_v0._0
{
    public partial class FormEndGame : Form
    {
        public Settings settings; // объект класса настроек
        public FormEndGame()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Уставка флага в предыдущей формы, закрытие текущей формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_inMenu_Click(object sender, EventArgs e)
        {
            FormLevel1.flags = true;
            this.Close();
        }
        /// <summary>
        /// Сохранить результаты прохождения уровня в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_save_Click(object sender, EventArgs e)
        {
            string filename = Assembly.GetExecutingAssembly().Location;
            filename = filename.Replace(Application.ProductName + ".exe", "") + "Progress.txt";

            string results = "\n" + tb_name.Text + " " + settings.level + " " + tb_result.Text;
            try
            {
                StreamWriter sw = new StreamWriter(File.Open(filename, FileMode.Append));
                sw.WriteLine(results);
                sw.Close();
            }
            catch
            {

            }
            Close();
        }
        /// <summary>
        /// Отобразить результаты прохождения уровня
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEndGame_Load(object sender, EventArgs e)
        {
            tb_result.Text = FormLevel1.timeResult;
        }

    }
}
