using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    internal class WageforMonth
    {
        public static void CalculateMonthWage()
        {
            int empHrs = 0;
            int totalempWage = 0;

            for (int day = 1; day <= 20; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);//,1,2

                switch (empCheck)
                {
                    // case 0:empHrs = 0;
                    //   break;
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    default: empHrs = 0;
                        break;
                }
                int empWage = empHrs * 20;
                totalempWage += empWage;//totalempWage=totalempWge+empWage
                Console.WriteLine("Daily emp wage is {0} and total employee wage is {1}",empWage,totalempWage);
            }
            Console.WriteLine("Total emp salary is:" + totalempWage);
        }
    }
}
