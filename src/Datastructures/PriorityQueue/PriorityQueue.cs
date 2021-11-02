using System;


namespace AD
{
    public partial class PriorityQueue<T> : IPriorityQueue<T>
        where T : IComparable<T>
    {
        public static int DEFAULT_CAPACITY = 100;
        public int size;   // Number of elements in heap
        public T[] array;  // The heap array

        //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------
        public PriorityQueue()
        {
            array = new T[DEFAULT_CAPACITY];
        }

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------
        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            size = 0;
        }

        public void Add(T x)
        {
            int hole = ++size;
            if (size == array.Length)
            {
                DoubleArray();
            }
            
            array[0] = x;
            for (;x.CompareTo(array[hole / 2]) < 0; hole /= 2)
            {
                array[hole] = array[hole / 2];
            }

            array[hole] = x;
        }

        public void DoubleArray()
        {
            T[] newArray = new T[array.Length * 2];
            for (var i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }

        // Removes the smallest item in the priority queue
        public T Remove()
        {
            if (size == 0)
                throw new PriorityQueueEmptyException();

            T val = array[1];
            array[1] = array[size--];

            PercolateDown(1);

            return val;
        }

        private void PercolateDown(int index)
        {
            int child;
            T tmp = array[index];

            for (; index * 2 <= size; index = child)
            {
                child = index * 2;

                if (child != size && array[child + 1].CompareTo(array[child]) < 0)
                    child++;

                if (array[child].CompareTo(tmp) < 0)
                    array[index] = array[child];
                else
                    break;
            }

            array[index] = tmp;
        }

        public override string ToString()
        {
            string toReturn = "";
            for (var i = 1; i < size + 1; i++)
            {
                toReturn += array[i] + " ";
            }

            return toReturn.Trim();
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public void AddFreely(T x)
        {
            throw new System.NotImplementedException();
        }

        public void BuildHeap()
        {
            throw new System.NotImplementedException();
        }

    }
}
