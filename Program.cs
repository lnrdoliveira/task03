using System;
using System.Globalization;
using task03;
namespace Controle{
    class Program{
        static void Main(String[] args){
            Produto p = new Produto();

            System.Console.WriteLine("Entre os dados do produto: ");
            System.Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            System.Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados do produto: "+p);
            System.Console.WriteLine("");
            System.Console.Write("Digite a quantidade de produtos a serem adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            System.Console.WriteLine("");
            System.Console.WriteLine("Dados atualizados: "+p);
            System.Console.WriteLine("");
            System.Console.Write("Digite a quantidade de produtos a serem removidos: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            System.Console.WriteLine("Dados atualizados: "+p);


        }
    }
}