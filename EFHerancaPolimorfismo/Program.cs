using System;
using System.Globalization;
using System.Collections.Generic;
using EFHerancaPolimorfismo.Entidades;


namespace EFHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();
            Console.Write("Informe o número de produtos: ");
            int numeroProduto = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroProduto; i++)
            {
                Console.WriteLine($"Dados do produto #{i}:");
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipo == 'c')
                {
                    lista.Add(new Produto(nome, preco));
                }
                if (tipo == 'u')
                {
                    Console.WriteLine("Data da fabricação (DD/MM/AAAA: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                }

                

            }
        }
    }
}
