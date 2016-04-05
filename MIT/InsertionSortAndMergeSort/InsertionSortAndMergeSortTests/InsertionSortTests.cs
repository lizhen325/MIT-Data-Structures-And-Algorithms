using Microsoft.VisualStudio.TestTools.UnitTesting;
using InsertionSortAndMergeSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAndMergeSort.Tests
{
    [TestClass()]
    public class InsertionSortTests
    {
        [TestMethod()]
        public void InsertionSortingTest()
        {
            int[] nums = { 3, 4, 5, 3, 2, 1 };
            int[] res = InsertionSort.InsertionSorting(nums);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 3, 4, 5 }, res);
        }
    }
}