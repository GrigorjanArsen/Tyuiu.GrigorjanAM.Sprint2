using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrigorjanAM.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            bool res;
            if ( (Math.Pow(Math.Abs(x),2) + Math.Pow(y,2) <= 1) && (Math.Abs(x) <= y) && (Math.Abs(x) <= 0.707 ) && (y <= 1) && (y>=0)  )
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
