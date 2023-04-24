using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    class Student
    {
        private int id;
        private string name;
        // Creating setter and getter for each property  
        public int ID {

            set { id = value; }
            get { return id; }
             }
        public string Name {
            set { name = value; }
            get { return name; }
             }
       
    }

    public class Program

    {
        static void Main(string[] args)
        {
            Student student = new Student();
            // Setting values to the properties  
            student.ID = 101;
            student.Name = "Mohan Ram";
           
            // getting values  
            Console.WriteLine("ID = " + student.ID);
            Console.WriteLine("Name = " + student.Name);
           
            Console.Read();
        }

    }
}
