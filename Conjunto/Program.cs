using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashSet é um conjunto e não permite que a lista tenha elementos repetidos
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();

            a.Add(3);
            a.Add(4);
            a.Add(5);
            a.Add(6);

            b.Add(3);
            b.Add(7);
            b.Add(9);

            Console.WriteLine("Digite um valor inteiro: ");
            int c = int.Parse(Console.ReadLine());

            if (a.Contains(c))
                Console.WriteLine(c + " pertence ao conjunto");
            else
                Console.WriteLine(c + " não pertence ao conjunto");

            b.Remove(3);

            //Diferença
            a.ExceptWith(b);

            //União
            a.UnionWith(b);

            //Intersecção
            a.IntersectWith(b);


            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
