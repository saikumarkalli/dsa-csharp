📘 Array Traversal Patterns (C# Interview Reference)

Array traversal is one of the most important foundations for coding interviews and real-world problem solving.
Most array problems become easy once you recognize the correct traversal pattern.

This README documents the most common array traversal patterns, explains when to use them, and lists interview-style problems commonly asked for each pattern.

1️⃣ Linear Traversal (Forward)
🔹 Description

    Traverse the array from start to end, visiting each element once.

    🔹 Traversal Logic
    for i = 0 → n-1
        process array[i]

    🔹 When to Use

    When every element must be processed

    Simple scans and aggregations

    🔹 Common Interview Problems

    Find maximum / minimum element

    Find sum or average of elements

    Count occurrences of an element

    Check if array is sorted

    Find first duplicate or unique element

    🔹 Time Complexity

    O(n)    

2️⃣ Reverse Traversal
    🔹 Description

    Traverse the array from end to start.

    🔹 Traversal Logic
    for i = n-1 → 0
        process array[i]

    🔹 When to Use

    Backward comparison

    Reverse-related logic

    🔹 Common Interview Problems

    Reverse an array

    Check if array/string is palindrome

    Compare arrays from right to left

    Print elements in reverse order

    🔹 Time Complexity

    O(n)

3️⃣ Two-Pointer Traversal