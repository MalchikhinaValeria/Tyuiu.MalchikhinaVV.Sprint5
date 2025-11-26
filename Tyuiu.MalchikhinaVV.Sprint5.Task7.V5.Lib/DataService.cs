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

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string strLine = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!((line[i] >= 'A' && line[i] <= 'Z') || (line[i] >= 'a' && line[i] <= 'z')))
                        {
                            strLine = strLine + line[i];
                        }
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                }
            }
            return pathSaveFile;
        }
    }
}
