using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MalchikhinaVV.Sprint5.Task4.V24.Lib
{
    public class DataService : ISprint5Task4V24
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Trim().Replace(".", ",");
            double x = Convert.ToDouble(strX);

            double res = (Math.Pow(x, -2) + 2) * Math.Sin(x);

            return Math.Round(res, 3);
        }
    }
}
