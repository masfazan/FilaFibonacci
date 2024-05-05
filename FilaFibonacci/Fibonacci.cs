
namespace FilaFibonacci
{
    internal class Fibonacci
    {
        public int numero;
        public Fibonacci proximo;

        public Fibonacci(int numero)
        {
            this.numero = numero; // Correção: atribuição correta do valor ao atributo
            proximo = null;
        }


        public void setNext(Fibonacci aux)
        {
            this.proximo = aux;
        }

        public Fibonacci getNext()
        {
            return this.proximo;
        }
        public override string? ToString()
        {
            return this.numero.ToString();
        }

    }
}

