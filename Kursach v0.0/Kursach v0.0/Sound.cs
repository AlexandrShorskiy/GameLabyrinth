using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;

namespace Kursach_v0._0
{
    public class Sound
    {
        static SoundPlayer soundStart = new SoundPlayer(Properties.Resources._11_TooManyCooks); // Объект плеера с песней
        static bool sound_enabled = true; // Флаг вкл/выкл музыку
        /// <summary>
        /// Метод вкл/выкл музыку
        /// </summary>
        public static void Play_start()
        {
            if (sound_enabled)
                soundStart.Play();
            else soundStart.Stop();
        }
        /// <summary>
        /// Метод включает музыку
        /// </summary>
        public static void sound_on()
        {
            sound_enabled = true;
        }
        /// <summary>
        /// Метод выключает музыку
        /// </summary>
        public static void sound_off()
        {
            sound_enabled = false;
        }
    }
}
