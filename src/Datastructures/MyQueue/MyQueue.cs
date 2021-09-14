using System.Collections.Generic;

namespace AD
{
    public partial class MyQueue<T> : IMyQueue<T>
    {
        public MyLinkedList<T> queue = new MyLinkedList<T>();
        public int size;

        public bool IsEmpty()
        {
            return queue.Size() == 0;
        }

        public void Enqueue(T data)
        {
            queue.Insert(queue.Size(), data);
        }

        public T GetFront()
        {
            if (queue.Size() > 0)
            {
                return queue.GetFirst();
            }

            throw new MyQueueEmptyException();
        }

        public T Dequeue()
        {
            if (queue.Size() <= 0) throw new MyQueueEmptyException();

            var Dequeued = GetFront();
            queue.RemoveFirst();
            return Dequeued;

        }

        public void Clear()
        {
            size = 0;
        }
    }
}