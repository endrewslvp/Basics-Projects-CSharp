using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Primos_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NÚMEROS PRIMOS -----\n");
            Console.WriteLine("Este sistema foi desenvolvido para descobrir se um número é primo.\n");
            Console.Write("Insira um número inteiro: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\nResultado: " + primovfy(num));
            Console.ReadLine();
        }
        static string primovfy(int number)
        {
            string resultado = "É primo";

            for (int i = 2;  i < number; i++) 
            {
                if (number % i == 0) resultado = "Não é primo"; break;
            }
            return resultado;
        }
    }
}
