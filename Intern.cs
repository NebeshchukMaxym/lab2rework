using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Intern : Subordinate
    {
        public Intern(string name, int age, int salary) : base(name, age, salary) { }

        public override string ToString()
        {
            return "Intern " + base.ToString();
        }
    }
}
