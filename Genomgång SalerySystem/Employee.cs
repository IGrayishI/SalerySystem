using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genomgång_SalerySystem
{
    internal class Employee
    {
        private int EmployeeId;
        private string Name;
        private double MonthlySalary;



        public Employee(int employeeId, string name, double monthlySalary)
        {
            EmployeeId = employeeId;
            Name = name;
            SetSalary(monthlySalary);
        }

        public void SetSalary(double salary)
        {
            if (salary >= 0) 
            { 
                MonthlySalary = salary;
            }
            else
            {
                Console.WriteLine("Invalid salary input. Please enter a positive value.");
            }
        }

        public int GetEmployeeId()
        {
            return EmployeeId;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetMonthlySalary()
        {
            return MonthlySalary;
        }


    }
}
