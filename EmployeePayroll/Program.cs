namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to wage computation Program");
            Console.WriteLine("Choose option \n 1.Employee is present or absent \t 2. Daily wage \t 3.Calculate Part Time \t4.PartTimeSwitch");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    EmpPresentAbsent.EmpAttendanceCheck();
                    break;
                    case 2:
                    DailyWage.CalDailyWages();
                    break;
                case 3:
                    PartTimeWage.CalculatePartTime();
                    break;
                 case 4;
                    PartTimeSwitch.CalculatePartTime();
                    break;
                default:

                    Console.WriteLine("Entered Wrong Choice ");
                    break;

            }
        }
    }
}