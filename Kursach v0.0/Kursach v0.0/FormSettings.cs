using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Kursach_v0._0
{
    public partial class FormSettings : Form
    {
        public Settings set = Labyrinth.setting; // объект класса настроек
        static WindowsMediaPlayer WMP = new WindowsMediaPlayer(); // объект проигрывателя музыки

        public FormSettings()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Установка параметров соответстующих предыдущим изменениям
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSettings_Load(object sender, EventArgs e)
        {
            if (set.level == "Лёгкий") rB_easy.Checked = true;
            else if (set.level == "Средний") rB_average.Checked = true;
            else if (set.level == "Сложный") rB_complicated.Checked = true;
            else rB_professional.Checked = true;
            cB_sound.Checked = set.music;
            tB_sound.Value = set.volume;
            WMP.settings.volume = tB_sound.Value;
        }
        /// <summary>
        /// Закрыть текущую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_Close_Click(object sender, EventArgs e)
        {
            SaveSetting();
            this.Close();
        }
        /// <summary>
        /// Сохранить текущие настройки
        /// </summary>
        public void SaveSetting()
        {
            if (rB_easy.Checked == true) set.level = rB_easy.Text;
            else if (rB_average.Checked == true) set.level = rB_average.Text;
            else if (rB_complicated.Checked == true) set.level = rB_complicated.Text;
            else set.level = rB_professional.Text;
            set.music = cB_sound.Checked;
            set.volume = tB_sound.Value;
        }
        /// <summary>
        /// Установить настройки по умолчанию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_standart_Click(object sender, EventArgs e)
        {
            tB_sound.Value = 100;
            cB_sound.Checked = true;
            rB_easy.Checked = true;
            WMP.settings.volume = tB_sound.Value;
        }
        /// <summary>
        /// Контролирует вкл/выкл музыки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cB_sound_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_sound.Checked)
            {
                Sound.sound_on();
                Sound.Play_start();
            }
            else
            { Sound.sound_off(); Sound.Play_start(); }
            WMP.settings.volume = tB_sound.Value;
        }
        /// <summary>
        /// Контролирует громкость музыки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tB_sound_Scroll(object sender, EventArgs e)
        {
            WMP.settings.volume = tB_sound.Value;
        }
    }
}
