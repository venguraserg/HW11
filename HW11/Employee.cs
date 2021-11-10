using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    public class Employee
    {
        public Guid IdEmployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportNumber { get; set; }
        //public Department Department { get; set; }

        public Employee()
        {

        }

        public Employee(string fitstName, string lastName, string position, string phoneNumber, string passportNumber)
        {
            this.IdEmployee = Guid.NewGuid();
            this.FirstName = fitstName;
            this.LastName = lastName;
            this.Position = position;
            this.PhoneNumber = phoneNumber;
            this.PassportNumber = passportNumber;
            //this.Department = department;
        }

    }
}
