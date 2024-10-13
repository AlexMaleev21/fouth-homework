using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace dz4
{
    internal class Employee
    {
        public double Salary { get; set; }

        public Employee(double Salary)
        {
            this.Salary = Salary;
        }

        public static Employee operator + (Employee employee, double addition)
        {
            employee.Salary += addition;
           return employee;
        }

        public static Employee operator -(Employee employee, double decrease)
        {
            employee.Salary -= decrease;
            return employee;
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Salary.Equals(employee2.Salary))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Employee employee1, Employee employee2)
        {
            if (employee1.Salary.Equals(employee2.Salary))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator > (Employee employee1, Employee employee2)
        {
            if (employee1.Salary > employee2.Salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator < (Employee employee1, Employee employee2)
        {
            if (employee1.Salary < employee2.Salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals (Object? obj)
        {
            var item = obj as Employee;
            return this.Salary.Equals(item.Salary);
        }

        public override int GetHashCode()
        {
            return this.Salary.GetHashCode();
        }
    }
}
