using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace List_exerc_1
{
    class Employees
    {
        public int Id { get;private set; }
        public string Name { get; set; }

        public double Salary { get; set; }

        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IcreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return Id + "," + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
