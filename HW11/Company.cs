using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    public class Company
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }

        public Company(string name)
        {
            Name = name;
            Departments = new List<Department>();
        }

        public void AddDepartment (string name)
        {
            Departments.Add(new Department(name));
        }

        
    }
}
