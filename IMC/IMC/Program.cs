using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMC -----\n");
            Console.WriteLine("Este sistema é responsável por analisar seu Índice de Massa Corpórea.\n");
            Console.Write("Insira seu peso em kg: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Insira sua altura em metros: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("\nResultado: "+imcresult(imcsolve(weight,height)));
            Console.WriteLine();
            weightneed(weight,height);
            Console.ReadLine();
        }
        static double imcsolve (double weight,double height)
        {
            double imc = weight / Math.Pow(height, 2);
            return imc;
        }

        static string imcresult (double imc)
        {
            string resultado;
            if (imc <= 18.5) resultado = "Abaixo do peso";
            else if (imc <= 24.9) resultado = "Peso normal";
            else if (imc <= 29.9) resultado = "Sobrepeso";
            else if (imc <= 34.9) resultado = "Obesidade Grau I";
            else if (imc <= 39.9) resultado = "Obesidade Grau II";
            else resultado = "Obesidade Grau III";
            return resultado;
        }

        static void weightneed (double weight, double height)
        {
          
            double weightncry, imc = imcsolve(weight, height);
            weightncry = Math.Pow(height, 2) * 21.75;
            weightncry = Math.Round(weightncry);

            if (imc>24.9)
            {
                Console.WriteLine($"Peso ideal: {weightncry}kg");
                Console.WriteLine($"Recomendação: deverá perder {weight-weightncry}kg");
            }
            else if (imc < 18.6)
            {
                Console.WriteLine($"Peso ideal: {weightncry}kg");
                Console.WriteLine($"Recomendação: deverá ganhar {weightncry - weight}kg");
            }
            else
            {
                Console.WriteLine("Parabéns! Seu IMC está dentro dos conformes.");
            }
        }
    }
}
