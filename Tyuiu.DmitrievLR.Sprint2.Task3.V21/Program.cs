using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DmitrievLR.Sprint2.Task3.V21.Lib;

namespace Tyuiu.DmitrievLR.Sprint2.Task3.V21
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
            Console.WriteLine("* Тема: Вложенные операторы if - else                                    *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант: #21                                                           *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПб-23-1                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с   *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит     *");
            Console.WriteLine("* значение переменной X с клавиатуры                                     *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            /*  
            *   Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
                Console.WriteLine("**************************************************************************");
            */
            Console.WriteLine("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();

        }
    }
}
