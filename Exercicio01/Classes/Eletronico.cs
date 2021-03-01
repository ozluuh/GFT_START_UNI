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
        public new double calcularValorFinal()
        {
            double resultado = this.valor * this.quantidade;
            double valorImposto = resultado * (15 / 100);

            return resultado + valorImposto;
        }
    }
}