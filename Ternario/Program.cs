using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ternario
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto;
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else{
                desconto = preco * 0.05;
            }

            //Ternario
            // ? true : False
            desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;


            Console.WriteLine(desconto) ;
        }
    }
}
