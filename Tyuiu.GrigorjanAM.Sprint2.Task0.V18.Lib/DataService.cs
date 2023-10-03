using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrigorjanAM.Sprint2.Task0.V18.Lib
{
    public class DataService : ISprint2Task0V18
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 574 == y + 5015;
            res[1] = x - 4629 != y;
            res[2] = y + 1200 < x;
            res[3] = x - 4629 > y;
            res[4] = y + 4629 <= x;
            res[5] = x  >= y + 4631;
            return res;

        }
    }
}
