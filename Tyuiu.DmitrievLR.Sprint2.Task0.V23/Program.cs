using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DmitrievLR.Sprint2.Task0.V23.Lib;

namespace Tyuiu.DmitrievLR.Sprint2.Task0.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            //Сокращаем ссылку на DataService

            Console.Title = " Спринт 2 | Выполнил Дмитриев Л. Р.  | ИИПб-23-1 ";

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Операции сравнения                                               *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант: #23                                                           *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПб-23-1                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу из операций сравнений                               *");
            Console.WriteLine("*  (==, !=, <, >, <=, >=, последовательность операций не должна          *");
            Console.WriteLine("*  нарушаться) и арифметических выражений, которая вернет логическую     *");
            Console.WriteLine("* последовательность(массив)                                             *");             
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            /*
            *   Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
                Console.WriteLine("**************************************************************************");
            */
            int x = 105, y = 795;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }


            Console.ReadKey();

        }
    }
}
