# Task 1 Report

By **Seif El-Din Sweilam**

## Task 1.1

Write a program that reads from the console
three numbers of type `int` and prints their sum

### Code
```c#
int sum = 0;

for (int i = 1; i <= 3; i++) {
    Console.WriteLine($"Enter Number {i}:");
    sum += Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(sum);
```

### Runtime
```
Enter Number 1:
4
Enter Number 2:
5
Enter Number 3:
9
18
```

## Task 1.2

Write a program that reads from the console the radius
of a circle and prints its perimeter and area

### Code
```c#
const double PIE = 22.0 / 7.0;
Console.WriteLine("Enter Radius:");
double radius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Perimeter: {2*PIE*radius}");
Console.WriteLine($"Area: {PIE*radius*radius}");
```

### Runtime
```
Enter Radius:
7
Perimeter: 44
Area: 154
```

## Task 1.3
A given company has a name, an address, a phone number,
a fax number, a website and a manager. The manager has
a name, a surname and a phone number. Write a program
that reads the info about the company and the manager
and prints them into the console.

### Code
```c#
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
```

### Runtime
```
Enter Company Name:
ODC
Enter Company Address:
Cairo, Egypt
Enter Company Phone Number:
+20129394921
Enter Company Fax Number:
+20198872342
Enter Company Website:
www.google.com
Enter Company Manager Name:
Samir
Enter Company Manager Surname:
Ali
Enter Company Manager Phone Number:
+20193278783

Welcome at ODC,
Mr. Samir Ali, the manager,
will be waiting for you tomorrow at his office.
You can always reach us through:
Address: Cairo, Egypt
Phone Number: +20129394921
Fax Number: +20198872342
Website: www.google.com
Manager Phone Number: +20193278783
```