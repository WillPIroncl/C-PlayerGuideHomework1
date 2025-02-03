// by william pfaff
// written 2/2/2025 
using System;


class DuckbearProgram
{
    static void Main()
    {
        // getting user egg input
        int chocolateEggs;

        Console.Write("Enter an integer value for chocolate eggs gathered today: ");
        string chocolateEggsInput = Console.ReadLine();

        if (int.TryParse(chocolateEggsInput, out chocolateEggs))
        {
            Console.WriteLine($"Eggs Gathered: {chocolateEggs}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer number for your gathered egg count" + "/n");
            chocolateEggs = -999;
        }

        Console.WriteLine("Each sister receives " + ((chocolateEggs - (chocolateEggs % 3)) / 3)+" Chocolate eggs."+"\n"+" The Duckbear receives "+(chocolateEggs%3)+" chocolate eggs.");
    }
}

