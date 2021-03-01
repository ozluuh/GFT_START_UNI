using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe intervalo Inicial:");
            int intervaloInicial = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe intervalo Final:");
            int intervaloFinal = Int32.Parse(Console.ReadLine());

            int intervalo = intervaloFinal - intervaloInicial;

            if (intervalo <= 15)
            {
                for (int i = intervaloInicial; i <= intervaloFinal; i++)
                {
                    Console.WriteLine($"Cubo de {i} = {Math.Pow(i, 3)}");
                }
            }
            else
            {
                Console.WriteLine("Fim da execução, intervalo não pode ser superior a 15");
                Console.WriteLine($"Intervalo atual é {intervalo}");
            }

        }
    }
}
