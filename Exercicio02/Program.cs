using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 215; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
