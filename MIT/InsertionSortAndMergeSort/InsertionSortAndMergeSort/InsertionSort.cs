using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAndMergeSort
{
    public class InsertionSort
    {
        public static int[] InsertionSorting(int[] nums)
        {
            for(int i=1; i<nums.Length; i++)
            {
                for(int j=i; j>0; j--)
                {
                    if(nums[j] < nums[j-1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j - 1];
                        nums[j - 1] = temp;
                    }
                }
            }
            return nums;
        }
    }
}
