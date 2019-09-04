using System;
using System.Collections.Generic;
using System.Globalization;
using ListaProdutos.Entidades;

namespace ListaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Etiquetas de Preço");
            Console.WriteLine();

            List<Produtos> Lista = new List<Produtos>();

            Console.Write("Informe a quantidade de produtos cadastrados: ");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= q; i++)
            {
                Console.Write($"Informações do {i}º Produto!");
                Console.WriteLine();
                Console.Write("Informe o tipo de produto (Comum; Usado; Importado): ");
                string produto = Console.ReadLine();
                Console.Write("Nome do Produto: ");
                string nome = Console.ReadLine();
                Console.Write("Valor: ");
                double preco = double.Parse(Console.ReadLine());
                if(produto == "Comum")
                {
                    Lista.Add(new Produtos(nome, preco));
                    Console.WriteLine();
                }
                else if(produto == "Usado")
                {
                    Console.Write("Informe a data de fabricação: ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    Lista.Add(new ProdutosUsados(nome, preco, data));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Valor da taxa de importação: ");
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Lista.Add(new ProdutosImportados(nome, preco, taxa));
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Produtos Etiquetados");
            foreach (Produtos prod in Lista)
            {
                Console.WriteLine(prod.Etiqueta());
            }
        }
    }
}
