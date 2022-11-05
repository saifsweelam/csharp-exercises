/**
 * Task 2
 *
 * Create a program that takes two matrices from user
 * and outputs the result of their division (A * B^-1)
 *
 * Dimensions: 2*2
 */

const int SIZE = 2;

static double GetDeterminant(double[,] matrix) {
    return matrix[0,0]*matrix[1,1] - matrix[0,1]*matrix[1,0];
}

static double[,] GetInverse(double[,] matrix) {
    double determinant = GetDeterminant(matrix);
    double[,] adjoint = {
        { matrix[1, 1], -matrix[0, 1]},
        {-matrix[1, 0],  matrix[0, 0]}
    };
    double[,] inverse = new double[SIZE, SIZE];
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            inverse[i, j] = adjoint[i, j] / determinant;
        }
    }
    return inverse;
}

static void DisplayMatrix(double[,] matrix) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            System.Console.Write("{0, 7} ", matrix[i, j].ToString("F"));
        }
        System.Console.WriteLine();
    }
}

static double[,] ReadMatrix(string name) {
    double[,] matrix = new double[SIZE, SIZE];
    System.Console.WriteLine(
        $"Enter Matrix {name} each row in a single " +
        "line and values separated by spaces"
    );
    for (int i = 0; i < SIZE; i++) {
        string[] row = System.Console.ReadLine().Split(" ");
        for (int j = 0; j < SIZE; j++) {
            matrix[i, j] = Convert.ToDouble(row[j]);
        }
    }
    return matrix;
}

static double[,] MultiplyMatrices(double[,] a, double[,] b) {
    double[,] c = new double[SIZE, SIZE];
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            c[i, j] = 0;
            for (int k = 0; k < SIZE; k++) {
                c[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return c;
}

static void Begin() {
    double[,] a = ReadMatrix("A");
    double[,] b = ReadMatrix("B");
    double[,] result = MultiplyMatrices(a, GetInverse(b));
    System.Console.WriteLine("Result:");
    DisplayMatrix(result);
}

Begin();