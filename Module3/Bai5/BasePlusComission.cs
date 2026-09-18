using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai5
{
    internal class BasePlusComission : ComissionEmp
    {
        public double BaseSalary { get; }
        public BasePlusComission(string firstName, string lastName, string socialSecurityNumber, double grossSales, double commissionRate, double baseSalary)
            : base(firstName, lastName, socialSecurityNumber, grossSales, commissionRate)
        {
            BaseSalary = baseSalary;
        }
        public override double GetSalary()
        {
            return BaseSalary + (GrossSales * CommissionRate);
        }
    }
}
