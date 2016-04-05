# MIT-Data-Structures-And-Algorithms

##[Chapter 1 Find a Peak Element in array](https://github.com/lizhen325/MIT-Data-Structures-And-Algorithms/tree/master/MIT/PeakFinding)

###Divide and Conquer Algorithm: O(logN) time complexity

>**pseudocode**
```
look at n/2 position
length = n/2;
if(arr[length]) < arr[length - 1])
  only look at left half to look for a peak
else if(arr[length] < arr[length + 1])
  only look at right half to look for a peak
else
  arr[length / 2] is a peak
```

##[Chapter 2 Document Distance](https://github.com/lizhen325/MIT-Data-Structures-And-Algorithms/tree/master/MIT/DocumentDistance)

###Algorithm:
>1. Split document into words
2. Compare word frequencies
3. Compute Distance: 
<code>
arccos(D1 * D2 / sqrt(D1 * D1) * sqrt(D2 * D2))
</code>

##[Charpter 3 InsertionSort & Merge Sort](https://github.com/lizhen325/MIT-Data-Structures-And-Algorithms/tree/master/MIT/InsertionSortAndMergeSort)

###InsertionSort Algoritm: O(n<sup>2</sup>) complexity
>For 1-> n insert arr[i] into sorted array arr[0 -> i-1] by pairwise swaps down to the correct position
>**pseudocode**
```
for i=1 to leanth arr
  for j=1 to j > 0
    if arr[j-1] > arr[j]
      swap arr[j] and arr[j-1]
  end for
end for
```

###Merge Sort Algorithm: O(NlogN) complexity
>1. Divide the unsorted list into n sublists, each containing 1 element (a list of 1 element is considered sorted).
2. Repeatedly merge sublists to produce new sorted sublists until there is only 1 sublist remaining. This will be the sorted list.

>**pesudocode**

>Merge([]unsorted,first,last,[]sorted)
```
if(first + 1 < last)
  then mid = (first + last) / 2                 //Divide Step
  Merge(unsorted,first,mid,sorted)              //Conquer Step
  Merge(unsorted,mid+1,last,sorted)             //Conquer Step
  MergeSorting(unsorted,first,mid,last,sorted)  //Conquer Step
```

>MergeSorting([]unsorted,first,mid,last,sorted)
```
i <- first,
j <- mid,
k = 0,
while i < mid && j < last
  DO IF unsorted[i] < unsorted[j]
      THEN sorted[k++] <- unsorted[i++]
    ELSE
      sorted[k++] <- unsorted[j++]
while i < mid
  DO sorted[k++] <- unsorted[i++]
whlie j < last
  DO sorted[k++] <- unsorted[j++]
CopyArray unsorted <- sorted
```

##[Charpter 4 Heap Sort](https://github.com/lizhen325/MIT-Data-Structures-And-Algorithms/tree/master/MIT/Heap)
###Algorithm N(logN) Complexity
>1. Build Max Heapify from unorder array      //O(n) Complexity
2. Find Max element A[0]                      //O(1) Complexity
3. swap elements A[i] with A[0]: now max element is at the end of array  //O(1) Complexity
4. Discard node i from heap                   //O(1) Complexity
5. New root many violate max heap but children are max-heaps              //O(logN) Complexity
6. goes step 2 until the heap is null         //run n times

>**pesudocode
```
MaxHeapify(A,i,heapsize)
  left <- 2 * i
  right <- 2 * i + 1
  max <- i
  if left < heapsize && A[left] > A[max]
    max <- left
  if right < heapsize && A[right] > A[max]
    max <- right
  if max != i
    swap A[i] to A[max]
    MaxHeapify(A,max,heapsize)
  end if
```
```
BuildHeap(A)
  for i = heapsize/2 down to 1
    MaxHeapify(A,i,heapsize)
  end for
```
```
HeapSort(A)
  BuildHeap(A)
  for i = heapsize down to 1
    swap A[0] to A[i]
    MaxHeapify(A,0,i-1)
  end for
```
