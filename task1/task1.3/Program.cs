/* Task 1.3
 *
 * A given company has a name, an address, a phone number,
 * a fax number, a website and a manager. The manager has
 * a name, a surname and a phone number. Write a program
 * that reads the info about the company and the manager
 * and prints them into the console.
 */

Console.WriteLine("Enter Company Name:");
string? companyName = Console.ReadLine();
Console.WriteLine("Enter Company Address:");
string? companyAddress = Console.ReadLine();
Console.WriteLine("Enter Company Phone Number:");
string? companyPhoneNumber = Console.ReadLine();
Console.WriteLine("Enter Company Fax Number:");
string? companyFaxNumber = Console.ReadLine();
Console.WriteLine("Enter Company Website:");
string? companyWebsite = Console.ReadLine();
Console.WriteLine("Enter Company Manager Name:");
string? managerName = Console.ReadLine();
Console.WriteLine("Enter Company Manager Surname:");
string? managerSurname = Console.ReadLine();
Console.WriteLine("Enter Company Manager Phone Number:");
string? managerPhoneNumber = Console.ReadLine();

// `$` Allows embedding variables to string
// `@` Allows Multiline string
Console.WriteLine($@"
Welcome at {companyName},
Mr. {managerName} {managerSurname}, the manager,
will be waiting for you tomorrow at his office.
You can always reach us through:
Address: {companyAddress}
Phone Number: {companyPhoneNumber}
Fax Number: {companyFaxNumber}
Website: {companyWebsite}
Manager Phone Number: {managerPhoneNumber}
");