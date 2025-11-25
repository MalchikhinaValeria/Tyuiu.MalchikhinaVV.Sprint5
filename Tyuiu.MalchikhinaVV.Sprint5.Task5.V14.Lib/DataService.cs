using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MalchikhinaVV.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Trim().Replace(".", ",");
            string[] numbers = strX.Split(new char[] { ' ', '\t', '\n', '\r' },
                                        StringSplitOptions.RemoveEmptyEntries);

            int max = int.MinValue;

            foreach (string numStr in numbers)
            {
                if (double.TryParse(numStr.Trim(), out double number))
                {
                    if (number % 1 == 0)
                    {
                        int intNumber = (int)number;

                        if (Math.Abs(intNumber) % 3 == 0 && intNumber > max)
                        {
                            max = intNumber;
                        }
                    }
                }
            }

            double res = 0;
            if (max != int.MinValue && max >= 0)
            {
                res = 1;
                for (int i = 2; i <= max; i++)
                {
                    res *= i;
                }
            }

            return res;
        }
    }
}
