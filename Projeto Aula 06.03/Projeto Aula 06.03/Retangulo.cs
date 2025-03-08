using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aula_06._03
{
    internal class Retangulo
    {

        public Retangulo() { }
        public Retangulo(int id) { }
        public Retangulo(int id, double largura, double altura)
        {
            Id = id;
            Largura = largura;
            Altura = altura;
        }


        public int Id;
        public double Largura;
        public double Altura;

    }
}
