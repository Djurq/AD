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
            int pivot = getPivot(list);

        }

        public int getPivot(List<int> list)
        {
            int first = list[0];
            int middle = list[list.Count / 2];
            int last = list[list.Count - 1];

            return Math.Max(Math.Min(first, middle), Math.Min(Math.Max(first, middle), last));
        }
    }
}
