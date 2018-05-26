using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursach_v0._0;

namespace UnitTestForLabyrinth
{
    [TestClass]
    public class UnitTestMyLabyrith
    {
        [TestMethod]
        public void TestCreateMatrixHorisontalWalls()
        {
            GenerateLabyrinth generator = new GenerateLabyrinth(20);
            generator.generateLabirynth(10, 10);
            Assert.AreNotEqual(null, generator.horisontalWalls);
        }
        [TestMethod]
        public void TestCreateMatrixVerticalWalls()
        {
            GenerateLabyrinth generator = new GenerateLabyrinth(20);
            generator.generateLabirynth(10, 10);
            Assert.AreNotEqual(null, generator.verticalWalls);
        }
        [TestMethod]
        public void TestSettings1()
        {
            Settings my_settings = new Settings();
            my_settings.width = 20;
            my_settings.height = 12;
            my_settings.sizeble = 55;
            my_settings.level = "Лёгкий";
            my_settings.music = false;
            my_settings.volume = 100;
            Assert.IsNotNull(my_settings);
        }
        [TestMethod]
        public void TestSettings2()
        {
            Assert.IsNotNull(new Settings("Лёгкий"));
        }
    }
}
