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

        }
    }
}