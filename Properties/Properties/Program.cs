using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark;
        
        //id validation
        public void SetId(int id)
        {
            if(id <= 0)
            {
                throw new Exception("Student id can not be negative"); 
            }
            this._id = id;
        }

        public int GetId()
        {
            return this._id;
        }

        //name validation
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name can not be null or empty");
            }
            this._name = name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._name) ? "field can not be empty" : this._name;
        }

        //pass mark
        public int GetPassMark(int mark)
        {
            return this._passMark = mark;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.SetId(113151558);
            std.SetName("md.enamul haque sarker");
            
         
            Console.WriteLine("Student Id = {0}", std.GetId());
            Console.WriteLine("Student Name = {0}", std.GetName());
            Console.WriteLine("Student Mark = {0}", std.GetPassMark(71));
            Console.ReadKey();
        }
    }
}
