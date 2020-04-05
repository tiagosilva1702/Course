using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamentoMemoriaArraysListas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * a variavel deve ser inicializada usando struct
             * O struct pode ser ou não ser declarado, mas é necessário atribuir valor 
             */
            Point p;
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);
            
            // Não é preciso instanciar usando new, mas é possível
            Point p2 = new Point();
            Console.WriteLine(p2);
        }
    }
}
