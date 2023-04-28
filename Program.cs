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
            Program Obj= new Program();
            Obj.NonParameterizeMethod();
            Obj.ParameterizeMethod("subhash");
            StaticMethod();
          

            Console.Read();
        }

    }
}
