using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name"); 
            int num1 = Convert.ToInt32(Console.ReadLine());
             int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("sum " + sum);
            
            Console.ReadKey();
        }
    }
}
