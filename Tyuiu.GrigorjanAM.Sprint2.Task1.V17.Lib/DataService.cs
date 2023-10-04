using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrigorjanAM.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < 123) | (c > d);
            res[1] = ((a + 777) > (b + 888)) & ((c+666) > (d + 42));
            res[2] = (a + 5 >= b + 16) || (c / 5 < d);
            res[3] = !res[1];
            res[4] = (a + 3 > b + 10) && (c - 11 >= d + 35);
            res[5] = (a + 15 == b + 17) ^ (c + 53 < d -1);

            return res;

        }
    }
    // (True, False, True, True, True, False)
    // a = 135, b = 123, c = 455, d = 321
}
