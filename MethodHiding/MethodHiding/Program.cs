using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{

    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }


    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Contractor");
        }
    }

    public class FullTimeEmployee : Employee
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee pte = new PartTimeEmployee();
            pte.FirstName = "Md.Enamul";
            pte.LastName = "Haque Sarker";
            pte.PrintFullName();

            FullTimeEmployee fte  = new FullTimeEmployee();
            fte.FirstName = "Enamul";
            fte.LastName = "limon";
            fte.PrintFullName();
            Console.ReadKey();
        }
        
    }
}
