using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MalchikhinaVV.Sprint5.Task7.V5.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint5.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedLoadDataAndSave()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V3.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsists);
        }
    }
}
