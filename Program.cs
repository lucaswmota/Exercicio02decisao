using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02Decisao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe a quantidade comprada: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor unitario: ");
            double valorUnitario = double.Parse(Console.ReadLine());

            double valor = quantidade * valorUnitario;

            if (quantidade > 100)
            {
                Console.Write("Informe o % de desconto: ");
                double desconto = double.Parse(Console.ReadLine());               

                valor -= valor * (desconto / 100);

                Console.WriteLine("O Valor total da compra com desconto é de: " + valor.ToString("C"));
            }
            else
            {
                Console.WriteLine("O Valor total da compra sem desconto é de: " + valor.ToString("C"));
            }

            Console.ReadKey();
        }
    }
}
