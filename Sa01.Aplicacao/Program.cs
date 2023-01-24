using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sa01.Aplicacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Aviao1, Aviao2, Somar = 0;

            Console.WriteLine("Digite o valor do PRIMEIRO avião: ");
            aviao1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do SEGUNDO avião: ");
            Aviao2 = double.Parse(Console.ReadLine());

            Somar = Aviao1 + Aviao2;

            Console.WriteLine("A soma dos precos doas aviões são: " + Somar);
            Console.ReadLine(); 

        }
    }
}
