using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamento
{
    class Produto
    {
        public string Nome;
        public double preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return preco * Quantidade;
        }
        public void AdicionarProdutos(int qte)//no parentereses sera armazenado o valor que é passado lá no console.readline
        {
            Quantidade += qte;
        }
        public void RemoverProdutos(int qte)//no parentereses sera armazenado o valor que é passado lá no console.readline
        {
            Quantidade -= qte;
        }
        public override string ToString()
        {
            return "Nome do produto: " 
                + Nome + " $ "
                + preco + ", "               
                + Quantidade + " Unidades "
                + " Valor total em estoque de produtos "
                + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
