/**
 * Section 6
 *
 * Write a program to find the cube of
 * any number using a private method
 */

class Program {
    public static void Main(string[] args) {
        Program program = new Program();
        System.Console.WriteLine(program.Cube(7));
    }

    private double Cube(double n) {
        return Math.Pow(n, 3);
    }
}