using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai5
{
    internal class HourlyEmp: EmployeeManagement
    {
        public double Wage { get; }
        public double Hour { get; }

        public HourlyEmp(string firstName, string lastName, string socialSecurityNumber, double wage, double hour)
            : base(firstName, lastName, socialSecurityNumber)
        {
            Wage = wage;
            Hour = hour;
        }

        public override double GetSalary()
        {
            if (Hour <= 40)
            {
                return Wage * Hour;
            }
            else
            {
                return (Wage * 40) + ((Hour - 40) * Wage * 1.5);
            }
        }

    }
}
