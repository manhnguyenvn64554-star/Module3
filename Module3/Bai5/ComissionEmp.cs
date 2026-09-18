using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai5
{
    internal class ComissionEmp: EmployeeManagement
    {
        public double GrossSales { get; }
        public double CommissionRate { get; }

        public ComissionEmp(string firstName, string lastName, string socialSecurityNumber, double grossSales, double commissionRate)
            : base(firstName, lastName, socialSecurityNumber)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        public override double GetSalary()
        {
            return GrossSales * CommissionRate;
        }
    }
}
