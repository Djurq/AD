namespace AD
{
    public partial class MyArrayList : IMyArrayList
    {
        private int[] data;
        private int size;

        public MyArrayList(int capacity)
        {
            data = new int[capacity];
        }

        public void Add(int n)
        {
            if (size + 1 <= Capacity())
            {
                data[size] = n;
                size++;
            }
            else
            {
                throw new MyArrayListFullException();
            }
        }

        public int Get(int index)
        {
            if (index >= 0 && index < size && size >= 1)
            {
                return data[index];
            }
            throw new MyArrayListIndexOutOfRangeException();
        }

        public void Set(int index, int n)
        {
            if (index < size && index >= 0)
            {
                data[index] = n;
            }
            else
            {
                throw new MyArrayListIndexOutOfRangeException();
            }
        }

        public int Capacity()
        {
            return data.Length;
        }

        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            size = 0;
        }

        public int CountOccurences(int n)
        {
            int Occurences = 0;
            for (int i = 0; i < size; i++)
            {
                if (Get(i) == n)
                {
                    Occurences++;
                }
            }

            return Occurences;
        }

        public override string ToString()
        {
            if (size == 0)
            {
                return "NIL";
            }

            string text = "[";
            for (int i = 0; i < size; i++)
            {
                text += data[i];
                if (i != size - 1 && size != 1)
                {
                    text += ",";
                }
            }

            text += "]";
            return text;
        }
    }
}