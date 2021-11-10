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
        public Employee Boss { get; set; }
        public List<Department> Departments { get; set; }

        public Company()
        {

        }

        public Company(string name)
        {
            Name = name;
            Boss = new Employee();
            Departments = new List<Department>();
        }

        public void AddEmployee(string fitstName, string lastName, string position, string phoneNumber, string passportNumber, Department department)
        {
            Employee newEmployee = new Employee(fitstName, lastName, position, phoneNumber, passportNumber);
            int index = GetDepartmentListIndex(department);
            this.Departments[index].Employees.Add(newEmployee);
        }

        private int GetDepartmentListIndex(Department department)
        {
            return this.Departments.IndexOf(department);
        }
    }
}
