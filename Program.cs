using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
   public class Program
    {
        public void ValueTypeMethod(int a) // this created seperate memory block for storing value
        {
            a += 10;
            Console.WriteLine(" value of a is:"+a);
        }
        public void RefTypeMethod( ref int a) // this variable access address  for storing value
        {
            a += 10;
            Console.WriteLine(" value of a is:" + a);
        }
        public void OutTypeMethod(out int a) // this variable access address  for storing value
        {
            a = 10;
            Console.WriteLine(" value of a is:" + a);
        }





        static void Main(string[] args)
        { 
            Program Obj= new Program();
            int a = 5;
            Obj.ValueTypeMethod(a); //15
            Console.WriteLine("value of a in Main Method "+a); //5
           
            // Reference Type
            int b = 5;  // send reference of this variable
            Obj.RefTypeMethod(ref b); //15
            Console.WriteLine("value of a in Main Method "+b); // 15

            //Out parameterise
            int c;  // send reference of this variable And no need to initialize value
            Obj.OutTypeMethod(out c); //10
            Console.WriteLine("value of a in Main Method " + c); // 10

            Console.Read();
        }

    }
}
