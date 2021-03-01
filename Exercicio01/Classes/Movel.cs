namespace Exercicio01.Classes
{
    public class Movel : Produto
    {
        public Movel() { }

        public Movel(string nome, int quantidade, double valor)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.valor = valor;
        }
        public override double calcularValorFinal()
        {
            double resultado = this.valor * this.quantidade;
            double imposto = 0.05;

            if (this.quantidade < 10)
            {
                imposto = 0.11;
            }

            double valorImposto = resultado * (imposto / 100);

            return resultado + valorImposto;
        }
    }
}