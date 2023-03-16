using System;
using Course;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Product prod1;
            prod1 = new Product();

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            prod1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            prod1.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            prod1.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dados dos produtos: \n {prod1}");
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque");
            int qtd = int.Parse(Console.ReadLine());
            prod1.AdicionarProdutos(qtd);
            Console.WriteLine(prod1);
            Console.WriteLine("Digite o número de produtos a ser retirado do estoque");
            int qtdTirar = int.Parse(Console.ReadLine());
            prod1.RemoverProdutos(qtdTirar);
            Console.WriteLine(prod1);
        }
    }
}