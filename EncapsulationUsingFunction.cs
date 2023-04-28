using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class EncapsulationUsingFunction
    {
        // variable make as private so no anyone can assign the value outside of class
        private int id;
        private string name;

        // make method as public
        public void SetData(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void GetData()
        {
            Console.WriteLine("Your id is: "+id);
            Console.WriteLine("Your name is: " + name);

        }


       

    }

}
