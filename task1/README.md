# Task 1 Report

By **Seif El-Din Sweilam**

## Task 1.1

Write a program that reads from the console
three numbers of type `int` and prints their sum

### Code
```c#
int sum = 0;

for (int i = 1; i <= 3; i++) {
    Console.WriteLine($"Enter Number {i}:");
    sum += Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(sum);
```

### Runtime
```
Enter Number 1:
4
Enter Number 2:
5
Enter Number 3:
9
18
```

## Task 1.2

Write a program that reads from the console the radius
of a circle and prints its perimeter and area

### Code
```c#
const double PIE = 22.0 / 7.0;
Console.WriteLine("Enter Radius:");
double radius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Perimeter: {2*PIE*radius}");
Console.WriteLine($"Area: {PIE*radius*radius}");
```

### Output
```
Enter Radius:
7
Perimeter: 44
Area: 154
```