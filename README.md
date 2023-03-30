# InterviewQuestions
Interview questions tasks with (sometimes) interesting solutions

Tasks
## Binary Gap
The goal of this code is to find the length of the longest sequence of consecutive 0's in the binary representation of an integer n.

The code achieves this by first creating a string zeroes consisting of maxLength number of '0's. The value of maxLength is determined by multiplying the size of an integer (in bytes) by 10. This ensures that the resulting string has enough '0's to cover the binary representation of any integer.

The string s is then initialized with zeroes and the letter 'X' appended to it. The 'X' is used as a delimiter to make it easier to split the string later.

The code then enters a loop that iterates sizeof(int) * 8 times (i.e., the number of bits in an integer). During each iteration, the least significant bit of n is extracted using the bitwise AND operator (&) and compared to 0. If the bit is 0, the string "0" is concatenated to s. Otherwise, the string "1" is concatenated. After each iteration, n is shifted right by one bit.

Once the loop completes, the string s has the binary representation of n padded with leading '0's and delimited by 'X' at the beginning and end.

The final step is to split the string s using "1" as the delimiter. This will produce a sequence of substrings, each of which consists of consecutive '0's. The Select method is then used to convert each substring into its length. The Where method is used to filter out any substring whose length equals maxLength. Finally, the OrderByDescending method is used to sort the remaining substrings by their length in descending order. The FirstOrDefault method is used to return the length of the first substring in the sorted sequence, which represents the length of the longest sequence of consecutive 0's in the binary representation of n.
## Cyclic Rotation
The goal of this code is to rotate the elements of an integer array A by K positions to the right.

The code first checks if the length of the input array A is zero. If A is empty, the function returns the same array as there is no need to perform any rotation.

Next, the code calculates the actual number of positions to rotate actual by taking the modulo of K and the length of A. If actual is zero, it means that rotating A by K positions would result in the same array, so the function returns the original array.

If actual is not zero, the code creates a new list result to hold the rotated array.

The first step in rotating the array is to take the last actual elements of A in reverse order, using the Reverse method, and add them to the beginning of the result list, again in reverse order using another Reverse method. This effectively places the last actual elements at the beginning of the new array in the correct order.

The second step is to add the remaining elements of A to the end of the result list. This is achieved using the Take method to extract the first A.Length - actual elements of A, and then the AddRange method to add those elements to the end of the result list.

Finally, the result list is converted back to an array using the ToArray method and returned as the result of the function.

In summary, the code rotates the elements of an array A by K positions to the right, by first calculating the actual number of positions to rotate, creating a new list to hold the rotated array, and then adding the appropriate elements to the beginning and end of the list in the correct order.

## Odd Occurrences In Array
The goal of this code is to find the element in an integer array A that appears an odd number of times.

The code achieves this using the bitwise XOR operator (^). The basic idea is that XORing a number with itself results in 0, and XORing 0 with any number results in that number. Therefore, if we XOR all the elements in A together, any elements that appear an even number of times will cancel each other out and the result will be 0. The element that appears an odd number of times, however, will not have a pair to cancel it out, and so it will remain in the result.

This code uses LINQ's Aggregate method to find the element that appears an odd number of times in an array A.

The Aggregate method applies a binary operator to the elements of a sequence, accumulating the result into a single value. In this case, the binary operator is the bitwise XOR (^) operator.

Here's a step-by-step breakdown of how the code works:

1. The Aggregate method is called on the input array A.
2. The first argument to Aggregate is the initial accumulator value, which is set to 0.
3. The second argument to Aggregate is a lambda expression that takes two parameters: acc (the accumulator value) and num (the next element in the sequence).
4. The lambda expression applies the XOR operator to acc and num, and returns the result.
5. The Aggregate method applies the lambda expression to the first two elements of A, XORing them together to get a new accumulator value.
6, The Aggregate method applies the lambda expression to the new accumulator value and the next element of A, XORing them together to get another new accumulator value.
7, The Aggregate method continues this process, applying the lambda expression to the current accumulator value and the next element of A, until it has processed all the elements of A.
8. At the end of this process, the accumulator value returned by Aggregate is the XOR of all the elements in A. Since XORing a number with itself an even number of times results in 0, the only element that will be left in the accumulator at the end of the process is the element that appears an odd number of times in A.

In summary, the code uses the bitwise XOR operator to find the element in an integer array A that appears an odd number of times by XORing all the elements together

# Frog Jump
The goal is to calculate the minimum number of jumps required for a frog to go from a starting point X to a target point Y, with a fixed jump distance of D.

Here's a breakdown of how the code works:

1. var distance = Y - X; - Calculate the total distance the frog needs to jump to reach the target point. This is done by subtracting the starting point X from the target point Y.

2. (distance / D) - Calculate the number of full jumps the frog can take to cover the distance. This is done by dividing the total distance by the fixed jump distance D.

3. (distance % D == 0 ? 0 : 1) - Calculate the additional jump required to cover any remaining distance that cannot be covered in full jumps. This is done by checking if there is a remainder when the total distance is divided by the fixed jump distance. If there is no remainder, the frog does not need an additional jump, so the result is 0. Otherwise, the frog needs one more jump to cover the remaining distance, so the result is 1.

4. return (distance / D) + (distance % D == 0 ? 0 : 1); - Combine the results from step 2 and step 3 to get the minimum number of jumps required to reach the target point. The result is the sum of the full jumps and the additional jump (if needed).

# PermMissingElem
Task: Calculate the smallest positive integer missing from the input array A.
Solution is calculating the sum of all the elements in the array and comparing it to the expected sum of positive integers from 1 to the length of the array plus one. The difference between the two sums is the smallest missing positive integer.

# TapeEquilibrium
Task description:

You are given a ribbon with integer lengths, and you need to find the position to cut the ribbon such that the absolute difference between the sum of the lengths of each part is minimized.

Solution summary:

One possible solution to this task is to iterate through the ribbon and calculate the sum of the lengths of the elements up to the current index, and the sum of the lengths of the elements after the current index. Then, calculate the absolute difference between the two sums and store the minimum difference. Finally, return the minimum difference. This solution has a time complexity of O(n), where n is the length of the ribbon.
