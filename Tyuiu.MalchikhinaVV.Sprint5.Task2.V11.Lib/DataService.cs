using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MalchikhinaVV.Sprint5.Task2.V11.Lib
{
    public class DataService : ISprint5Task2V11
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            FileInfo fInfo = new FileInfo(path);
            bool FileExist = fInfo.Exists;

            if (FileExist) { File.Delete(path); }

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0) { matrix[i, j] = 0; }
                }
            }
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str += matrix[i, j] + ";";
                    }
                    else
                    {
                        str += matrix[i, j];
                    }
                }
                if (i != rows - 1) File.AppendAllText(path, str + Environment.NewLine);
                else File.AppendAllText(path, str);
                str = "";
            }
            return path;
        }
    }
}
