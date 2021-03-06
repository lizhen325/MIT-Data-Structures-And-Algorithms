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

###[Charpter 5 Binary Search Tree](https://github.com/lizhen325/MIT-Data-Structures-And-Algorithms/tree/master/MIT/BST)

>The tree additionally satisfies the binary search tree property, which states that the key in each node must be greater than all keys stored in the left sub-tree, and smaller than all keys in right sub-tree.

>##Operations
1. Insertion : If the insert data greater than the data of the current node move to the right child else move to left child
2. Search: Simiar to Insertion
3. Find Max : Keep going right untill the node has no children
4. Find Min : Keep going left untill the node has no children
5. Delete Node :
  1. the node has no children
  2. the node only has left node
  3. the node only has right node
  4. the node has two children node
6. Count height of tree : take the maximum of left height and right height + 1
7. Traversal: (Pre-Order, In-Order, Post-Order)

>##pseudocode
Insertion Data
```
Insert(item)
  if item greater than data
    if right child <- null
      right child <- new node(item,null,null)
    else
      right child.Insert(item)
  else if item samller than data
    if left child <- null
      left child <- new node (item,null,null)
    else
      left child.Insert(item)
  else if item equel to data
      Error:
```
Search Data
```
 Search(item, Node node)
  if node.data eqaul to item
    Found
  else if node.data greater than item
    goes left
  else if node.data smaller than item
    goes right
```
Find minimum data
```
  FindMin(Node node)
    while node != null
      node goes left
    return node.data
```
Count Height of tree
```
  Height(Node node)
    leftHeight <- Height(node.left)
    rightHeight <- Height(node.right)
    Max(leftHeight,rightHeight) + 1
```
Pre-Order
```
  PreOrder(Node node)
    print node.data
    PreOrder(node.left)
    PreOrder(node.right)
```
In-Order
```
  InOrder(Node node)
    InOrder(node.left);
    print node.data
    InOrder(node.right)
```
Post-Order
```
  PostOrder(Node node)
    PostOrder(node.left)
    PostOrder(node.right)
    print node.data
```

###[Charpter 6 AVL Tree](https://github.com/lizhen325/MIT-Data-Structures-And-Algorithms/tree/master/MIT/AVLTree)

##Definition
AVL Tree: Require heights of left and right children of every node to differ by at most +- 1.

##Algorithms
1. Get the height difference from both sides of the tree, using recursion and the difference in balance is the height of the left side minus height of the right side
2. If the balance is greater 1 or less than -1, rotations must occur to balance the tree, if the balance is -1, 0, or 1, then no rotations are needed.
3. Nodes in the AVL Tree also store their height, for example, nodes at the top are higher than nodes at the bottom therefore the root would store the highest height while leaf nodes at the bottom would store a height of 1

##Operations
There are four cases rotations: Left-Left(LL), Right-Right(RR), Left-Right(LR), Right-Left(RL)
>####Insert()
after inserting a new node using normal procedure (BST), its necessary to check each of the nodes ancestors for an unbalance in the tree, therefore calling the Balance() method, basically, insert and then a small fix. 

>####Search(): 
Searching is more optimized since things are more balanced, therefore normal implementation(BST) in this function is sufficient.

>####Delete()
Just like Insert(), after Deletion occurs we have to call Balance() to check each of the nodes for any unbalance in the tree, we have a public Delete() and a private recursive Delete() that does the actual work.

>####GetHeight()
Max(leftHeight,rightHeight) + 1

>####BalanceFactor()
lefthHeight - righHeight

>####BalanceTree()
1. If balance factor is greater than 1, we first check if we have a left-left case, if we do then we perform that rotation, else, we perform a left-right rotation.
2. If balance factor is < -1, we first check if we have a right-right case, if we do then we perform a right right rotation, else, we perform a right-left rotation

###[Charpter 7 Counting Sort](https://github.com/lizhen325/MIT-Data-Structures-And-Algorithms/tree/master/MIT/CountringSortAndRadixSort)

###Counting Sort
####Algorithm: Sorting non negative integer with linear time complexity
1. Get the range of array for new length of array
2. Frequencies of the elements of array in new array
3. Number of elements less than or equal to element of array
4. Sorting

>##Pesudocode
```
CountingSort(A)
   range <- maximum element of array - minimum element of array + 1
   int[] C = new int[range];
   for i <- 0 to length of A
       C[A[i]] = C[A[i]] + 1
   for i <- 1 to length of C
       C[i] = C[i-1] = C[i]
   int [] R = new int[length of A]
   for i <-length(A) down to 1
       R[C[A[i]] - 1] = A[i]
       C[A[i]] = C[A[i]] - 1 
```

