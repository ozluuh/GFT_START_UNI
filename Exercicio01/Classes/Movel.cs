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
        public new double calcularValorFinal()
        {
            double resultado = this.valor * this.quantidade;
            int imposto = 5;

            if (this.quantidade < 10)
            {
                imposto = 11;
            }

            double valorImposto = resultado * (imposto / 100);

            return resultado + valorImposto;
        }
    }
}