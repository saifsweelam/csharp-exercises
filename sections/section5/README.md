# Section 5 Home Assignment

By **Seif El-Din Sweilam**

## Required

Write your full name using `StringBuilder` and `Append` method

## Code

```c#
using System.Text;

StringBuilder name = new StringBuilder();

System.Console.WriteLine("Enter your first name");
name.Append(System.Console.ReadLine());
name.Append(" ");

System.Console.WriteLine("Enter your middle name");
name.Append(System.Console.ReadLine());
name.Append(" ");

System.Console.WriteLine("Enter your last name");
name.Append(System.Console.ReadLine());

System.Console.WriteLine();
System.Console.WriteLine("Your full name is: " + name.ToString());
```

## Runtime

```
Enter your first name
Seif
Enter your middle name
El-Din
Enter your last name
Sweilam

Your full name is: Seif El-Din Sweilam
```