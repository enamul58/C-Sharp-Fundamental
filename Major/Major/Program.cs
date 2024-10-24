using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Major
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? areYouMajor = true;
            
            if(areYouMajor == true)
            {
                Console.WriteLine("are you major ture");
            }
            else if(areYouMajor == false)
            {
                Console.WriteLine("are you major false");
            }
            else
            {
                Console.WriteLine("user id did not answer the question");
            }
            Console.ReadKey();
                
        }
    }
}
