using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManagement[] employees = new EmployeeManagement[3];
            employees[0] = new SalariedEmp("John", "Doe", "123-45-6789", 1000.0);
            employees[1] = new ComissionEmp("Jane", "Smith", "987-65-4321", 5000.0, 0.1);
            employees[2] = new BasePlusComission("Bob", "Johnson", "555-55-5555", 3000.0, 0.05, 500.0);
            foreach (EmployeeManagement employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: ${employee.GetSalary():F2}");
            }
        }
    }
}
