namespace AD
{
    public partial class MyLinkedList<T> : IMyLinkedList<T>
    {
        public MyLinkedListNode<T> first;
        private int size;

        public MyLinkedList()
        {
            first = new MyLinkedListNode<T>();
        }

        public void AddFirst(T data)
        {
            MyLinkedListNode<T> newNode = new MyLinkedListNode<T>();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
            size++;
        }

        public T GetFirst()
        {
            return first.data;
        }

        public void RemoveFirst()
        {
            first.next = null;
            size--;
        }

        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            size = 0;
        }

        public void Insert(int index, T data)
        {
            MyLinkedListNode<T> newNode = new MyLinkedListNode<T>(); 
            MyLinkedListNode<T> loopNode = new MyLinkedListNode<T>();
            loopNode = first;
            for (int i = 0; i < size; i++)
            {
                loopNode = loopNode.next;
                if (i == index)
                {
                    
                }
            }
        }

        public override string ToString()
        {
            // Write implementation here
            throw new System.NotImplementedException();
        }
    }
}