using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Callee;

namespace Caller
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte[] calcs = new Byte[10];
            UInt64[] fil_size = new UInt64[10];
            String[] files = new String[1];
            files[0] = "file1";

            Class1.process_these_files(1, files, calcs, fil_size);

        }
    }
}
