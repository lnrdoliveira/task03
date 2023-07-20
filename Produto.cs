using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task03
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque(){
            return Preco*Quantidade;
        }
        public void AdicionarProdutos(){
            
        }
        public void RemoverProdutos(){

        }
    }
}