# Section 2 Home Assignment

By **Seif El-Din Sweilam**

## Required

Find the lowest of three numbers entered
by user using conditional operator

## Code

```c#
Console.WriteLine("Enter first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
int c = Convert.ToInt32(Console.ReadLine());

int min = (a < b) ? a : b;
min = (c < min) ? c : min;
Console.WriteLine("Minimum = " + min);
```

## Runtime

```
Enter first number
111
Enter second number
02
Enter third number
8
Minimum = 2
```