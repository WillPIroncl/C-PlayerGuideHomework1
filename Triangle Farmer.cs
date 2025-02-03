// by william pfaff
// written 2/2/2025 

using System;
using System.Globalization;
class TriangleProgram
    {
    static void Main()
    {
        // getting user baseLength input
        float baseLength;

        Console.Write("Enter a float value: ");
        string userBaseInput = Console.ReadLine();

        if (float.TryParse(userBaseInput, out baseLength))
        {
            Console.WriteLine($"Base Length: {baseLength}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid float number for your base");
            baseLength = 1;
        }
        float height; 

        Console.Write("Enter a float value: ");
        string userHeightInput = Console.ReadLine();

        if (float.TryParse(userHeightInput, out height))
        {
            Console.WriteLine($"Height: {height}");
        }
        else
        {
            Console.WriteLine("Invalid input, Please enter a valid float number for your height.");
            height = -1;
        }

        Console.WriteLine("The Triangle Area is.." + (baseLength * height) / 2);
    }
}

