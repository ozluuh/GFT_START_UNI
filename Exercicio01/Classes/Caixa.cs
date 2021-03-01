using System;

namespace Exercicio01.Classes
{
    public class Caixa
    {
        public void calcularTotal(Produto[] produtos)
        {
            double valorTotalProdutos = 0;

            Console.WriteLine("Nome,Quantidade,Valor,Total");

            for (int i = 0; i < produtos.Length; i++)
            {
                double valorFinal = produtos[i].calcularValorFinal();

                Console.WriteLine($"{produtos[i]},{string.Format("{0:0,0.00}", valorFinal)}");

                valorTotalProdutos += valorFinal;
            }

            Console.WriteLine($"Total a ser pago: {string.Format("{0:0,0.00}", valorTotalProdutos)}");
        }
    }
}