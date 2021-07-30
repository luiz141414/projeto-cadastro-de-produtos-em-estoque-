using System;
using System.Globalization;
using treinamento;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("preco: ");
            p.preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto "+ p );

            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de produtos a ser adicionado no estoque");
            int qte = int.Parse(Console.ReadLine());//o que for digitado sera armazenado na variavel qte

            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados"+p);

            Console.WriteLine("Digite a quantidade de produtos a ser removido do estoque");
             qte = int.Parse(Console.ReadLine());//o que for digitado sera armazenado na variavel qte

            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados" + p);
        }
    }
}

