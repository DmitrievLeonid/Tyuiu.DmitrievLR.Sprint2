using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


/*
 * Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении) 
 * и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических выражений, 
 * которая вернет логическую последовательность(массив): 
 * (True, True, True, False, True, False), 
 * при a = 145, b = 716, c = 144, d = 137
 * 
 * 
 * 
 */
namespace Tyuiu.DmitrievLR.Sprint2.Task1.V16.Lib
{
    public class DataService : ISprint2Task1V16
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {

            bool[] res = new bool[6];

            res[0] = (a == c + 1) | (b > d); //true
            res[1] = (a-1 == c)&(b > d); //true 
            res[2] = (a < b)||(c > d); //true
            res[3] = (a == b)&&(c-1 >= d); //false
            res[4] = !(!res[1]); //true
            res[5] = (c>a)^(b < d); //false


            return res;
        }
    }
}
