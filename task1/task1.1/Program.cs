/* Task 1.1
 *
 * Write a program that reads from the console
 * three numbers of type int and prints their sum
 */

int sum = 0;

for (int i = 1; i <= 3; i++) {
    Console.WriteLine($"Enter Number {i}:");
    string? input = Console.ReadLine();
    if (input != null) {
        sum += int.Parse(input);
    }
}

Console.WriteLine(sum);