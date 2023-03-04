using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PiTPMLR_1;
using System.Linq;

namespace UnitTestsSort
{
    [TestClass]
    public class UnitTestSort
    {

        [TestMethod]
        public void ShellSort_Ascending_SortsArray()
        {
            int[] input = { 5, 2, 9, 1, 5 };
            int[] expectedOutput = { 1, 2, 5, 5, 9 };
            bool asc = true;

            string actualOutput = Algoritms.ShellSort(input, asc);

            CollectionAssert.AreEqual(expectedOutput, actualOutput.Split(',').Select(int.Parse).ToArray());
        }

        [TestMethod]
        public void ShellSort_Descending_SortsArray()
        {
            int[] input = { 5, 2, 9, 1, 5 };
            int[] expectedOutput = { 9, 5, 5, 2, 1 };
            bool asc = false;

            string actualOutput = Algoritms.ShellSort(input, asc);

            CollectionAssert.AreEqual(expectedOutput, actualOutput.Split(',').Select(int.Parse).ToArray());
        }

        [TestMethod]
        public void SelectionSort_Ascending_SortsArray()
        {
            int[] input = { 5, 2, 9, 1, 5 };
            int[] expectedOutput = { 1, 2, 5, 5, 9 };
            bool asc = true;

            string actualOutput = Algoritms.SelectSort(input, asc);

            CollectionAssert.AreEqual(expectedOutput, actualOutput.Split(',').Select(int.Parse).ToArray());
        }

        [TestMethod]
        public void SelectionSort_Descending_SortsArray()
        {
            int[] input = { 5, 2, 9, 1, 5 };
            int[] expectedOutput = { 9, 5, 5, 2, 1 };
            bool asc = false;

            string actualOutput = Algoritms.SelectSort(input, asc);

            CollectionAssert.AreEqual(expectedOutput, actualOutput.Split(',').Select(int.Parse).ToArray());
        }

        [TestMethod]
        public void SwapSort_Ascending_SortsArray()
        {
            int[] input = { 5, 2, 9, 1, 5 };
            int[] expectedOutput = { 1, 2, 5, 5, 9 };
            bool asc = true;

            string actualOutput = Algoritms.SwapSort(input, asc);

            CollectionAssert.AreEqual(expectedOutput, actualOutput.Split(',').Select(int.Parse).ToArray());
        }

        [TestMethod]
        public void SwapSort_Descending_SortsArray()
        {
            int[] input = { 5, 2, 9, 1, 5 };
            int[] expectedOutput = { 9, 5, 5, 2, 1 };
            bool asc = false;

            string actualOutput = Algoritms.SwapSort(input, asc);

            CollectionAssert.AreEqual(expectedOutput, actualOutput.Split(',').Select(int.Parse).ToArray());
        }
    }
}
