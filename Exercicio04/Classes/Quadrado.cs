namespace Exercicio04.Classes
{
    public class Quadrado : Exercicio04.Interfaces.AreaCalculavel
    {
        private double lado { get; set; }

        public Quadrado() { }

        public Quadrado(double lado)
        {
            this.lado = lado;
        }
        public double areaCalculavel()
        {
            return this.lado * this.lado;
        }
    }
}