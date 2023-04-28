using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
   public class Program
    {
       
        static void Main(string[] args)
        { 
            ValueType Obj= new ValueType();
            int a = 5;
            Obj.ValueTypeMethod(a); //15
            Console.WriteLine("value of a in Main Method "+a); //5
           
            // Reference Type
           RefrenceType Obj1 = new RefrenceType();
            int b = 5;  // send reference of this variable
            Obj1.RefTypeMethod(ref b); //15
            Console.WriteLine("value of a in Main Method "+b); // 15

            //Out parameterise
            int c;  // send reference of this variable And no need to initialize value
            Obj1.OutTypeMethod(out c); //10
            Console.WriteLine("value of a in Main Method " + c); // 10

            Console.Read();
        }

    }
}
