using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depi_c__Task4
{
    public class Employee
    {
        private string _Name;
        private int _Id;
        private string _JobTitle;
        private double _Salary;
        private DateTime _DateOfBirth;
        private DateTime _HireDate;
        private string _Address;
        private string _Department;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string JobTitle
        {
            get { return _JobTitle; }
            set { _JobTitle = value; }
        }
        public double Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public DateTime HireDate
        {
            get { return _HireDate; }
            set { _HireDate = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Department
        {
            get { return _Department; }
            set { _Department = value; }
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Job Title: {JobTitle}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Hire Date: {HireDate.ToShortDateString()}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Department: {Department}");
        }

    }
}
