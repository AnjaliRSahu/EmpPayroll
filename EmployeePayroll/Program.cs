namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to wage computation Program");
            Console.WriteLine("Choose option \n 1.Employee is present or absent ");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    EmpPresentAbsent.EmpAttendanceCheck();
                    break;
                default:
                    Console.WriteLine("Entered Wrong Choice ");
                    break;

            }
        }
    }
}