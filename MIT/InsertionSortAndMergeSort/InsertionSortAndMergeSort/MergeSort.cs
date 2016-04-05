using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAndMergeSort
{
    public class MergeSort
    {
        public void MergeSorting(int[] unsorted, int first, int mid, int last, int[]sorted)
        {
            int i = first, j = mid;
            int k = 0;
        
            while (i < mid && j < last)
                if (unsorted[i] < unsorted[j])
                    sorted[k++] = unsorted[i++];
                else
                    sorted[k++] = unsorted[j++];

            //Merge the elements in left array
            while (i < mid)
                sorted[k++] = unsorted[i++];
            //merge the elements in right array
            while (j < last)
                sorted[k++] = unsorted[j++];
            //move from sorted array
            for (int v = 0; v < k; v++)
                unsorted[first + v] = sorted[v];
        }

        public void Merge(int[] unsorted, int first, int last, int []sorted)
        {
            if (first + 1 < last)
            {
                int mid = (first + last) / 2;
                //merge elements left array
                Merge(unsorted, first, mid, sorted);
                //merge elements right array
                Merge(unsorted, mid, last, sorted);
                //merge
                MergeSorting(unsorted, first, mid, last, sorted);
            }
        }
    }
}
