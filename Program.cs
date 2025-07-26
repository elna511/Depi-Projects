namespace Depi_c__Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Nada = new Employee();
            Employee Ahmed = new Employee();
            Nada.Name = "Nada Hassan";
            Nada.Id = 1;
            Nada.JobTitle = "Data Scientist";
            Nada.Salary = 30000;
            Nada.DateOfBirth = new DateTime(2004, 11, 5);
            Nada.HireDate = new DateTime(2023, 1, 1);
            Nada.Address = "123 Main St, Alex, Egypt";
            Nada.Department = "Data Science";
            Console.WriteLine("Employees Information:");
            Console.WriteLine();
            Nada.DisplayEmployeeInfo();
            Console.WriteLine();
            Ahmed.Name = "Ahmed Ali";
            Ahmed.Id = 2;
            Ahmed.JobTitle = "Software Engineer";
            Ahmed.Salary = 25000;
            Ahmed.DateOfBirth = new DateTime(2003, 5, 15);
            Ahmed.HireDate = new DateTime(2023, 2, 1);
            Ahmed.Address = "456 Elm St, Cairo, Egypt";
            Ahmed.Department = "IT";
            Ahmed.DisplayEmployeeInfo();

            
        }
    }
}
