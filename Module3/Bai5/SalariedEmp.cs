using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai5
{
    internal class SalariedEmp:EmployeeManagement
    {
        public double WeeklySalary { get; }

        public SalariedEmp(string firstName, string lastName, string socialSecurityNumber, double weeklySalary)
            : base(firstName, lastName, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }

        public override double GetSalary()
        {
            return WeeklySalary;
        }
    }
}
