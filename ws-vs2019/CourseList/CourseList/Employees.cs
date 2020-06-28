using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CourseList
{
    class Employees
    {
        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public double Salary { get; set; }

        public void increaseSalary(double porcentage)
        {
            Salary = (Salary / 100 * porcentage) + Salary;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
