using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakFinding
{
    public class OneDPeakFinding
    {
        //O(n) complexity
        public static int FindPeakFind(int[] nums)
        {
            if (nums.Length == 1)
                return nums[nums.Length - 1];
            if (nums.Length == 0)
                return 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (i < nums.Length - 1)
                {
                    if (nums[i] >= nums[i - 1] && nums[i] >= nums[i + 1])
                        return nums[i];
                }
            }
            return nums[nums.Length - 1];
        }

        //Divide and Conquer: O(logN) Complexity
        public static int FindAPeak(int[] nums)
        {
            if (nums.Length == 1)
                return nums[nums.Length - 1];
            if (nums.Length == 0)
                return 0;
            //only look at left half to look for a peak
            if (nums[nums.Length / 2] < nums[nums.Length / 2 - 1])
            {
                for (int i = 1; i < nums.Length / 2 - 1; i++)
                {
                    if (nums[i] >= nums[i - 1] && nums[i] >= nums[i + 1])
                        return nums[i];
                }
            }
            //only look at right half to look for a peak
            else if (nums[nums.Length / 2] < nums[nums.Length / 2 + 1])
            {
                for (int i = nums.Length / 2 + 1; i < nums.Length; i++)
                {
                    if (i < nums.Length - 1)
                    {
                        if (nums[i] >= nums[i - 1] && nums[i] >= nums[i + 1])
                            return nums[i];
                    }
                }
            }
            return nums[nums.Length / 2 - 1];
        }
    }
}
