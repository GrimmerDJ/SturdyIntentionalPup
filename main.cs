using System;

class Program
//I can't figure out how to name a program something other than "Program" 
//without repl freaking out. 
{
    static void Main()
    {
        const double cpiConversionFactor = 2.54;

        Console.Write("Enter the measurement in inches: ");
        double inches = double.Parse(Console.ReadLine());
        // I see in the Unit Tests that "inches" doesn't actually have to be a double, but I 
        // made it a double anyway. I feel like this is more realistic.
        double centimeters = inches * cpiConversionFactor;

        Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
    }
}