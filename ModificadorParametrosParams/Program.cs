using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorParametrosParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = Calculator.Sum(3, 4, 6);
            Console.WriteLine(soma);
        }
    }
}
