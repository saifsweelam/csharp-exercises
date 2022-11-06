# Section 4 Home Assignment

By **Seif El-Din Sweilam**

## Required

Write a program to calculate the
average of elements of a 3*3 matrix

## Code

```c#
const int SIZE = 3;

double[,] matrix = new double[SIZE, SIZE];
for (int i = 0; i < SIZE; i++) {
    for (int j = 0; j < SIZE; j++) {
        Console.WriteLine($"Enter Element [{i}, {j}]");
        matrix[i, j] = Convert.ToDouble(Console.ReadLine());
    }
}

double sum = 0;
for (int i = 0; i < SIZE; i++) {
    for (int j = 0; j < SIZE; j++) {
        sum += matrix[i, j];
    }
}

double avg = sum / (SIZE * SIZE);
Console.WriteLine($"Average = {avg}");
```

## Runtime

```
Enter Element [0, 0]
9.7
Enter Element [0, 1]
11
Enter Element [0, 2]
19.2
Enter Element [1, 0]
-11 
Enter Element [1, 1]
23
Enter Element [1, 2]
0
Enter Element [2, 0]
12
Enter Element [2, 1]
-11
Enter Element [2, 2]
0
Average = 5.877777777777777
```