// code by william pfaff
// written 2/2/2025
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

int number;

Console.Write("Input Number: ");
string numberInput = Console.ReadLine();

if (int.TryParse(numberInput, out number))
{
    Console.WriteLine("\n");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer number for your number" + "/n");
    number = 1;

  
}
if (number % 2 == 0)
{
    Console.WriteLine("Tick");

}
else
{
    Console.WriteLine("Tock");
}