##[Charpter 8 String Match](https://github.com/lizhen325/MIT-Data-Structures-And-Algorithms/tree/master/MIT/RobinKarp/RobinKarp)

###Brute Force 
>The brute force algorithm consists in checking, at all positions in the text between 0 and n-m, whether an occurrence of the pattern starts there or not. Then, after each attempt, it shifts the pattern by exactly one position to the right. The search time complexity is O(m*n)

>##Pesudocode
```
BruteForce(T,P)
  n <- length(T)
  m <- length(P)
  if n greater or eqaul to m
    for i=0 to n-m
      j <- 0
      while j < m && P[j] == T[i+j]
        j++
      end while
      if j equal to m
        Found
      end if
    end for
  end if
```

###KMP
>KMP discovered first linear time string-matching algorithm by following a tight analysis of the naïve algorithm. KMP algorithm keeps the information that naive approach wasted gathered during the scan of the text. Seraching complexity is O(m+n)
>##Pesudocode
```
Navie(P,int[] next)
  i <- 0
  j <- -1
  next[0] <- -1
  while i < length(T) - 1
    if j== -1 || P[i] == P[j]
      i++;
      j++;
      next[i] = j;
    else
      j = next[j]
  end while
```
```
  KMP(T,P)
  int[] next = new int [lengt(P)]
  Navie(P,next)
  i <- 0, j <- 0
  while i < length(T) && j < length(P)
    if j == -1 || T[i] == P[j]
      i++
      j++
    else
      j = next[j]
    if j == length(p)
      Found
  end while
```

##[Charpter 9 Graph Representation: BFS & DFS](https://github.com/lizhen325/MIT-Data-Structures-And-Algorithms/tree/master/MIT/BreathFirstSearch)

>###Adjency List
An adjacency list representation for a graph associates each vertex in the graph with the collection of its neighboring vertices or edges. There are many variations of this basic idea, differing in the details of how they implement the association between vertices and collections, in how they implement the collections, in whether they include both vertices and edges or only vertices as first class objects, and in what kinds of objects are used to represent the vertices and edges
>###Graph Traversal BFS & DFS
>
>##Pesudocode

```
1 procedure BFS(G, v):
2     create a queue Q
3     enqueue v onto Q
4     mark v
5     while Q is not empty:
6         t ← Q.dequeue()
7         if t is what we are looking for:
8             return t
9         for all edges e in G.adjacentEdges(t) do
12            o ← G.adjacentVertex(t, e)
13            if o is not marked:
14                mark o
15                enqueue o onto Q
```

```
1 procedure DFS(G, v):
2     label v as explored
3     for all edges e in G.incidentEdges(v) do
4         if edge e is unexplored then
5             w ← G.adjacentVertex(v, e)
6             if vertex w is unexplored then
7                 label e as a discovered edge
8                 recursively call DFS(G, w)
9             else
10               label e as a back edge
```

##[Charpter 10 Shortest Path](https://github.com/lizhen325/MIT-Data-Structures-And-Algorithms/tree/master/MIT/ShortestPath)
>###Dijkstra Algorithm
1. Assign to every node a tentative distance value: set it to zero for our initial node and to infinity for all other nodes.
2. Set the initial node as current. Mark all other nodes unvisited. Create a set of all the unvisited nodes called the unvisited set.
3. For the current node, consider all of its unvisited neighbors and calculate their tentative distances. Compare the newly calculated tentative distance to the current assigned value and assign the smaller one. For example, if the current node A is marked with a distance of 6, and the edge connecting it with a neighbor B has length 2, then the distance to B (through A) will be 6 + 2 = 8. If B was previously marked with a distance greater than 8 then change it to 8. Otherwise, keep the current value.
4. When we are done considering all of the neighbors of the current node, mark the current node as visited and remove it from the unvisited set. A visited node will never be checked again.
5. If the destination node has been marked visited (when planning a route between two specific nodes) or if the smallest tentative distance among the nodes in the unvisited set is infinity (when planning a complete traversal; occurs when there is no connection between the initial node and remaining unvisited nodes), then stop. The algorithm has finished.
6. Otherwise, select the unvisited node that is marked with the smallest tentative distance, set it as the new "current node", and go back to step 3
