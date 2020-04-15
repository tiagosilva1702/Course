using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15); //ano, mes, dia
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58); //ano, mes, dia, hora, minuto, segundo
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275); //ano, mes, dia, hora, minuto, segundo, milissegundo
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            d1 = DateTime.Now;
            d2 = DateTime.UtcNow; //horário universal
            d3 = DateTime.Today;
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            //- Parse
            d1 = DateTime.Parse("2000-08-15");
            d2 = DateTime.Parse("2000-08-15 13:05:58");
            d3 = DateTime.Parse("15/08/2000");
            DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            //Demo - ParseExact
            d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}
