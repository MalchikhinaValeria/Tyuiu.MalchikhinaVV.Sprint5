using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MalchikhinaVV.Sprint5.Task1.V12.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint5.Task1.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнил: Мальчихина В. В. | ИИПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл.                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Мальчихина Валерия Викторовна | ИИПб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение, результат сохранить              *");
            Console.WriteLine("* в текстовый файл OutPutFileTask1.txt и вывести на консоль.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;


            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл:  " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}

