using System;
using System.Collections.Generic;
using System.Dynamic;


namespace AD
{
    public partial class QuickSort : Sorter
    {
        private static int CUTOFF = 3;

        public override void Sort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return;
            }

            List<int> smaller = new List<int>();
            List<int> same = new List<int>();
            List<int> larger = new List<int>();
            int chosenItem = list[list.Count / 2];

            foreach (int i in list)
            {
                if (i < chosenItem)
                {
                    smaller.Add(i);
                }
                else if (i > chosenItem)
                {
                    larger.Add(i);
                }
                else
                {
                    same.Add(i);
                }
            }

            Sort(smaller);
            Sort(larger);
            list.Clear();
            list.AddRange(smaller);
            list.AddRange(same);
            list.AddRange(larger);
        }
    }
}