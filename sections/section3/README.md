# Section 2 Home Assignment

By **Seif El-Din Sweilam**

## Required

Write a program that reads 10 numbers
and calculates their sum and average

## Code

```c#
const int SIZE = 10;

int[] nums = new int[SIZE];

for (int i = 0; i < SIZE; i++) {
    Console.WriteLine("Enter Number " + (i+1));
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Sum = " + nums.Sum());
Console.WriteLine("Average = " + nums.Average());
```

## Runtime

```
Enter Number 1
7
Enter Number 2
3
Enter Number 3
4
Enter Number 4
-6
Enter Number 5
2
Enter Number 6
4
Enter Number 7
1
Enter Number 8
0
Enter Number 9
-3
Enter Number 10
-1
Sum = 11
Average = 1.1
```