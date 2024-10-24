using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int TotalCoffeCost = 0;
            Start:
            Console.WriteLine("1-Small, 2-Medium, 3-Large");
            int selectItem = int.Parse(Console.ReadLine());

            switch(selectItem)
            {
                case 1:
                    TotalCoffeCost += 1;
                    break;
                case 2:
                    TotalCoffeCost += 2;
                    break;
                case 3:
                    TotalCoffeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your choie {0} is invalid", selectItem);
                    goto Start;
            }
          
            Decide:
            Console.WriteLine("Do You want to buy another coffe Yes - No?");
            string answer =  Console.ReadLine();
            switch(answer.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("your choice is {0} invaild", answer);
                    goto Decide;
            }

            Console.WriteLine("Thank you for shopping us");
            Console.WriteLine("Total Shooping Cost {0}", TotalCoffeCost);
            
            Console.ReadKey();
        }
    }
}
