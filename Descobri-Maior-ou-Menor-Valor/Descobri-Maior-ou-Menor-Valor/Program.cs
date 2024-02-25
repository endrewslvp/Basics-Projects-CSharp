using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descobrir_Maior_e_Menor_Valor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DESCOBRIR MENOR E MAIOR VALOR -----\n");
            Console.WriteLine("Este sistema foi construído para encontrar o maior e menor entre dois valores.\n");
            Console.Write("Insira o primerio valor: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Insira o segundo valor: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nMenor: " + Math.Min(num1, num2));
            Console.WriteLine("Maior: "+Math.Max(num1, num2));
            Console.ReadLine();
        }
    }
}
