# Time & Space Complexity – Clear Reference Guide

This document explains **Time Complexity** and **Space Complexity** in **simple, practical terms**.  
It is meant for **future reference** while learning Data Structures & Algorithms (DSA).

---

## 📌 Why This Matters

Code that works for small inputs may fail for large inputs.

**Time & Space Complexity help us answer:**
- Will this solution scale?
- Is this approach efficient?
- Can this pass interviews and production constraints?

---

## 1️ Time Complexity

**Time Complexity** describes how the **number of operations grows as input size (`n`) increases**.

> It does **NOT** measure real execution time.  
> It measures **growth trend**.

| Complexity     | Meaning                       | Example             |
| -------------- | ----------------------------- | ------------------- |
| **O(1)**       | Constant work                 | Accessing `arr[0]`  |
| **O(log n)**   | Problem size halves each step | Binary Search       |
| **O(n)**       | One pass over input           | Single loop         |
| **O(n log n)** | Loop + halving                | Sorting             |
| **O(n²)**      | Nested loops                  | Comparing all pairs |
| **O(n³)**      | Three nested loops            | Rare, very slow     |

Time Complexity Rules
-----------------------------------------
1. Single Loop

for (int i = 0; i < n; i++) { }

➡ O(n)
----------------------------------------
2. Nested Loops

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++) { }
}

➡ O(n²)

Rule: Nested loops multiply.
----------------------------------------
3. Sequential Loops

for (int i = 0; i < n; i++) { }
for (int j = 0; j < n; j++) { }

➡ O(n)

Rule: Sequential loops add → constants are ignored.
----------------------------------------
4. Halving Loop

while (n > 1)
{
    n = n / 2;
}

➡ O(log n)

Rule: Divide or multiply by 2 → logarithmic.
----------------------------------------
5. Loop + Halving

for (int i = 0; i < n; i++)
{
    int x = n;
    while (x > 1) x /= 2;
}

➡ O(n log n)

=====================================================

2. What is Space Complexity?

Space Complexity describes how much extra memory is used at one time.

Important:

Input size does NOT count.
Only extra memory matters.

| Space        | When it happens                 |
| ------------ | ------------------------------- |
| **O(1)**     | Only variables                  |
| **O(n)**     | Array, list, map of size `n`    |
| **O(log n)** | Recursion depth (binary search) |
| **O(n²)**    | 2D matrix                       |

Space Complexity Rules
-----------------------------------------
1. Variables Only

int sum = 0;

➡ O(1)
----------------------------------------
2. Array or Map of Size n

int[] arr = new int[n];

➡ O(n)
----------------------------------------
3. Array Inside Loop

for (int i = 0; i < n; i++)
{
    int[] temp = new int[n];
}


Only one array exists at a time

Memory does NOT accumulate

➡ Space = O(n)
➡ Time = O(n²)
----------------------------------------
4. Recursion

void func(int n)
{
    if (n <= 1) return;
    func(n / 2);
}


Recursion depth = log n

➡ Time = O(log n)
➡ Space = O(log n)

Rule: Recursion uses stack space.
=============================================

| Concept             | Time      | Space     |
| ------------------- | --------- | --------- |
| Repeated work       | Increases | ❌        |
| Repeated allocation | Increases | ❌        |
| Memory accumulation | ❌        | Increases |
| Recursion depth     | Increases | Increases |



