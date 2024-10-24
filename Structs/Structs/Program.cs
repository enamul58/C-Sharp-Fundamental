using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    //struct
    public struct Customer
    {
        private int _id;
        private string _name;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }

        public Customer(int Id, String Name)
        {
           this._id = Id;
            this._name = Name;
        }

        public void PrintDetailes()
        {
            Console.WriteLine("Id = {0} & Name = {1}", this._id, this._name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer C3 = new Customer
            {
                ID = 113151558,
                Name = "Md.Enamul Haque Sarker",

            };

            C3.PrintDetailes();
            Console.ReadKey();

        }
    }
}
