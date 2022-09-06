using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    internal class PartTimeSwitch
    {
        public static void CalculatePartTime()
        {
            //const int IS_FULL_TIME = 1;
            //const int IS_PART_TIME = 2;
            //const int EMP_PER_HOUR = 20;

            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(1, 3);//1,2

            switch (empCheck)
            {
                case 1:

                    empHrs = 8;
                    Console.WriteLine("Employee is present for full day");
                    break;
                case 2:
                    empHrs = 4;
                    Console.WriteLine("Employee is present for half day");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
        }
    }
}
