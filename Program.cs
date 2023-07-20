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

            System.Console.WriteLine("Fazer atualização no estoque (1):");
            System.Console.WriteLine("Sair (2)");
            System.Console.Write("Digite aqui: ");
            int Resposta, qte;
            Resposta = int.Parse(Console.ReadLine());

            if (Resposta == 1){
                System.Console.WriteLine("Adicionar (1):");
                System.Console.WriteLine("Remover (2):");
                System.Console.WriteLine("Sair (3): ");
                System.Console.Write("Digite aqui: ");
                int RespostaEstoque;
                RespostaEstoque = int.Parse(Console.ReadLine());
                if(RespostaEstoque == 1){
                    System.Console.Write("Digite a quantidade de produtos a serem adicionados: ");
                    qte = int.Parse(Console.ReadLine());
                    p.AdicionarProdutos(qte);
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Dados atualizados: "+p);
                }
                else if (RespostaEstoque == 2){
                    System.Console.WriteLine("");
                    System.Console.Write("Digite a quantidade de produtos a serem removidos: ");
                    qte = int.Parse(Console.ReadLine());
                    p.RemoverProdutos(qte);
                    System.Console.WriteLine("Dados atualizados: "+p);
                }
                else if (RespostaEstoque == 3 || RespostaEstoque > 3){
                    
                }
            }
            else if (Resposta == 2){
                
            }
        }
    }
}