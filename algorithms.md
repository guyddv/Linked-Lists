# Sorting Arrays and Traversing Linked Lists

## Summary
We will be practicing the below sorting algorithms:
- O(n^2) Bubble Sort
- O(n^2) Selection Sort
- O(n^2) Insertion Sort
- O(lg(x) x) Merge Sort

Then we will do these linked lists problems on LeetCode:
- Creating a linked list data structure
- Reversing a linked list
- Adding together the values in two linked lists

Complete the seven items.  Ideally, the sorting algorithms are completed in class while the linked list training is completed at home.  Follow the directions below to clone repository and complete all work by adding to the *LinkedListTraining* solution.

## Estimated time
Estimate time is 14 hours.

## Directions
Clone the exercise files found in the repository [Leap-Internal-Program / sorting-arrays-linked-lists](https://github.com/Leap-Internal-Program/sorting-arrays-linked-lists).  This activity will first be guided by the instructor.  Follow his or her guidance for getting started. Remember that the project files include some tests, but you will need to write additional tests.

![Sortin Tests](./img/sorting-header.png)


# Sorting
## Why are practicing these sorting algorithms?

- Sorting algorithms are an excellent way to explore time and space complexity. These sorting algorithms are staples of an introduction to computer science.
- Sorting algorithms let us see different solutions to the same problem.  Each solutions has tradeoffs.
- Apprentices should feel comfortable traversing arrays, swapping array values, and looping.
- Merge sort allows us to see a O(x*lg(x)) algorithm and practice recursion.


## Introduction to sorting
![](./img/sorting-video.png)
*YouTube* - [3 Levels of Sorting Algorithms - FASTEST Comparison Sort!](https://www.youtube.com/watch?v=qk7b4-iyCJ4)

Watch the introduction to the three types of sorting algorithms.  You will be practicing the sorting algorithms found below.  It may be helpful to review the video several times  to see how each sorting algorithm works.

## Bubble Sort
*We will do bubble sort as a class.*

What is Bubble Sort?
> Bubble sort, sometimes referred to as sinking sort, is a simple sorting algorithm that repeatedly steps through the list, compares adjacent elements and swaps them if they are in the wrong order. The pass through the list is repeated until the list is sorted. The algorithm, which is a comparison sort, is named for the way smaller or larger elements "bubble" to the top of the list.
>
>The only significant advantage that bubble sort has over most other algorithms, even quicksort, but not insertion sort, is that the ability to detect that the list is sorted efficiently is built into the algorithm.
>
>[Wikipedia: Bubble Sort](https://en.wikipedia.org/wiki/Bubble_sort) 

Image of bubble sort in progress: [Bubble sort example](https://en.wikipedia.org/wiki/Bubble_sort#/media/File:Bubble-sort-example-300px.gif) 

## Selection Sort
> The algorithm divides the input list into two parts: a sorted sublist of items which is built up from left to right at the front (left) of the list and a sublist of the remaining unsorted items that occupy the rest of the list. Initially, the sorted sublist is empty and the unsorted sublist is the entire input list. The algorithm proceeds by finding the smallest (or largest, depending on sorting order) element in the unsorted sublist, exchanging (swapping) it with the leftmost unsorted element (putting it in sorted order), and moving the sublist boundaries one element to the right.
>
> [Wikipedia: Selection Sort](https://en.wikipedia.org/wiki/Selection_sort)

Image of selection sort in progress: [Selection sort example](https://en.wikipedia.org/wiki/Selection_sort#/media/File:Selection-Sort-Animation.gif)

## Insertion Sort
>Insertion sort iterates, consuming one input element each repetition, and grows a sorted output list. At each iteration, insertion sort removes one element from the input data, finds the location it belongs within the sorted list, and inserts it there. It repeats until no input elements remain.
>
> [Wikipedia- Insertion Sort](https://en.wikipedia.org/wiki/Insertion_sort)

Image of insertion sort: [Insertion sort example](https://en.wikipedia.org/wiki/Insertion_sort#/media/File:Insertion-sort-example-300px.gif)

## Merge Sort
*We will first do merge sort as a class.*

> Merge sort is a divide and conquer algorithm that was invented by John von Neumann in 1945. A detailed description and analysis of bottom-up merge sort appeared in a report by Goldstine and von Neumann as early as 1948
>
>Conceptually, a merge sort works as follows:
> - Divide the unsorted list into n sublists, each containing one element (a list of one element is considered sorted).
> - Repeatedly merge sublists to produce new sorted sublists until there is only one sublist remaining. This will be the sorted list.
>
> [Wikipedia: Merg Sort](https://en.wikipedia.org/wiki/Merge_sort)

Image of merge sort: [Merge sort example](https://en.wikipedia.org/wiki/Merge_sort#/media/File:Merge-sort-example-300px.gif)

Merge sort may be one of the first times using recursion and the first introduction to a divide and conquer approach to solving problems. As a reminder, an algorithm that is recursive in structure calls itself recursively one or more times: function calls itself directly or indirectly. The divide and conquer algorithm typically follow these steps:
1)  Break the problem into subproblems that are similar in nature to the original problem but smaller in size.
2) Solve the subproblem.
3) Combine the solutions to the subproblems.

Specifically for merge sort we will be following this pattern:
1) Divide the sequence into two subsequences
2) When you can't divide the subsequences, sort the sub sequences
3) Combine the two sorted subsequences.

The reason that merge sort is faster than the other above solutions is *combining two sorted sequences is faster than, for example, placing a single item in a sorted sequence.*

![Merge sort](./img/merge-sort.png)


---
# LeetCode & LinkedLists

## What is LeetCode?

LeetCode.com

There are a plethora of training resources and practice environments on the web.  LeetCode is one of the most well-known online platforms used to practice your programming skills by solving interview like coding questions.  This is not an endorsement of a LeetCode rather an exploration of only one of many sites.  While LeetCode focuses on practicing "interview like questions," other sites focus on training on data structure or competing against other users.

To complete this exercise you will need to signup LeetCode.  Follow the sign up instructions on the site.  Do not pay to use LeetCode.  Do not sign up for any membership plan.

### *How many tests should I write?*
After writing the code, you will be pasting it into the LeetCode site for evaluation.  If your code does not pass all the tests on LeetCode, think about what test cases you should have added before submitting your code. Your goal should be the first submission on the LeetCode site passes all of their tests.

---

![Design linked list header](./img/design-linked-list.png)
## Designing a Linked List.
### Time:
Up to four hours.

### Problem
*LeetCode* - (Training) [Introduction - Singly Linked List](https://leetcode.com/explore/learn/card/linked-list/209/singly-linked-list/1287/)

*LeetCode* - (Training) [Add Operation - Singly Linked List](https://leetcode.com/explore/learn/card/linked-list/209/singly-linked-list/1288/)

*LeetCode* - (Training) [Delete Operation - Singly Linked List](https://leetcode.com/explore/learn/card/linked-list/209/singly-linked-list/1289/)

*LeetCode* - (Problem) [Design Linked List](https://leetcode.com/explore/learn/card/linked-list/209/singly-linked-list/1290/)

Follow the directions on LeetCode for designing a linked list.  If you have already followed Reynald's LinkedIn Learning training on algorithms, you may notice a different list design. Design this list according to the instructions on LeetCode.

After signing up for Leet Code, start here: [Introduction - Singly Linked List](https://leetcode.com/explore/learn/card/linked-list/209/singly-linked-list/1287/)

Remember to write tests for each of your methods.  You may need to complete several methods, such as `Get()` and `AddAtHead()` before you are able to complete your tests.  More than *twenty tests* is reasonable.  This activity is also about test writing.

Work this problem in the provided solution *LinkedListsTraining.*  Then you may copy and paste your solution in the LeetCode site.

---

![](./img/reverse-linked-list.png)
## Reverse a Linked List

### Time: 
Up to two hours.

### Problem
*LeetCode* - (Training) [Reverse Linked List](https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1204/*)

*LeetCode* -  (Problem) [Reverse Linked List](https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1205/*)

Read the problem [Reverse Linked List](https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1204/).  This problem is the foundation of many linked list problems, having us both traverse through a list while changing pointers.  Then [do the problem](https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1205/*).

Work this problem in the provided solution *LinkedListsTraining.*  Then you may copy and paste your solution in the LeetCode site.
![Linked list in solution](./img/reverse-linked-list-in-solution.png)

This problem does not require that much code to solve, but it may take experimentation  and practice.  Take a break when you need to.  Write out and diagram it on a piece of paper. A similar concept used in sorting would be swapping the values at index i and k below;

```csharp
var temp = arr[i];
arr[i] = arr[k];
arr[k] = temp;
```
After the test case section below is a hint section for solving the problem.  This hint may be helpful.  Don't let the approach below confuse you.

**Test Cases**


| | Can reverse list of five number|
|:-- | :-- |
| input | 1, 2, 3, 4, 5 | 
| Output | 5, 4, 3, 2, 1 |

*What other tests can you add?  What if the list only has one item?  What if the list is empty?* 

**Hint for** *Reverse Linked List*
```csharp
public ListNode ReverseList(ListNode head)
{
    ListNode prev = null;
    ListNode curr = head;
    ListNode next;

    while (curr != null)
    {
        // You want to change curr.next to equal the previous item, not the next item. 
        // 1. Store curr.next
        // 2. Change curr.next to point to the previous value
        // 3. Ready the loop for the next pass by updating prev
        // 4. Ready the loop for the next pass by updating curr.
    }

    return prev;
}

```
---
![Add two numbers header](./img/add-two-numbers.png)
## Add two numbers

### Time: 
Challanging (up to three hours).  You may not finish.

### Problem
*LeetCode* [Add two number](https://leetcode.com/problems/add-two-numbers/)

Read the problem [Add two numbers](https://leetcode.com/problems/add-two-numbers/).  This was the most popular question answered at LeetCode at one time because it was previously stated to be the most popular question asked during an interview.  It's listed at as a medium difficulty on LeetCode.

This problem was selected *not because it was a popular interview question* but becuase it's excellent problem to follow our test driven development best practices like breaking a problem down into parts through writing a test then refactoring.  A list of recommended tests have been outlined below with hints.  Instead of trying to write an answer that passes all the tests, try to write and then pass one test at a time.  You may find the hints and code samples helpful; don't allow the hints to confuse you.

Make sure your approach is storing your information in a new linked list and not temporarily storing a set a large set of numbers in System.Int64, an Array, or `List<int>`.

Work this problem in the provided solution *LinkedListsTraining.*  Then you may copy and paste your solution in the LeetCode site.
![Linked list in solution](./img/add-two-numbers-in-solution.png)

**Test Cases**

| | Can add two single digit numbers|
|:-- | :-- |
| l1 | 1 | 
| l2 | 2|
| Output | 3 |

*Hint: We are going to be returning the head of a ListNode.  We will need to keep track of both the tail and head.  The tail will be where we add the next node with the value.  The head will be what we return when we are finished.
```csharp
// Example of one way to set the head or the tail.  This section is missing

// At the top we might have
ListNode head = null;
ListNode tail = null;

// Other code goes here
 
// If there are no nodes yet, set head and tail to the first node.  Otherwise add a new node to the tail.
if (head == null)
{
    tail = head = new ListNode(total);
}
else
{
    tail = tail.next = new ListNode(total);
}

```

|  | Can add two numbers that are the same length |
|:-- | :-- |
| l1 | 1, 1, 1| 
| l2 | 2, 2, 2|
| Output | 3, 3, 3|

*Hint: We are probably going to need at least one while loop to move through the linked lists.*

|  | Can add two numbers that are different lengths |
|:-- | :-- |
| l1 | 1, 1 | 
| l2 | 2, 2, 2|
| Output | 3, 3, 2|

*Hint: While we only need one while loop, we proabably only want to get the value from a node and move onto the next node if the current node is not null.*

|  | Can add two numbers that are different lengths |
|:-- | :-- |
| l1 | 1 | 
| l2 | 2, 2, 2|
| Output | 3, 2, 2|

|  | Can add if number is zero |
|:-- | :-- |
| l1 | 0 | 
| l2 | 2, 2, 2|
| Output | 2, 2, 2|

|  | Can add if both numbers are zero |
|:-- | :-- |
| l1 | 0 | 
| l2 | 0|
| Output | 0|


|  | Can simple carry |
|:-- | :-- |
| l1 | 2, 8, 2| 
| l2 | 2, 2, 2|
| Output | 4, 0, 5|

*Hint: We probably want to check if the value of the two numbers is over nine, if it is, we want add one to the carry and subract 10 from the current total.
``` csharp
//Just an example.  There are other valid solutions
if (total > 9)
{
    total = total - 10;
    carry = 1;
}
```

|  | Can carry at the end |
|:-- | :-- |
| l1 | 2, 2, 8| 
| l2 | 2, 2, 3|
| Output | 4, 4, 1, 1|

|  | Can complicated carry |
|:-- | :-- |
| l1 | 9, 9, 9| 
| l2 | 9, 9, 9, 9, 9, 9, 9|
| Output | 8, 9, 9, 0, 0, 0, 0, 1|

|  | Can add long numbers |
|:-- | :-- |
| l1 |     9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9| 
| l2 |     9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9|
| Output | 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 1|