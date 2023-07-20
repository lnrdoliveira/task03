using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
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

        public override string ToString(){
            return Nome.ToUpper() +", $"+Preco.ToString("F2", CultureInfo.InvariantCulture)+", "+Quantidade+" unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}