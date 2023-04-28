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
           ClassName name = new ClassName();
            // name.MethodName();
            // name.paramiterizeMethod("Subhash Barela");

            // ReturnType rtype= new ReturnType();
            //rtype.MethodType(1);
            //int val=Obj.IntMethodType(4,5);
            //Console.WriteLine(val);
            //Console.WriteLine(rtype.DoubleMethodType(4.5,6.7));
            //Console.WriteLine(rtype.StringMethodType());
            //Console.WriteLine(rtype.BoolMethodType(10));

            VariableTypes vr= new VariableTypes();
            vr.id = 102;
            vr.name = "Subhash";
            vr.IsMarride = false;
            vr.Heigth = 6.64;
            vr.Display();
        }

    }
}
