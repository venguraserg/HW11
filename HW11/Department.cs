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
        public Department NestedDepartment { get; set; }
        public int _countNestedDepartment;

        public Department()
        {

        }

        
    }
}
