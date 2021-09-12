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
            data[size] = n;
            size++;
        }

        public int Get(int index)
        {
            return data[index];
        }

        public void Set(int index, int n)
        {
            data[index] = n;
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
            for (var i = 0; i < data.Length; i++)
            {
                data[i] = 0;
            }

            size = 0;
        }

        public int CountOccurences(int n)
        {
            int Occurences = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (Get(i) == n)
                {
                    Occurences++;
                }
            }

            return Occurences;
        }
    }
}
