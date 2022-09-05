using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    internal class PartTimeWage1
    {
        public static void CalculatePartTime()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_PER_HOUR = 20;

            int empHrs = 0;
            Random random = new Random();   
            int empCheck=random.Next(1,3);//1,2

            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is present for full day");
            }
            else if(empCheck==IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("Employee is present for half day");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent");
            }
            int empWage = empHrs * EMP_PER_HOUR;
            Console.WriteLine("Employee daily wage including part time " + empWage);
        }
    }
}
