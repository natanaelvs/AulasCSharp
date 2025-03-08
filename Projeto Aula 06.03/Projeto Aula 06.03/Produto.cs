using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aula_06._03
{
    internal class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }

        public double getTotalAmonunt()
        {
            return Preco * Quantidade;

        }

        public string getDetailProduct()
        {
            return Nome + ", $" + Preco + ", " + Quantidade + " unidades, Total: $" + getTotalAmonunt();
        }
    }
}
