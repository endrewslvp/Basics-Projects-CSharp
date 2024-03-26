using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC_v2
{
    internal class Pessoa
    {
        public double weight;
        public double height;

        public double imc()
        {
            return Math.Round(weight / Math.Pow(height, 2),2);
        }

        public string status()
        {
            if (imc() < 18.5) return "Abaixo do peso";
            else if (imc() < 25) return "Peso normal";
            else if (imc() < 30) return "Acima do peso";
            else if (imc() < 35) return "Obesidade I";
            else if (imc() < 40) return "Obesidade II";
            else return "Obesidade III";
        }

        public void message()
        {
            Console.WriteLine("Seu IMC é: "+imc());
            Console.WriteLine("Resultado: "+status());
        }
    }
}
