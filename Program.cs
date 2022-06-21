// See https://aka.ms/new-console-template for more information


Console.WriteLine("Welcome to .Net Banking System");
Console.WriteLine("-----------------------------------------");
Console.WriteLine();
Console.WriteLine("Enter Y to continue");
Console.WriteLine("Enter N to exit");

string log = Console.ReadLine();

if (log == "y" || log == "Y")
{
    Console.Clear();
    Console.WriteLine("Please insert your debit card");
    ATMservice.ATM();
}







    
