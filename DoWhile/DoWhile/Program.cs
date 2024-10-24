using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Please Enter your target");
        string userChoice = " ";  
       do{
           int userTaget = int.Parse(Console.ReadLine());
           int i = 0;
           while( i <= userTaget)
            {
                Console.Write(i + " ");
                i += 2;
            }
         do
         {
             Console.WriteLine("\nDo you want to continue - Yes or No");
             userChoice = Console.ReadLine();
             if (userChoice != "yes" && userChoice != "no")
             {
                 Console.Write("Invaild choice Enter Yes or No");
             }
         } while (userChoice != "yes" && userChoice != "no");
        } while(userChoice == "yes");
           
         Console.ReadKey();
        }
    }
}
