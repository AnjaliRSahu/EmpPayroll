using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    internal class DailyWage
    {
        public static void CalDailyWages()
        {
            int empHrs = 0;
            const int EMP_WAGE_PER_HOUR = 20;
            Random random = new Random();
            int empcheck = random.Next(0, 2);//0,1
            Console.WriteLine("Random generated value " + empcheck);
            if (empcheck == 0)
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            else
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }

            int empWage=empHrs* EMP_WAGE_PER_HOUR;
            Console.WriteLine("Daily employee wage is "+empWage);
            }
        }
}
