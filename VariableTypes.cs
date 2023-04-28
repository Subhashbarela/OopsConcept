using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class VariableTypes
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool IsMarride { get; set; }
        public double Heigth { get; set; }

        public void Display()
        {
            Console.WriteLine(" Student Id is: " + id);
            Console.WriteLine(" StudentName is: " + name);
            Console.WriteLine("Student Is Marride : " + IsMarride);
            Console.WriteLine(" Student heigth is: " + Heigth);

        }

        
    }
}
