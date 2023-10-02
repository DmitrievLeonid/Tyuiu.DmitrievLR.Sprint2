using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;



/*
 * Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) и арифметических выражений, 
 * которая вернет логическую последовательность(массив): 
 * (True, False, True, True, False, True),  
 * при x = 105, y = 795
 * 
 * 
 */
namespace Tyuiu.DmitrievLR.Sprint2.Task0.V23.Lib
{
    public class DataService : ISprint2Task0V23
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 690 == y;
            res[1] = x + 690 != y;
            res[2] = x < y;
            res[3] = x + 791 > y;
            res[4] = x + 691 <= y;
            res[5] = x + 791 >= y;

            return res;

        }
    }
}
