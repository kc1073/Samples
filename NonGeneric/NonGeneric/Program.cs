using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var caller = new Caller();

            var result1 = caller.CallOp1(10, 5);
            Console.WriteLine("Op1 result is {0}", result1);

            var result2 = caller.CallOp2(10, 5);
            Console.WriteLine("Op2 result is {0}", result2);

            var result3 = caller.CallOp3(10, 5);
            Console.WriteLine("Op3 result is {0}", result3);


        }
    }
}
