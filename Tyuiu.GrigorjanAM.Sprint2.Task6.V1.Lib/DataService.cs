using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GrigorjanAM.Sprint2.Task6.V1.Lib
{
    public class DataService : ISprint2Task6V1
    {
        public int FindMonthDaysCount(int value)
        {
            int days;

            switch (value)
            {
                case 1: return days = 31;
                case 2: return days = 28;
                case 3: return days = 31;
                case 4: return days = 30;
                case 5: return days = 31;
                case 6: return days = 30;
                case 7: return days = 31;
                case 8: return days = 31;
                case 9: return days = 30;
                case 10: return days = 31;
                case 11: return days = 30;
                case 12: return days = 31;
                default: throw new ArgumentException($"Номер месяца должен находиться в диапазоне 1-12. Значение {value}"); ;
            }
            return days;
        }
    }
}
