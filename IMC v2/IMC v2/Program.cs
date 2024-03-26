using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            Console.WriteLine("Bem-vindo(a) ao sistema IMC.");
            Console.Write("Insira seu peso em kilogramas (Kg): ");
            obj.weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira sua altura em metros: ");
            obj.height = Convert.ToDouble(Console.ReadLine());
            obj.message();
        }
    }
}
