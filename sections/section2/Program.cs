﻿/**
 * Section 2
 *
 * Find the lowest of three numbers entered
 * by user using conditional operator
 */

Console.WriteLine("Enter first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
int c = Convert.ToInt32(Console.ReadLine());

int min = (a < b) ? a : b;
min = (c < min) ? c : min;
Console.WriteLine("Minimum = " + min);