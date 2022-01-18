namespace LinkedList
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;
        public Node(T cData)
        {
            this.Data = cData;
        }
    }
}
/*
estrutura da linked list:

        head
       //  \\
    null    atual
           //  \\
        data   queijo
               //  \\
            data    next
                   //  \\
                data    next
*/