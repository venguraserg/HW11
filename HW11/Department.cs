using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Department> Departments { get; set; }

        //public int _nestingLevel;

        public Department()
        {

        }
        public Department(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Employees = new List<Employee>();
            Departments = new List<Department>();
        }

        public void AddDep (Department dep)
        {
            Departments.Add(dep);
        }


    }
}
