using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MalchikhinaVV.Sprint5.Task7.V5.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.MalchikhinaVV.Sprint5.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнил: Мальчихина В. В. | ИИПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Мальчихина Валерия Викторовна | ИИПб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл (файл взять из архива согласно вашему варианту. Создать папку  *");
            Console.WriteLine("* в ручную и скопировать в неё файл) в котором есть набор символьных      *");
            Console.WriteLine("* данных. Удалить все латинские буквы из файла.Полученный результат       *");
            Console.WriteLine("* сохранить в файл OutPutDataFileTask7V5.txt                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\Home\AppData\Local\Temp\DataSprint5\InPutDataFileTask7V5.txt";
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V5.txt");

            Console.WriteLine("Даннаые находятся в файле: " + path);


            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находятся в файле: ");

            pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine(pathSaveFile);



            Console.ReadKey();
        }
    }
}

