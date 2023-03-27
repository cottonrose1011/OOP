using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDll;

namespace MyConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 myDll = new Class1();
            Console.WriteLine(myDll.HelloDll());
        }
    }
}
