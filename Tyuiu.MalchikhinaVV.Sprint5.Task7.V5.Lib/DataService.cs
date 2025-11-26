using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MalchikhinaVV.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V5.txt");

            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string cleanedLine = Regex.Replace(line, @"[A-Za-z]", "");
                cleanedLine = Regex.Replace(cleanedLine, @"\s+\.", ".");

                File.AppendAllText(pathSaveFile, cleanedLine + Environment.NewLine);
            }

            return pathSaveFile;
        }
    }
}
