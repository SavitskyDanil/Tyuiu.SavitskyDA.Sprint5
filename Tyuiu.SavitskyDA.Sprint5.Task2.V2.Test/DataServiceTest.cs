using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.SavitskyDA.Sprint5.Task2.V2.Lib;

namespace Tyuiu.SavitskyDA.Sprint5.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\1uwuHAHAAHAHAHAHA\source\repos\Tyuiu.SavitskyDA.Sprint5\Tyuiu.SavitskyDA.Sprint5.Task2.V2\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
