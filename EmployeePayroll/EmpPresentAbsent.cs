using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    internal class EmpPresentAbsent
    {
        public static void EmpAttendanceCheck()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);//0,1
            Console.WriteLine("Random generated value "+empcheck);
            if (empcheck==0)
            {
                Console.WriteLine("Employee is absent");
            }
            else
            {
                Console.WriteLine("Employee is present");
            }
        }
    }
}
