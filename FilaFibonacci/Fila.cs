
namespace FilaFibonacci
{
    internal class Fila
    {
        Fibonacci head;
        Fibonacci tail;
        public Fila()
        {
            this.head = null;
            this.tail = null;
        }
        public bool FilaVazia() 
        {
            return head == null && tail == null; 
        }

        public void Push(Fibonacci aux) 
        {
            if (FilaVazia()) 
            {
                head = tail = aux;
            }
            else
            {
                tail.setNext(aux); 
                tail = aux; 
            }
        }
        public void Imprimir()
        {

            if (!FilaVazia())
            {
                Fibonacci aux = head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getNext();
                } while (aux != null);
               
   
            }
            else
            {
                Console.WriteLine("Fila vazia!");

            }
        }
    }
}
