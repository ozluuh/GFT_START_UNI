using System;
using Exercicio01.Classes;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] produtos = new Produto[6];

            produtos[0] = new Eletronico("Ventilador", 3, 320);
            produtos[1] = new Eletronico("Computador", 2, 3999);
            produtos[2] = new Movel("Mesa", 2, 270);
            produtos[3] = new Produto("Caderno", 10, 10.50);
            produtos[4] = new Movel("Cadeira", 2, 234.25);
            produtos[5] = new Produto("Caneta", 15, 0.70);

            Caixa caixa = new Caixa();

            caixa.calcularTotal(produtos);
        }
    }
}
