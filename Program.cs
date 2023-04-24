using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
   

    public class Program
    {
        public void NonParameterizeMethod()
        {
            Console.WriteLine("this is non parameteriase method");
        }
        public void ParameterizeMethod(string name)
        {
            Console.WriteLine("this is  parameteriase method"+ name);
        }
        public static void StaticMethod()
        {
            Console.WriteLine("This is static method");
        }


        static void Main(string[] args)
        { 
            Program Obj= new Program();
            Obj.NonParameterizeMethod();
            Obj.ParameterizeMethod("subhash");
            StaticMethod();
          

            Console.Read();
        }

    }
}
