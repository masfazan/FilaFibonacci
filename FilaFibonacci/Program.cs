using FilaFibonacci;

internal class Program
{
    private static void Main(string[] args)
    {
        FilaFibonacci.Fila filaResult = new Fila();

        int pos, penultimo = -1, atual, ultimo = 1;

        Console.WriteLine("Informe a posição: ");
        pos = int.Parse(Console.ReadLine());

        for (int i = 0; i < pos; i++)
        {
            atual = penultimo + ultimo;
            filaResult.Push(new Fibonacci(atual));//números são adicionados
            penultimo = ultimo;
            ultimo = atual;
        }
        Console.WriteLine("Sequência Fibonacci");
        filaResult.Imprimir();
    }
}
