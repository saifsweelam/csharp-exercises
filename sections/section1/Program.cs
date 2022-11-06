/**
 * Section 1
 *
 * Write a program to display the average
 * of two numbers entered by the user
 */

Console.WriteLine("Enter first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int b = Convert.ToInt32(Console.ReadLine());

float avg = (float) (a+b) / 2.0f;
Console.WriteLine("Average = " + avg);