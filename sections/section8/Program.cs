/**
 * Section 8
 *
 * Write a program that includes a Car
 * structure including the following fields:
 * - Brand
 * - Price
 * - Year of production
 * And the following methods:
 * - A constructor to set default year to 2021
 * - A constructor to using 3 parameters
 * - A method to display the car information
 * Then create 2 objects in the main function
 */

struct Car {
    private string brand;
    private double price;
    private int year;

    public Car(string brand, double price) {
        this.brand = brand;
        this.price = price;
        this.year = 2021;
    }

    public Car(string brand, double price, int year) {
        this.brand = brand;
        this.price = price;
        this.year = year;
    }

    public override string ToString() {
        return $"Car(Brand:{brand}, price:{price}, year:{year})";
    }
}

class Program {
    public static void Main(string[] args) {
        Car suzuki = new Car("Suzuki", 230000);
        Car toyota = new Car("Toyota", 500000, 2019);
        System.Console.WriteLine(suzuki);
        System.Console.WriteLine(toyota);
    }
}