using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class EncapsulatioUsinProperty
    {
        private int id=102;
        private string name;         
        public int ID
        {
      private set {}       // set private so no anyone can assign value from other class
              get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        } 
    }
}
