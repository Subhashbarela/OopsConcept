using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class ValueType
    {
        // this created seperate memory block for storing value
        public void ValueTypeMethod(int a) 
        {
            a += 10;
            Console.WriteLine(" value of a is:" + a);
        }
     }       
       
    }
