using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnSettableInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tConstructing MyClass c");
            MyClass c = new MyClass();
            Console.WriteLine("\n\t\tTest1: Assign value 14");
            c.Count = 14;
            Console.WriteLine("\n\t\tTest2: operator++ to yield 15");
            c.Count++;

            Console.WriteLine("");
        }
    }
}
