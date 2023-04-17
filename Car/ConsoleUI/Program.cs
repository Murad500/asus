
using ConsoleUI.Models;
using ConsoleUI.Services;

CarService carService = new();
Car car1 = new()
{
    Name = "NazLifan",
    EnginePower = 1.3M,
    MaxOil = 50,
    CurrentOil = 50,
    Milage = 130
};

Console.WriteLine("1. Herekete basla.");
Console.WriteLine("2. Benzin yoxla.");
Console.WriteLine("3. YDM.");
Console.WriteLine("4. Serfiyyat.");
Console.WriteLine("5. Exit.");

Console.Write("Reqem daxil edin: ");
int userInput = Convert.ToInt32(Console.ReadLine());

switch (userInput)
{
    case 1:
    Console.Clear();
        Console.WriteLine("Km daxil edin: ");
        int userKm = Convert.ToInt32(Console.ReadLine());
        carService.Move(car1,userKm);
    break;
    case 2:
        
    break;
    case 3:
        Console.Clear();
        Console.Write("Benzin daxil edin: ");
        int userOil = Convert.ToInt32(Console.ReadLine());
        carService.Ydm(car1,userOil);
    break;
    case 4:
        Console.Clear();
        Console.WriteLine(car1.Milage + " Km");
        Console.WriteLine(car1.CurrentOil + " L");
    break;
    case 5:

    break;

    default:
    break;
}