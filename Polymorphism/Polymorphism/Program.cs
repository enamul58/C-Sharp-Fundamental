using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Employee
    {
        public string FirstName = "Md.Enamul Haque";
        public string LastName = "Sarker";

        public void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    class PartTimeEmployee : Employee
    {
        public void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "Part time employee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[2];
            employee[0] = new Employee();
            employee[1] = new PartTimeEmployee();

            foreach(Employee emp in employee)
            {
                Console.WriteLine("loop");
                emp.FullName();
            }
            Console.ReadKey();
        }
    }
}
