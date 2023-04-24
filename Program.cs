using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing...");
        }
    }
    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
        public class Program
        {


            static void Main(string[] args)
            {
                Shape s= new Shape();
                s.draw();
                s = new Rectangle();
                s.draw();
                s = new Circle();
                s.draw();

                Console.Read();
            }
        }
    
}
