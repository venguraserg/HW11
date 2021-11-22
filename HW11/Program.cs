using System;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("MyCompany");

            for(int i =0; i<10; i++)
            {
                company.AddDepartment($"dep_{i}");

            }

            for (int i = 0; i < 10; i++)
            {
                company.Departments[0].AddDep(new Department($"dep_{i}_{i}"));

            }
            
            Console.ReadKey();

        }

        
    }
}
