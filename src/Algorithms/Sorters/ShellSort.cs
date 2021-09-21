using System;
using System.Collections.Generic;


namespace AD
{
    public partial class ShellSort : Sorter
    {
        Sorter sorter;

        public override void Sort(List<int> list)
        {
            for (int gap = list.Count / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < list.Count; i++)
                {
                    int key = list[i - gap];
                    int j = i;
                    while (j >= gap && list[j] < key)
                    {
                        int temp = list[j];
                        list[j] = list[j - gap];
                        list[j - gap] = temp;
                        j -= gap;
                    }
                }
            }
        }
    }
}