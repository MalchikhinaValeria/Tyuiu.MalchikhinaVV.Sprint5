using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MalchikhinaVV.Sprint5.Task0.V27.Lib
{
    public class DataService : ISprint5Task0V27
    {
        public string SaveToFileTextData(int x)
        {
            
            double y = Math.Pow(x - 1, 3 * x + 1);
            double res = Math.Round(y, 3);

            string tempPath = Path.GetTempPath();
            string path = Path.Combine(tempPath, "OutPutFileTask0.txt");

            File.WriteAllText(path, Convert.ToString(res));

            return path;
        }
    }
}
