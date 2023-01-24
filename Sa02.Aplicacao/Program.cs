using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sa02.Aplicacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AnoAtual, Subtracao = 0;

            Console.WriteLine("Digite o ano atual: ");
            AnoAtual = int.Parse(Console.ReadLine());

            Subtracao = 1968 - AnoAtual ;

            Console.WriteLine("O valor da subtração é: "+Subtracao);
            Console.ReadLine(); 
        }
    }
}
