using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MalchikhinaVV.Sprint5.Task0.V27.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint5.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\Users\Home\AppData\Local\Temp\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
