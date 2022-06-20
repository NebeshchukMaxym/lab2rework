using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Manager : Employee
    {
        public Manager(string name, int age, int salary) : base(name, age, salary) { }

        public void Fire(Subordinate subordinate)
        {
            Console.WriteLine($"{GetData()} Fired Subordinate {subordinate.GetData()}");
            subordinate.IsFired = true;
        }

        public void GiveRaise(Subordinate subordinate, int raise)
        {
            Console.WriteLine($"{GetData()} Gave Raise To Subordinate {subordinate.GetData()}");
            subordinate.Salary += raise;
        }

        public override string ToString()
        {
            return "Manager " + base.ToString();
        }
    }
}
