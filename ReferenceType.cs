using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{      
    }
    public class ReferenceType
    {
        // this argument access address  for storing value
        public void ReferIntVariable(ref int a) 
        {
            a += 10;
            Console.WriteLine(" value of a is:" + a);
        }
        // this variable access address  for storing value
        public void OutTypeMethod(out string str)
        {
            str = "BridgeLebs";
            Console.WriteLine(" string is:" + str);
        }
    }
}
