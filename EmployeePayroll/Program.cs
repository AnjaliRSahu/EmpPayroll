namespace EmployeePayroll
{
    internal class Program
    {
        
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to wage computation Program");
            Console.WriteLine("Choose option \n 1.Employee is present or absent \t 2. Daily wage \t 3.Calculate Part Time \t4.PartTimeSwitch\t 5.Wages of a month\n 6.Refactor using Class \t7.EmpWage for Multiple Companies");
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
                    PartTimeWage1.CalculatePartTime();
                    break;
                case 4:
                    PartTimeSwitch.CalculatePartTime();
                    break;
                 case 5:
                    WageforMonth.CalculateMonthWage();
                    break;
                
                case 6:
                    Refactor1.ComputeEmpWage();
                    break;
                case 7:
                    MultipleCompanies.computeEmpWage("Tata", 30, 20,110);
                    MultipleCompanies.computeEmpWage("Google", 50, 20, 150);
                    MultipleCompanies.computeEmpWage("Dmart", 20,20, 100);
                    break;
                default:
                    Console.WriteLine("Entered Wrong Choice ");
                    break;

            }
            
        }
    }
}