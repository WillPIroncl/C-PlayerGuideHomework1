
using System.Runtime.InteropServices;
// setting title
Console.Title="Defense of Consolas";
// getting row input
int targetRow;

Console.Write("Target Row? ");
string targetRowInput =  Console.ReadLine();

if (int.TryParse(targetRowInput, out targetRow))
{
    Console.WriteLine("\n");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer number for your target row!" + "/n");
    targetRow = -999;
}
// getting column input
int targetColumn;

Console.Write("Target Column? ");
string targetColumnInput = Console.ReadLine();

if (int.TryParse(targetColumnInput, out targetColumn))
{
    Console.WriteLine("\n");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer number for your target column!" + "/n");
    targetColumn = -999;
}
// printing deploy coordinates
Console.WriteLine("Deploy to: ");
Console.WriteLine("(" + targetRow + " , "+(targetColumn-1)+")");
Console.WriteLine("(" + (targetRow-1) + " , "+(targetColumn)+")");
Console.WriteLine("(" + (targetRow) + " , "+(targetColumn+1)+")");
Console.WriteLine("(" + (targetRow+1) + " , "+(targetColumn)+")");
