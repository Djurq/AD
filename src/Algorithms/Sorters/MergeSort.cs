using System;
using System.Collections.Generic;


namespace AD
{
    public partial class MergeSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            mergeSort(list, 0, list.Count - 1);
        }

        public void merge(List<int> list, int left, int center, int right)
        {
            //waardes bepalen
            int n1 = center - left + 1;
            int n2 = right - center;


            //lijsten aanmake
            List<int> L = list.GetRange(left, n1);
            List<int> R = list.GetRange(center + 1, n2);


            int i = 0;
            int j = 0;
            int k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    list[k] = L[i];
                    i++;
                }
                else
                {
                    list[k] = R[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                list[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                list[k] = R[j];
                j++;
                k++;
            }
        }


        public void mergeSort(List<int> list, int left, int right)
        {
            if (left < right)
            {
                int center = (left + right) / 2;
                mergeSort(list, left, center);
                mergeSort(list, center + 1, right);
                merge(list, left, center, right);
            }
        }
    }
}