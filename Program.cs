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
    // Derive class 1
    public class ClassB:ClassA
    {
        public void DeriveClassOneMethod()
        {
            Console.WriteLine("This Is derive Class Method:..");
        }
    }
    // Derive class 2
    public class Program:ClassA
    {
        public void DeriveClassTwoMethod()
        {
            Console.WriteLine("this is Second derive class method");
        }

        static void Main(string[] args)
        {
            Program Obj= new Program();
            Obj.BaseClassMethod(); // Base Class Method          
            Obj.DeriveClassTwoMethod();

            ClassB ObjB= new ClassB();
            ObjB.BaseClassMethod();
            ObjB.DeriveClassOneMethod(); // Derive Class Method


            Console.Read();
        }
    }
}
