using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Company
    {
        private List<Employee> _employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public Dictionary<string, int> GetPositionsCounts()
        {
            Dictionary<string, int> counts = new Dictionary<string, int>
            {
                ["Manager"] = 0,
                ["Engineer"] = 0,
                ["Intern"] = 0
            };

            foreach (Employee employee in _employees)
            {
                if (employee is Manager)
                    counts["Manager"]++;
                else if (employee is Engineer)
                    counts["Engineer"]++;
                else if (employee is Intern)
                    counts["Intern"]++;
            }
            return counts;
        }
    }
}
