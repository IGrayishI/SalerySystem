using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genomgång_SalerySystem
{
    internal class Outlet
    {
        //Location
        //Employee
        //CurrentEmployeeCount

        private string OutletLocation;
        private Employee[] Employees;
        private int CurrentEmployeeCount = 0;

        public Outlet (string location, int maxEmployees)
        {
            OutletLocation = location;
            Employees = new Employee[maxEmployees];
        }

        public void AddEmployee(Employee newEmployee)
        {
            if (CurrentEmployeeCount < Employees.Length)
            {
                Employees[CurrentEmployeeCount] = newEmployee;
                CurrentEmployeeCount++;
            } else
            {
                Console.WriteLine("Outlet has reached maximus employees");
            }
        }

        public double GetTotalOutletSalary()
        {
            double total = 0;
            for (int i = 0; i < CurrentEmployeeCount; i++)
            {
                total += Employees[i].GetMonthlySalary();
            }
            return total;
            
        }

        public string GetLocation()
        {
            return OutletLocation;
        }
    }
}
