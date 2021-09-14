namespace AD
{
    public partial class MyStack<T> : IMyStack<T>
    {
        public MyLinkedList<T> stack = new MyLinkedList<T>();

        public bool IsEmpty()
        {
            return stack.Size() == 0;
        }

        public T Pop()
        {
            if (stack.Size() <= 0) throw new MyStackEmptyException();
            var popped = Top();
            stack.RemoveFirst();
            return popped;

        }

        public void Push(T data)
        {
            stack.AddFirst(data);
        }

        public T Top()
        {
            if (stack.Size() > 0)
            {
                return stack.GetFirst();
            }
            throw new MyStackEmptyException();
            
        }
    }
}