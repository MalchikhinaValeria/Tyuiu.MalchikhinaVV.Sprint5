
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MalchikhinaVV.Sprint5.Task1.V12.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint5.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            string path = ds.SaveToFileTextData(startValue, stopValue);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
