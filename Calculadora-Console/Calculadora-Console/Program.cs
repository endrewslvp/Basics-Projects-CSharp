using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA -----\n");
            Console.WriteLine("Este sistema foi criado para realizar cálculos simples, envolvendo dois números.\n");
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIndique qual operação deseja realizar");
            Console.Write("\n1.Soma\n2.Subtração\n3.Multiplicação\n4.Divisão\n\n= ");
            char op = char.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (op)
            {
                case '1':
                    Console.WriteLine($"A soma entre {num1} e {num2} é {num1 + num2}");
                    break;
                case '2':
                    Console.WriteLine($"A subtração entre {num1} e {num2} é {num1-num2}");
                    break;
                case '3':
                    Console.WriteLine($"A multiplicação entre {num1} e {num2} é {num1*num2}");
                    break;
                case '4':
                    float numf1 = num1,numf2 = num2;
                    Console.WriteLine($"A divisão entre {num1} e {num2} é {numf1/numf2}");
                    break;
                default:
                    Console.WriteLine("Insira uma opção válida.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
