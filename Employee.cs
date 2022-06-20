using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }


        public Employee() { }
        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;

            Console.WriteLine($"New Employee Hired: {GetData()}");
        }

        public string GetData()
        {
            return ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is not Employee)
                return false;

            return GetHashCode() == obj.GetHashCode();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override string ToString()
        {
             return $"{Name} | Age: {Age} | Salary: {Salary} |";
        }
    }

}
