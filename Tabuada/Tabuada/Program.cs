using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABUADA -----\n");
            Console.WriteLine("Este sistema é responsável por gerar a tabuada de um valor inserido pelo usuário.\n");
            Console.Write("Insira um número: ");
            float num = float.Parse(Console.ReadLine());
            Console.WriteLine();
            multtable(num);
            Console.ReadLine(); 
        }
        static void multtable (float num)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
