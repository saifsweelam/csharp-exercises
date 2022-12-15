# Section 6 Home Assignment

By **Seif El-Din Sweilam**

## Required

Write a program to find the cube of
any number using a private method

## Code

```c#
class Program {
    public static void Main(string[] args) {
        Program program = new Program();
        System.Console.WriteLine(program.Cube(7));
    }

    private double Cube(double n) {
        return Math.Pow(n, 3);
    }
}
```

## Runtime

```
343
```