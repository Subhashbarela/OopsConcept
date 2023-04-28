using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
   
    // Derive class 2
    public class Program:ClassB
    {
        public void DeriveClassTwoMethod()
        {
            Console.WriteLine("this is Second derive class method");
        }

        static void Main(string[] args)
        {
            Program Obj= new Program();
            Obj.BaseClassMethod(); // Base Class Method
            Obj.DeriveClassOneMethod(); // Derive Class Method

            Obj.DeriveClassTwoMethod();


           Console.Read();
        }
    }
}
