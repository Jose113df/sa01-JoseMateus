using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sa05.Aplicacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double PrimeiroT, SegundoT, TerceiroT, media = 0;
            Console.WriteLine("Digite o faturamento do PRIMEIRO trimestre: ");
            PrimeiroT = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o faturamento do SEGUNDO trimestre: ");
            SegundoT = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o faturamento do TERCEIRO trimestre: ");
            TerceiroT = double.Parse(Console.ReadLine());

            media = (PrimeiroT + SegundoT + TerceiroT) / 3;

            Console.WriteLine("A media do faturamentro trimestral é: "+media);
            Console.ReadLine(); 

        }
    }
}
