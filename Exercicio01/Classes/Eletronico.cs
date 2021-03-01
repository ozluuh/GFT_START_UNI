namespace Exercicio01.Classes
{
    public class Eletronico : Produto
    {
        public Eletronico() { }

        public Eletronico(string nome, int quantidade, double valor)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.valor = valor;
        }
        public override double calcularValorFinal()
        {
            double resultado = this.valor * this.quantidade;
            double valorImposto = resultado * 0.15;

            return resultado + valorImposto;
        }
    }
}