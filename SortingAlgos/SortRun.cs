///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresResearchPaper
//	File Name:         SortRun.cs
//	Description:       This is used to run the different list types on all the sorting algo's. 
//	Course:            CSCI 2210 - Data Structures	
//	Author:            DESKTOP-FOTV38D\Joshua, trimmj@etsu.edu
//	Created:           11/4/2021
//	Copyright:         DESKTOP-FOTV38D\Joshua, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace SortingAlgos
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="SortRun" />.
    /// </summary>
    public class SortRun : Sort
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortRun"/> class.
        /// </summary>
        public SortRun() : base()
        {
        }

        /// <summary>
        /// This region is for the starting run of 100 ints.
        /// </summary>
        /// <param name="numberOfInts">The numberOfInts<see cref="int?"/>.</param>
        public void RunSortOnRandomNumbers(int? numberOfInts = 100)
        {
            var list = GenerateRandomInts((int)numberOfInts);

            var selectionList = new List<int>(list);
            var insertionList = new List<int>(list);
            var mergeList = new List<int>(list);
            var qsList = new List<int>(list);
            var qsMedianList = new List<int>(list);
            var shellList = new List<int>(list);
            var countingSortList = new List<int>(list);
            var radixList = new List<int>(list);

            SinkSort(list);
            SelectionSort(selectionList, selectionList.Count);
            InsertionSort(insertionList);
            var newMergeSortList = MergeSort(mergeList);
            OriginalQuickSort(qsList);
            StartQuickMedianOfThreeSort(qsMedianList);
            ShellSort(shellList);
            var newCountingList = CountingSort(countingSortList);
            Radix10LSDSort(radixList);
        }

        /// <summary>
        /// The RunSortOnAlreadyInOrder.
        /// </summary>
        /// <param name="numberOfInts">The numberOfInts<see cref="int?"/>.</param>
        public void RunSortOnAlreadyInOrder(int? numberOfInts = 100)
        {
            var list = AlreadyInOrderList((int)numberOfInts);
            var selectionList = new List<int>(list);
            var insertionList = new List<int>(list);
            var mergeList = new List<int>(list);
            var qsList = new List<int>(list);
            var qsMedianList = new List<int>(list);
            var shellList = new List<int>(list);
            var countingSortList = new List<int>(list);
            var radixList = new List<int>(list);

            SinkSort(list);
            SelectionSort(selectionList, selectionList.Count);
            InsertionSort(insertionList);
            var newMergeSortList = MergeSort(mergeList);
            OriginalQuickSort(qsList);
            StartQuickMedianOfThreeSort(qsMedianList);
            ShellSort(shellList);
            var newCountingList = CountingSort(countingSortList);
            Radix10LSDSort(radixList);
        }

        /// <summary>
        /// The RunSortOnReverseOrder.
        /// </summary>
        /// <param name="numberOfInts">The numberOfInts<see cref="int?"/>.</param>
        public void RunSortOnReverseOrder(int? numberOfInts = 100)
        {
            var list = ReverseOrderList((int)numberOfInts);
            var selectionList = new List<int>(list);
            var insertionList = new List<int>(list);
            var mergeList = new List<int>(list);
            var qsList = new List<int>(list);
            var qsMedianList = new List<int>(list);
            var shellList = new List<int>(list);
            var countingSortList = new List<int>(list);
            var radixList = new List<int>(list);

            SinkSort(list);
            SelectionSort(selectionList, selectionList.Count);
            InsertionSort(insertionList);
            var newMergeSortList = MergeSort(mergeList);
            OriginalQuickSort(qsList);
            StartQuickMedianOfThreeSort(qsMedianList);
            ShellSort(shellList);
            var newCountingList = CountingSort(countingSortList);
            Radix10LSDSort(radixList);
        }

        /// <summary>
        /// The RunsSortOnTenPercentUnsorted.
        /// </summary>
        /// <param name="numberOfInts">The numberOfInts<see cref="int?"/>.</param>
        public void RunsSortOnTenPercentUnsorted(int? numberOfInts = 100)
        {
            var list = AlmostRandomData((int)numberOfInts);
            var selectionList = new List<int>(list);
            var insertionList = new List<int>(list);
            var mergeList = new List<int>(list);
            var qsList = new List<int>(list);
            var qsMedianList = new List<int>(list);
            var shellList = new List<int>(list);
            var countingSortList = new List<int>(list);
            var radixList = new List<int>(list);

            SinkSort(list);
            SelectionSort(selectionList, selectionList.Count);
            InsertionSort(insertionList);
            var newMergeSortList = MergeSort(mergeList);
            OriginalQuickSort(qsList);
            StartQuickMedianOfThreeSort(qsMedianList);
            ShellSort(shellList);
            var newCountingList = CountingSort(countingSortList);
            Radix10LSDSort(radixList);
        }

        /// <summary>
        /// The RunSinkSort.
        /// </summary>
        /// <param name="numberOfInts">The numberOfInts<see cref="int?"/>.</param>
        public void RunSinkSort(int? numberOfInts = 100)
        {
            var randomIntsList = GenerateRandomInts((int)numberOfInts);
            var listOfOrderedInts = AlreadyInOrderList((int)numberOfInts);
            var reverseOrderedList = ReverseOrderList((int)numberOfInts);
            var almostRando = AlmostRandomData((int)numberOfInts);


            Radix10LSDSort(randomIntsList);
            Radix10LSDSort(listOfOrderedInts);
            Radix10LSDSort(reverseOrderedList);
            Radix10LSDSort(almostRando);
        }

    }
}
