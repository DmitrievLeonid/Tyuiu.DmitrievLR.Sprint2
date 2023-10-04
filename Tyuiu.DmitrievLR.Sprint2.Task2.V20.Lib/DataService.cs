using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DmitrievLR.Sprint2.Task2.V20.Lib
{
    public class DataService : ISprint2Task2V20
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            int[,] coord = new int[15, 15]
            {//X 1  2  3  4  5  6  7  8  9 10 11 12 13 14 15                  
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //y1
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //y2
                {0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }, //y3
                {0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }, //y4
                {0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 }, //y5
                {0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0 }, //y6
                {0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0 }, //y7
                {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, //y8
                {0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0 }, //y9
                {0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0 }, //y10
                {0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0 }, //y11
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0 }, //y12
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 }, //y13
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //y14
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //y15
            };

            if (coord[x, y] == 1)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
