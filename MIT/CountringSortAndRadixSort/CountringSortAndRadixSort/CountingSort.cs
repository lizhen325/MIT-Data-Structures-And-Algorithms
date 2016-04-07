using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountringSortAndRadixSort
{
    public class CountingSort
    {
        public static int[] CountingSorting(int[] nums)
        {
            int min = nums[0];
            int max = nums[0];
            for(int i=1; i<nums.Length; i++)
            {
                if (max < nums[i])
                    max = nums[i];
                else if (min > nums[i])
                    min = nums[i];
            }
            //get range 
            int[] Contains = new int[max - min + 1];
            //contains number of elements
            for (int i = 0; i < nums.Length; i++)
                Contains[nums[i]] = Contains[nums[i]] + 1;
            //contains number of elements less than or equal to nums[i]
            for (int i = 1; i < Contains.Length; i++)
                Contains[i] = Contains[i - 1] + Contains[i];

            int[] res = new int[nums.Length];
            //sorting
            for (int i = nums.Length - 1; i >= 1; i--)
            {
                res[Contains[nums[i]] - 1] = nums[i];
                Contains[nums[i]] = Contains[nums[i]] - 1;
            }
            return res;
        }
    }
}
