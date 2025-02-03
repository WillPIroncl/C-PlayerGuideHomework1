class DominionOfKingsProgram
{
    static void Main()
    {
        // getting inputs for kingdom
        int provinces;

        Console.Write("Enter an integer value for all provinces in your kingdom! ");
        string provinceInput = Console.ReadLine();

        if (int.TryParse(provinceInput, out provinces))
        {
            Console.WriteLine($"Provinces: {provinces}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer number for your Province count" + "/n");
            provinces = -999;
        }


        int duchies;

        Console.Write("Enter an integer value for all duchies in your kingdom! ");
        string duchiesInput = Console.ReadLine();

        if (int.TryParse(duchiesInput, out duchies))
        {
            Console.WriteLine($"duchies: {duchies}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer number for your duchy count." + "/n");
            duchies = -999;
        }

        // getting inputs for kingdom
        int estates;

        Console.Write("Enter an integer value for all estates in your kingdom! ");
        string estatesInput = Console.ReadLine();

        if (int.TryParse(estatesInput, out estates))
        {
            Console.WriteLine($"Estates: {estates}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer number for your estate count" + "/n");
            estates = -999;
        }
        Console.WriteLine("Total Kingdom Points: " + ((provinces * 6) + (duchies * 3) + estates));
    }
}

