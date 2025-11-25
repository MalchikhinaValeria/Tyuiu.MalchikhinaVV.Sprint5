using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MalchikhinaVV.Sprint5.Task2.V11.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint5.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedFileExist()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3] {
                { 4, 9, 3 },
                { 5, 8, 8 },
                { 5, 7, 5 }
            };
            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
