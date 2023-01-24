using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sa06.Aplicacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Preco, Total=0;
            int Quant;

            Console.WriteLine("Digite a quantidade de aviões da sua frota");
            Quant= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço unitario dos aviões");
            Preco= double.Parse(Console.ReadLine());    

            Total = Quant * Preco;

            Console.WriteLine("O preço total da sua frota é: R$" + Total);
            Console.ReadLine(); 

        }
    }
}
