namespace Exercicio01.Classes
{
    public class Produto
    {
        protected string nome { get; set; }
        protected double valor { get; set; }
        protected int quantidade { get; set; }

        public override string ToString()
        {
            return this.nome + "," + this.quantidade + "," + this.valor;
        }

        public Produto() { }

        public Produto(string nome, int quantidade, double valor)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.valor = valor;
        }

        public double calcularValorFinal()
        {
            double resultado = this.valor * this.quantidade;
            double valorImposto = resultado * (10 / 100);

            return resultado + valorImposto;
        }
    }
}