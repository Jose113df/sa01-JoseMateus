using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sa03.Aplicacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int QuantAviao, multiplicacao=0;

            Console.WriteLine("Qual a quantidade de aviões? ");
            QuantAviao=int.Parse(Console.ReadLine());

            multiplicacao = 17 * QuantAviao;
            Console.WriteLine("Total de assentos: " + multiplicacao);
            Console.ReadLine(); 
        }
    }
}
