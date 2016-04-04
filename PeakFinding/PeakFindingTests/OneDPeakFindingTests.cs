using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeakFinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakFinding.Tests
{
    [TestClass()]
    public class OneDPeakFindingTests
    {
        [TestMethod()]
        public void FindPeakFindTest()
        {
            int[] nums = { 1, 2, 3 };
            int peak = OneDPeakFinding.FindPeakFind(nums);
            Assert.AreEqual(3, peak);

            int[] nums1 = { 1, 2, 3, 4, 5, 6, 5, 4, 2 };
            int peak1 = OneDPeakFinding.FindPeakFind(nums1);
            Assert.AreEqual(6, peak1);

            int[] nums2 = { 1 };
            int peak2 = OneDPeakFinding.FindPeakFind(nums2);
            Assert.AreEqual(1, peak2);

            int[] nums3 = { };
            int peak3 = OneDPeakFinding.FindPeakFind(nums3);
            Assert.AreEqual(0, peak3);

            int[] nums4 = { 1, 2, 5, 4, 6, 2 };
            int peak4 = OneDPeakFinding.FindPeakFind(nums4);
            Assert.AreEqual(5, peak4);
        }

        [TestMethod()]
        public void FindAPeakTest()
        {

            int[] nums1 = { 1, 2, 3, 4, 5, 6, 5, 4, 2 };
            int peak1 = OneDPeakFinding.FindPeakFind(nums1);
            Assert.AreEqual(6, peak1);

            int[] nums2 = { 1 };
            int peak2 = OneDPeakFinding.FindAPeak(nums2);
            Assert.AreEqual(1, peak2);

            int[] nums3 = { };
            int peak3 = OneDPeakFinding.FindAPeak(nums3);
            Assert.AreEqual(0, peak3);

            int[] nums4 = { 1, 2, 5, 4, 6, 2 };
            int peak4 = OneDPeakFinding.FindAPeak(nums4);
            Assert.AreEqual(5, peak4);
        }
    }
}