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
                for (int i = 0; i + gap < list.Count; i++)
                {
                    int j = i + gap; 
                    int temp = list[j];
                    while (j >= gap && temp < list[j - gap])
                    {
                        list[j] = list[j - gap];
                        j -= gap;
                    }
                    list[j] = temp;
                }
            }
        }
    }
}