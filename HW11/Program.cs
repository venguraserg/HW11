using System;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company = AutoInsert();

            Console.ReadKey();
        }

        private static Company AutoInsert()
        {
            Company company = new Company();


            return company;
        }
    }
}
