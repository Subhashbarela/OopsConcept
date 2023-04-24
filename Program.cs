using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    // Base Class
    public class ClassA
    {
        public void BaseClassMethod()
        {
            Console.WriteLine("This Is Base Class Method:..");
        }
    }

    public class Program:ClassA
    {
        public void DeriveClassMethod()
        {
            Console.WriteLine("this is derive class method");
        }

        static void Main(string[] args)
        {
            Program Obj= new Program();
            Obj.BaseClassMethod();
            Obj.DeriveClassMethod();
           
           Console.Read();
        }
    }
}
