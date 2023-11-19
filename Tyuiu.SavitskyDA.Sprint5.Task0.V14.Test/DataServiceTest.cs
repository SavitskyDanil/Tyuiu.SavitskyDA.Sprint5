using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.SavitskyDA.Sprint5.Task0.V14.Lib;

namespace Tyuiu.SavitskyDA.Sprint5.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\1uwuHAHAAHAHAHAHA\source\repos\Tyuiu.SavitskyDA.Sprint5\Tyuiu.SavitskyDA.Sprint5.Task0.V14\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
