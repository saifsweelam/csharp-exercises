/* Task 1.4
 *
 * Print the following pattern using for loops
 * *******
 *  *****
 *   ***
 *    *
 */

// Should be odd
const int LENGTH = 7;

for (int i = LENGTH; i > 0; i-=2) {
    int spaces = (LENGTH - i) / 2;
    for (int j = 0; j < spaces; j++) Console.Write(" ");
    for (int k = 0; k < i; k++) Console.Write("*");
    Console.WriteLine();
}