///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresResearchPaper
//	File Name:         Program.cs
//	Description:       Program.cs is the driver of DataStructuresResearchPaper. There is no console window to display the sorting algorithms working because that would slow down the Performance Profiler. 
//	Course:            CSCI 2210 - Data Structures	
//	Author:            DESKTOP-FOTV38D\Joshua, trimmj@etsu.edu
//	Created:           11/4/2021
//	Copyright:         Joshua, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace DataStructuresResearchPaper
{
    using SortingAlgos;

    /// <summary>
    /// Defines the <see cref="Program" /> and acts as a Driver.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The Main, i.e., the Driver.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        public static void Main(string[] args)
        {
            // Instantiate my custom Sorting Algo library
            SortRun sortRun = new SortRun();

            // Run each sorting requirement on the required list types
            sortRun.RunsSortOnTenPercentUnsorted(10000);
            sortRun.RunSortOnReverseOrder(10000);
            sortRun.RunSortOnRandomNumbers(10000);
            sortRun.RunSortOnAlreadyInOrder(10000);
        }
    }
}
