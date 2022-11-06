# Section 1 Home Assignment

By **Seif El-Din Sweilam**

## Required

Write a program to display the average of two numbers entered by the user

## Code

```c#
Console.WriteLine("Enter first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int b = Convert.ToInt32(Console.ReadLine());

float avg = (float) (a+b) / 2.0f;
Console.WriteLine("Average = " + avg);
```

## Runtime

```
Enter first number
7
Enter second number
8
Average = 7.5
```