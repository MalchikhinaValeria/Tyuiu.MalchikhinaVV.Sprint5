using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MalchikhinaVV.Sprint5.Task3.V16.Lib
{
    public class DataService : ISprint5Task3V16
    {
        public string SaveToFileTextData(int x)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.txt");
            double res = ((2 * Math.Pow(x , 2)) - 1)/(Math.Sqrt((Math.Pow(x, 2) - 2)));
            res = Math.Round(res, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(res));
            }
            return filePath;
        }
    }
}
