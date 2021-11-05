///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresResearchPaper
//	File Name:         Sort.cs
//	Description:       This file houses all the sorting algorithms and their associated methods. It also has methods to generate the list requirements for sorting.
//	Course:            CSCI 2210 - Data Structures	
//	Author:            DESKTOP-FOTV38D\Joshua, trimmj@etsu.edu
//	Created:           10/29/2021
//	Copyright:         DESKTOP-FOTV38D\Joshua, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace SortingAlgos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="Sort" />.
    /// </summary>
    public class Sort
    {
        /// <summary>
        /// The GenerateRandomInts generates a list of N random ints. Defaults to a list size of 100
        /// </summary>
        /// <param name="numberOfInts">The numberOfInts<see cref="int?"/>.</param>
        /// <returns>The <see cref="List{int}"/>.</returns>
        public List<int> GenerateRandomInts(int? numberOfInts = 100)
        {
            Random random = new Random();
            List<int> list = new List<int>((int)numberOfInts);
            for (var i = 0; i < numberOfInts; i++)
            {
                var randNum = random.Next((int)numberOfInts);
                list.Add(randNum);
            }
            return list;
        }

        /// <summary>
        /// The AlreadyInOrderList generates a list of N ints in an ordered list. Defaults to a list size of 100.
        /// </summary>
        /// <param name="numberOfInts">The numberOfInts<see cref="int?"/>.</param>
        /// <returns>The <see cref="List{int}"/>.</returns>
        public List<int> AlreadyInOrderList(int? numberOfInts = 100)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < numberOfInts; i++)
                list.Add(i);
            return list;
        }

        /// <summary>
        /// The ReverseOrderList generates a list of N values in a reverse ordred list. Defaults to a list size of 100
        /// </summary>
        /// <param name="numberOfInts">The numberOfInts<see cref="int?"/>.</param>
        /// <returns>The <see cref="List{int}"/>.</returns>
        public List<int> ReverseOrderList(int? numberOfInts = 100)
        {
            List<int> list = new List<int>();
            for (int i = (int)numberOfInts; i > 0; i--)
                list.Add(i);
            return list;
        }

        /// <summary>
        /// The AlmostRandomData orders a list of N ints and then randomizes 10% of that list. Defaults to a list size of 100
        /// </summary>
        /// <param name="numberOfInts">The numberOfInts<see cref="int?"/>.</param>
        /// <returns>The <see cref="List{int}"/>.</returns>
        public List<int> AlmostRandomData(int? numberOfInts = 100)
        {
            var list = numberOfInts > 100 ? AlreadyInOrderList((int)numberOfInts) : AlreadyInOrderList();

            Random random = new Random();
            for (var i = 0; i < (list.Count * 0.10); i++)
            {
                var randomIndex = random.Next(list.Count);
                var randomIndex2 = random.Next(list.Count);

                Swap(list, randomIndex, randomIndex2);
            }

            return list;
        }

        /// <summary>
        /// The InsertionSort.
        /// </summary>
        /// <param name="list">The list<see cref="List{int}"/>.</param>
        public void InsertionSort(List<int> list)
        {
            int temp, j;
            for (int i = 1; i < list.Count; i++)
            {
                temp = list[i];

                for (j = i; j > 0 && temp < list[j - 1]; j--)
                {
                    list[j] = list[j - 1];
                }
                list[j] = temp;
            }
        }

        /// <summary>
        /// The SinkSort.
        /// </summary>
        /// <param name="list">The list<see cref="List{int}"/>.</param>
        public void SinkSort(List<int> list)
        {
            bool sorted = false;
            int pass = 0;

            while (!sorted && (pass < list.Count))
            {
                pass++;
                sorted = true;

                for (int i = 0; i < list.Count - pass; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        Swap(list, i, i + 1);
                        sorted = false;
                    }
                }
            }
        }

        /// <summary>
        /// The Swap method swaps to indexes in a specific list.
        /// </summary>
        /// <param name="list">The list<see cref="List{int}"/>.</param>
        /// <param name="n">The n<see cref="int"/> index is where m index will be swapped too.</param>
        /// <param name="m">The m<see cref="int"/> index is where the n index will be swapped too.</param>
        private void Swap(List<int> list, int n, int m)
        {
            int temp = list[n];
            list[n] = list[m];
            list[m] = temp;
        }

        /// <summary>
        /// The SelectionSort.
        /// </summary>
        /// <param name="list">The list<see cref="List{int}"/>.</param>
        /// <param name="n">The n<see cref="int"/>.</param>
        public void SelectionSort(List<int> list, int n)
        {
            if (n <= 1)
                return;

            int max = Max(list, n);
            if (list[max] != list[n - 1])
                Swap(list, max, n - 1);
            SelectionSort(list, n - 1);
        }

        /// <summary>
        /// The Max.
        /// </summary>
        /// <param name="list">The list<see cref="List{int}"/>.</param>
        /// <param name="n">The n<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        private int Max(List<int> list, int n)
        {
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                if (list[max] < list[i])
                    max = i;
            }
            return max;
        }

        /// <summary>
        /// The OriginalQuickSort.
        /// </summary>
        /// <param name="list">The list<see cref="List{int}"/>.</param>
        public void OriginalQuickSort(List<int> list)
        {
            QuickSort(list, 0, list.Count - 1);
        }

        /// <summary>
        /// The QuickSort.
        /// </summary>
        /// <param name="list">The list<see cref="List{int}"/>.</param>
        /// <param name="start">The start<see cref="int"/>.</param>
        /// <param name="end">The end<see cref="int"/>.</param>
        private void QuickSort(List<int> list, int start, int end)
        {
            int left = start;
            int right = end;

            if (left >= right)
                return;

            while (left < right)
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

        /// <summary>
        /// The StartQuickMedianOfThreeSort.
        /// </summary>
        /// <param name="list">The list<see cref="List{int}"/>.</param>
        public void StartQuickMedianOfThreeSort(List<int> list)
        {
            QuickMedianOfThreeSort(list, 0, list.Count - 1);
        }

        /// <summary>
        /// The QuickMedianOfThreeSort.
        /// </summary>
        /// <param name="list">The list<see cref="List{int}"/>.</param>
        /// <param name="start">The start<see cref="int"/>.</param>
        /// <param name="end">The end<see cref="int"/>.</param>
        private void QuickMedianOfThreeSort(List<int> list, int start, int end)
        {
            const int cutoff = 10;

            if (start + cutoff > end)
                InsertionSort(list, start, end);
            else
            {
                int middle = (start + end) / 2;

                if (list[middle] < list[start])
                    Swap(list, start, middle);
                if (list[end] < list[start])
                    Swap(list, start, end);
                if (list[end] < list[middle])
                    Swap(list, middle, end);

                int pivot = list[middle];
                Swap(list, middle, end - 1);

                int left, right;
                for (left = start, right = end - 1; ;)
                {
                    while (list[++left] < pivot)
                        ;
                    while (pivot < list[--right])
                        ;
                    if (left < right)
                        Swap(list, left, right);
                    else
                        break;
                }

                Swap(list, left, end - 1);

                QuickMedianOfThreeSort(list, start, left - 1);
                QuickMedianOfThreeSort(list, left + 1, end);
            }
        }

        /// <summary>
        /// The InsertionSort.
        /// </summary>
        /// <param name="list">The list<see cref="List{int}"/>.</param>
        /// <param name="start">The start<see cref="int"/>.</param>
        /// <param name="end">The end<see cref="int"/>.</param>
        private void InsertionSort(List<int> list, int start, int end)
        {
            int temp, j;
            for (int i = start + 1; i <= end; i++)
            {
                temp = list[i];
                for (j = i; j > start && temp < list[j - 1]; j--)
                {
                    list[j] = list[j - 1];
                }
                list[j] = temp;
            }
        }

        /// <summary>
        /// The ShellSort.
        /// </summary>
        /// <param name="list">The list<see cref="List{int}"/>.</param>
        public void ShellSort(List<int> list)
        {
            for (int gap = list.Count / 2; gap > 0; gap = (gap == 2 ? 1 : (int)(gap / 2.2)))
            {
                int temp, j;
                for (int i = gap; i < list.Count; i++)
                {
                    temp = list[i];

                    for (j = i; j >= gap && temp < list[j - gap]; j -= gap)
                    {
                        list[j] = list[j - gap];
                    }
                    list[j] = temp;
                }
            }
        }

        /// <summary>
        /// The mergeSort.
        /// </summary>
        /// <param name="list">The list<see cref="List{int}"/>.</param>
        /// <returns>The <see cref="List{int}"/>.</returns>
        public List<int> MergeSort(List<int> list)
        {
            if (list.Count <= 1)
                return list;

            List<int> result = new List<int>();
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = list.Count / 2;
            for (int i = 0; i < middle; i++)
                left.Add(list[i]);
            for (int i = middle; i < list.Count; i++)
                right.Add(list[i]);

            left = MergeSort(left);
            right = MergeSort(right);

            if (left[left.Count - 1] <= right[0])
                return append(left, right);

            result = merge(left, right);
            return result;
        }

        /// <summary>
        /// The append.
        /// </summary>
        /// <param name="left">The left<see cref="List{int}"/>.</param>
        /// <param name="right">The right<see cref="List{int}"/>.</param>
        /// <returns>The <see cref="List{int}"/>.</returns>
        private List<int> append(List<int> left, List<int> right)
        {
            List<int> result = new List<int>(left);
            foreach (int x in right)
                result.Add(x);
            return result;
        }

        /// <summary>
        /// The merge.
        /// </summary>
        /// <param name="left">The left<see cref="List{int}"/>.</param>
        /// <param name="right">The right<see cref="List{int}"/>.</param>
        /// <returns>The <see cref="List{int}"/>.</returns>
        private List<int> merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] < right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }

            return result;
        }

        /// <summary>
        /// The Radix10LSDSort.
        /// </summary>
        /// <param name="list">The list<see cref="List{int}"/>.</param>
        /// <returns>The <see cref="List{int}"/>.</returns>
        public List<int> Radix10LSDSort(List<int> list)
        {
            List<List<int>> bin = new List<List<int>>(10);

            for (int i = 0; i < 10; i++)
                bin.Add(new List<int>(list.Count));

            int numDigits = list.Max().ToString().Length;

            for (int j = 0; j < numDigits; j++)
            {
                for (int n = 0; n < list.Count; n++)
                    bin[Digit(list[n], j)].Add(list[n]);

                CopyToResult(bin, list);

                for (int i = 0; i < 10; i++)
                {
                    bin[i].Clear();
                }

            }

            return list;
        }

        /// <summary>
        /// The CopyToResult.
        /// </summary>
        /// <param name="bin">The bin<see cref="List{List{int}}"/>.</param>
        /// <param name="result">The result<see cref="List{int}"/>.</param>
        private void CopyToResult(List<List<int>> bin, List<int> result)
        {
            result.Clear();
            for (int i = 0; i < 10; i++)
                foreach (int j in bin[i])
                    result.Add(j);
        }

        /// <summary>
        /// The Digit.
        /// </summary>
        /// <param name="value">The value<see cref="int"/>.</param>
        /// <param name="digitPosition">The digitPosition<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        private int Digit(int value, int digitPosition)
        {
            return (value / (int)Math.Pow(10, digitPosition) % 10);
        }

        /// <summary>
        /// The CountingSort.
        /// </summary>
        /// <param name="list">The list<see cref="List{int}"/>.</param>
        /// <returns>The <see cref="List{int}"/>.</returns>
        public List<int> CountingSort(List<int> list)
        {
            List<int> newList = new List<int>(list);

            int max = list.Max();
            int[] counts = new int[max + 1];

            for (int i = 0; i <= max; i++)
                counts[i] = 0;

            for (int j = 0; j < list.Count; j++)
                counts[list[j]]++;

            for (int j = 1; j <= max; j++)
                counts[j] += counts[j - 1];

            for (int j = 0; j < newList.Count; j++)
            {
                newList[counts[list[j]] - 1] = list[j];
                counts[list[j]]--;
            }

            return newList;
        }
    }
}
