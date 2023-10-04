using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DmitrievLR.Sprint2.Task1.V16.Lib;

namespace Tyuiu.DmitrievLR.Sprint2.Task1.V16
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
            Console.WriteLine("* Тема: Логические операции                                              *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант: #16                                                           *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПб-23-1                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)        *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность          *");
            Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,      *");
            Console.WriteLine("* которая вернет логическую последовательность(массив)                   *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            /*  
            *   Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
                Console.WriteLine("**************************************************************************");
            */
            int a = 145, b = 716, c = 144, d = 137;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a,b,c,d);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

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
