using System;


class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
           int sum = p.Add(20, 20);
           Console.WriteLine(sum);
           
            Program.EvenNumber(30);
            Console.ReadKey();
        }

        public int Add(int num1, int num2 )
        {
            return num1 + num2;
        }
       
        public static void EvenNumber(int range)
        {
            int start = 0;
            while( start <= range)
            {
                Console.WriteLine(start);
                start = start + 2; 
            }
        }

    }

