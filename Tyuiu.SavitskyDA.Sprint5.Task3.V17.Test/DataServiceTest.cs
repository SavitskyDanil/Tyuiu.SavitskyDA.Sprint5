using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.SavitskyDA.Sprint5.Task3.V17.Lib;

namespace Tyuiu.SavitskyDA.Sprint5.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\1uwuHAHAAHAHAHAHA\source\repos\Tyuiu.SavitskyDA.Sprint5\Tyuiu.SavitskyDA.Sprint5.Task3.V17\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
