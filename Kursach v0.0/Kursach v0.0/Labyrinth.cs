using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Collections;
using WMPLib;

namespace Kursach_v0._0
{
    public partial class Labyrinth : Form
    {
        public ProgressForm form = new ProgressForm();
        public static Settings setting;
        public static bool flag = true;

        public Labyrinth()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Включает музыку при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Labyrinth_Load(object sender, EventArgs e)
        {
            Sound.Play_start();
        }
        /// <summary>
        /// Закривает текущую форму после нажатия на кнопку выйти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Начать игру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            if(!flag) setting = new Settings(setting.level);
            else setting = new Settings();
            FormLevel1 level = new FormLevel1();
            FormLevel1.setting = setting;
            level.ShowDialog();
        }
        /// <summary>
        /// Просмотр достижений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_progress_Click(object sender, EventArgs e)
        {
            form.ShowDialog();
        }
        /// <summary>
        /// Просмотр информации об авторе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Info_Click(object sender, EventArgs e)
        {
            FormInfo form = new FormInfo();
            form.ShowDialog();
        }
        /// <summary>
        /// Настроить игру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_settings_Click(object sender, EventArgs e)
        {
            if(flag) setting = new Settings();
            FormSettings fsetring = new FormSettings();
            fsetring.set = setting;
            fsetring.ShowDialog();
            flag = false;
        }

    }
}
