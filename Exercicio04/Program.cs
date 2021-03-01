using System;
using Exercicio04.Classes;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(15);
            Quadrado quadrado = new Quadrado(8);
            Retangulo retangulo = new Retangulo(7, 5);

            Console.WriteLine("O cálculo da área é:");
            Console.WriteLine($"Quadrado: {quadrado.areaCalculavel()}");
            Console.WriteLine($"Retângulo: {retangulo.areaCalculavel()}");
            Console.WriteLine($"Círculo: {circulo.areaCalculavel()}");
        }
    }
}
