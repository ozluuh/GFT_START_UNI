namespace Exercicio04.Classes
{
    public class Retangulo : Exercicio04.Interfaces.AreaCalculavel
    {
        private double largura { get; set; }

        private double altura { get; set; }

        public Retangulo() { }
        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }
        public double areaCalculavel()
        {
            return this.largura * this.altura;
        }
    }
}