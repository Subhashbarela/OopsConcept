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
            MethodType Obj= new MethodType();
            Obj.NonParameterizeMethod();
            Obj.ParameterizeMethod("subhash");
            StaticMethod();
          

            Console.Read();
        }

    }
}
