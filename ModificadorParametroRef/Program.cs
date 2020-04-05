using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorParametroRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            Console.WriteLine();
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
