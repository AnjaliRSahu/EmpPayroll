using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    internal class WagesOfMonthWhileLoop
    {
        public static void CalculateWages()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs < 100 && totalWorkingDays < 20)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);//0,1,2
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        break;
                        case 2:
                        empHrs = 8;
                        break;
                     default:
                        empHrs = 0;
                        break;
                }
                 totalEmpHrs+=empHrs;
                Console.WriteLine("Day {0} and empHrs {1}", totalWorkingDays, totalEmpHrs);
                }
            int totalEmpWage = totalEmpHrs * 20;
            Console.WriteLine();
            Console.WriteLine("total emp wage is : {0}",totalEmpWage);


        }
    }
}
