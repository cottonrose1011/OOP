using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.Print();

            Child c = (Child)p;
            c.Print();
        }
    }
    class Parent
    {
        public virtual void Print()
        {
            Console.WriteLine("Parent");
        }
    }

    class Child : Parent
    {
        public override void Print()
        {
            Console.WriteLine("Child");
        }
    }

}
