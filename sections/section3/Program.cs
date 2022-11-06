/**
 * Section 3
 *
 * Write a program that reads 10 numbers
 * and calculates their sum and average
 */

const int SIZE = 10;

int[] nums = new int[SIZE];

for (int i = 0; i < SIZE; i++) {
    Console.WriteLine("Enter Number " + (i+1));
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Sum = " + nums.Sum());
Console.WriteLine("Average = " + nums.Average());
