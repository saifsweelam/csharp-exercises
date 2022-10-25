/* Task 1.2
 *
 * Write a program that reads from the console the radius
 * of a circle and prints its perimeter and area
 */

const double PIE = 22.0 / 7.0;
Console.WriteLine("Enter Radius:");
double radius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Perimeter: {2*PIE*radius}");
Console.WriteLine($"Area: {PIE*radius*radius}");