/**
 * Section 4
 *
 * Write a program to calculate the
 * average of elements of a 3*3 matrix
 */

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