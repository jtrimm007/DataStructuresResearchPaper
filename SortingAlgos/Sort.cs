using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgos
{
    public static class Sort
    {
        public static void InsertionSort(List<int> list)
        {
            int temp, j;
            for(int i = 1; i < list.Count; i++)
            {
                temp = list[i];

                for(j=i; j > 0 && temp < list[j - 1]; j--)
                {
                    list[j] = list[j - 1];
                }
                list[j] = temp;
            }
        }

        public static void SinkSort(List<int> list)
        {
            bool sorted = false;
            int pass = 0;

            while(!sorted && (pass < list.Count))
            {
                pass++;
                sorted = true;

                for(int i = 0; i < list.Count -pass; i++)
                {
                    if(list[i] > list[i + 1])
                    {
                        Swap(list, i, i + 1);
                        sorted = false;
                    }
                }
            }
        }

        private static void Swap(List<int> list, int n, int m)
        {
            int temp = list[n];
            list[n] = list[m];
            list[m] = temp;
        }

        public static void SelectionSort(List<int> list, int n)
        {
            if (n <= 1)
                return;

            int max = Max(list, n);
            if (list[max] != list[n - 1])
                Swap(list, max, n - 1);
            SelectionSort(list, n - 1);
        }

        private static int Max(List<int> list, int n)
        {
            int max = 0;

            for(int i = 0; i < n; i++)
            {
                if (list[max] < list[i])
                    max = i;
            }
            return max;
        }

        public static void OriginalQuickSort(List<int> list)
        {
            QuickSort(list, 0, list.Count - 1);
        }

        private static void QuickSort(List<int> list, int start, int end)
        {
            int left = start;
            int right = end;

            if (left >= right)
                return;

            while(left < right)
            {
                while (list[left] <= list[right] && left < right)
                    right--;

                if (left < right)
                    Swap(list, left, right);

                while (list[left] <= list[right] && left < right)
                    left++;

                if (left < right)
                    Swap(list, left, right);
            }

            QuickSort(list, start, left - 1);
            QuickSort(list, right + 1, end);
        }

        public static void QuickMedianOfThreeSort(List<int> list, int v)
        {
            QuickMedianOfThreeSort(list, 0, list.Count - 1);
        }
    }
}
