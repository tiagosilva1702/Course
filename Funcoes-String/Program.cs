using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper(); //converte tudo para maiusculo
            string s2 = original.ToLower(); //converte tudo para minusculo
            string s3 = original.Trim(); //Pagar o espaço em branco
            int n1 = original.IndexOf("bc"); //busca a posição com a primeira ocorrência 
            int n2 = original.LastIndexOf("bc"); //busca a posição com a última ocorrência 
            string s4 = original.Substring(3); //recorta a partir da posição
            string s5 = original.Substring(3, 5); //inicia na posiçao e quantidade
            string s6 = original.Replace('a', 'x'); //substituir 
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original); //Testa se a string esta vazia (null or "" vazio)
            bool b2 = String.IsNullOrWhiteSpace(original); //Testa se a variavel é null ou somente com espaço vazio

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
