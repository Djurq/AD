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
            array = new T[1];
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
            if (size + 1 >= array.Length)
            {
                DoubleArray();
            }

            int hole = size++;
            array[0] = x;
            for (;compare(x, array[hole / 2]) < 0; hole /= 2)
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

        public int compare(T x, T arrayPosition)
        {
            return Convert.ToInt32(arrayPosition) - Convert.ToInt32(x);
        }

        // Removes the smallest item in the priority queue
        public T Remove()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            string toReturn = "";
            for (var i = 0; i < size; i++)
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
