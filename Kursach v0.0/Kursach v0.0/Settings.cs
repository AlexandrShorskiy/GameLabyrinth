using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_v0._0
{
    public class Settings
    {
        public int width; // Ширина
        public int height; // Высота
        public int sizeble; // Масштаб
        public string level; // Уровень
        public int volume; // Громкость звука
        public bool music; // Музыку вкл/выкл
        /// <summary>
        /// Конструктор по умолчанию, параметры для лёгкого уровня игры
        /// </summary>
        public Settings()
        {
            this.level = "Лёгкий";
            width = 20;
            height = 12;
            sizeble = 55;
            volume = 100;
            music = true;
        }
        /// <summary>
        /// Конструктор - установка параметров для уровня переданного переменной level
        /// </summary>
        /// <param name="level"></param>
        public Settings(string level)
        {
            if (level == "") level = "Лёгкий";
            switch(level)
            {
                case "Лёгкий": 
                    width = 20;
                    height = 12;
                    sizeble = 55;
                    this.level = "Лёгкий"; 
                    break;
                case "Средний":
                    width = 27;
                    height = 17;
                    sizeble = 40;
                    this.level = "Средний"; 
                    break;
                case "Сложный":
                    width = 36;
                    height = 23;
                    sizeble = 30;
                    this.level = "Сложный";
                    break;
                case "Профессиональный":
                    width = 50;
                    height = 30;
                    sizeble = 22;
                    this.level = "Профессиональный";
                    break;
            }
            music = false;
            volume = 100;
        }
        
    }
}
