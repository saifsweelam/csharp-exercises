/**
 * Section 7
 *
 * Write a program to make a method that
 * returns the summation and multiplication of
 * an array of length 4*4 using out parameters
 */

class Program {
    public static void Main(string[] args) {
        double[,] matrix = ReadMatrix(4, 4);
        double sum, product;
        AnalyzeMatrix(matrix, out sum, out product);
        System.Console.WriteLine("Matrix sum: " + sum);
        System.Console.WriteLine("Matrix product: " + product);
    }

    public static void AnalyzeMatrix(double[,] matrix, out double sum, out double product) {
        sum = 0; product = 1;
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                sum += matrix[i, j];
                product *= matrix[i, j];
            }
        }
    }

    static double[,] ReadMatrix(int rows, int columns) {
        double[,] matrix = new double[rows, columns];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                System.Console.WriteLine("Enter Element [{0}, {1}]", i, j);
                matrix[i, j] = Convert.ToDouble(System.Console.ReadLine());
            }
        }
        return matrix;
    }
}
