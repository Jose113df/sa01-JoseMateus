using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sa07.Aplicacao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Peca1, Peca2, Peca3, Peca4, Peca5, Total = 0;

            Console.WriteLine("Digite o valor da PRIMEIRA peça");
            Peca1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da SEGUNDA peça");
            Peca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da TERCEIRA peça");
            Peca3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da QUARTA peça");
            Peca4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da QUINTA peça");
            Peca5 = int.Parse(Console.ReadLine());

            Total = Peca1 + Peca2 + Peca3 + Peca4 + Peca5;

            Console.WriteLine("O valor total de todas as peças é: R$" + Total);
            Console.ReadLine(); 

        }
    }
}
