using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    abstract class Subordinate : Employee
    {
        public bool IsFired { get; set; }
        public Subordinate(string name, int age, int salary) : base(name, age, salary) { }

        public override string ToString()
        {
            return base.ToString() + (IsFired ? "Fired" : "");
        }

    }
}
