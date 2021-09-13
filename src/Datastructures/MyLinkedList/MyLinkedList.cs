using System;

namespace AD
{
    public partial class MyLinkedList<T> : IMyLinkedList<T>
    {
        public MyLinkedListNode<T> first;
        private int size;

        public MyLinkedList()
        {
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
            if (size > 0)
            {
                return first.data;
            }

            throw new MyLinkedListEmptyException();
        }

        public void RemoveFirst()
        {
            if (size > 0)
            {
                first = first.next;
                size--;
            }
            else
            {
                throw new MyLinkedListEmptyException();
            }
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
            if (index == 0)
            {
                AddFirst(data);
            }
            else
            {
                if (index > -1 && index <= size)
                {
                    MyLinkedListNode<T> loopNode = new MyLinkedListNode<T>();
                    loopNode = first;
                    for (int i = 0; i < size; i++)
                    {
                        if (i == index - 1)
                        {
                            MyLinkedListNode<T> newNode = new MyLinkedListNode<T>();
                            newNode.next = loopNode.next;
                            newNode.data = data;
                            loopNode.next = newNode;
                            size++;
                            break;
                        }
                        loopNode = loopNode.next;
                    }
                }
                else
                {
                    throw new MyLinkedListIndexOutOfRangeException();
                }
            }
        }

        public override string ToString()
        {
            if (size == 0)
            {
                return "NIL";
            }

            string text = "[";
            MyLinkedListNode<T> node = first;
            for (int i = 0; i < size; i++)
            {
                text += node.data.ToString();
                if (i != size - 1 && size != 1)
                {
                    text += ",";
                }

                node = node.next;
            }

            text += "]";
            return text;
        }
    }
}