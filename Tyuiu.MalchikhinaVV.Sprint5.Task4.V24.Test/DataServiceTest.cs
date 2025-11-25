using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MalchikhinaVV.Sprint5.Task4.V24.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint5.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Home\AppData\Local\Temp\DataSprint5\InPutDataFileTask4V24.txt";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsists);
        }
    }
}
