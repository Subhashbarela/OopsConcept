using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    // class is templete of pragram it is used for data cotegorise entitise.
    //class is just blueprint or it is not real world entity.
    // class contain field and method and it is not accupies memory space
    public class Program
    {
       public int id;
        public string name;
        public void SetData(int id,string name)
        {
            this.id=id;
            this.name=name;
        }
        public void GetData()
        {
         Console.WriteLine("name is: "+name);
             Console.WriteLine("id is: "+id);
        }
        static void Main(string[] args)
        {
            //object is instance of the class in one class we can create more than one object.
            //object is real world entity and it hold memory space.
            //object have behaviour and state.
            Program obj=new Program();
            obj.SetData(101,"subhash");
            obj.GetData();
            
           // ClassName name= new ClassName();
           // name.MethodName();
          
            Console.Read();
        }
    }
}
