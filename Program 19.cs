using System;
using System.IO;

class MetricConverter
{
    public double Meters { get; set; }
    public double Centimeters { get; set; }

    // Method to read user input and save to meters.txt
    public void ReadAndSaveInput()
    {
        Console.Write("Enter value in meters: ");
        Meters = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value in centimeters: ");
        Centimeters = Convert.ToDouble(Console.ReadLine());

        using (StreamWriter writer = new StreamWriter("meters.txt"))
        {
            writer.WriteLine($"{Meters},{Centimeters}");
        }

        Console.WriteLine("\nData saved to meters.txt ✅");
    }

    // Method to convert to feet and inches
    public (double feet, double inches) ConvertToImperial()
    {
        double totalCentimeters = (Meters * 100) + Centimeters;

        double inches = totalCentimeters / 2.54;
        double feet = Math.Floor(inches / 12);
        inches = inches % 12;

        return (feet, inches);
    }

    // Save conversion result to feet.txt
    public void SaveToFeetFile(double feet, double inches)
    {
        using (StreamWriter writer = new StreamWriter("feet.txt"))
        {
            writer.WriteLine($"Feet: {feet}");
            writer.WriteLine($"Inches: {inches:F2}");
        }

        Console.WriteLine("\nConverted values saved to feet.txt ✅");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MetricConverter converter = new MetricConverter();

        // Step 1: Get input and save to file
        converter.ReadAndSaveInput();

        // Step 2: Convert to feet and inches
        var (feet, inches) = converter.ConvertToImperial();

        // Step 3: Save converted values to feet.txt
        converter.SaveToFeetFile(feet, inches);

        // Optional: Show on console
        Console.WriteLine($"\nConverted Values:\nFeet: {feet}\nInches: {inches:F2}");
    }
}
