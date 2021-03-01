namespace Exercicio04.Classes
{
    public class Circulo : Exercicio04.Interfaces.AreaCalculavel
    {
        private int raio { get; set; }
        private double pi = 3.14;

        public Circulo() { }
        public Circulo(int raio)
        {
            this.raio = raio;
        }
        public double areaCalculavel()
        {
            return pi * System.Math.Pow(raio, 2);
        }
    }
}