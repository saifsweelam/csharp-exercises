/**
 * Section 5
 *
 * Write your full name using a string
 * builder and append method
 */


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